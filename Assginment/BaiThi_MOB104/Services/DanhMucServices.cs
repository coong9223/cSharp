using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Services
{
    public class DanhMucServices
    {
        private DanhMucRepositories _ChDanhMucRepositories;
        public DanhMucServices()
        {
            _ChDanhMucRepositories = new DanhMucRepositories();
        }

        public string AddDanhMucServices(DongSp obj)
        {
            if (_ChDanhMucRepositories.AddDanhMucRepositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm  không Thành công";
        }

        public string UpdateDanhMucServices(DongSp obj)
        {
            var dm = _ChDanhMucRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            dm.Ma = obj.Ma;
            dm.Ten = obj.Ten;


            if (_ChDanhMucRepositories.UpdateDanhMucRepositories(dm))
            {
                return "Sửa Thành công";
            }
            return "Sửa không Thành công";
        }
        public string DeleteDanhMucServices(DongSp obj)
        {
            var kh = _ChDanhMucRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_ChDanhMucRepositories.DeleteDanhMucRepositories(kh))
            {
                return "Xóa Thành công";
            }
            return "Xóa không Thành công";
        }
        public List<DongSp> GetDongSps()
        {
            return _ChDanhMucRepositories.GetAll();
        }


    }
}
