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
    
    public partial class DatVe
    {
        public int IDDatVe { get; set; }
        public int IDTK { get; set; }
        public string IDve { get; set; }
        public System.DateTime NgayDat { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string HoTen { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}