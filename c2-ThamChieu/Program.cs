// See https://aka.ms/new-console-template for more information
using c2_ThamChieu;
Console.WriteLine("Hello, World!");

//ép kiểu: Chuyển đổi dữ liệu này sang kiểu dữ liệu khác sao cho phù hợp với mục đích của người sử dụng

//ép kiểu tường minhP ép kiểu mà người dùng chủ đích muốn thay đổi kiểu dữ liệu
Console.WriteLine(Convert.ToInt32("12345"));
Console.WriteLine(int.Parse("0"));//null và chuỗi rỗng không thể ép kiểu
int x;
bool ok= int.TryParse("abcd",out x);//trả về 1 bool. Nếu ép kiểu đc thì sẽ trả về true, ngược lại thì false
//sau khi thực hiện TryParse s out ra một giá trị là kết quả của việc ép kiểu
//phương thức này là phương thức public static ool truyền vào 1 string
Console.WriteLine(x);
Console.WriteLine(x+ "ép kiểu "+ok);

int y;
bool ko=int.TryParse(Console.ReadLine(),out y);
Console.WriteLine(y+" "+ko);
//ép kiểu ngầm định: chương trình khi chạy sẽ tự động ép kiểu để các câu lệnh sau được thực hiện mà ko lỗi

//khóa static: là từ khóa để đánh dấu một lớp, phương thức biến là ở t trạng thái tĩnh: không thể khởi tạo được với lớp
//vào có thể gọi trực tiếp thông qua tên lớp đối với hàm
TinhToan.MyProperty = 100; Console.WriteLine(TinhToan.MyProperty);
TinhToan.TinhCong();
//viết ngoài main
void ThayDoi(int x,int y)
{
    x += 10;y+=10;
    Console.WriteLine($"x= {x},y= {y}");
}

//ref
void ThayDoi2(ref int x, ref int y)
{
    x += 10; y += 10;
    Console.WriteLine($"x= {x},y= {y}");
}

//out
void ThayDoi3( int x,  int y, out int z)
{//khi dùng out thì thực tế out đánh dấu cho thành phần trả về của kết quả
    //ko trực tiếp tham gia vào hoạt động logic của khối lệnh
    x += 10; y += 10;
    Console.WriteLine($"x= {x},y= {y}");
    z = x + y;
}
//viết trong main
int a = 10; int b = 10;
int c;
ThayDoi (a,b);//truyền vào giá trị của a và b
Console.WriteLine($"x= {a},y= {b}");
Console.WriteLine("thực hiệc truyền tham ch iếu thì:");
ThayDoi2(ref a, ref b);//tác động đến vùng nhớ chứa 2 biến a và b
Console.WriteLine($"x= {a},y= {b}");
ThayDoi3( a,  b, out c);
Console.WriteLine(c);
//dùng ref khi muốn thay đổi trực tiếp thành phần tham chiếu mà chúng có tham gia vào câu lệnh
//các thành phần này cũng đã có ẵn giá trị

//dùng out khi muốn thay đôi 1 thành phần tham chiếu như một giá trị trả về
//mà thành phần này trực tiếp tham gia hoặc chưa được khởi tạo

//khối lệnh try catch - cho phép chúng ta thực hiện 1 khối lệnh chứa lỗi, show ra lỗi mà chương trình vẫn 
//có thể thực thi mà ko bị dừng
try
{
    Console.WriteLine("nhập số: ");
    Convert.ToInt32(Console.ReadLine()); 
}catch (Exception e)
{
    Console.WriteLine("bạn vừa nhập 1 thành phần ko phải int");
    Console.WriteLine(e.Message);
}
//thử viết lại TryParse class TinhToan - Dùng Convert.ToInt32

int v; 
bool alo=TinhToan.TryParse("1234", out v);
Console.WriteLine(v);
Console.WriteLine(v + " ép " + alo) ;


