using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_0_TaoWindowFormBangCode
{
    internal class Frm1:Form//Kế thừa lớp cha là form
    {
        //Khai báo control
        private Label lblName;
        private Button btnClick1;
        public Frm1()
        {
            //Phần 1: Tạo form
            this.Text = "frm C#3";
            this.Size = new Size(700,300);

            //Phần 2: Add label vào form
            lblName = new Label();
            lblName.Text = "PTPM .NET C#3";
            lblName.Location = new Point(100, 100);
            this.Controls.Add(lblName);

            //Phần 3: Add Button vào form
            btnClick1 = new Button();
            btnClick1.Text = "Click vào đây";
            btnClick1.Height = 70;
            btnClick1.Width = 100;
            btnClick1.Location = new Point(150, 100);
            this.Controls.Add(btnClick1);
        }

        public static void Main(string[] arg)
        {
            Application.Run(new Frm1());
        }
    }
}
