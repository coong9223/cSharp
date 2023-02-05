using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OnTapcSharp3.Repositories;
using OnTapcSharp3.DomainClass;

namespace OnTapcSharp3.Services
{
    public class service
    {
        List<SanPham> _lstSp;
        repo _spRepo;

        public service()
        {
            _lstSp = new List<SanPham>();
            _spRepo = new repo();
            getDataFromDb();
        }

        public void getDataFromDb()
        {
            _lstSp = _spRepo.GetSp();
        }

        public string Add(SanPham sp)
        {
            if (_spRepo.Add(sp))
            {
                getDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Update(SanPham sp)
        {
            var temp = _spRepo.GetSp().FirstOrDefault(c => c.Id ==sp.Id);
            temp.Ten = sp.Ten;
            temp.GiaBan = sp.GiaBan;
            temp.SoLuong = sp.SoLuong;
            temp.Website = sp.Website;
            temp.TrangThai = sp.TrangThai;
            if (_spRepo.Update(sp))
            {
                getDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(SanPham sp)
        {
            var temp = _spRepo.GetSp().FirstOrDefault(c => c.Id == sp.Id);
            if (_spRepo.Delete(sp))
            {
                getDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }


        public List<SanPham> GetAllSp()
        {
            return _lstSp;
        }

        public List<string> getAllWeb()
        {
            return new List<string> { "fpt", "dienmayxanh" };
        }
    }
}
