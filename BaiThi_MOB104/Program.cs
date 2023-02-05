using BaiThi_MOB104.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi_MOB104
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        ////Scaffold-DbContext 'Data Source=HIEUPHAMVAN\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=hieupvph27565;Password=hieupvph27565' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
        }
    }
}
