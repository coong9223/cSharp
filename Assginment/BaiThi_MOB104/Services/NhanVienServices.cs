using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class NhanVienServices
    {
        private NhanVienRepositories _ChNhanVienRepositories;
        public NhanVienServices()
        {
            _ChNhanVienRepositories = new NhanVienRepositories();
        }

        public string AddNhanVienServices(NhanVien obj)
        {
            if (_ChNhanVienRepositories.AddNhanVienRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateNhanVienServices(NhanVien obj)
        {
            var nv = _ChNhanVienRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            nv.Ma = obj.Ma;
            nv.Ten = obj.Ten;
            nv.NgaySinh = obj.NgaySinh;
            nv.GioiTinh = obj.GioiTinh;
            nv.DiaChi = obj.DiaChi;
            nv.Sdt = obj.Sdt;

            if (_ChNhanVienRepositories.UpdateNhanVienRepositories(nv))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteNhanVienServices(NhanVien obj)
        {
            var nv = _ChNhanVienRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChNhanVienRepositories.DeleteNhanVienRepositories(nv))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }
        public List<NhanVien> GetNhanViens()
        {
            return _ChNhanVienRepositories.GetAll();
        }


    }
}
