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
    public class SanPhamService : ISanPhamService
    {
        private ISanPhamRepository _iSanPhamRepository;
        List<SanPham> _lstSanPham;
        public SanPhamService()
        {
            _iSanPhamRepository = new SanPhamRepository();
            _lstSanPham = new List<SanPham>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstSanPham = _iSanPhamRepository.GetAll();
        }
        public string Add(SanPham obj)
        {
            if (obj == null) return "thêm thất bại";
            var sanPham = obj;
            if (_iSanPhamRepository.Add(sanPham))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(SanPham obj)
        {
            if (obj == null) return "xóa thất bại";
            var sanPham = obj;
            if (_iSanPhamRepository.Delete(sanPham))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<SanPham> GetAll()
        {
            return _lstSanPham;
        }

        public List<SanPham> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstSanPham.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }
        public string Update(SanPham obj)
        {
            if (obj == null) return "sửa thất bại";
            var sanPham = obj;
            if (_iSanPhamRepository.Add(sanPham))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public SanPham GetById(Guid id)
        {
            return _lstSanPham.FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string input)
        {
            return _lstSanPham.FirstOrDefault(c => c.Ten == input).Id;
        }
    }
}
