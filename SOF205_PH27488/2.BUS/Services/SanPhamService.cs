using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _2.BUS.iServices;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using System.Linq;

namespace _2.BUS.Services
{
    public class SanPhamService : iSanPhamService
    {
        private iSanPhamRepositories _iSanPhamRepositories;
        private List<SanPham> _lstSanPham;
        public SanPhamService()
        {
            _iSanPhamRepositories = new SanPhamRepositories();
            _lstSanPham=new List<SanPham>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstSanPham=_iSanPhamRepositories.GetAll();
        }
        string iSanPhamService.Add(SanPham obj)
        {
            if (obj == null) return "thêm không thành công";
            var Nsx = obj;
            if (_iSanPhamRepositories.Add(Nsx))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm không thành công";
        }

        string iSanPhamService.Delete(SanPham obj)
        {
            if (obj == null) return "xóa không thành công";
            var SanPham = obj;
            if (_iSanPhamRepositories.Delete(SanPham))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa không thành công";
        }

        List<SanPham> iSanPhamService.GetAll()
        {
            return _lstSanPham;
        }

        SanPham iSanPhamService.GetById(Guid id)
        {
            return _lstSanPham.FirstOrDefault(c=>c.Id== id);
        }

        Guid iSanPhamService.GetIdFormTen(string ten)
        {
            return _lstSanPham.Where(x => x.Ten == ten).Select(x => x.Id).FirstOrDefault();
        }

        string iSanPhamService.Update(SanPham obj)
        {
            if (obj == null) return "sửa thất bại";
            var SanPham = obj;
            if (_iSanPhamRepositories.Update(SanPham))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
