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
    public class MauSacService:iMauSacService
    {
        private iMauSacRepository iMauSacRepo;
        public MauSacService()
        {
            iMauSacRepo = new MauSacRepository();
        }

        public string Add(MauSacView obj)
        {
            if (obj == null) return "that bai";
            var ms = new MauSac()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
            };
            if (iMauSacRepo.Add(ms)) return "thanh cong";
            return "that bai";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "that bai";
            var temp=iMauSacRepo.GetAllMs().FirstOrDefault(c=>c.Id==obj.id);
            if (iMauSacRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<MauSacView> GetAllMs()
        {
            List<MauSacView> lst = new List<MauSacView>();
            lst = (from a in iMauSacRepo.GetAllMs()
                   select new MauSacView()
                   {
                       id = a.Id,
                       ma = a.Ma,
                       ten = a.Ten,
                   }).ToList();
            return lst;
        }

        public List<MauSacView> GetAllMs(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllMs();
            return GetAllMs().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public MauSac GetById(Guid id)
        {
            return iMauSacRepo.GetAllMs().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string ten)
        {
            return iMauSacRepo.GetAllMs().FirstOrDefault(c => c.Ten == ten).Id;
        }

        public string Update(MauSacView obj)
        {
            if (obj == null) return "that bai";
            var temp = iMauSacRepo.GetAllMs().FirstOrDefault(c => c.Id == obj.id);
            temp.Ma = obj.ma;
            temp.Ten = obj.ten;
            if (iMauSacRepo.Update(temp)) return "thanh cong";
            return "that bai";
        }
    }
}
