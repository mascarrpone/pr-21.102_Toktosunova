//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr_21._102_Toktosunova_3.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusTeacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusTeacher()
        {
            this.Teachers = new HashSet<Teachers>();
        }
    
        public int IdStatusTeacher { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}
