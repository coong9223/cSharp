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
    public class HoaDonChiTietService : IHoaDonChiTietSerivce
    {
        private IHoaDonChiTietRepository _iHoaDonChiTietRepository;
        List<HoaDonChiTiet> _lstHoaDonChiTiet;
        public HoaDonChiTietService()
        {
            _iHoaDonChiTietRepository = new HoaDonChiTietRepository();
            _lstHoaDonChiTiet = new List<HoaDonChiTiet>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstHoaDonChiTiet = _iHoaDonChiTietRepository.GetAll();
        }
        public string Add(HoaDonChiTiet obj)
        {
            if (obj == null) return "thêm thất bại";
            var hoaDonChiTiet = obj;
            if (_iHoaDonChiTietRepository.Add(hoaDonChiTiet))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return "xóa thất bại";
            var hoaDonChiTiet = obj;
            if (_iHoaDonChiTietRepository.Delete(hoaDonChiTiet))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _lstHoaDonChiTiet;
        }

        public List<HoaDonChiTiet> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstHoaDonChiTiet.Where(c => c.IdHoaDon == Guid.Parse(input)).ToList();
        }

        public string Update(HoaDonChiTiet obj)
        {
            if (obj == null) return "sửa thất bại";
            var hoaDonChiTiet = obj;
            if (_iHoaDonChiTietRepository.Update(hoaDonChiTiet))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
