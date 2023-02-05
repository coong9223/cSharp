using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Cong_agile_sm22.DomainClass;
using Cong_agile_sm22.Repositories;

namespace Cong_agile_sm22.Services
{
    public class AgileServices
    {
        AgileRepo repos;
        public AgileServices()
        {
            repos = new AgileRepo();
        }

        public string Add(Nhanvien nv)
        {
            if (repos.Add(nv)) return "thành công";
            return "thất bại";
        }
    }
}
