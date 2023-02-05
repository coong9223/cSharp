using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("khachhang")]
    public partial class Khachhang
    {
        public Khachhang()
        {
            Giohangs = new HashSet<Giohang>();
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("makh")]
        [StringLength(10)]
        public string Makh { get; set; }
        [Column("hotenkh")]
        [StringLength(30)]
        public string Hotenkh { get; set; }
        [Column("ngsinhkh", TypeName = "date")]
        public DateTime? Ngsinhkh { get; set; }
        [Column("diachi")]
        [StringLength(50)]
        public string Diachi { get; set; }
        [Column("sdt")]
        [StringLength(15)]
        public string Sdt { get; set; }
        [Column("matkhau")]
        [StringLength(40)]
        public string Matkhau { get; set; }

        [InverseProperty(nameof(Giohang.IdkhNavigation))]
        public virtual ICollection<Giohang> Giohangs { get; set; }
        [InverseProperty(nameof(Hoadon.IdkhNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
