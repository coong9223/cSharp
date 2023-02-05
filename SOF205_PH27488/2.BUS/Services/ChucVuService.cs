using System;
using System.Collections.Generic;
using System.Text;
using _2.BUS.iServices;
using _1.DAL.Repositories;
using _2.BUS.ViewModels;
using _1.DAL.iRepositories;
using _1.DAL.DomainClass;
using System.Linq;

namespace _2.BUS.Services
{
    public class ChucVuService:iChucVuService
    {
        private iChucVuRepositories iChucVuRepositories;
        List<ChucVu> _lstChucVu;   
        public ChucVuService()
        {
            iChucVuRepositories = new ChucVuRepositories();
            _lstChucVu = new List<ChucVu>();

        }

        string iChucVuService.Add(ChucVu obj)
        {
            if (obj == null) return "thêm thất bại";
            var Nsx = obj;
            if (iChucVuRepositories.Add(Nsx))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        string iChucVuService.Delete(ChucVu obj)
        {
            if (obj == null) return "xóa thất bại";
            var nsx = obj;
            if (iChucVuRepositories.Delete(nsx))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        List<ChucVu> iChucVuService.GetAll()
        {
            return _lstChucVu;
        }

        ChucVu iChucVuService.GetById(Guid id)
        {
            return _lstChucVu.FirstOrDefault(c=>c.Id==id);
        }

        private void GetDataFromDb()
        {
            _lstChucVu = iChucVuRepositories.GetAll();
        }

        Guid iChucVuService.GetIdFormTen(string ten)
        {
            throw new NotImplementedException();
        }

        string iChucVuService.Update(ChucVu obj)
        {
            if (obj == null) return "sửa thất bại";
            var nsx = obj;
            if (iChucVuRepositories.Update(nsx))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
