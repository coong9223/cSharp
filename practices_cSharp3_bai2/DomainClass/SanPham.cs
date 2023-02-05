using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace practices_cSharp3_bai2.DomainClass
{
    [Table("SanPham")]
    [Index(nameof(Ma), Name = "UQ__SanPham__3214CC9E8FD64ECD", IsUnique = true)]
    public partial class SanPham
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [Column("NgaySX", TypeName = "date")]
        public DateTime? NgaySx { get; set; }
        [StringLength(30)]
        public string Mota { get; set; }
        [StringLength(30)]
        public string Website { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }
        public int? SoLuong { get; set; }
        [Column("IdLoaiSP")]
        public Guid? IdLoaiSp { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdLoaiSp))]
        [InverseProperty(nameof(LoaiSp.SanPhams))]
        public virtual LoaiSp IdLoaiSpNavigation { get; set; }
    }
}
