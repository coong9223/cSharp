using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("sp")]
    public partial class Sp
    {
        public Sp()
        {
            Cthds = new HashSet<Cthd>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("masp")]
        [StringLength(10)]
        public string Masp { get; set; }
        [Column("tensp")]
        [StringLength(50)]
        public string Tensp { get; set; }
        [Column("gianhap", TypeName = "decimal(20, 0)")]
        public decimal? Gianhap { get; set; }
        [Column("giaban", TypeName = "decimal(20, 0)")]
        public decimal? Giaban { get; set; }
        [Column("nambh")]
        public int? Nambh { get; set; }
        [Column("slton")]
        public int? Slton { get; set; }
        [Column("mota")]
        [StringLength(30)]
        public string Mota { get; set; }

        [InverseProperty(nameof(Cthd.IdspNavigation))]
        public virtual ICollection<Cthd> Cthds { get; set; }
    }
}
