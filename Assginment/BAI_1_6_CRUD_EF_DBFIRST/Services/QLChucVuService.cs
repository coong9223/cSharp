using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using BAI_1_6_CRUD_EF_DBFIRST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Services
{
    public class QLChucVuService
    {
        List<ChucVu> _lstChucVu;
        ChucVuRepository _cvRepository;
        public QLChucVuService()
        {
            _lstChucVu = new List<ChucVu>();
            _cvRepository = new ChucVuRepository();
            GetDataFromDB();
        }
        private void GetDataFromDB()
        {
            _lstChucVu = _cvRepository.GetAll();
        }
        public string Add(ChucVu chucvu)
        {
            if (_cvRepository.Add(chucvu))
            {
                GetDataFromDB();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string Update(ChucVu chucvu)
        {
            var temp = _cvRepository.GetAll().FirstOrDefault(c => c.Id == chucvu.Id);
            temp.Ma = chucvu.Ma;
            temp.Ten = chucvu.Ten;
            if (_cvRepository.Update(temp))
            {
                GetDataFromDB();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public string Delete(ChucVu chucvu)
        {
            var temp = _cvRepository.GetAll().FirstOrDefault(c => c.Id == chucvu.Id);
            if (_cvRepository.Delete(temp))
            {
                GetDataFromDB();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }
        public ChucVu GetChucVuById(Guid Id)
        {
            return _lstChucVu.FirstOrDefault(c => c.Id == Id);
        }
        public List<ChucVu> GetAllChucVu()
        {
            return _lstChucVu;
        }
        public List<ChucVu> GetAllChucVu(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllChucVu();
            }
            return _lstChucVu.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }
    }
}
