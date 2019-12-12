using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WpfClients
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client
    {
        /// <summary>
        /// ID клиента
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// VIP
        /// </summary>
        public bool VIP { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        public virtual List<Order> Orders { get; set; }

        public Client()
        {
            Orders = Orders == null ? new List<Order>() : Orders;
        }

        public Client(string name)
        {
            Name = name;
            Orders = Orders == null ? new List<Order>() : Orders;
        }
    }
}
