using System.Windows;

namespace WpfClients
{
    /// <summary>
    /// Модель-представление клиента
    /// </summary>
    public class ClientViewModel : NotifyPropertyChangedClass
    {
        public Client Client { get; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name => Client.Name;

        /// <summary>
        /// Адресс клиента
        /// </summary>
        public string Address => Client.Address;

        /// <summary>
        /// VIP
        /// </summary>
        public bool VIP => Client.VIP;

        /// <summary>
        /// VIP
        /// </summary>
        public Visibility? VisibileVIP =>
            VIP ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        /// Цвет имени клиента
        /// </summary>
        public string Foreground =>
            VIP ? "Red" : "Black";

        /// <summary>
        /// Список заказов
        /// </summary>
        public OrdersViewModel OrdersViewModel { get; }

        public ClientViewModel(Client client)
        {
            Client = client;
            OrdersViewModel = new OrdersViewModel(client.Orders);
        }

        public void AddOrder() =>
            new CreateOrderWindow().ShowDialog();

        
    }
}