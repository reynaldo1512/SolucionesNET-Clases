﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_ADO.modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_Practica1 : DbContext
    {
        public BD_Practica1()
            : base("name=BD_Practica1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCliente> tbCliente { get; set; }
        public virtual DbSet<tbPais> tbPais { get; set; }
        public virtual DbSet<tbTarjeta> tbTarjeta { get; set; }
        public virtual DbSet<tbViaje> tbViaje { get; set; }
    }
}