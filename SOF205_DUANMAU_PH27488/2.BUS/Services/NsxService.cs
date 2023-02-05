using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.iRepositories;
using _2.BUS.iServices;
using _2.BUS.ViewModels;
using _1.DAL.DomainClass;
using _1.DAL.Repositories;

namespace _2.BUS.Services
{
    public class NsxService : iNsxService
    {
        private iNsxRepository _iNsxRepository;
        List<NsxView> _lstNsxView;
        public NsxService()
        {
            _iNsxRepository = new NsxRepository();
            _lstNsxView = new List<NsxView>();
        }

        string iNsxService.Add(NsxView nsx)
        {
            if (nsx == null) return "thêm không thành công";
            var Nsx = nsx.nsx;
            var NsxView = new Nsx()
            {
                Id = nsx.Id,
                Ma = nsx.ma,
                Ten = nsx.ten,
            };
            if (_iNsxRepository.Add(Nsx)) return "thêm thành công";
            return "thêm không thành công";
        }

        string iNsxService.Delete(NsxView nsx)
        {
            if (nsx == null) return "xóa thất bại";
            var Nsx = nsx.nsx;
            if (_iNsxRepository.Delete(Nsx)) return "xóa thành công";
            return "xóa thất bại";
        }

        Nsx iNsxService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        List<NsxView> iNsxService.GetData()
        {
            _lstNsxView = (from a in _iNsxRepository.GetAll()
                           select new NsxView()
                           {
                               nsx = a,
                               Id = a.Id,
                               ma = a.Ma,
                               ten = a.Ten,

                           }).ToList();
            return _lstNsxView;
        }

        string iNsxService.Update(NsxView nsx)
        {
            if (nsx == null) return "sửa thất bại";
            var Nsx=nsx.nsx;
            if (_iNsxRepository.Update(Nsx))return "sửa thành công";               
            return "sửa thất bại";
        }
        
    }
}
