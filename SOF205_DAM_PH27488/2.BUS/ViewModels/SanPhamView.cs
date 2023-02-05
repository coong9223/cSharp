using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class SanPhamView
    {
        public Guid id { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
    }
}
