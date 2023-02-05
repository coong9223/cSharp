using assignment;

List<SinhVien> list=new List<SinhVien>();
Service sv=new Service(list);

//kiến thức kế thừa
KeThua kt = new KeThua();

//kiến thức TryParse() trong việc báo lỗi ép kiểu
int v;
bool check=int.TryParse(Console.ReadLine(), out v);
Console.WriteLine("giá trị của x nhập vào là: "+v);
Console.WriteLine(v+",check: "+check);


//kiến thức TryCatch trong việc báo lỗi
void NhapSo()
{
    while (true)
    {
        try
        {
            Console.WriteLine("mời nhập: ");
            int x=Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("bạn đã nhập sai.");
        }
    }
}


//kiến thức generic
void TinhTong<T>(T t,T y)
{
    Console.WriteLine("tổng: "+t+y);
}


//kiến thức ref
void TinhGiaTriCoBan(ref int x, ref int y)
{
    x += 10;y += 10;
    Console.WriteLine($"giá trị lần lượt của x và y là: {x}, {y} ");
}


//nội dung chính assignment
string path = @"D:\console\assignment\New Text Document.xml";
static int Menu()
{
    Console.WriteLine("mời nhập mục: ");
    int nhap=Convert.ToInt32(Console.ReadLine()); 
    return nhap;
}

void RunMenu()
{
    do
    {
        switch(Menu())
        {
            case 1:
                sv.Nhap();
                break;

            case 2:
                sv.Xuat();
                break;

            case 3:
                sv.Delete();
                break;

            case 4:
                sv.KTDinhDangSDT();
                break;

            case 5:
                sv.Them();
                break;

            case 6:
                Console.WriteLine("delegate: ");
                list lists = delegate (string name)
                {
                    Console.WriteLine($"ten: {name}");
                };
                lists("Công");
                break;
            
            case 7:
                sv.DocFile<SinhVien>(path);
                break;

            case 8:
                sv.GhiFile(path, list);
                break;

            case 9:
                sv.LinQ();
                break;

            case 10:
                Console.WriteLine("biệt thức lambda: ");
                InThongTin inluon = (string s) => Console.WriteLine(s+"quá đẹp zai");
                inluon("Công");
                break;

            case 0:
                System.Environment.Exit(0);
                break;

            default:
                Console.WriteLine("mời nhập lại");
                break;
        }
    }while(true);
}
Console.OutputEncoding=System.Text.Encoding.UTF8;

//kiến thức ref
int a = 10;int b = 10;
TinhGiaTriCoBan(ref a, ref b);
Console.WriteLine($"giá trị của a và b lần lượt là: {a}, {b}");

//kiến thức generic
TinhTong<int>(12, 15);

//kiến thức TryCatch
NhapSo();
RunMenu();

//kiến thức kế thừa
kt.InThongTinThem();
kt.GhiDe();

public delegate void list(string name);
public delegate void InThongTin(string id);


