using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongQuanWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InThongTin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "chào mừng bạn đã đến với cSharp";
        }
        public void InThongTin()
        {
            Class1 class1 = new Class1();//khởi tạo đối tượng
            DataTable dt=new DataTable();//tạo db
            dt.Columns.Add("stt",typeof(int));//tạo các cột
            dt.Columns.Add("ten", typeof(string));
            dt.Columns.Add("tloai", typeof(string));
            int stt = 1;
            foreach(var x in class1.GetClass())//lấy giá trị của x với từng thông tin có trong list GetClass
            {
                dt.Rows.Add(stt++, x.name, x.tloai);
            }
            dataGridView1.DataSource = dt;//đổ dữ liệu vào db
        }
    }
}
