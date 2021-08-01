using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :base("ConnBD")
        {
            
    }
        public DbSet<Cliente> Cliente{ get; set; }
        public DbSet<TipoExamen> TipoExamenes { get; set; }
        public DbSet<SolicitudAnalisis>  SolicitudAnalises{ get; set; }

    }
}
