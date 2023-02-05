using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cong_agile_sm22.Views;

namespace Cong_agile_sm22.Views
{
    public partial class FrmDangKi : Form
    {
        public FrmDangKi()
        {
            InitializeComponent();
            
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == null || txt_password.Text == null || txt_repass == null)
            {
                MessageBox.Show("đăng nhập không thành công"); 
            }
            FrmLogIn fLogIn = new FrmLogIn();
            fLogIn.Show();
        }

        bool check(string value)
        {
            if(txt_name.Text == null)return false;
            return true;
        }

        string checkName(string value)
        {
            if (txt_name == null)
            {

                return "không thành công";
            }
            return "thành công";
        }
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
