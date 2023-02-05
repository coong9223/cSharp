///*
// * Delegate là một phương pháp dùng để tham chiếu đến hàm - phương thức
// * mọi hàm - phương thức có cùng chữ kí hàm với Delegate đều có thể được chọn tới từ Delegate đó
// * Chữ kĩ hàm: kiểu trả về và tập tham số truyền vào
// * Khi một Delegate được đánh dấu tham chiếu tới hàm thông qua việc gán delegate với tên hàm thì 
// * khi gọi lại delegate chính là ta thực thi hàm đó
// * Một delegate có thể dùng tham chiếu tới nhiều hàm
// * 
// */

//static void InTen(string ten) { Console.WriteLine("Tên: " + ten); }
//static void InDiaChi(string address) { Console.WriteLine("address: " + address); }
//static void InSDT(string SDT) { Console.WriteLine("SDT:  " + SDT); }

//InString iss = InTen;//tham chiếu delegate tới hàm InTen
//iss("Công");
//iss = InSDT;
//iss("Công");
///*
// * Multicast Delegate: 1 delegate tham chiếu nhiều hàm cùng 1 lúc
// * dùng với delegate void
// */
//InString iss2 = InSDT; iss2 += InTen; iss2 += InDiaChi;
//iss2("abc");

///*
// * Delegate Callback: khi 1 hàm dùng làm tham số truyền vào cho hàm khác
// * => Callback: tuy nhiên C# ko hỗ trợ điều này với hàm ở thời điểm hiện tạo
// * Nhưng với delegate thì có thể
// */

//static void InSomthing(InString s, string t)
//{
//    s(t); s("abc");
//}
//InSomthing(iss2, "++++++++++++++++");

///*
// * Các loại delegate đã được dựng sẵn
// * 1. Func: có thể tham chiếu cho tất cả các hàm trả về
// * 2. Action: có thể tham chiếu cho tất cả các hmaf void
// * 3. Predicate: có thể tham chiếu cho tất cả các hàm trả về bool và có 1 tham số
// */
///*
// *Func: là delegate truyền vào các tham số với tham số cuối cùng là kiểu trả về
// *của hàm mà nó tham chiếu tới. Func được dựng sẵn do đó chúng ta chỉ cần sử dụng 
// *mà ko cần định nghĩa lại. Tham số cuối cùng khi gọi lại ko cần được đề cập 
// *và Func luôn có nhiều hơn hàm mà nó tham chiếu 1 tham số. Func tối thiểu 1 tham số
// */
//static long Hieu(int a, int b) { return a - b; }
//Func<int, int, long> func = Hieu;
//Console.WriteLine(func(10, 20));

///*
// * Action: có cấu tạo như Func nhưng ko có tham số cuối cùng
// * Action có thể ko có tham số
// */

//static void ABC() { Console.WriteLine("hello"); }
//static void XYZ(int t) { Console.WriteLine("hello"); }
//Action ac = ABC;
//Action<int> ac2 = XYZ;

///*
// * Predicate: là delegate truyền vào 1 tham số và trả về bool
// * Predicate thường dùng trong việc tìm kiếm hoặc kiểm tra
// */

//static bool IsChan(int a) { return a % 2 == 0; }
//Predicate<int> pred = IsChan;

//public delegate void InString(string s);//Delegate chỉ có cấu tạo, ko có phần thân



/*
 * Even trong C#
 * Là những hành động: click chuột, hover, ấn nút, ...
 * Trong C# thì Event là 1 hướng đối tượng đặc biệt được xây dựng dựa trên Delegate
 * Event chứa các phương thức sẽ đc thực thi khi sự kiện xảy ra
 * Đặc điểm chung của Event:
 * được khai báo ở lớp hoặc Interface, thực thi dựa trên delegate,
 * thường là 1 thành phần được đánh dấu là virtual hoặc abstract
 * => cách sử dụng Event:
 * 1. Định nghĩa delegate cho event
 * 2. Tạo event thông qua delegate đó
 * 3. Đăng kí event chương trình hearing và xử lý
 * 4. Kích hoạt event
 */

AnhChangE ace = new AnhChangE();
ace.eThemMotNam += ThemTuoi;
ace.Tuoi = 30;
Console.WriteLine($"ế ở {ace.Tuoi} tuổi");
ace.Tuoi = 35;
Console.WriteLine($"vẫn ế ở {ace.Tuoi} tuổi");


static void ThemTuoi(int tuoi)
{
    Console.WriteLine("thêm tuổi, nhưng vẫn ế");
    Console.BackgroundColor = ConsoleColor.Red;
}
class AnhChangE
{
    private int tuoi;
    public event TangTuoi eThemMotNam;

    public int Tuoi
    {
        get => tuoi; set
        {
            tuoi = value;
            if (eThemMotNam != null)//khi event đc kích hoạt
            {//gọi hành động của nó ra
                eThemMotNam(tuoi);
            }
        }
    }
}
//1. Tạo delegate cho event
delegate void TangTuoi(int tuoi);