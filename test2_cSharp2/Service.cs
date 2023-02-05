using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2_cSharp2
{
    internal class Service
    {
        List<MayTinh> mt=new List<MayTinh> ();

        public Service()
        {
        }

        public Service(List<MayTinh> mt)
        {
            this.Mt = mt;
        }

        internal List<MayTinh> Mt { get => mt; set => mt = value; }

        public int MaTuSinhInt()//mã tự sinh int trong trường hợp Id là số
        {

        }
    }
}
