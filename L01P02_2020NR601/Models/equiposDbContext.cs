using Microsoft.EntityFrameworkCore;
using L01P02_2020NR601.Models;

namespace L01P02_2020NR601.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options)
        {

        }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<L01P02_2020NR601.Models.platos>? platos { get; set; }
       
        public DbSet<L01P02_2020NR601.Models.clientes>? clientes { get; set; }
       
        public DbSet<L01P02_2020NR601.Models.motoristas>? motoristas { get; set; }

    }
}
