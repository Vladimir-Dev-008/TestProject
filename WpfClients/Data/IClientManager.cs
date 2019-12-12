using System.Collections.Generic;

namespace WpfClients
{
    public interface IClientManager
    {
        IEnumerable<Client> FindOll();

        void Add(Client client);

        void Remove(Client client);
    }
}