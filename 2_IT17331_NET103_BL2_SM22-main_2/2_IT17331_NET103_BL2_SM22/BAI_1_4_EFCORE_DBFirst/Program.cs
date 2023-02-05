using BAI_1_4_EFCORE_DBFirst.DomainModels;
using BAI_1_4_EFCORE_DBFirst.Context;
using System;
using System.Linq;

namespace BAI_1_4_EFCORE_DBFirst
{
    internal class Program
    {

        //Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=1

        //Scaffold-DbContext 'MỜI ANH CHỊ COPY ĐƯỜNG DẪN VÀO ĐÂY' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyContext -Contextdir Context -DataAnnotations -Force



        //Scaffold-DbContext 'Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyContext -Contextdir Context -DataAnnotations -Force

        //Scaffold-DbContext 'Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force


        //Data Source = LEMINHHIEU\SQLEXPRESS;Initial Catalog = FINALASS_FPTShop_SP22_BL2_DUNGNA29; Persist Security Info=True;User ID = lmaohieu; Password=1

        //Dungna
        //Scaffold-DbContext 'Data Source = LEMINHHIEU\SQLEXPRESS;Initial Catalog = FINALASS_FPTShop_SP22_BL2_DUNGNA29; Persist Security Info=True;User ID = lmaohieu; Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        static void Main(string[] args)
        {
            FpolyContext dbContext = new FpolyContext();
            MauSac ms1 = new MauSac() { Id = Guid.Empty, Ma = "RD1", Ten = "Red" };
            dbContext.Add(ms1);
            dbContext.SaveChanges();
            foreach (var x in dbContext.MauSacs.ToList().OrderBy(c => c.Ma))
            {
                Console.WriteLine($"{x.Id} {x.Ma} {x.Ten}");
            }

        } 
    }
}
