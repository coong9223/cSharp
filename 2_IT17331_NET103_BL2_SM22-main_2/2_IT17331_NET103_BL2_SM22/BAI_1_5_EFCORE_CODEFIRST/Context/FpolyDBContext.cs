using BAI_1_6_EFCORE_CODEFIRST.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_EFCORE_CODEFIRST.Context
{
    public class FpolyDBContext : DbContext // ke thua lop db context
    {

        //ghi de 1 phuong thuc
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //cau hinh duong ket noi
            optionsBuilder.UseSqlServer(@"Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=IT17331_CodeFirst;User ID=lmaohieu;Password=1");
        }
        public DbSet<SinhVien> SinhViens { get; set; }

        public DbSet<Point> Points { get; set; }
        public object MauSacs { get; set; }
    }
}
//add-migration CreateDB270722

//Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=IT17331_CodeFirst;User ID=lmaohieu;Password=1


//Scaffold - DbContext 'Data Source = LEMINHHIEU\SQLEXPRESS;Initial Catalog = FINALASS_FPTShop_SP22_BL2_DUNGNA29; Persist Security Info=True;User ID = lmaohieu; Password=1' Microsoft.EntityFrameworkCore.SqlServer - OutputDir DomainClass - context FpolyDBContext - Contextdir Context - DataAnnotations - Force


//Scaffold-DbContext 'Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyContext -Contextdir Context -DataAnnotations -Force