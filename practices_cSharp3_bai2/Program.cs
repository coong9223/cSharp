using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using practices_cSharp3_bai2.View;

namespace practices_cSharp3_bai2
{
    internal static class Program
    {
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.ReadKey();
        }
    }
}
