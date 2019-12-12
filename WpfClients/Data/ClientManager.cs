using System.Collections.Generic;
using System.Linq;

namespace WpfClients
{
    public class ClientManager : IClientManager
    {
        private readonly DataBaseContext _dataBaseContext;

        public ClientManager(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public IEnumerable<Client> FindOll()
        {
            try
            {
                return _dataBaseContext.Clients.ToList();
            }
            catch { }

            return new List<Client>();
        }

        public void Add(Client client)
        {
            try
            {
                _dataBaseContext.Clients.Add(client);
                _dataBaseContext.SaveChanges();
            }
            catch { }
        }

        public void Remove(Client client)
        {
            try
            {
                _dataBaseContext.Clients.Remove(client);
                _dataBaseContext.SaveChanges();
            }
            catch { }
        }
    }
}