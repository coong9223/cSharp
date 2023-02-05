using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAI_1_6_EFCORE_CODEFIRST.DomainClass
{
    [Table("Point")]
    public class Point
    {
        [Key]
        public Guid ID { get; set; }
        public string Mon { get; set; }



        [ForeignKey("IdSv")]
        public SinhVien SinhVien { get; set; }

    }
}
