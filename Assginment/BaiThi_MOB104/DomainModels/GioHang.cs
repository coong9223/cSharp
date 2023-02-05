using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BaiThi_MOB104.DomainModels
{
    [Table("GioHang")]
    [Index(nameof(Masp), Name = "UQ__GioHang__27240C254C277B88", IsUnique = true)]
    [Index(nameof(Ma), Name = "UQ__GioHang__3214CC9EC0AB30D0", IsUnique = true)]
    public partial class GioHang
    {
        public GioHang()
        {
            GioHangChiTiets = new HashSet<GioHangChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        [StringLength(20)]
        public string Masp { get; set; }
        [StringLength(30)]
        public string Tensp { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }
        public int? SoLuongTon { get; set; }
        [StringLength(30)]
        public string DanhMuc { get; set; }
        [StringLength(10)]
        public string TrangThai { get; set; }

        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.GioHangs))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [InverseProperty(nameof(GioHangChiTiet.IdGioHangNavigation))]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
