using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Cong_agile_sm22.DomainClass
{
    [Table("chucvu")]
    public partial class Chucvu
    {
        public Chucvu()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("macv")]
        [StringLength(10)]
        public string Macv { get; set; }
        [Column("tencv")]
        [StringLength(30)]
        public string Tencv { get; set; }

        [InverseProperty(nameof(Nhanvien.IdcvNavigation))]
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
