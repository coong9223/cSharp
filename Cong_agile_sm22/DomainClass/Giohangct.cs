using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Keyless]
    [Table("giohangct")]
    public partial class Giohangct
    {
        [Column("idgiohang")]
        public int? Idgiohang { get; set; }
        [Column("idsp")]
        public int? Idsp { get; set; }
        [Column("dongia", TypeName = "decimal(20, 0)")]
        public decimal? Dongia { get; set; }
        [Column("giadagiam", TypeName = "decimal(20, 0)")]
        public decimal? Giadagiam { get; set; }

        [ForeignKey(nameof(Idgiohang))]
        public virtual Giohang IdgiohangNavigation { get; set; }
        [ForeignKey(nameof(Idsp))]
        public virtual Sp IdspNavigation { get; set; }
    }
}
