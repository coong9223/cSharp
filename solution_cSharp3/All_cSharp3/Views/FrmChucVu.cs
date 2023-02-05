using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using All_cSharp3.DomainClass;
using All_cSharp3.Services;
using All_cSharp3.Utilities;
using All_cSharp3.DomainClass;


namespace All_cSharp3.Views
{
    public partial class FrmChucVu : Form
    {
        private CVServices _chService;
        private Guid _id;
        public FrmChucVu()
        {
            _chService = new CVServices();
            txt_ma.Enabled = false;
            InitializeComponent();
        }

        public void LoadData(string data)
        {
            int stt = 1;
            Type type = typeof(ChucVu);
            int slThuocTinh = type.GetProperties().Length;
            dataGridView1.ColumnCount = slThuocTinh + 1;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "mã";
            dataGridView1.Columns[2].Name = "tên";
            dataGridView1.Rows.Clear();

            foreach(var x in _chService.GetAllCV())
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }

        public ChucVu getGuid(string input)
        {
            return new ChucVu()
            {
                Id = Guid.NewGuid(),
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
            };
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text = CuaHangUtilities.GenMaAuTo(txt_ten.Text) + _chService.GetAllCV(null).Count;
        }
    }
}
