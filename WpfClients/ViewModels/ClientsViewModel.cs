using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Unity;

namespace WpfClients
{
    /// <summary>
    /// Модель-представление списка клиентов
    /// </summary>
    public class ClientsViewModel : NotifyPropertyChangedClass
    {
        /// <summary>
        /// Клиент выбранный в списке
        /// </summary>
        private ClientViewModel _selectedClient;

        /// <summary>
        /// Список моделей-представлений клиентов
        /// </summary>
        public ObservableCollection<ClientViewModel> ClientViewModels { get; }

        /// <summary>
        /// Клиент выбранный в списке
        /// </summary>
        public ClientViewModel SelectedClient
        {
            get => _selectedClient;
            set => SetProperty(ref _selectedClient, value);
        }

        public ICommand AddClientCommand { get; }

        public ICommand AddOrderCommand { get; }

        public ClientsViewModel(IClientManager clientManager, IOrderManager orderManager)
        {
            ClientViewModels = new ObservableCollection<ClientViewModel>(clientManager?.FindOll()?.Select(p=> new ClientViewModel(p)));

            AddClientCommand = new DelegateCommand(arg => 
            {
                var createClientWindowViewModel = new CreateClientWindowViewModel();
                createClientWindowViewModel.SaveCommand = new DelegateCommand(args =>
                {
                    var newClient = new Client
                    {
                        Name = createClientWindowViewModel.Name,
                        Address = createClientWindowViewModel.Address,
                        VIP = createClientWindowViewModel.VIP
                    };

                    clientManager.Add(newClient);
                    ClientViewModels.Add(new ClientViewModel(newClient));
                });

                new CreateClientWindow 
                { 
                    DataContext = createClientWindowViewModel
                }.ShowDialog();
            });


            AddOrderCommand = new DelegateCommand(arg =>
            {
                var createOrderWindowViewModel = new CreateOrderWindowViewModel();
                createOrderWindowViewModel.SaveCommand = new DelegateCommand(args =>
                {
                    var newOrder = new Order
                    {
                        Client = SelectedClient.Client,
                        ClientId = SelectedClient.Client.Id,
                        Description = createOrderWindowViewModel.Description
                    };

                    orderManager.Add(newOrder);
                    SelectedClient.OrdersViewModel.OrderViewModels.Add(new OrderViewModel(newOrder));
                });

                new CreateOrderWindow
                {
                    DataContext = createOrderWindowViewModel
                }.ShowDialog();
            });


        }
    }
}