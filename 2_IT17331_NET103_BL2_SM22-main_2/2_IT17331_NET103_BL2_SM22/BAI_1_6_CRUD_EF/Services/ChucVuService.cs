using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Services
{
    public class ChucVuService
    {
        private List<ChucVu> _lstChucVus;
        private ChucVuRepository _CVRepository;


        public ChucVuService()
        {

            _lstChucVus = new List<ChucVu>();
            _CVRepository = new ChucVuRepository();
            GetDataFromDB();

        }

        private void GetDataFromDB()
        {
            _lstChucVus = _CVRepository.GetAll();
        }

        public string Add(ChucVu obj)
        {
            if (_CVRepository.Add(obj))
            {
                GetDataFromDB();
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string Update(ChucVu obj)
        {
            var temp = _CVRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            if (_CVRepository.Update(temp))
            {
                GetDataFromDB();
                return "Sửa thành công";
            }

            return "Sửa thất bại";

        }

        public string Delete(ChucVu obj)
        {
            var temp = _CVRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_CVRepository.Delete(temp))
            {
                GetDataFromDB();
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }
        public ChucVu GetChucVuById(Guid id)
        {


            return _lstChucVus.FirstOrDefault(c => c.Id == id);

        }

        public List<ChucVu> GetAllChucVu()
        {

            return _lstChucVus;
        }

        public List<ChucVu> GetAllChucVu(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllChucVu();
            }

            return _lstChucVus.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();

        }
    }
}
