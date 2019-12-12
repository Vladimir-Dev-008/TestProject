namespace WpfClients
{
    public class OrderManager : IOrderManager
    {
        private readonly DataBaseContext _dataBaseContext;

        public OrderManager(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Add(Order order)
        {
            try
            {
                _dataBaseContext.Orders.Add(order);
                _dataBaseContext.SaveChanges();
            }
            catch { }
        }

        public void Update(Order order)
        {
            try
            {
                _dataBaseContext.SaveChanges();
            }
            catch { }
        }

        public void Remove(Order order)
        {
            try
            {
                _dataBaseContext.Orders.Remove(order);
                _dataBaseContext.SaveChanges();
            }
            catch { }
        }
    }
}