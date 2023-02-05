using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.iServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class CtSpService:iCtSpService
    {
        private iCtSpRepository iCtSpRepo;
        private iSanPhamRepository iSanPhamRepo;
        private iDspRepository iDspRepo;
        private iNsxRepository iNsxRepo;
        private iMauSacRepository iMauSacRepo;
        public CtSpService()
        {
            iCtSpRepo = new CtSpRepository();
            iSanPhamRepo=new SanPhamRepository();
            iDspRepo = new DspRepository();
            iNsxRepo = new NsxRepository();
            iMauSacRepo = new MauSacRepository();
        }

        public string Add(CtSpView obj)
        {
            if (obj == null) return "that bai";
            var ctsp = new ChiTietSp()
            {
                Id = Guid.Empty,
                IdSp = obj.idSp,
                IdMauSac = obj.idMs,
                IdDongSp = obj.idDsp,
                NamBh = obj.namBh,
                MoTa = obj.moTa,
                SoLuongTon = obj.slTon,
                GiaBan = obj.giaBan,
                GiaNhap = obj.giaNhap,
            };
            if (iCtSpRepo.Add(ctsp)) return "thanh cong";
            return "that bai";
        }

        public string Delete(CtSpView obj)
        {
            if (obj == null) return "that bai";
            var temp=iCtSpRepo.GetAllCtSp().FirstOrDefault(c=>c.Id==obj.id);   
            if (iCtSpRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<CtSpView> GetAllCtSp()
        {
            List<CtSpView> lst = new List<CtSpView>();
            lst = (from a in iCtSpRepo.GetAllCtSp()
                   join b in iSanPhamRepo.GetAllSp() on a.IdSp equals b.Id
                   join c in iDspRepo.GetAllDsp() on a.IdDongSp equals c.Id
                   join d in iNsxRepo.GetAllNsx() on a.IdNsx equals d.Id
                   join e in iMauSacRepo.GetAllMs() on a.IdMauSac equals e.Id
                   select new CtSpView()
                   {
                       ctsp = a,
                       sp = b,
                       dsp = c,
                       nsx = d,
                       ms = e,
                       id = a.Id,
                       idSp = b.Id,
                       idDsp = c.Id,
                       idNsx = d.Id,
                       idMs = e.Id,
                       namBh = a.NamBh.Value,
                       moTa = a.MoTa,
                       slTon = a.SoLuongTon.Value,
                       giaNhap = a.GiaNhap.Value,
                       giaBan = a.GiaBan.Value,

                   }).ToList();
            return lst;
        }

        public List<CtSpView> GetAllCtSp(string input)
        {
            throw new NotImplementedException();
        }

        public ChiTietSp GetById(Guid id)
        {
            return iCtSpRepo.GetAllCtSp().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string ten)
        {
            throw new NotImplementedException();
        }

        public string Update(CtSpView obj)
        {
            if (obj == null) return "that bai";
            var temp = iCtSpRepo.GetAllCtSp().FirstOrDefault(c => c.Id == obj.id);
            temp.IdSp = obj.idSp;
            temp.IdDongSp = obj.idDsp;
            temp.IdNsx = obj.idNsx;
            temp.IdMauSac = obj.idMs;
            temp.NamBh = obj.namBh;
            temp.MoTa = obj.moTa;
            temp.SoLuongTon = obj.slTon;
            temp.GiaNhap = obj.giaNhap;
            temp.GiaBan = obj.giaBan;
            if (iCtSpRepo.Update(temp)) return "thanh cong";
            return "that bai";
        }
    }
}
