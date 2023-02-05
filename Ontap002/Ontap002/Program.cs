using System;
using System.Collections.Generic;

namespace Ontap002
{
    class Program
    {
        static List<Hocsinh> hocsinhs = new List<Hocsinh>();
        static Service sv = new Service(hocsinhs);

        static string Menu()
        {
            Console.WriteLine("+++++++++++++++ MENU ++++++++++++++");
            Console.WriteLine("1. Nhập danh sách đối tượng ");
            Console.WriteLine("2. Xuất danh sách đối tượng ");
            Console.WriteLine("3. Xuất các đối tượng có bao gồm thêm thông tin năm sinh ");
            Console.WriteLine("4. Tìm đối tượng theo MaHs và thông báo không tìm thấy khi nhập mã không tồn tại ");
            Console.WriteLine("5. Tên viết tắt. Xuất danh sách các đối tượng, yêu cầu thay đổi tên ");
            Console.WriteLine("6. Kế thừa ");
            Console.WriteLine("0. Thoát ");
            Console.WriteLine("Nhập lựa chọn đi anh 2: ");
            string luachon = Console.ReadLine();
            return luachon;
        }

        static void ChayMenuLapLai()
        {
            do
            {
                switch (Menu())
                {
                    case "1": // switch theo Menu là string nên case cũng là string
                        sv.NhapDS(); // Gọi phương thức
                        break; // Bắt buộc phải có break;
                    case "2":
                        if (hocsinhs.Count == 0)
                        {
                            Console.WriteLine("Danh sách đang trống, bạn hãy nhập thêm trước đi");
                            sv.NhapDS();
                        }
                        else
                        {
                            sv.XuatDS();
                        }                       
                        break;
                    case "3":
                        sv.XuatDSNS();
                        break;
                    case "4":
                        sv.TimTheoMa();
                        break;
                    case "5":
                        sv.TenVietTat();
                        break;
                    case "6":
                        sv.KeThua();
                        break;
                    case "7":
                        return;
                        System.Environment.Exit(1232138);
                        break;
                    default:
                        Console.WriteLine("Hãy nhập từ 0 đến 7 để cỏ thể trải nghiệm chương trình");
                        break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ChayMenuLapLai();
        }
    }
}
