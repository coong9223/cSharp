using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BUS.Services
{
    public class SanPhamService : ISanPhamService
    {
        ISanPhamRepository _iSanPhamRepository;

        public SanPhamService()
        {
            _iSanPhamRepository = new SanPhamRepository();
        }
        public string Add(ViewSP obj)
        {
            if (obj == null)
                return "Them that bai";
            var sp = new SanPham()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iSanPhamRepository.Add(sp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(ViewSP obj)
        {
            if (obj == null) return "Xoa that bai";
            var sp = _iSanPhamRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iSanPhamRepository.Delete(sp))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public string Update(ViewSP obj)
        {
            if (obj == null) return "Sua that bai";
            var sp = _iSanPhamRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            sp.Ma = obj.Ma;
            sp.Ten = obj.Ten;
            if (_iSanPhamRepository.Update(sp))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
        public List<ViewSP> GetAll()
        {
            List<ViewSP> lst = new List<ViewSP>();
            lst =
                (
                from a in _iSanPhamRepository.GetAll()
                select new ViewSP()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return lst;
        }

        public List<ViewSP> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }


        public SanPham GetById(Guid id)
        {
            return _iSanPhamRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;
        }

        
    }
}
