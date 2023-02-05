using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class SanPhamServices
    {

        private SanPhamRepositories _ChSanPhamRepositories;
        public SanPhamServices()
        {
            _ChSanPhamRepositories = new SanPhamRepositories();
        }

        public string AddSanPhamServices(SanPham obj)
        {
            if (_ChSanPhamRepositories.AddSanPhamRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateSanPhamServices(SanPham obj)
        {
            var sp = _ChSanPhamRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            sp.Ma = obj.Ma;
            sp.Ten = obj.Ten;
            sp.GiaBan = obj.GiaBan;
            sp.SoLuongTon = obj.SoLuongTon;
            sp.DanhMuc = obj.DanhMuc;
            sp.TrangThai = obj.TrangThai;

            if (_ChSanPhamRepositories.UpdateSanPhamRepositories(sp))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteSanPhamServices(SanPham obj)
        {
            var sp = _ChSanPhamRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChSanPhamRepositories.DeleteSanPhamRepositories(sp))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }
        public List<SanPham> GetSanPhams()
        {
            return _ChSanPhamRepositories.GetAll();
        }
    }
}
