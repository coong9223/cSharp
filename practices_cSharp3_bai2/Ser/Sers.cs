using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using practices_cSharp3_bai2.DomainClass;
using practices_cSharp3_bai2.Repo;
using practices_cSharp3_bai2.View;
namespace practices_cSharp3_bai2.Ser
{
    public class Sers
    {
        Repos re;
        private List<SanPham> lst;
        public Sers()
        {
            re=new Repos();
            lst=new List<SanPham>();
        }
        public void GetDataFromDB()
        {
            lst = re.GEtAllSp();
        }
        public List<SanPham> GetAlSps()
        {
            return lst;
        }
        public List<string> GetWeb()
        {
            return new List<string> { "skdflskdjf", "dsfjhajsdfh"};

        }
        public string Addsps(SanPham sp)
        {
            if (re.Addsp(sp)) {
                GetDataFromDB();
                return "thành công";
            }
            return "thất bại";
        }

        public string Delsps(SanPham sp)
        {
            var temp = re.GEtAllSp().FirstOrDefault(c => c.Ma == sp.Ma);
            if (re.Delsp(temp))
            {
                GetDataFromDB();
                return "thành công";
            }
            return "thất bại";
        }

        public string Upsps(SanPham sp)
        {
            var temp = re.GEtAllSp().FirstOrDefault(c => c.Ma == sp.Ma);
            temp.Ten = sp.Ten;
            temp.GiaBan = sp.GiaBan;
            temp.TrangThai = sp.TrangThai;
            if (re.Upsp(temp))
            {
                GetDataFromDB();
                return "thành công";
            }
            return "thất bại";
        }


    }
}
