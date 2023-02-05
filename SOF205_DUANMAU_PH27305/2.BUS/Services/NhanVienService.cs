using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        List<NhanVien> _lstNhanVien;
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _lstNhanVien = new List<NhanVien>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstNhanVien = _iNhanVienRepository.GetAll();
        }
        public string Add(NhanVien obj)
        {
            if (obj == null) return "thêm thất bại";
            var nhanVien = obj;
            if (_iNhanVienRepository.Add(nhanVien))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(NhanVien obj)
        {
            if (obj == null) return "xóa thất bại";
            var nhanVien = obj;
            if (_iNhanVienRepository.Delete(nhanVien))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<NhanVien> GetAll()
        {
            return _lstNhanVien;
        }

        public List<NhanVien> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstNhanVien.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(NhanVien obj)
        {
            if (obj == null) return "sửa thất bại";
            var nhanVien = obj;
            if (_iNhanVienRepository.Update(nhanVien))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
