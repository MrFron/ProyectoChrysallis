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
    
    public partial class esdeveniments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public esdeveniments()
        {
            this.assistir = new HashSet<assistir>();
            this.documents = new HashSet<documents>();
            this.notificacions = new HashSet<notificacions>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public string ubicació { get; set; }
        public Nullable<System.DateTime> data_limit { get; set; }
        public Nullable<int> id_comunitat { get; set; }
        public string descripcio { get; set; }
        public string nom { get; set; }
        public byte[] img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assistir> assistir { get; set; }
        public virtual comunitats comunitats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documents> documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notificacions> notificacions { get; set; }
    }
}