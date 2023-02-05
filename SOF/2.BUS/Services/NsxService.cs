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
    public class NsxService : IQLNsxService
    {
        INsxRepository _iNsxRepository;
        public NsxService()
        {
            _iNsxRepository = new NsxRepository();
        }
        public string Add(NsxView obj)
        {
            if (obj == null)
                return "Them that bai";
            var sp = new Nsx()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iNsxRepository.Add(sp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(NsxView obj)
        {
            if (obj == null) return "Xoa that bai";
            var nsx = _iNsxRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iNsxRepository.Delete(nsx))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public string Update(NsxView obj)
        {
            if (obj == null) return "Sua that bai";
            var nsx = _iNsxRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            nsx.Ma = obj.Ma;
            nsx.Ten = obj.Ten;
            if (_iNsxRepository.Update(nsx))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
        public List<NsxView> GetAll()
        {
            List<NsxView> lst = new List<NsxView>();
            lst =
                (
                from a in _iNsxRepository.GetAll()
                select new NsxView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return lst;
        }
        public List<NsxView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public Nsx GetById(Guid id)
        {
            return _iNsxRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;
        }
    }
}
