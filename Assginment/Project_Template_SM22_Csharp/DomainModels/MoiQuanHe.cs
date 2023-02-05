using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_Template_SM22_Csharp.DomainModels
{
    [Table("MoiQuanHe")]
    [Index(nameof(Ma), Name = "UQ__MoiQuanH__3214CC9E89D98D92", IsUnique = true)]
    public partial class MoiQuanHe
    {
        public MoiQuanHe()
        {
            Bans = new HashSet<Ban>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }

        [InverseProperty(nameof(Ban.IdMqhNavigation))]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}
