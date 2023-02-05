using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Practice_cSharp_3.DomainClass;
using Practice_cSharp_3.Repositories;
using Practice_cSharp_3.Views;
namespace Practice_cSharp_3.Services
{
    public class PracticesSer
    {
        PracticesRepo _PracticesRepos;
        public PracticesSer()
        {
            _PracticesRepos = new PracticesRepo();
        }

        public string DeleteSp(SanPham sp)
        {
            var item=_PracticesRepos.GelAllSP().FirstOrDefault(c=>c.Id == sp.Id);
            if (_PracticesRepos.DeleteSp(item))
            {
                return "thành công";
            }return "thất bại";
        }

        public string AddSp(SanPham sp)
        {
            if (_PracticesRepos.AddSp(sp))
            {
                return "thành công";
            }
            return "thất bại";
        }

        public string Update(SanPham sp)
        {
            var item = _PracticesRepos.GelAllSP().FirstOrDefault(c => c.Id == sp.Id);
            sp.Ten=item.Ten;
            sp.Ma=item.Ma;
            sp.GiaBan=item.GiaBan;  
            sp.TrangThai = item.TrangThai;
            if (_PracticesRepos.UpdateSp(sp))
            {
                return "thành công";
            }
            return "thất bại";
        }


        public List<SanPham> GetAllSps()
        {
            return _PracticesRepos.GelAllSP();
        }


        public List<string> GetAllWebsites()
        {
            return new List<string> { "fpt.vn", "w3school.com" };
        }
    }
}
