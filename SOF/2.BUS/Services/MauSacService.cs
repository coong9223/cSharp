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
    public class MauSacService : IMauSacService
    {
        IMauSacRepository _iMauSacRepository;
        public MauSacService()
        {
            _iMauSacRepository = new MauSacRepository();
        }

        public string Add(MauSacView obj)
        {
            if (obj == null)
                return "Them that bai";
            var cv = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_iMauSacRepository.Add(cv))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "Xoa that bai";
            var cv = _iMauSacRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iMauSacRepository.Delete(cv))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<MauSacView> GetAll()
        {
            List<MauSacView> lst = new List<MauSacView>();
            lst =
                (
                from a in _iMauSacRepository.GetAll()
                select new MauSacView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return lst;
        }

        public List<MauSacView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public MauSac GetById(Guid id)
        {
            return _iMauSacRepository.GetAll().FirstOrDefault(c => c.Id == id);

        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;

        }

        public string Update(MauSacView obj)
        {

            if (obj == null) return "Sua that bai";
            var ms = _iMauSacRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            ms.Ma = obj.Ma;
            ms.Ten = obj.Ten;
            if (_iMauSacRepository.Update(ms))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
