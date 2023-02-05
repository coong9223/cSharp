using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace assignment
{
    internal class Service
    {
        List<SinhVien> sinhviens=new List<SinhVien>();

        

        public Service()
        {
        }
        public Service(List<SinhVien> sinhviens)
        {
            this.Sinhviens = sinhviens;
        }
        public List<SinhVien> Sinhviens { get => sinhviens; set => sinhviens = value; }
        public SinhVien NhapThongTin()
        {
            Console.WriteLine("nhập thông tin sinh viên: ");
            Console.WriteLine("id: ");
            string id=Console.ReadLine();
            Console.WriteLine("ten: ");
            string name=Console.ReadLine();
            Console.WriteLine("sdt: ");
            string sdt=KTDinhDangSDT();
            Console.WriteLine("msv: ");
            string msv=Console.ReadLine();
            Console.WriteLine("diem: ");
            double mark=Convert.ToDouble(Console.ReadLine());

            string[]hoten=name.Split(' ');
            string kq=hoten[hoten.Length-1];
            for(int i = 0; i < hoten.Length-1; i++)
            {
                kq+=hoten[i][0];
            }
            string email = kq + msv + "@poly";
            SinhVien sv=new SinhVien(id,name,sdt,msv,email,mark);
            return sv;
        }
        public void Nhap()
        {
            Console.WriteLine("nhập số lượng phần tử: ");
            int n=Convert.ToInt32(Console.ReadLine());  
            int[] arr=new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                SinhVien sv=NhapThongTin();
                Sinhviens.Add(sv);
            }
        }
        public void Them()
        {
            Sinhviens.Insert(2, new SinhVien("1", "Công", "0962968674", "ph27488", "congntph27488@gmail.com", 8.9));
        }
        public void Xuat()
        {
            foreach(SinhVien sv in Sinhviens)
            {
                sv.InThongTin();
            }
        }
        public void Delete()
        {
            Console.WriteLine("nhập id sinh viên cần xóa: ");
            string xoa = Console.ReadLine();
            for (int i=0; i < Sinhviens.Count;)
            {
                if (Sinhviens[i].Id1 == xoa)
                {
                    Sinhviens.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        public void LinQ()
        {
            Sinhviens=Sinhviens.OrderBy(x => x.Id1).ToList();
            foreach (var item in Sinhviens)
            {
                item.InThongTin();
            }           
        }
        public List<T> DocFile<T>(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("file khong ton tai"); return null;
            }
            else
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<T> result = (List<T>)xs.Deserialize(fs);
                    fs.Close(); return result;
                }
            }
        }
        public void GhiFile<T>(string path, List<T> t)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("file khong ton tai");
            }
            else
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                using (TextWriter tw = new StreamWriter(path))
                {
                    xs.Serialize(tw, t); tw.Close();
                }
            }
        }
        public string KTDinhDangSDT()
        {
            string sdt;
            try
            {
                Console.WriteLine("Nhap sdt: ");
                sdt = Console.ReadLine();
                if (string.IsNullOrEmpty(sdt))
                {
                    KTDinhDangSDT();
                }
                if (sdt.Length > 12)
                {
                    KTDinhDangSDT();
                }
                else
                {
                    var r = new Regex(@"(\d{3})-(\d{3})-(\d{4})");
                    bool kt = r.IsMatch(sdt);
                    if (kt == false)
                    {
                        Console.WriteLine("Ko dung dinh dang");
                        KTDinhDangSDT();
                    }
                }
                return sdt;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
