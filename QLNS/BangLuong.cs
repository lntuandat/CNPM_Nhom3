//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangLuong
    {
        public string MaBL { get; set; }
        public string MaNV { get; set; }
        public string MaBHXH { get; set; }
        public string MaXL { get; set; }
        public string MaCC { get; set; }
        public string MaCV { get; set; }
        public Nullable<double> ThucLinh { get; set; }
    
        public virtual BaoHiemXaHoi BaoHiemXaHoi { get; set; }
        public virtual ChamConggg ChamCong { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual XepLoai XepLoai { get; set; }
    }
}
