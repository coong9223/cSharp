using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace OnTapcSharp3.DomainClass
{
    [Table("NXB")]
    [Index(nameof(Ma), Name = "UQ__NXB__3214CC9E44F0F8C5", IsUnique = true)]
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
