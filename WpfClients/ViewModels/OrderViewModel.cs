namespace WpfClients
{
    /// <summary>
    /// Модель представления заказа
    /// </summary>
    public class OrderViewModel : NotifyPropertyChangedClass
    {
        private readonly Order _order;

        /// <summary>
        /// Номер заказа
        /// </summary>
        public int Number
        {
            get => _order.Number;
            set { _order.Number = value; }
        }

        /// <summary>
        /// Описание заказа
        /// </summary>
        public string Description
        {
            get { return _order.Description; }
            set
            {
                if (_order.Description != value)
                {
                    _order.Description = value;
                    OnPropertyChanged();
                    //App.DataManager.GetOrderManager().Update(_order);
                }
            }
        }

        public OrderViewModel(Order order)
        {
            _order = order;
        }
    }
}