﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_Lab2Entities : DbContext
    {
        public BD_Lab2Entities()
            : base("name=BD_Lab2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbExamen> tbExamen { get; set; }
        public virtual DbSet<tbPaciente> tbPaciente { get; set; }
        public virtual DbSet<tbRol> tbRol { get; set; }
        public virtual DbSet<tbSexo> tbSexo { get; set; }
        public virtual DbSet<tbSolicitudExamen> tbSolicitudExamen { get; set; }
        public virtual DbSet<tbUsuario> tbUsuario { get; set; }
    }
}
