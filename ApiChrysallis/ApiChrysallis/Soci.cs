//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiChrysallis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Soci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Soci()
        {
            this.assistir = new HashSet<assistir>();
            this.comunitats = new HashSet<comunitats>();
        }
    
        public int id { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string contrasenya { get; set; }
        public Nullable<bool> actiu { get; set; }
        public Nullable<bool> administrador { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assistir> assistir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comunitats> comunitats { get; set; }
    }
}
