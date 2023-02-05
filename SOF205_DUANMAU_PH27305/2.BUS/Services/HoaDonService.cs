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
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _iHoaDonRepository;
        List<HoaDon> _lstHoaDon;
        public HoaDonService()
        {
            _iHoaDonRepository = new HoaDonRepository();
            _lstHoaDon = new List<HoaDon>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstHoaDon = _iHoaDonRepository.GetAll();
        }
        public string Add(HoaDon obj)
        {
            if (obj == null) return "thêm thất bại";
            var hoaDon = obj;
            if (_iHoaDonRepository.Add(hoaDon))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(HoaDon obj)
        {
            if (obj == null) return "xóa thất bại";
            var hoaDon = obj;
            if (_iHoaDonRepository.Delete(hoaDon))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<HoaDon> GetAll()
        {
            return _lstHoaDon;
        }

        public List<HoaDon> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstHoaDon.Where(c=>c.Ma.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(HoaDon obj)
        {
            if (obj == null) return "sửa thất bại";
            var hoaDon = obj;
            if (_iHoaDonRepository.Update(hoaDon))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
