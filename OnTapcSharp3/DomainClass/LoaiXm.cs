using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace OnTapcSharp3.DomainClass
{
    [Table("LoaiXM")]
    [Index(nameof(Ma), Name = "UQ__LoaiXM__3214CC9EA6F30E16", IsUnique = true)]
    public partial class LoaiXm
    {
        public LoaiXm()
        {
            XeMays = new HashSet<XeMay>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }

        [InverseProperty(nameof(XeMay.IdLxmNavigation))]
        public virtual ICollection<XeMay> XeMays { get; set; }
    }
}
