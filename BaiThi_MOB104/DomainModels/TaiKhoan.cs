using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BaiThi_MOB104.DomainModels
{
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("TenTK")]
        [StringLength(30)]
        public string TenTk { get; set; }
        [StringLength(50)]
        public string Pass { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
    }
}
