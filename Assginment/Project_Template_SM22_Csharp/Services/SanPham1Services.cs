
using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{

    public class SanPham1Services
    {
        private SanPham1Repositories  _chSanPham1Repositoriesq;

        public SanPham1Services() {
            _chSanPham1Repositoriesq = new SanPham1Repositories();
        }
        public string AddSanPham1Services(SanPham obj)
        {
            if (_chSanPham1Repositoriesq.AddSanPham1Repositories(obj))
            {
                return "Thêm Thành công";
            }
            return "Thêm k Thành công";
        }


        public string UpdateSanPham1Services(SanPham obj)
        {
            var sp1 = _chSanPham1Repositoriesq.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            sp1.Ma=obj.Ma;
            sp1.Ten=obj.Ten;    
            sp1.GiaBan=obj.GiaBan;
            sp1.TrangThai = obj.TrangThai;
            sp1.Website = obj.Website;
            if (_chSanPham1Repositoriesq.UpdateSanPham1Repositories(sp1))
            {
                return "Sửa Thành công";
            }
            return "Sửa k Thành công";
        }
        public string DeleteSanPham1Services(SanPham obj)
        {
            var sp1 = _chSanPham1Repositoriesq.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);

            if (_chSanPham1Repositoriesq.DeleteSanPham1Repositories(sp1))
            {
                return "xoá Thành công";
            }
            return "Xóa k Thành công";
        }
        public List<SanPham> GetSanPhams()
        {
            return _chSanPham1Repositoriesq.GetAll();
        }
        public List<string> GetWebs()
        {
            return new List<string>(){"fpt.com", "thế giới di độ"};
        }
    }
  
}
