using System.Data.Entity;

namespace WpfClients
{
    /// <summary>
    /// Контекст для работы с БД 
    /// </summary>
    public class DataBaseContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DataBaseContext()
            : base("DBContext")
        {
        }
    }
}