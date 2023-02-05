using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_TongQuanWindowForm
{
    internal class Phim
    {
        //prop + tab
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string TheLoaiPhim { get; set; }
        public int TrangThai { get; set; }

        public List<Phim> GetLstPhim()
        {
            return new List<Phim>()
            {
                new Phim(){Id = Guid.NewGuid(),Ten = "Kỳ 11",TheLoaiPhim = "Kinh dị",TrangThai = 1},
                new Phim(){Id = Guid.NewGuid(),Ten = "Học lại C#3",TheLoaiPhim = "Kinh dị",TrangThai = 1},
                new Phim(){Id = Guid.NewGuid(),Ten = "ABC",TheLoaiPhim = "Kinh dị",TrangThai = 0},
                new Phim(){Id = Guid.NewGuid(),Ten = "ZYZ",TheLoaiPhim = "Kinh dị",TrangThai = 0},

            };
        }
    }
}
