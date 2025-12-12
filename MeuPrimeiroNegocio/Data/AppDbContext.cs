using MeuPrimeiroNegocio.Data;
using MeuPrimeiroNegocio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MeuPrimeiroNegocio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
