using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLHoaDonService : IQLHoaDonService
    {
        private IHoaDonChiTietRepository _iHoaDonChiTietRepository;
        private IHoaDonRepository _iHoaDonRepository;
        private INhanVienRepository _iNhanVienRepository;
        private IKhachHangRepository _iKhachHangRepository;
        private IQLSanPhamService _iQlSanphamService;
        public QLHoaDonService()
        {
            _iHoaDonChiTietRepository = new HoaDonChiTietRepository();
            _iHoaDonRepository = new HoaDonRepository();
            _iNhanVienRepository = new NhanVienRepository();
            _iKhachHangRepository = new KhachHangRepository();
            _iQlSanphamService = new QLSanPhamService();
        }
        public string Add(QLHoaDonView obj)
        {
            if (obj == null) return "thêm thất bại";
            var hoaDonChiTiet = obj.HoaDonChiTiet;
            if (_iHoaDonChiTietRepository.Add(hoaDonChiTiet) && _iHoaDonRepository.Update(obj.HoaDon)) return "thêm thành công";
            return "thêm thất bại";
        }

        public string Delete(QLHoaDonView obj)
        {
            if (obj == null) return "xóa thất bại";
            var hoaDonChiTiet = obj.HoaDonChiTiet;
            if (_iHoaDonChiTietRepository.Delete(hoaDonChiTiet)) return "xóa thành công";
            return "xóa thất bại";
        }

        public List<QLHoaDonView> GetAll()
        {
            List<QLHoaDonView> lstHoadonViews = new List<QLHoaDonView>();
            lstHoadonViews =
                (
                    from a in _iHoaDonRepository.GetAll()
                    join b in _iNhanVienRepository.GetAll() on a.IdNv equals b.Id
                    join c in _iKhachHangRepository.GetAll() on a.IdKh equals c.Id
                    join d in _iHoaDonChiTietRepository.GetAll() on a.Id equals d.IdHoaDon
                    join e in _iQlSanphamService.GetAll() on d.IdChiTietSp equals e.ChiTietSp.Id
                    select new QLHoaDonView()
                    {
                        HoaDon = a,
                        NhanVien = b,
                        KhachHang = c,
                        HoaDonChiTiet = d,
                        QLSanPhamView = e,
                    }
                ).ToList();
            return lstHoadonViews;
        }

        public string Update(QLHoaDonView obj)
        {
            if (obj == null) return "sửa thất bại";
            var hoaDonChiTiet = obj.HoaDonChiTiet;
            if (_iHoaDonChiTietRepository.Update(hoaDonChiTiet) && _iHoaDonRepository.Update(obj.HoaDon)) return "sửa thành công";
            return "sửa thất bại";
        }
    }
}
