//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Cliente()
        {
            this.tb_ContactoCliente = new HashSet<tb_ContactoCliente>();
        }
    
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidosCliente { get; set; }
        public System.DateTime fechaNacimientoCliente { get; set; }
        public string numeroDocumentoCliente { get; set; }
        public string celularCliente { get; set; }
        public string direccionCliente { get; set; }
        public string emailCliente { get; set; }
        public string generoCliente { get; set; }
        public bool estadoCliente { get; set; }
        public int idTipoDocumento { get; set; }
        public int idCategoria { get; set; }
        public string creacionUser { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public string modificacionUser { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<int> idubigeo { get; set; }
    
        public virtual tb_Categoria tb_Categoria { get; set; }
        public virtual tb_Ubigeo tb_Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ContactoCliente> tb_ContactoCliente { get; set; }
        public virtual tb_TipoDocumento tb_TipoDocumento { get; set; }
    }
}
