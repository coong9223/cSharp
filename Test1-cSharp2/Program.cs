using Test1_cSharp2;
List<Student> students=new List<Student>();
Service sv=new Service(students);
static int Menu()
{
    Console.WriteLine("menu: ");
    Console.WriteLine("nhập ds ");
    Console.WriteLine("xuất ds ");
    Console.WriteLine("lưu file-đọc file ");
    Console.WriteLine("nhập id ");
    Console.WriteLine("linq ");
    Console.WriteLine("thoát");
    Console.WriteLine("mời nhập: ");
    int chon=Convert.ToInt32(Console.ReadLine());
    return chon;
}

void Main(string[] args)
{
    do
    {
        switch (Menu())
        {
            case 1:
                sv.Xuat();
                break;
            default:
                Console.WriteLine("mời nhập lại: ");
                break;
        }
    }while (true);
}
