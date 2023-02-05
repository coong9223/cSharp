using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("giohang")]
    public partial class Giohang
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idkh")]
        public int? Idkh { get; set; }
        [Column("idnv")]
        public int? Idnv { get; set; }
        [Column("ngtao", TypeName = "date")]
        public DateTime? Ngtao { get; set; }
        [Column("ngthanhtoan", TypeName = "date")]
        public DateTime? Ngthanhtoan { get; set; }
        [Column("hotenngnhan")]
        [StringLength(30)]
        public string Hotenngnhan { get; set; }
        [Column("diachingnhan")]
        [StringLength(50)]
        public string Diachingnhan { get; set; }
        [Column("sdtngnhan")]
        [StringLength(15)]
        public string Sdtngnhan { get; set; }
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Idkh))]
        [InverseProperty(nameof(Khachhang.Giohangs))]
        public virtual Khachhang IdkhNavigation { get; set; }
        [ForeignKey(nameof(Idnv))]
        [InverseProperty(nameof(Nhanvien.Giohangs))]
        public virtual Nhanvien IdnvNavigation { get; set; }
    }
}
