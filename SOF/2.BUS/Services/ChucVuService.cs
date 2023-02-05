using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChucVuService : IChucVuService
    {
        IChucVuRepository _iChucVuRepository;
        public ChucVuService()
        {
            _iChucVuRepository = new  ChucVuRepository();
        }

        public string Add(ChucVuView obj)
        {
            if (obj == null)
                return "Them that bai";
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iChucVuRepository.Add(cv))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "Xoa that bai";
            var cv = _iChucVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iChucVuRepository.Delete(cv))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst =
                (
                from a in _iChucVuRepository.GetAll()
                select new ChucVuView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return lst;
        }

        public List<ChucVuView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public ChucVu GetById(Guid id)
        {
            return _iChucVuRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "Sua that bai";
            var cv = _iChucVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            cv.Ma = obj.Ma;
            cv.Ten = obj.Ten;
            if (_iChucVuRepository.Update(cv))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
