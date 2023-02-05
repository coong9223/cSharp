using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public class NhanVienServices
    {
        private NhanVienRepositories _chNhanVienRepositories;
        public NhanVienServices()
        {
            _chNhanVienRepositories = new NhanVienRepositories();
        }

        public string AddNhanVienServices(NhanVien obj)
        {
            if (_chNhanVienRepositories.AddNhanVienRepositories(obj))
            {
                return "Thêm Thành Công";
            }
            return "Thêm không Thành Công";
        }


        public string UpdateNhanVienServices(NhanVien obj)
        {
            var nv= _chNhanVienRepositories.GetAll().FirstOrDefault(c =>c.Ma == obj.Ma);
            nv.Ma= obj.Ma;
            nv.Ten=obj.Ten;
            nv.DiaChi=obj.DiaChi;
            nv.Sdt=obj.Sdt; 
            if (_chNhanVienRepositories.UpdateNhanVienRepositories(nv))
            {
                return "Sửa Thành Công";
            }
            return "Sửa không Thành Công";
        }


        public string DeleteNhanVienServices(NhanVien obj)
        {
            var nv = _chNhanVienRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_chNhanVienRepositories.DeleteNhanVienRepositories(nv))
            {
                return "xóa Thành Công";
            }
            return "xóa không Thành Công";
        }

        public List<NhanVien> GetNhanViens()
        {
            return _chNhanVienRepositories.GetAll();
        }






    }
}
