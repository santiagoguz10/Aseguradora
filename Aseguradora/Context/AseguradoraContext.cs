using Aseguradora.Model;
using Microsoft.EntityFrameworkCore;

namespace Aseguradora.Context
{
    public class AseguradoraContext : DbContext
    {
        public AseguradoraContext(DbContextOptions<AseguradoraContext> options)
            : base(options)
        {

        }

        public DbSet<Poliza> Polizas { get; set; } = null!;
    }
}
