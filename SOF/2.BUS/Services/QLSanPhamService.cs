
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
    public class QLSanPhamService : IQLSanPhamService
    {
        IChiTietSPRepository _iChiTietSPRepository;
        INsxRepository _iNsxRepository;
        ISanPhamRepository _iSanPhamRepository;
        IMauSacRepository _iMauSacRepository;
        IDspRepository _iDspRepository;

        public QLSanPhamService()
        {
            _iChiTietSPRepository = new ChiTietSPRepository();
            _iNsxRepository = new NsxRepository();
            _iSanPhamRepository = new SanPhamRepository();
            _iMauSacRepository = new MauSacRepository();
            _iDspRepository = new DspRepository();
        }
        public string Add(ChiTietSanPhamView obj)
        {
            if (obj == null) return "thêm thất bại";
            var chiTietSp = new ChiTietSp()
            {
                Id = Guid.Empty,

                NamBh = obj.NamBh,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa
            };
            if (_iChiTietSPRepository.Add(chiTietSp)) return "thêm thành công";
            return "thêm thất bại";
        }


        public string Update(ChiTietSanPhamView obj)
        {
            if (obj == null) return "sửa thất bại";
            var chiTietSp = _iChiTietSPRepository.GetAll().FirstOrDefault(c => c.Id == obj.IdChitietSp);

            chiTietSp.NamBh = obj.NamBh;
            chiTietSp.GiaNhap = obj.GiaNhap;
            chiTietSp.GiaBan = obj.GiaBan;
            chiTietSp.SoLuongTon = obj.SoLuongTon;
            chiTietSp.MoTa = obj.MoTa;
            if (_iChiTietSPRepository.Update(chiTietSp)) return "sửa thành công";
            return "sửa thất bại";
        }

        public List<ChiTietSanPhamView> GetAll()
        {
            List<ChiTietSanPhamView> lstSPViews = new List<ChiTietSanPhamView>();
            lstSPViews =
                (
                    from a in _iChiTietSPRepository.GetAll()

                    select new ChiTietSanPhamView()
                    {
                        IdChitietSp = a.Id,
                        SoLuongTon = a.SoLuongTon.Value,
                        GiaNhap = a.GiaNhap.Value,
                        GiaBan = a.GiaBan.Value,
                        NamBh = a.NamBh.Value,
                        MoTa = a.MoTa
                    }
                ).ToList();
            return lstSPViews;
        }

        public string delete(ChiTietSanPhamView obj)
        {
            if (obj == null) return "xóa thất bại";
            var chiTietSp = _iChiTietSPRepository.GetAll().FirstOrDefault(c => c.Id == obj.IdChitietSp);
            if (_iChiTietSPRepository.Delete(chiTietSp)) return "xóa thành công";
            return "xóa thất bại";
        }
    }
}
