using System;
using System.Collections.Generic;
using System.Text;

namespace bai_1._2_CRUD_OBJECT.Models
{
    public class CuaHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int Status { get; set; }

    }
}
