using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private FpolyDBContext _dbContext;
        public KhachHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;

            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.KhachHangs.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;

            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.QuocGia = obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;

            _dbContext.KhachHangs.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }


        public KhachHang Get(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }
    }
}
