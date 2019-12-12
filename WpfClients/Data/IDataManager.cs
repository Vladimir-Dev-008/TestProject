using System;

namespace WpfClients
{
    /// <summary>
    /// Интерфейс DataManager
    /// </summary>
    public interface IDataManager : IDisposable
    {
        IClientManager GetClientManager();

        IOrderManager GetOrderManager();
    }
}