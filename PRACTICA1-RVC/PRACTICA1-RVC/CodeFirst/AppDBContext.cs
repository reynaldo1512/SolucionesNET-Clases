using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() :base("ConnBD")
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Viaje> Viaje { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Pais> Pais { get; set; }
    }
}
