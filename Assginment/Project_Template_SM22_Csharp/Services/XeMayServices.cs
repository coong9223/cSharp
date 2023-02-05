using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public  class XeMayServices
    {
        private XeMayRepositories _chXeMayRepositories;
        public XeMayServices()
        {
            _chXeMayRepositories = new XeMayRepositories();
        }
        public string AddXeMayServices(XeMay obj)
        {
            if (_chXeMayRepositories.AddXeMayRepositories(obj))
            {
                return "Thêm Thành Công";
            }
            return "Thêm k Thành Công";
        }
        public string UpdateXeMayServices(XeMay obj)
        {
            var xm= _chXeMayRepositories.GetAll().FirstOrDefault(c => c.Ma ==obj.Ma);
            xm.Ma = obj.Ma;
            xm.Ten=obj.Ten;
            xm.SoLuong=obj.SoLuong;
            xm.TrangThai=obj.TrangThai;
            if (_chXeMayRepositories.UpdateXeMayRepositories(xm))
            {
                return "sửa Thành Công";
            }
            return "sửa  k Thành Công";
        }
        public string DeleteXeMayServices(XeMay obj)
        {
            var xm = _chXeMayRepositories.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
            if (_chXeMayRepositories.DeleteXeMayRepositories(xm))
            {
                return "xóa Thành Công";
            }
            return "xóa k Thành Công";
        }
        public List<XeMay> GetXeMays()
        {
            return _chXeMayRepositories.GetAll();
        }
        public List<int > Getsoluong()
        {
            return new List<int>() { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
