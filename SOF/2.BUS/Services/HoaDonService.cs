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
    public class HoaDonService : IHoaDonService
    {
        IHoaDonRepository _iHoaDonRepository;
        public HoaDonService()
        {
            _iHoaDonRepository = new HoaDonRepository();
        }
        public string Add(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Them that bai";
            }
            var dsp = new HoaDon()
            {
                Id = obj.Id,

                Ma = obj.Ma,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayNhan = obj.NgayNhan,
                NgayShip = obj.NgayShip,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                TinhTrang = obj.TinhTrang,
            };
            if (_iHoaDonRepository.Add(dsp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Xoa that bai";
            }
            var dsp = _iHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_iHoaDonRepository.Delete(dsp))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> dspViews = new List<HoaDonView>();
            dspViews =
                (
                from obj in _iHoaDonRepository.GetAll()
                select new HoaDonView()
                {
                    Id = obj.Id,

                    Ma = obj.Ma,
                    NgayTao = obj.NgayTao,
                    NgayThanhToan = obj.NgayThanhToan,
                    NgayNhan = obj.NgayNhan,
                    NgayShip = obj.NgayShip,
                    TenNguoiNhan = obj.TenNguoiNhan,
                    DiaChi = obj.DiaChi,
                    Sdt = obj.Sdt,
                    TinhTrang = obj.TinhTrang,
                }
                ).ToList();
            return dspViews;
        }

        public List<HoaDonView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ma.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public HoaDon GetById(Guid id)
        {
            return _iHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == id);

        }

        public Guid GetIdByMa(string ma)
        {
            return GetAll().FirstOrDefault(c => c.Ma == ma).Id;

        }

        public List<string> TrangThai()
        {
            return new List<string>() { "Hoat dong", "Khong hoat dong" };

        }

        public string Update(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Sua that bai";
            }
            var dsp = _iHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);


            dsp.Ma = obj.Ma;
            dsp.NgayTao = obj.NgayTao;
            dsp.NgayThanhToan = obj.NgayThanhToan;
            dsp.NgayNhan = obj.NgayNhan;
            dsp.NgayShip = obj.NgayShip;
            dsp.TenNguoiNhan = obj.TenNguoiNhan;
            dsp.DiaChi = obj.DiaChi;
            dsp.Sdt = obj.Sdt;
            dsp.TinhTrang = obj.TinhTrang;

            if (_iHoaDonRepository.Update(dsp))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
