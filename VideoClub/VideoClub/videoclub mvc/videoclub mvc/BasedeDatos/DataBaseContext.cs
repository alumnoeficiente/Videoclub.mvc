using Microsoft.EntityFrameworkCore;
using videoclub_mvc.Models;

namespace videoclub_mvc.Base_de_Datos
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public string ConnectionString => "Server=Localhost;Database=Vidly;Trusted_Connection=True;Encrypt=False;";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);
    }
}
