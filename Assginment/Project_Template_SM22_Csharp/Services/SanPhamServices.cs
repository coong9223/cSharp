using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
   public class SanPhamServices
    {

        private SanPhamRepositories _chSanPhamRepositories;

        public SanPhamServices()
        {
            _chSanPhamRepositories = new SanPhamRepositories();
        }

        public string AddSanPhamServices(SanPham obj )
        {
            if (_chSanPhamRepositories.AddSanPhamRepositories(obj))
            {
                return "Thêm Thành Công";
            }
            return "Thêm không Thành Công";
        }

        public string UpdateSanPhamServices(SanPham obj)
        {
            var sp = _chSanPhamRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            sp.Ma = obj.Ma;
            sp.Ten = obj.Ten;
            sp.GiaBan = obj.GiaBan;
            sp.TrangThai=obj.TrangThai;



            if (_chSanPhamRepositories.UpdateSanPhamRepositories(sp))
            {
                return "Sửa Thành Công";
            }
            return "Sửa không Thành Công";
        }

        public string DeleteSanPhamServices(SanPham obj)
        {
            var sp = _chSanPhamRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
          
            if (_chSanPhamRepositories.DeleteSanPhamRepositories(sp))
            {
                return "Sửa Thành Công";
            }
            return "Sửa không Thành Công";
        }

        public List<SanPham> GetSanPhams()
        {
            return _chSanPhamRepositories.GetAll();
        }
        //public List<string> GetSoluong(string)
        //{
        //    return { }
        //}


    }
}
