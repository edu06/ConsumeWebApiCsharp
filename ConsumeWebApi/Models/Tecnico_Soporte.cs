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
    
    public partial class Tecnico_Soporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tecnico_Soporte()
        {
            this.Incidencias = new HashSet<Incidencias>();
            this.Solicitud_Requerimientos = new HashSet<Solicitud_Requerimientos>();
            this.Telefonos_Tecnicos = new HashSet<Telefonos_Tecnicos>();
            this.Especialidad = new HashSet<Especialidad>();
        }
    
        public int Codigo_Tecnico { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Direccion { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Correo_Usuario { get; set; }
        public string DPI { get; set; }
        public int Codigo_Departamento_Tecnico { get; set; }
        public int Codigo_Perfil { get; set; }
        public string Pasword { get; set; }
    
        public virtual Departamento_Tecnico Departamento_Tecnico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencias> Incidencias { get; set; }
        public virtual Perfiles Perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud_Requerimientos> Solicitud_Requerimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefonos_Tecnicos> Telefonos_Tecnicos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Especialidad> Especialidad { get; set; }
    }
}
