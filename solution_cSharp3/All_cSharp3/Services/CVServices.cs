using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using All_cSharp3.DomainClass;
using All_cSharp3.Repositories;

namespace All_cSharp3.Services
{
    public class CVServices
    {
        private CVRepositories _CVRepo;
        private List<ChucVu> _lstCV;

        public CVServices()
        {
            _CVRepo = new CVRepositories();
            _lstCV = new List<ChucVu>();
        }

        public void GetDataFromDB()
        {
            _lstCV=_CVRepo.GetAll();
        }

        public string Add(ChucVu cv)
        {
            if (_CVRepo.Add(cv))
            {
                GetDataFromDB();
                return "thêm thành viên";
            }
            return "thêm thất bại";
        }

        public string Update(ChucVu cv)
        {
            var temp = _CVRepo.GetAll().FirstOrDefault(c => c.Id == cv.Id);
            temp.Ma=cv.Ma;
            temp.Ten=cv.Ten;
            if (_CVRepo.Update(cv))
            {
                GetDataFromDB();
                return "thêm thành viên";
            }
            return "thêm thất bại";
        }

        public string Delete(ChucVu cv)
        {
            var temp=_CVRepo.GetAll().FirstOrDefault(c => c.Id == cv.Id);
            if (_CVRepo.Delete(cv))
            {
                GetDataFromDB();
                return "xóa thành viên";
            }
            return "xóa thất bại";
        }


        public List<ChucVu> GetAllCV()//Trả về danh sách các cửa hàng
        {
            return _lstCV;
        }
        public ChucVu GetId(Guid Id)
        {
            return _lstCV.FirstOrDefault(c => c.Id == Id);
        }

        internal object GetAllCV(object value)
        {
            throw new NotImplementedException();
        }
    }
}
