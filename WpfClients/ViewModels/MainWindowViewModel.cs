using Unity;

namespace WpfClients
{
    /// <summary>
    /// Модель-представление главного окна
    /// </summary>
    public class MainWindowViewModel : NotifyPropertyChangedClass
    {
        /// <summary>
        /// Модель-представление списка клиентов
        /// </summary>
        public ClientsViewModel ClientsViewModel { get; }

        public MainWindowViewModel(IUnityContainer container)
        {
            ClientsViewModel = container.Resolve<ClientsViewModel>();
        }
    }
}