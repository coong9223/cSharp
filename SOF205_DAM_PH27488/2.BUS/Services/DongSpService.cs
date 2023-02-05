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
    public class DongSpService:iDspService
    {
        private iDspRepository iDspRepo;
        public DongSpService()
        {
            iDspRepo = new DspRepository();
        }

        public string Add(DongSpView obj)
        {
            if (obj == null) return "that bai";
            var dsp = new DongSp()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
            };
            if (iDspRepo.Add(dsp)) return "thanh cong";
            return "that bai";
        }

        public string Delete(DongSpView obj)
        {
            if (obj == null) return "that bai";
            var temp = iDspRepo.GetAllDsp().FirstOrDefault(c => c.Id == obj.id);
            if (iDspRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<DongSpView> GetAllDsp()
        {
            List<DongSpView> lst = new List<DongSpView>();
            lst=(from a in iDspRepo.GetAllDsp()
                 select new DongSpView()
                 {
                     id=a.Id,
                     ma=a.Ma,
                     ten=a.Ten,
                 }).ToList();
            return lst;
        }

        public List<DongSpView> GetAllDsp(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllDsp();
            return GetAllDsp().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public DongSp GetById(Guid id)
        {
            return iDspRepo.GetAllDsp().FirstOrDefault(c=>c.Id==id);
        }

        public Guid GetIdByName(string ten)
        {
            return iDspRepo.GetAllDsp().FirstOrDefault(c => c.Ten == ten).Id;
        }

        public string Update(DongSpView obj)
        {
            if (obj == null) return "that bai";
            var temp = iDspRepo.GetAllDsp().FirstOrDefault(c => c.Id == obj.id);
            temp.Ma = obj.ma;
            temp.Ten = obj.ten;
            if (iDspRepo.Update(temp)) return "thanh cong";
            return "that bai";
        }
    }
}
