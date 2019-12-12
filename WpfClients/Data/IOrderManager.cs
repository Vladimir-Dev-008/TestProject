namespace WpfClients
{
    public interface IOrderManager
    {
        void Add(Order order);

        void Remove(Order order);

        void Update(Order order);
    }
}