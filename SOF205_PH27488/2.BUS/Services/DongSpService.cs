using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.iServices;
using _1.DAL.DomainClass;

namespace _2.BUS.Services
{
    public class DongSpService: iDongSpService
    {
        private iDongSpRepositories _iDongSpRepositories;
        private List<DongSp> _lstDongSp;
        public DongSpService()
        {
            _iDongSpRepositories = new DongSpRepositories();
            _lstDongSp = new List<DongSp>();
            GetDataFromDb();
        }

        string iDongSpService.Add(DongSp obj)
        {
            if (obj == null) return "thêm thất bại";
            var DongSp = obj;
            if (_iDongSpRepositories.Add(DongSp))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        string iDongSpService.Delete(DongSp obj)
        {
            if (obj == null) return "xóa thất bại";
            var DongSp = obj;
            if (_iDongSpRepositories.Delete(DongSp))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        List<DongSp> iDongSpService.GetAll()
        {
            return _lstDongSp;
        }

        DongSp iDongSpService.GetById(Guid id)
        {
            return _lstDongSp.FirstOrDefault(c => c.Id == id);
        }

        private void GetDataFromDb()
        {
            _lstDongSp = _iDongSpRepositories.GetAll();
        }

        Guid iDongSpService.GetIdFormTen(string ten)
        {
            throw new NotImplementedException();
        }

        string iDongSpService.Update(DongSp obj)
        {
            if (obj == null) return "sửa thất bại";
            var DongSp = obj;
            if (_iDongSpRepositories.Update(DongSp))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
