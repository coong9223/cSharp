using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_Template_SM22_Csharp.DomainModels
{
    [Table("LoaiXM")]
    [Index(nameof(Ma), Name = "UQ__LoaiXM__3214CC9E2B750870", IsUnique = true)]
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
