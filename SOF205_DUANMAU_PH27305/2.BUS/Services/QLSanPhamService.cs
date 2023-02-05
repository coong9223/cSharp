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
    public class QLSanPhamService : IQLSanPhamService
    {
        private IChiTietSpRepository _iChiTietSpRepository;
        private ISanPhamRepository _iSanPhamRepository;
        private IDongSpRepository _iDongSpRepository;
        private INsxRepository _iNsxRepository;
        private IMauSacRepository _iMauSacRepository;
        public QLSanPhamService()
        {
            _iChiTietSpRepository = new ChiTietSpRepository();
            _iSanPhamRepository = new SanPhamRepository();
            _iDongSpRepository = new DongSpRepository();
            _iNsxRepository = new NsxRepository();
            _iMauSacRepository = new MauSacRepository();
        }
        public string Add(QLSanPhamView obj)
        {
            if (obj == null) return "thêm thất bại";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepository.Add(chiTietSp)) return "thêm thành công";
            return "thêm thất bại";
        }

        public string Delete(QLSanPhamView obj)
        {
            if (obj == null) return "xóa thất bại";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepository.Delete(chiTietSp)) return "xóa thành công";
            return "xóa thất bại";
        }

        public List<QLSanPhamView> GetAll()
        {
            List<QLSanPhamView> lstSPViews = new List<QLSanPhamView>();
            lstSPViews =
                (
                    from a in _iChiTietSpRepository.GetAll()
                    join b in _iMauSacRepository.GetAll() on a.IdMauSac equals b.Id
                    join c in _iDongSpRepository.GetAll() on a.IdDongSp equals c.Id
                    join d in _iNsxRepository.GetAll() on a.IdNsx equals d.Id
                    join e in _iSanPhamRepository.GetAll() on a.IdSp equals e.Id
                    select new QLSanPhamView()
                    {
                        ChiTietSp = a,
                        MauSac = b,
                        DongSp = c,
                        Nsx = d,
                        SanPham = e
                    }
                ).ToList();
            return lstSPViews;
        }

        public string Update(QLSanPhamView obj)
        {
            if (obj == null) return "sửa thất bại";
            var chiTietSp = obj.ChiTietSp;
            if (_iChiTietSpRepository.Update(chiTietSp)) return "sửa thành công";
            return "sửa thất bại";
        }
    }
}
