using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfClients
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        [Key]
        public int Number { get; set; }

        /// <summary>
        /// Описание заказа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Внешний ключь
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Покупатель
        /// </summary>
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public Order() { }

        /// <summary>
        /// Конструктор заказа
        /// </summary>
        /// <param name="number">Уникальный номер заказа</param>
        /// <param name="description">Описание заказа</param>
        public Order(int number, string description, Client client)
        {
            Number = number;
            Description = description;
            Client = client;
        }
    }
}