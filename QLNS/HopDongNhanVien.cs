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
    
    public partial class HopDongNhanVien
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string ThoiHanHopDong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<double> MucLuong { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
