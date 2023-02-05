//using System;
//using System.Collections.Generic;
//using System.Text;
//using _2.BUS.iServices;
//using _2.BUS.ViewModels;
//using _1.DAL.iRepositories; 
//using _1.DAL.Repositories;
//using System.Linq;
//using _1.DAL.DomainClass;

//namespace _2.BUS.Services
//{
//    public class QuanLySpServices : iQuanLySpServices
//    {
//        private IChiTietSpRepositories _IchiTietSpRepositories;
//        private iMauSacRepositories _iMauSacRepositories;
//        private iNsxRepositories _iNsxRepositories;
//        private iSanPhamRepositories _iSanPhamRepositories;
//        private iDongSpRepositories _iDongSpRepositories;
//        List<SanPhamView> _lstSanPhamView = new List<SanPhamView>();
//        public QuanLySpServices()
//        {
//            _IchiTietSpRepositories = new ChiTietSpRepositories();
//            _iMauSacRepositories = new MauSacRepositories();
//            _iNsxRepositories = new NsxRepositories();
//            _iSanPhamRepositories = new SanPhamRepositories();
//            _iDongSpRepositories = new DongSpRepositories();
//            _lstSanPhamView = new List<SanPhamView>();
//        }

//        string iQuanLySpServices.Add(SanPhamView obj)
//        {
//            if (obj == null) return "thêm không thành công";
//            var chiTietSp = obj.ChiTietSp;
//            if (_IchiTietSpRepositories.Add(chiTietSp)) return "thêm thành công";
//            return "thêm không thành công";
//        }


//        string iQuanLySpServices.Delete(SanPhamView obj)
//        {
//            if (obj == null) return "xóa không thành công";
//            var chiTietSp = obj.ChiTietSp;
//            if (_IchiTietSpRepositories.Delete(chiTietSp)) return "xóa thành công";
//            return "xóa không thành công";
//        }

//        List<SanPhamView> iQuanLySpServices.GetAll()
//        {
            
//            //viết 1 câu Linq để gán giá trị cho từng prop của viewSp
//            _lstSanPhamView =
//                (from a in _IchiTietSpRepositories.GetAll()
//                 join b in _iMauSacRepositories.GetAll() on a.IdMauSac equals b.Id
//                 join c in _iSanPhamRepositories.GetAll() on a.IdSp equals c.Id
//                 join d in _iDongSpRepositories.GetAll() on a.IdDongSp equals d.Id
//                 join e in _iNsxRepositories.GetAll() on a.IdNsx equals e.Id
//                 select new SanPhamView()
//                 {
//                     ChiTietSp=a,
//                     MauSac=b,
//                     SanPham=c,
//                     DongSp=d,
//                     Nsx=e
//                 }
//                 ).ToList();
//            return _lstSanPhamView;
//        }

//        string iQuanLySpServices.Update(SanPhamView obj)
//        {
//            if (obj == null) return "sửa không thành công";
//            var chiTietSp = obj.ChiTietSp;
//            if (_IchiTietSpRepositories.Update(chiTietSp)) return "Sửa thành công";
//            return "sửa không thành công";
//        }
//    }
//}
