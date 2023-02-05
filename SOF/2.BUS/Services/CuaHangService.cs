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
    public class CuaHangService : ICuaHangService
    {
        ICuaHangRepository _iCuaHangRepository;
        public CuaHangService()
        {
            _iCuaHangRepository = new CuaHangRepository();
        }
        public string Add(CuaHangView obj)
        {
            if (obj == null) return "Them that bai";
            var ch = new CuaHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia
            };
            if (_iCuaHangRepository.Add(ch))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(CuaHangView obj)
        {
            if (obj == null) return "Xoa that bai";
            var ch = _iCuaHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iCuaHangRepository.Delete(ch))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<CuaHangView> GetAll()
        {
            List<CuaHangView> lst = new List<CuaHangView>();
            lst =
                (
                from a in _iCuaHangRepository.GetAll()
                select new CuaHangView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    DiaChi = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia,
                }
                ).ToList();
            return lst;
        }

        public List<CuaHangView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())|| c.DiaChi.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public CuaHang GetById(Guid id)
        {
            return _iCuaHangRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;

        }

        public List<string> GetThanhPhos()
        {
            return new List<string>() { "Hà Nội", "Hải Phòng", "Thái Bình", "Hồ Chí Minh", "Đà Nẵng", "Quảng Bình", "Nghệ An" };

        }

        public string Update(CuaHangView obj)
        {
            if (obj == null) return "sua that bai";
            var ch = _iCuaHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            ch.Ma = obj.Ma;
            ch.Ten = obj.Ten;
            ch.DiaChi = obj.DiaChi;
            ch.ThanhPho = obj.ThanhPho;
            ch.QuocGia = obj.QuocGia;
            if (_iCuaHangRepository.Update(ch))
            {
                return "sua thanh cong";
            }
            return "sua that bai";
        }
    }
}
