using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_EFCORE_CODEFIRST.DomainClass
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public Guid Id { get; set; }
        public string MaSV { get; set; }

    }
}
