using BAI_1_6_CRUD_EF_DBFIRST.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_6_CRUD_EF_DBFIRST
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmQLNhanVien());
        }
        //Scaffold-DbContext 'Data Source=DESKTOP-P5GSVI1\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=cuongnpm;Password=123456' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
    }
}
