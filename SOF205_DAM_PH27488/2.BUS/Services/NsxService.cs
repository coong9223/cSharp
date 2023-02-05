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
    public class NsxService:iNsxService
    {
        private iNsxRepository iNsxRepo;
        public NsxService()
        {
            iNsxRepo = new NsxRepository();
        }

        public string Add(NsxView obj)
        {
            if (obj == null) return "that bai";
            var nsx = new Nsx()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
            };
            if (iNsxRepo.Add(nsx)) return "thanh cong";
            return "that bai";
        }

        public string Delete(NsxView obj)
        {
            if (obj == null) return "that bai";
            var temp=iNsxRepo.GetAllNsx().FirstOrDefault(c=>c.Id==obj.id);  
            if (iNsxRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<NsxView> GetAllNsx()
        {
            List<NsxView> lst = new List<NsxView>();
            lst=(from a in iNsxRepo.GetAllNsx()
                 select new NsxView()
                 {
                     id=a.Id,
                     ma=a.Ma,
                     ten=a.Ten,
                 }).ToList();
            return lst;
        }

        public List<NsxView> GetAllNsx(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllNsx();
            return GetAllNsx().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public Nsx GetById(Guid id)
        {
            return iNsxRepo.GetAllNsx().FirstOrDefault(c=>c.Id==id);
        }

        public Guid GetIdByName(string ten)
        {
            return iNsxRepo.GetAllNsx().FirstOrDefault(c => c.Ten == ten).Id;
        }

        public string Update(NsxView obj)
        {
            if (obj == null) return "that bai";
            var temp = iNsxRepo.GetAllNsx().FirstOrDefault(c => c.Id == obj.id);
            temp.Ma = obj.ma;
            temp.Ten = obj.ten;
            if (iNsxRepo.Update(temp)) return "thanh cong";
            return "that bai";

        }
    }
}
