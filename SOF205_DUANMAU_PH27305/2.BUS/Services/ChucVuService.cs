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
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository _iChucVuRepository;
        List<ChucVu> _lstChucVu;
        public ChucVuService()
        {
            _iChucVuRepository = new ChucVuRepository();
            _lstChucVu = new List<ChucVu>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstChucVu = _iChucVuRepository.GetAll();
        }
        public string Add(ChucVu obj)
        {
            if (obj == null) return "thêm thất bại";
            var chucVu = obj;
            if (_iChucVuRepository.Add(chucVu))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(ChucVu obj)
        {
            if (obj == null) return "xóa thất bại";
            var chucVu = obj;
            if (_iChucVuRepository.Delete(chucVu))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<ChucVu> GetAll()
        {
            return _lstChucVu;
        }

        public List<ChucVu> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstChucVu.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(ChucVu obj)
        {
            if (obj == null) return "sửa thất bại";
            var chucVu = obj;
            if (_iChucVuRepository.Update(chucVu))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public ChucVu GetById(Guid id)
        {
            return _lstChucVu.FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string input)
        {
            return _lstChucVu.Where(x => x.Ten == input).Select(x => x.Id).FirstOrDefault();
        }
    }
}
