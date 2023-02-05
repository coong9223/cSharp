using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.iServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class SanPhamService:iSanPhamService
    {
        private iSanPhamRepository iSanPhamRepo;
        public SanPhamService()
        {
            iSanPhamRepo = new SanPhamRepository();
        }

        public string Add(SanPhamView obj)
        {
            if (obj == null) return "that bai";
            var sp = new SanPham()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
            };
            if (iSanPhamRepo.Add(sp)) return "thanh cong";
            return "that bai";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "that bai";
            var temp = iSanPhamRepo.GetAllSp().FirstOrDefault(c => c.Id == obj.id);
            if (iSanPhamRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<SanPhamView> GetAllSp()
        {
            List<SanPhamView> lst = new List<SanPhamView>();
            lst =
                    (
                    from a in iSanPhamRepo.GetAllSp()
                    select new SanPhamView()
                    {
                        id = a.Id,
                        ma = a.Ma,
                        ten = a.Ten,
                    }
                    ).ToList();
            return lst;
        }

        public List<SanPhamView> GetAllSp(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllSp();
            return GetAllSp().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public SanPham GetById(Guid id)
        {
            return iSanPhamRepo.GetAllSp().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string ten)
        {
            return iSanPhamRepo.GetAllSp().FirstOrDefault(c => c.Ten == ten).Id;
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "that bai";
            var temp = iSanPhamRepo.GetAllSp().FirstOrDefault(c => c.Id == obj.id);
            temp.Ma = obj.ma;
            temp.Ten = obj.ten;
            if (iSanPhamRepo.Update(temp)) return "thanh cong";
            return "that bai";
        }
    }
}
