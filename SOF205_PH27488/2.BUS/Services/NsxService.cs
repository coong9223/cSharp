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
    public class NsxService : iNsxService
    {
        private iNsxRepositories _iNsxRepositories;
        private List<Nsx> _lstNsx;
        public NsxService()
        {
            _iNsxRepositories = new NsxRepositories();
            _lstNsx = new List<Nsx>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstNsx = _iNsxRepositories.GetAll();
        }
        string iNsxService.Add(Nsx obj)
        {
            if (obj == null) return "thêm thất bại";
            var Nsx = obj;
            if (_iNsxRepositories.Add(Nsx))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        string iNsxService.Delete(Nsx obj)
        {
            if (obj == null) return "xóa thất bại";
            var nsx = obj;
            if (_iNsxRepositories.Delete(nsx))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        List<Nsx> iNsxService.GetAll()
        {
            return _lstNsx;
        }

        Nsx iNsxService.GetById(Guid id)
        {
            return _lstNsx.FirstOrDefault(c => c.Id == id);
        }

        Guid iNsxService.GetIdFormTen(string ten)
        {
            return _lstNsx.Where(x => x.Ten == ten).Select(x => x.Id).FirstOrDefault();
        }

        string iNsxService.Update(Nsx obj)
        {
            if (obj == null) return "sửa thất bại";
            var nsx = obj;
            if (_iNsxRepositories.Update(nsx))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
    }
}
