//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapChieuPhim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ghe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ghe()
        {
            this.Ves = new HashSet<Ve>();
        }
    
        public int ghe_id { get; set; }
        public Nullable<int> Loai_id { get; set; }
        public bool TringTrang { get; set; }
        public Nullable<int> Id_phong { get; set; }
        public string TenGhe { get; set; }
        public string HangGhe { get; set; }
    
        public virtual LoaiGhe LoaiGhe { get; set; }
        public virtual Phong Phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}