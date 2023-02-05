using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class KhachHangServices
    {

        private KhachHangRepositories _ChKhachHangRepositories;
        public KhachHangServices()
        {
            _ChKhachHangRepositories = new KhachHangRepositories();
        }

        public string AddKhachHangServices(KhachHang obj)
        {
            if (_ChKhachHangRepositories.AddKhachHangRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateKhachHangServices(KhachHang obj)
        {
            var kh = _ChKhachHangRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            kh.Ma = obj.Ma;
            kh.Ten = obj.Ten;
            kh.NgaySinh = obj.NgaySinh;
            kh.GioiTinh = obj.GioiTinh;
            kh.DiaChi = obj.DiaChi;
            kh.Sdt = obj.Sdt;

            if (_ChKhachHangRepositories.UpdateKhachHangRepositories(kh))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteKhachHangServices(KhachHang obj)
        {
            var kh = _ChKhachHangRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChKhachHangRepositories.DeleteKhachHangRepositories(kh))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }
        public List<KhachHang> GetKhachHangs()
        {
            return _ChKhachHangRepositories.GetAll();
        }
    }
}
