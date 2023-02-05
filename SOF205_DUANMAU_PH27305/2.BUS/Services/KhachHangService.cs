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
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepository;
        List<KhachHang> _lstKhachHang;
        public KhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
            _lstKhachHang = new List<KhachHang>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstKhachHang = _iKhachHangRepository.GetAll();
        }
        public string Add(KhachHang obj)
        {
            if (obj == null) return "thêm thất bại";
            var khachHang = obj;
            if (_iKhachHangRepository.Add(khachHang))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(KhachHang obj)
        {
            if (obj == null) return "xóa thất bại";
            var khachHang = obj;
            if (_iKhachHangRepository.Delete(khachHang))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<KhachHang> GetAll()
        {
            return _lstKhachHang;
        }

        public List<KhachHang> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstKhachHang.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(KhachHang obj)
        {
            if (obj == null) return "sửa thất bại";
            var khachHang = obj;
            if (_iKhachHangRepository.Update(khachHang))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public KhachHang GetById(Guid id)
        {
            return _lstKhachHang.FirstOrDefault(c=>c.Id == id);
        }
        public Guid GetIdByName(string input)
        {
            return _lstKhachHang.Where(x => x.Ten == input).Select(x => x.Id).FirstOrDefault();
        }
        public List<String> TrangThai()
        {
            return new List<String>() { "Không Hoạt Động", "Hoạt Động" };
        }
    }
}
