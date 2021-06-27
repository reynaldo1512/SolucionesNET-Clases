using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    public class ApplicationDBContext : DbContext
    {
        /* DbContext sirve para configurar algunas de las caracteristicas que tendra la BD
         * CREAR UNA PROPIEDAD  DbSet , sera adelante una tabla */

        public ApplicationDBContext() : base("ConnBD")
        {
        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento{  get; set; }

    }
}