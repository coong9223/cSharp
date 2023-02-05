// See https://aka.ms/new-console-template for more information
using Generic;
/*
 * Tổng quát hóa các kiểu dữ liệu theo cùng 1 format
 * Chúng ta đã từng làm quen với Generic qua List
 * List là 1 collection Generic 
 * + Khái niệm: Lập trình Generic là 1 dạng lập trình trong đó kiểu 
 * dữ liệu (của biến truyền vào, cục bộ, tham số hoặc kiểu trả về
 * không được xác định rõ ràng trong quá trình viết hàm, class 
 * (xây dựng hàm, class)
 * mà được xác định khi chúng ra gọi hàm hoặc class (quá trình sử dụng)
 * Bản chất chính là tham số hóa kiểu dữ liệu
 * Tuy nhiên khi xây dụng hàm, class chúng ta không thể loại bỏ
 * kiểu dữ liệu => Sử dụng kiểu dữ liệu giả
 */
// Phương thức Generic 
static void Hienthi<T>(T x, T y)// T là kiểu dữ liệu giả - đại diện cho các kiểu khác
{// Ngoài main
    Console.WriteLine($"x là: {x}, y là: {y}");
}

// trong main
//Hienthi<int>(12, 15);
//Hienthi<string>("ancvd", "wefwef");
//Hienthi("1234", "1111111");// .Net Core 6.0
static void ABCD<T,Z>(T x, Z y)
{
    Console.WriteLine(x);
    Console.WriteLine(y);
}
//ABCD<string, int>("1234abc", 123);
// Viết 1 phương thức Generic thực hiện việc hoán đổi giá trị 2 biến cùng kiểu
// có dử dụng tham chiếu (ref)

static void Hoandoi<T>(ref T x, ref T y) where T : struct
{
    T z = x;
    x = y; y = z;
}

//string a = "abc", b = "bcd";
//Console.WriteLine($"a = {a}, b = {b}");
//Hoandoi<string>(ref a, ref b);
//Console.WriteLine($"a = {a}, b = {b}");
// Chữa bài 
// 1: 
// bước 1: tìm căn bậc 2 và ép về int
// bước 2: kiểm tra xem căn bậc đó khi ép kiểu có thay đổi không,
// nếu có thì giảm đi 1 vì yêu cầu tìm số nguyên gần nhất nhỏ hơn
static void MinSQRT (int x, out int y)
{
    y = (int)Math.Sqrt(x);
    if (y*y==x)
    {
        y -= 1;
    }
}
int z;
//MinSQRT(16, out z);
//Console.WriteLine(z);
static void NhapSoNguyen()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Hãy nhập 1 số nguyên");
            int x = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Nhập lại đê: ");
        }
    }
}
//NhapSoNguyen();
QuanLyNhanKhau<Nguoi> q1 = new QuanLyNhanKhau<Nguoi>();
QuanLyNhanKhau<NguoiGia> q2 = new QuanLyNhanKhau<NguoiGia>();
Nguoi n = new Nguoi("anc", "xyz");
NguoiGia ng = new NguoiGia(100);
q1.TenGiCungDuoc.Add(n);
q1.TenGiCungDuoc[0].IN();
q2.TenGiCungDuoc.Add(ng);
q2.TenGiCungDuoc[0].IN();

static void InGiaTriCuaBIen<T>(T x)
{
    Console.WriteLine(x);
}
InGiaTriCuaBIen<string>("16");
InGiaTriCuaBIen<int>(16);
InGiaTriCuaBIen<List<int>>(new List<int>());

//generic là ột phương pháp cho phép chúng ta thực hiện cùng một công việc 
//trên những kiểu dữ liệu khác nhau
//biểu thức với hàm dùng generic phải thỏa mãn mọi trường hợp ứng với mọi kiểu dữ liệu
//từ khóa var và dynamic: đều sử dụng để thao tác với nhiều kiểu dữ liệu
//kiểu dữ liệu của chúng chưa cần đưỡ xác nhận trước khi được sử dụng
/*
 * vả chỉ là từ khóa đánh dấu một viến có thể nhận nhiều kiểu dữ liệu, biến
 * đi cùng từ khóa var bắt buộc phải được khởi tạo giá trị => kiểu dữ liệu 
 * => kiểu dữ liệu này không thể thay đổi trong quá trình code
 * dynamic có thể sử dugj độc lập như 1 kiểu dữ liệu nhưng chấp nhận mọi kiểu 
 * dữ liệu khác: có thể khai báo biến với kiểu dữ liệu dynamic, biến đi với 
 * dynamic có thể thay đổi kiểu dữ liệu khi code
 */

var x = 10;
dynamic a;
a = 10;a = "abc";

//lưu ý: không nên lạm dụng dynamic vì thông thường khi chúng ta code thì sẽ
//cần xác định chính xác kiểu dữ liệu để đưa ra các phương pháp hợp lý. Việc thay
//đổi kiểu dữ liệu thường xuyên sẽ gây ra các lỗi không đáng có

static void InThongTin(dynamic x, dynamic y)
{
    Console.WriteLine(x+y);
}InThongTin(10, 20);
InThongTin(20, "abc");