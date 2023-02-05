using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_Template_SM22_Csharp.DomainModels
{
    [Table("NXB")]
    [Index(nameof(Ma), Name = "UQ__NXB__3214CC9EFAF90EC1", IsUnique = true)]
    public partial class Nxb
    {
        public Nxb()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }

        [InverseProperty(nameof(Sach.IdNxbNavigation))]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
