using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BaiThi_MOB104.DomainModels
{
    [Table("SanPham")]
    [Index(nameof(Ma), Name = "UQ__SanPham__3214CC9E3187A8AB", IsUnique = true)]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }
        public int? SoLuongTon { get; set; }
        [StringLength(30)]
        public string DanhMuc { get; set; }
        [StringLength(10)]
        public string TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdSpNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
