using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NsxService : INsxService
    {
        private INsxRepository _iNsxRepository;
        List<Nsx> _lstNsx;
        public NsxService()
        {
            _iNsxRepository = new NsxRepository();
            _lstNsx = new List<Nsx>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstNsx = _iNsxRepository.GetAll();
        }
        public string Add(Nsx obj)
        {
            if (obj == null) return "thêm thất bại";
            var nsx = obj;
            if (_iNsxRepository.Add(nsx))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(Nsx obj)
        {
            if (obj == null) return "xóa thất bại";
            var nsx = obj;
            if (_iNsxRepository.Delete(nsx))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<Nsx> GetAll()
        {
            return _lstNsx;
        }
        public List<Nsx> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstNsx.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(Nsx obj)
        {
            if (obj == null) return "sửa thất bại";
            var nsx = obj;
            if (_iNsxRepository.Update(nsx))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public Nsx GetById(Guid id)
        {
            return _lstNsx.FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdFromTen(string ten)
        {
            return _lstNsx.Where(x => x.Ten == ten).Select(x => x.Id).FirstOrDefault();
        }
    }
}
