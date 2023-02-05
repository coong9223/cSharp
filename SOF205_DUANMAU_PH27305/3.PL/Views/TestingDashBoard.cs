using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _3.PL.Views
{
    public partial class TestingDashBoard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public TestingDashBoard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnl_nav.Height = btn_Dashboard.Height;
            pnl_nav.Top = btn_Dashboard.Top;
            pnl_nav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void TestingDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Dashboard.Height;
            pnl_nav.Top = btn_Dashboard.Top;
            pnl_nav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Dasboard";
            this.pnl_Formloader.Controls.Clear();
            QLSanPham frm_Sanpham = new QLSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            frm_Sanpham.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Formloader.Controls.Add(frm_Sanpham);
            frm_Sanpham.Show();
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Analytics.Height;
            pnl_nav.Top = btn_Analytics.Top;
            btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Calender_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Calender.Height;
            pnl_nav.Top = btn_Calender.Top;
            btn_Calender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Contactus_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Contactus.Height;
            pnl_nav.Top = btn_Contactus.Top;
            btn_Contactus.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Settings.Height;
            pnl_nav.Top = btn_Settings.Top;
            btn_Settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Dashboard_Leave(object sender, EventArgs e)
        {
            btn_Dashboard.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_Analytics_Leave(object sender, EventArgs e)
        {
            btn_Analytics.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_Calender_Leave(object sender, EventArgs e)
        {
            btn_Calender.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_Contactus_Leave(object sender, EventArgs e)
        {
            btn_Contactus.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btn_Settings_Leave(object sender, EventArgs e)
        {
            btn_Settings.BackColor = Color.FromArgb(20, 30, 54);
        }
    }
}
