using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class TaiKhoanServices
    {
        private TaiKhoanRepositories _ChTaiKhoanRepositories;
        public TaiKhoanServices()
        {
            _ChTaiKhoanRepositories = new TaiKhoanRepositories();
        }

        public string AddTaiKhoanServices(TaiKhoan obj)
        {
            if (_ChTaiKhoanRepositories.AddTaiKhoanRepositories(obj))
            {
                return "Tạo tài khoản Thành công";
            }
            return "Tạo tài khoản  không Thành công";
        }

        public string UpdateTaiKhoanServices(TaiKhoan obj)
        {
            var nv = _ChTaiKhoanRepositories.GetAll().FirstOrDefault(c => c.TenTk == obj.TenTk);
            nv.TenTk = obj.TenTk;
            nv.Pass = obj.Pass;
            nv.Sdt = obj.Sdt;

            if (_ChTaiKhoanRepositories.UpdateTaiKhoanRepositories(nv))
            {
                return "Sửa tài khoản Thành công";
            }
            return "Sửa không tài khoản Thành công";
        }
        public string DeleteTaiKhoanServices(TaiKhoan obj)
        {
            var nv = _ChTaiKhoanRepositories.GetAll().FirstOrDefault(c => c.TenTk == obj.TenTk);

            if (_ChTaiKhoanRepositories.DeleteTaiKhoanRepositories(nv))
            {
                return "Xóa tài khoản Thành công";
            }
            return "Xóa tài khoản không Thành công";
        }


        public List<TaiKhoan> GetTaiKhoans()
        {
            return _ChTaiKhoanRepositories.GetAll();
        }

    }
}
