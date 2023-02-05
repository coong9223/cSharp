using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class HoaDonServices
    {

        private HoaDonRepositories _ChHoaDonRepositories;
        public HoaDonServices()
        {
            _ChHoaDonRepositories = new HoaDonRepositories();
        }

        public string AddHoaDonServices(HoaDon obj)
        {
            if (_ChHoaDonRepositories.AddHoaDonRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateHoaDonServices(HoaDon obj)
        {
            var hd = _ChHoaDonRepositories.GetAll().FirstOrDefault(c => c.Manv == obj.Manv);
            hd.Ma = obj.Ma;
            hd.Manv=obj.Manv;
            hd.TenNguoiNhan=obj.TenNguoiNhan;
            hd.Tensp=obj.Tensp;
            hd.SoLuong=obj.SoLuong;
            hd.NgayTao=obj.NgayTao;
            hd.TongTien=obj.TongTien;


            if (_ChHoaDonRepositories.UpdateHoaDonRepositories(hd))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteHoaDonServices(HoaDon obj)
        {
            var hd = _ChHoaDonRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChHoaDonRepositories.DeleteHoaDonRepositories(hd))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }

        public List<HoaDon> GetHoaDons()
        {
            return _ChHoaDonRepositories.GetAll();
        }











    }
}
