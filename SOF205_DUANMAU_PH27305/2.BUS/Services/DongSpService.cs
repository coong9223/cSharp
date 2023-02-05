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
    public class DongSpService : IDongSpService
    {
        private IDongSpRepository _iDongSpRepository;
        List<DongSp> _lstDongSp;
        public DongSpService()
        {
            _iDongSpRepository = new DongSpRepository();
            _lstDongSp = new List<DongSp>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstDongSp = _iDongSpRepository.GetAll();
        }
        public string Add(DongSp obj)
        {
            if (obj == null) return "thêm thất bại";
            var dongSp = obj;
            if (_iDongSpRepository.Add(dongSp))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(DongSp obj)
        {
            if (obj == null) return "xóa thất bại";
            var dongSp = obj;
            if (_iDongSpRepository.Delete(dongSp))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<DongSp> GetAll()
        {
            return _lstDongSp;
        }

        public List<DongSp> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstDongSp.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(DongSp obj)
        {
            if (obj == null) return "sửa thất bại";
            var dongSp = obj;
            if (_iDongSpRepository.Update(dongSp))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public DongSp GetById(Guid id)
        {
            return _lstDongSp.FirstOrDefault(c => c.Id == id);
        }
        public Guid GetIdFromTen(string ten)
        {
            return _lstDongSp.Where(x => x.Ten == ten).Select(x => x.Id).FirstOrDefault();
        }
    }
}
