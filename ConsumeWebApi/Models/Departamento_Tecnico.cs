//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Departamento_Tecnico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departamento_Tecnico()
        {
            this.Tecnico_Soporte = new HashSet<Tecnico_Soporte>();
        }
    
        public int Codigo_Departamento_Tecnico { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tecnico_Soporte> Tecnico_Soporte { get; set; }
    }
}
