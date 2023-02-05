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
    public class DspService : IDspService
    {
        IDspRepository _iDspRepository;
        public DspService()
        {
            _iDspRepository = new DspRepository();
        }

        public string Add(DspView obj)
        {
            if (obj == null)
            {
                return "Them that bai";
            }
            var dsp = new DongSp()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_iDspRepository.Add(dsp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(DspView obj)
        {
            if (obj == null)
            {
                return "Xoa that bai";
            }
            var dsp = _iDspRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_iDspRepository.Delete(dsp))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<DspView> GetAll()
        {
            List<DspView> dspViews = new List<DspView>();
            dspViews =
                (
                from a in _iDspRepository.GetAll()
                select new DspView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }
                ).ToList();
            return dspViews;
        }

        public List<DspView> GetAll(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public DongSp GetById(Guid id)
        {
            return _iDspRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;

        }

        public string Update(DspView obj)
        {
            if (obj == null)
            {
                return "Sua that bai";
            }
            var dsp = _iDspRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            dsp.Ma = obj.Ma;
            dsp.Ten = obj.Ten;
            if (_iDspRepository.Update(dsp))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
