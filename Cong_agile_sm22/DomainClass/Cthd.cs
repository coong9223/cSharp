using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("cthd")]
    public partial class Cthd
    {
        [Key]
        [Column("idhd")]
        public int Idhd { get; set; }
        [Key]
        [Column("idsp")]
        public int Idsp { get; set; }
        [Column("soluong")]
        public int? Soluong { get; set; }
        [Column("dongia", TypeName = "decimal(20, 0)")]
        public decimal? Dongia { get; set; }

        [ForeignKey(nameof(Idhd))]
        [InverseProperty(nameof(Hoadon.Cthds))]
        public virtual Hoadon IdhdNavigation { get; set; }
        [ForeignKey(nameof(Idsp))]
        [InverseProperty(nameof(Sp.Cthds))]
        public virtual Sp IdspNavigation { get; set; }
    }
}
