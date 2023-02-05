using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class GioHangServices
    {
        private GioHangRepositories _ChGioHangRepositories;
        public GioHangServices()
        {
            _ChGioHangRepositories = new GioHangRepositories();
        }

        public string AddGioHangServices(GioHang obj)
        {
            if (_ChGioHangRepositories.AddGioHangRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateGioHangServices(GioHang obj)
        {
            var gh = _ChGioHangRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            gh.Masp = obj.Masp;
            gh.Tensp = obj.Tensp;
            gh.GiaBan = obj.GiaBan;
            gh.SoLuongTon = obj.SoLuongTon;
            gh.DanhMuc = obj.DanhMuc;
            gh.TrangThai = obj.TrangThai;


            if (_ChGioHangRepositories.UpdateGioHangRepositories(gh))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteGioHangServices(GioHang obj)
        {
            var gh = _ChGioHangRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChGioHangRepositories.DeleteGioHangRepositories(gh))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }

        public List<GioHang> GetGioHangs()
        {
            return _ChGioHangRepositories.GetAll();
        }

    }
}
