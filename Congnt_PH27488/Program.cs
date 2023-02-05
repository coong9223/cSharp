using Congnt_PH27488;

List<NganhHoc> list=new List<NganhHoc>();
SERVICE sv=new SERVICE(list);
string path = @"D:\console\Congnt_PH27488\New Text Document.xml";

static int Menu()
{
    Console.WriteLine("1. Nhập:");
    Console.WriteLine("2. Xuất");
    Console.WriteLine("3. Lưu File: ");
    Console.WriteLine("4. Đọc File: ");
    Console.WriteLine("5. Tìm kiếm LinQ");
    Console.WriteLine("6. Xóa LinQ");
    Console.WriteLine("0. ");
    Console.WriteLine("Mời chọn mục: ");
    int chon=Convert.ToInt32(Console.ReadLine());
    return chon;
}

void Main()
{
    do
    {
        switch (Menu())
        {
            case 0:
                System.Environment.Exit(0);
                break;
            case 1:
                sv.NhapDS();
                break;
            case 2:
                sv.XuatDS();
                break;
            case 5:
                sv.TimKiemLinQ();
                break;
            case 6:
                sv.XoaLinQ();
                break;
            default:
                Console.WriteLine("mời nhập lại");
                break;
        }
    }while(true);
}
Console.OutputEncoding=System.Text.Encoding.UTF8;
Main();