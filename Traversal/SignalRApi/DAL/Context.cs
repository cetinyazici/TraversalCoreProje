using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace SignalRApi.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
    }

}
