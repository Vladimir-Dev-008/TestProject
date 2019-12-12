namespace WpfClients
{
    public class DataManager : IDataManager
    {
        private readonly IClientManager _clientManager;

        private readonly IOrderManager _orderManager;

        public readonly DataBaseContext _dataBaseContext;

        public DataManager()
        {
            _dataBaseContext = new DataBaseContext();
            _clientManager = new ClientManager(_dataBaseContext);
            _orderManager = new OrderManager(_dataBaseContext);
        }

        public IClientManager GetClientManager() => _clientManager;
        
        public IOrderManager GetOrderManager() => _orderManager;

        public void Dispose() => _dataBaseContext.Dispose();
    }
}
