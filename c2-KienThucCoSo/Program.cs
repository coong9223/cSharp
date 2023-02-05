// See https://aka.ms/new-console-template for more information
using c2_OnTap6._0;

//ép kiểu -chuyển đổi kiểu dữ liệu phục vụ cho quá trình xử lý
//các hình thức ép kiểu
//1. ép kiểu tường minh
int x = int.Parse("1234");//convert null sẽ báo lỗi,ko convert đc string rỗng
int y = Convert.ToInt32("5678");// convert null sẽ ra 0,ko convert đc string rỗng
Console.WriteLine(x+" "+y);
//2. ép kiểu ngầm định ( khi thao tác với các kiểu dữ liệu khác nhau mà chúng có thể ép kiểu qua lại)
double z = 10 + 12.5;
string t = "1234" + 1234;
Console.WriteLine(z);
Console.WriteLine(t);
Console.WriteLine("ádfkasd"+1234);



HamPhuongThuc hp = new HamPhuongThuc();
hp.PhuongThucKhongTraVe();
hp.PhuongThucKhongTraVe(13);
Console.WriteLine(hp.TraVeMotTong());
Console.WriteLine(hp.TraVeMotTong(10, 25));
HamPhuongThuc.HamTinh();

/*
 *vòng lặp: for, while, do-while, foreach, đệ quy
 */
VongLapDoWhile();
VongLapFor();
VongLapForeach();
VongLapWhile();
TinhTongSoLe();
TinhTrungBinh();


void VongLapFor()
{
    int i = 0;
    for(; i < 10;)
    {
        if (i++ < 10)
        {
            Console.WriteLine(i++);
        }
        Console.WriteLine("đã dừng");//check xem vòng lặp đã dừng hay chưa
    }
}//có thể dùng cách này để chạy vòng lặp

void VongLapWhile()
{
    Console.WriteLine(int.MaxValue);
        int i=0;
    while(i++ < 10)
    {
        Console.WriteLine("Hello");
    }
    Console.WriteLine("đã dừng");//check xem vòng lặp đã dừng hay chưa
}

void VongLapDoWhile()
{
    int i = 1000;
    do
    {
        Console.WriteLine(i);
    } while (i++ < 10);
    Console.WriteLine("đã dừng");//check xem vòng lặp đã dừng hay chưa
}

void VongLapForeach()// phải có tập hợp để thao tác trên dữ liệu của nó
{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(1);
    list.Add(5);
    list.Add(3);
    list.Add(2);
    list.Add(14);
    list.Add(1);
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    foreach(var item in arr)
    {
        Console.WriteLine(item);
    }
    /*foreach(var item in list)
    {
        if(item%2!= 0)
        {
            list.Remove(item);
        }
    }*///cách này bị lỗi ko thể xóa được
    for(int i = 0; i < list.Count; )
    {
        if (list[i] % 2 != 0)
        {
            list.RemoveAt(i);
        }
        else i++;
    }
    foreach (var item in list)
    {
        Console.WriteLine(item+" ");
    }
}//sử dụng khi không thay đổi kích thước của collection


static void TinhTrungBinh()
{
    //tìm số lớn thứ 2 trong 3 số
    int a = 10, b = 15, c = 8;
    int max = a >= b && a >= c ? a : b >= c ? b : c;
    int tb = (a - b) * (a - c) <= 0 ? a : (b - c) * (b - a) <= 0 ? b : c;
    Console.WriteLine(tb);
}

static void TinhTongSoLe() 
{
    //cho 1 mảng, ko sử dụng câu lệnh điều kiện, tính tổng tất cả các số lẻ
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i] * Math.Abs(arr[i]) % 2;//sai, cần nghiên cứu lại 
    }
    Console.WriteLine(sum);
}
