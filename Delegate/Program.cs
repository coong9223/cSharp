// Delegate là gì?
/*
 * Delegate là một phương pháp lập trình trong C# cho phép chúng ta tham chiếu
 * tới một phương thức thông qua một con trỏ => delegate. Cho nên có thể 
 *  coi delegate như một con trỏ hàm
 */


static void PrintTen( string s)
{
    Console.WriteLine("tên tôi là: "+s);
}
static void PrintHo(string s)
{
    Console.WriteLine("họ tôi là: " + s);
}
Print pt = PrintTen;
//khi gọi pt(string s) tứ là ta đang gọi đến hàm PrintTen( string s)
pt("Nam");
pt = PrintHo;
pt("Nam");
//Multicast delegate => 1 delegate có thể trỏ tới nhiều hàm
Print pt2 = PrintTen;
pt2 += PrintHo;
pt2("Name");
//Lúc này delegate sẽ gọi cả 2 hàm mà nó tham chiếu tới và cùng truyền vào 1 giá trị
//chữ kí hàm: kiểu dữ liệu trả về và các tham số truyền vào 
//Thử viết 1 delegate cho hàm truyền vào 1 string, 1 int và ko trả về sau đó 
//gọi lại
static void ThongTin(string a, int b)
{
    Console.WriteLine($"tên: {a},tuổi: {b}");
}
Print2 pt3 = ThongTin;
pt3("Công", 21);


static int Sum(int x, int y)
{
    return x + y;   
}
static int TraVe() { return 10; }
Func<int, int, int> tong = Sum;
Console.WriteLine(tong(10,20));//gọi lại
Func<int> tv = TraVe;


static void In(int x, string y)
{
    Console.WriteLine(y+x);
}
Action<int, string> ac = In;
ac(10, "Tuổi của tôi là ");

static bool IsChan(int x) { return x % 2 == 0; }
Predicate<int> chan = IsChan;
Console.WriteLine(chan(10));
//chúng ta có thể sử dụng delegate dạng Func để dùng với các hàm trả về
//với phương thức truyền vào n tham số thì Func có n+ tham số với tham số
//cuối cùng tương tự như một tham số out
//Func có tối thiểu 1 tham số
//với những phuonwg thức ko trả về - void, chỉ thực hiện những hành động delegate Action
//Action có thể ko chứa tham số nào

//vói những phương thức trả về kiểu bool chúng ta dùng Predicate

//delegate Callback - sử dụng hàm như 1 tham số của hàm khác
//với C# thì việc này là không thể tuy nhiên với delegate thì ta có thể sử dụng để call back
GiftDelegate gd = SendGift;
Noel("bupbe", gd);

static void SendGift(string gift) { Console.WriteLine("đã tặng "+ gift); }
static void Noel(string s, GiftDelegate TangQua)
{
    var qua = s;
    TangQua(qua);

}

public delegate void GiftDelegate(string gift);

public delegate Func<int,int,int>Sum(int x, int y);//khi khai báo


//Cách khai báo access modifier + delegate + kiểu trả về + tên(param)
//delegate Print có thể trỏ đến bất kì hàm nào kiểu void và truyền vào một string
public delegate void Print2(string a, int b);   
public delegate void Print(string s);