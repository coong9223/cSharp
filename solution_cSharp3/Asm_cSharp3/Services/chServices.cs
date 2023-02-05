using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asm_cSharp3.DomainClass;
using Asm_cSharp3.Context;
using Asm_cSharp3.Repositories;
using Asm_cSharp3.Views;

namespace Asm_cSharp3.Services
{
    public class chServices
    {
        public List<CuaHang> _lstCH;
        public CHRepositories _chRepo;
        public chServices()
        {
            _lstCH = new List<CuaHang>();
            _chRepo = new CHRepositories();
        }
        private void GetDataFromDB()
        {
            _lstCH=_chRepo.GetAll();
        }

        public List<CuaHang> GetAllCuaHang(string input)
        {
            return _lstCH;
        }

        public string Add(CuaHang ch)
        {
            if (_chRepo.Add(ch))
            {
                GetDataFromDB();
                return "thêm thành công";
            }return "thêm thất bại";
        }

        public string Update(CuaHang ch)
        {
            var temp = _chRepo.GetAll().FirstOrDefault(c => c.Id == ch.Id);
            ch.Ten = temp.Ten;
            ch.Ma = temp.Ma;
            ch.QuocGia = temp.QuocGia;
            ch.DiaChi = temp.DiaChi;
            ch.ThanhPho = temp.ThanhPho;
            if (_chRepo.Update(ch))
            {
                GetDataFromDB();
                return "cập nhật thành công";
            }return "cập nhật thất bại";
        }

        public string Delete(CuaHang ch)
        {
            var temp=_chRepo.GetAll().FirstOrDefault(c=>c.Id== ch.Id);
            if (_chRepo.Delete(ch))
            {
                GetDataFromDB();
                return "xóa thành công";
            }return "xóa thất bại";
        }
        public CuaHang GetById(Guid id)
        {
            return _lstCH.FirstOrDefault(c=>c.Id== id);
        }

        public List<string> GetThanhPho()
        {
            return new List<string> { "thêm thành phố","hanoi", "thaibinh", "haiphong", "quangning", "thanhhoa" };
        }
    }
}
