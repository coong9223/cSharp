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
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _iChucVuRepository;
        private ICuaHangRepository _iCuaHangRepository;
        public QLNhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _iChucVuRepository = new ChucVuRepository();
            _iCuaHangRepository = new CuaHangRepository();
        }
        public string Add(QLNhanVienView obj)
        {
            if (obj == null) return "thêm thất bại";
            var nhanVien = obj.NhanVien;
            if (_iNhanVienRepository.Add(nhanVien)) return "thêm thành công";
            return "thêm thất bại";
        }

        public string Delete(QLNhanVienView obj)
        {
            if (obj == null) return "xóa thất bại";
            var nhanVien = obj.NhanVien;
            if (_iNhanVienRepository.Delete(nhanVien)) return "xóa thành công";
            return "xóa thất bại";
        }

        public List<QLNhanVienView> GetAll()
        {
            List<QLNhanVienView> lstNvViews = new List<QLNhanVienView>();
            lstNvViews =
                (
                    from a in _iNhanVienRepository.GetAll()
                    join b in _iChucVuRepository.GetAll() on a.IdCv equals b.Id
                    join c in _iCuaHangRepository.GetAll() on a.IdCh equals c.Id
                    select new QLNhanVienView()
                    {
                        NhanVien = a,
                        ChucVu = b,
                        CuaHang = c,
                    }
                ).ToList();
            return lstNvViews;
        }

        public string Update(QLNhanVienView obj)
        {
            if (obj == null) return "xóa thất bại";
            var nhanVien = obj.NhanVien;
            if (_iNhanVienRepository.Update(nhanVien)) return "xóa thành công";
            return "xóa thất bại";
        }
        public List<String> TrangThai()
        {
            return new List<String>() { "Không Hoạt Động", "Hoạt Động" };
        }
    }
}
