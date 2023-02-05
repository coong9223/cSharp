using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_cSharp_3.DomainClass
{
    [Table("MoiQuanHe")]
    [Index(nameof(Ma), Name = "UQ__MoiQuanH__3214CC9E07CAA88B", IsUnique = true)]
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
