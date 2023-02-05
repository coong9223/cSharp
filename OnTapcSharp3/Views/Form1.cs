using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using OnTapcSharp3.DomainClass;
using OnTapcSharp3.Services;
using OnTapcSharp3.Views;

namespace OnTapcSharp3.Views
{
    //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _serSp = new service();
            LoadWeb();
        }

        service _serSp;
        public void LoadWeb()
        {
            foreach(var x in _serSp.getAllWeb())
            {
                comboBox1.Items.Add(x);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void LoadDgrid()
        {
            int slTT = 1;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "tên";
            dataGridView1.Columns[2].Name = "giá";
            dataGridView1.Columns[3].Name = "số lượng";
            dataGridView1.Columns[4].Name = "trạng thái";
            dataGridView1.Columns[5].Name = "website";
            dataGridView1.Rows.Clear();
            foreach(var x in _serSp.GetAllSp())
            {
                dataGridView1.Rows.Add(slTT++, x.Ten, x.GiaBan, x.SoLuong, x.TrangThai, x.Website);

            }
        }

        private SanPham GetDfromGuid()
        {
            return new SanPham
            {
                Ten = textBox1.Text,
                GiaBan = Convert.ToDecimal(textBox2.Text),
                SoLuong = Convert.ToInt32(textBox3.Text),
                Website = comboBox1.Text,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_serSp.Add(GetDfromGuid()));
            LoadDgrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_serSp.Update(GetDfromGuid()));
            LoadDgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_serSp.Delete(GetDfromGuid()));
            LoadDgrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x == _serSp.GetAllSp().Count)
            {
                return;
            }

            var ten = dataGridView1.Rows[x].Cells[1].Value.ToString();
            //2. Lấy được khóa chính trên grid

            //3. TÌm đối tượng theo id
            var obj = _serSp.GetAllSp().FirstOrDefault(x => x.Ten.Equals(ten));
            textBox1.Text = obj.Ten;
            textBox2.Text = Convert.ToString(obj.GiaBan);
            textBox3.Text = Convert.ToString(obj.SoLuong);
            comboBox1.SelectedItem = obj.Website;
        }
    }
}
