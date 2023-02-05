using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("nhanvien")]
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Giohangs = new HashSet<Giohang>();
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idcv")]
        public int? Idcv { get; set; }
        [Column("manv")]
        [StringLength(10)]
        public string Manv { get; set; }
        [Column("hotennv")]
        [StringLength(30)]
        public string Hotennv { get; set; }
        [Column("ngsinh", TypeName = "date")]
        public DateTime? Ngsinh { get; set; }
        [Column("gioitinh")]
        [StringLength(10)]
        public string Gioitinh { get; set; }
        [Column("diachi")]
        [StringLength(50)]
        public string Diachi { get; set; }
        [Column("sdt")]
        [StringLength(15)]
        public string Sdt { get; set; }

        [ForeignKey(nameof(Idcv))]
        [InverseProperty(nameof(Chucvu.Nhanviens))]
        public virtual Chucvu IdcvNavigation { get; set; }
        [InverseProperty(nameof(Giohang.IdnvNavigation))]
        public virtual ICollection<Giohang> Giohangs { get; set; }
        [InverseProperty(nameof(Hoadon.IdnvNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
