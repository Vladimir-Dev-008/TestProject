using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfClients
{
    /// <summary>
    /// Модель-представление списка заказов
    /// </summary>
    public class OrdersViewModel
    {
        public ObservableCollection<OrderViewModel> OrderViewModels { get; }

        public OrdersViewModel(IEnumerable<Order> orders)
        {
            OrderViewModels = new ObservableCollection<OrderViewModel>(orders?.Select(p => new OrderViewModel(p)));
        }
    }
}