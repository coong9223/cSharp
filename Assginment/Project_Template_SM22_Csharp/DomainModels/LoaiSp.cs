using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_Template_SM22_Csharp.DomainModels
{
    [Table("LoaiSP")]
    [Index(nameof(Ma), Name = "UQ__LoaiSP__3214CC9E00B9D9E0", IsUnique = true)]
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }

        [InverseProperty(nameof(SanPham.IdLoaiSpNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
