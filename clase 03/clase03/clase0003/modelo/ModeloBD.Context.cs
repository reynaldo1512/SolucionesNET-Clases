﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clase0003.modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnDB_EF : DbContext
    {
        public ConnDB_EF()
            : base("name=ConnDB_EF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Categoria> tb_Categoria { get; set; }
        public virtual DbSet<tb_Cliente> tb_Cliente { get; set; }
        public virtual DbSet<tb_Colaborador> tb_Colaborador { get; set; }
        public virtual DbSet<tb_ContactoCliente> tb_ContactoCliente { get; set; }
        public virtual DbSet<tb_Meta> tb_Meta { get; set; }
        public virtual DbSet<tb_Producto> tb_Producto { get; set; }
        public virtual DbSet<tb_Rol> tb_Rol { get; set; }
        public virtual DbSet<tb_SemanaPlanificada> tb_SemanaPlanificada { get; set; }
        public virtual DbSet<tb_TipoDocumento> tb_TipoDocumento { get; set; }
        public virtual DbSet<tb_Ubigeo> tb_Ubigeo { get; set; }
    }
}
