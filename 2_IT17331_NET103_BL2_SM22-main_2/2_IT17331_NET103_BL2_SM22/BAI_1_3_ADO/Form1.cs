using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_3_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=***********

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            // 1. khởi tạo kết nối vào csdl
            string sqlConnectionString = @"Data Source=LEMINHHIEU\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=lmaohieu;Password=1";
            // 2. gọi sql connection
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            // 3. mở kết nối đến
            conn.Open();
            // 4. mở kế nối xong thì thực hiện 1 hành động nào đó
            // 5. khởi tạo 1 câu query với SqlCommand
            string sql = "select * from ChucVu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            // 5. thực thi và hứng dữ liệu vào sqladapter
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            // 6. sau Khi thực hiện xong thì đóng kêt nối
            conn.Close();
        }
    }
}
