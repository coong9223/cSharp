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
    public class MauSacService : IMauSacService
    {
        
        private IMauSacRepository _iMauSacRepository;
        List<MauSac> _lstMausac;
        public MauSacService()
        {
            _iMauSacRepository = new MauSacRepository();
            _lstMausac = new List<MauSac>();
            GetDataFromDb();
        }

        private void GetDataFromDb()
        {
            _lstMausac = _iMauSacRepository.GetAll();
        }

        public string Add(MauSac obj)
        {
            if (obj == null) return "thêm thất bại";
            var mauSac = obj;
            if (_iMauSacRepository.Add(mauSac))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(MauSac obj)
        {
            if (obj == null) return "xóa thất bại";
            var mauSac = obj;
            if (_iMauSacRepository.Delete(mauSac))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<MauSac> GetAll()
        {
            return _lstMausac;
        }
        public List<MauSac> GetAll(string input)
        {
            if(string.IsNullOrEmpty(input)) return GetAll();
            return _lstMausac.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(MauSac obj)
        {
            if (obj == null) return "sửa thất bại";
            var mauSac = obj;
            if (_iMauSacRepository.Update(mauSac))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public MauSac GetById(Guid id)
        {
            return _lstMausac.FirstOrDefault(c => c.Id == id);
        }
        public Guid GetIdFromTen(string ten)
        {
            return _lstMausac.Where(x => x.Ten == ten).Select(x => x.Id).FirstOrDefault();
        }
    }
}
