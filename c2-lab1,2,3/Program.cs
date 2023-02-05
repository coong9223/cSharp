// See https://aka.ms/new-console-template for more informat
using c2_lab1_2_3;
//bài 1
Console.WriteLine("nhập tên: ");
string name = Console.ReadLine();
Console.WriteLine("nhập mssv: ");
string mssv = Console.ReadLine();
Console.WriteLine("nhập tuổi: ");
int age = Convert.ToInt32(Console.ReadLine());

sinhVien sv=new sinhVien(mssv,name,age);
sv.InThongTin();

//bài 2
void HoanDoi<T>(ref T x, ref T y)
{
    T z = x;
    x = y;
    y = z;
}
string ReverseString(string x, out string y)
{
    char[] arr=x.ToCharArray();
    
    Array.Reverse(arr);
    y = new string(arr);
    return y;
}
string a = "123456789cong";
Console.WriteLine($"chuỗi gốc: {a}");
string b;
ReverseString(a,out b);
Console.WriteLine($"chuỗi đảo ngược: {b}");
//bài 3
void Generic<t>(ref t a)
{
    List<t> list = new List<t>();
    list.Add(a);
}
string z = "Nguyễn Thành Công";
Generic<string>(ref z);
Console.WriteLine(z);



