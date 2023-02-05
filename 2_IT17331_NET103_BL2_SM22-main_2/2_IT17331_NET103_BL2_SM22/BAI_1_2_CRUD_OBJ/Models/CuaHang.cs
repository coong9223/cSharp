using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_OBJ.Models;

namespace BAI_1_2_CRUD_OBJ.Models
{
    public class CuaHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int Status { get; set; }//1 Hoạt động - 0 Không hoạt động - 2 Đang sửa chữa
    }
}