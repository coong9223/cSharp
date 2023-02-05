using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using All_cSharp3.Context;
using All_cSharp3.DomainClass;

namespace All_cSharp3.Repositories
{
    public class CuaHangRepositories
    {
        private FpolyDBContext _dbContext;//tạo đối tượng
        public CuaHangRepositories()
        {
            _dbContext = new FpolyDBContext();//khởi tạo đối tượng và cho phép dùng trong repositories
        }

        public List<CuaHang> GetAll()//tạo list cửa hàng và lấy tất cả giá trị trong bảng của hàng
        {
            return _dbContext.CuaHangs.ToList();//trả lại bảng cửa hàng theo list
        }

        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.Add(obj);//thêm giá trị vào bảng
            _dbContext.SaveChanges();//lưu thay đổi
            return true;
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
