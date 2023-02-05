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
    public class CuaHangService:iCuaHangService
    {
        private iCuaHangRepository iCuaHangRepo;
        public CuaHangService()
        {
            iCuaHangRepo = new CuaHangRepository();
        }

        public string Add(CuaHangView obj)
        {
            if (obj == null) return "that bai";
            var ch = new CuaHang()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
            };
            if (iCuaHangRepo.Add(ch)) return "thanh cong";
            return "that bai";
        }

        public string Delete(CuaHangView obj)
        {
            if (obj == null) return "that bai";
            var temp = iCuaHangRepo.GetAllCh().FirstOrDefault(c => c.Id == obj.id);
            if (iCuaHangRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<CuaHangView> GetAllCh()
        {
            List<CuaHangView> list = new List<CuaHangView>();
            list = (from a in iCuaHangRepo.GetAllCh()
                    select new CuaHangView()
                    {
                        id = a.Id,
                        ma = a.Ma,
                        ten = a.Ten,
                    }).ToList();
            return list;
        }

        public List<CuaHangView> GetAllCh(string input)
        {
            if(string.IsNullOrEmpty(input)) return GetAllCh();
            return GetAllCh().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public CuaHang GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid GetIdByName(string ten)
        {
            throw new NotImplementedException();
        }

        public string Update(CuaHangView obj)
        {
            throw new NotImplementedException();
        }
    }
}
