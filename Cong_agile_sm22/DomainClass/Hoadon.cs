using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("hoadon")]
    public partial class Hoadon
    {
        public Hoadon()
        {
            Cthds = new HashSet<Cthd>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idkh")]
        public int? Idkh { get; set; }
        [Column("idnv")]
        public int? Idnv { get; set; }
        [Column("mahd")]
        [StringLength(10)]
        public string Mahd { get; set; }
        [Column("ngtao", TypeName = "date")]
        public DateTime? Ngtao { get; set; }
        [Column("ngship", TypeName = "date")]
        public DateTime? Ngship { get; set; }
        [Column("hotenngnhan")]
        [StringLength(30)]
        public string Hotenngnhan { get; set; }
        [Column("diachingnhan")]
        [StringLength(50)]
        public string Diachingnhan { get; set; }
        [Column("sdtngnhan")]
        [StringLength(15)]
        public string Sdtngnhan { get; set; }

        [ForeignKey(nameof(Idkh))]
        [InverseProperty(nameof(Khachhang.Hoadons))]
        public virtual Khachhang IdkhNavigation { get; set; }
        [ForeignKey(nameof(Idnv))]
        [InverseProperty(nameof(Nhanvien.Hoadons))]
        public virtual Nhanvien IdnvNavigation { get; set; }
        [InverseProperty(nameof(Cthd.IdhdNavigation))]
        public virtual ICollection<Cthd> Cthds { get; set; }
    }
}
