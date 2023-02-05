using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cong_agile_sm22.Views;

namespace Cong_agile_sm22
{
    internal static class Program
    {
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=Agile_sm22;Persist Security Info=True;User ID=cong_agile;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangKi());
        }
    }
}
