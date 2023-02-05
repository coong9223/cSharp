//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using _2.BUS.iServices;
//using _2.BUS.Services;
//using _1.DAL.DomainClass;
//using _2.BUS.ViewModels;

//namespace _3.PL.Views
//{
//    public partial class FrmQuanLySp : Form
//    {
//        private iQuanLySpServices _iQuanLySpServices;
//        public FrmQuanLySp()
//        {
//            InitializeComponent();
//            _iQuanLySpServices = new QuanLySpServices();
//            //cần chức năng j thì gọi ra
//            LoadDGrid();

//        }
//        private void LoadDGrid()
//        {
//            int stt = 1;
//            Type type = typeof(SanPham);
//            dataGridView1.ColumnCount = 8;
//            dataGridView1.Columns[0].Name = "stt";
//            dataGridView1.Columns[1].Name = "id";
//            dataGridView1.Columns[2].Name = "tên";
//            dataGridView1.Columns[3].Name = "màu";
//            dataGridView1.Columns[4].Name = "nsx";
//            dataGridView1.Columns[5].Name = "dòng sp";
//            dataGridView1.Columns[6].Name = "năm bh";
//            dataGridView1.Columns[7].Name = "mô tả";
//            dataGridView1.Rows.Clear();
//            foreach (var x in _iQuanLySpServices.GetAll())
//            {
//                dataGridView1.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.MauSac.Ten, x.Nsx.Ten, x.DongSp.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa);
//            }

//        }
//        private SanPhamView GetDataFromGuid()
//        {
//            SanPhamView spv = new SanPhamView();
//            spv.ChiTietSp = new ChiTietSp()
//            {
//                Id = Guid.NewGuid(),
//                MoTa = "còn nguyên",

//            };
//            return spv;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void btn_them_Click(object sender, EventArgs e)
//        {
//            _iQuanLySpServices.Add(GetDataFromGuid());
//            LoadDGrid();
//        }

//        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int x=e.RowIndex;
//            if (x == _iQuanLySpServices.GetAll().Count)
//            {
//                return;
//            }
//        }
//    }
//}
