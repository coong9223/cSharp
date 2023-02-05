using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2.BUS.iServices;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _1.DAL.DomainClass;

namespace _2.BUS.Services
{
    public class MauSacService:iMauSacService
    {
        private iMauSacRepositories _iMauSacRepositories;
        List<MauSac> _lstMauSac;
        public MauSacService()
        {
            _iMauSacRepositories = new MauSacRepositories();
            _lstMauSac = new List<MauSac>();
        }
        private void GetDFromDb()
        {
            _lstMauSac = _iMauSacRepositories.GetAll();
        }

        string iMauSacService.Add(MauSac obj)
        {
            if (obj == null) return "thêm thất bại";
            if (_iMauSacRepositories.Add(obj))
            {
                GetDFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        string iMauSacService.Delete(MauSac obj)
        {
            if (obj == null) return "xóa thất bại";
            if (_iMauSacRepositories.Delete(obj))
            {
                GetDFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        List<MauSac> iMauSacService.GetAll()
        {
            return _lstMauSac;
        }

        MauSac iMauSacService.GetById(Guid id)
        {
            return _lstMauSac.FirstOrDefault(c => c.Id == id);
        }

        Guid iMauSacService.GetIdFormTen(string ten)
        {
            throw new NotImplementedException();
        }

        string iMauSacService.Update(MauSac obj)
        {
            if (obj == null) return "sửa thất bại";
            if (_iMauSacRepositories.Update(obj))
            {
                GetDFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
