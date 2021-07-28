using Microsoft.EntityFrameworkCore;

namespace Cadastro.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options)
        : base (options)
        {
            //Default
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}