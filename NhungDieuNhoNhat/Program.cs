/*
 * Partial Class: là khi một class có thể chia nhỏ ra thành các thành phần khác nhau, lưu trên các 
 * file vật lý (được lưu)
 */
//Nullable: là 1 biến bình thường có thể nhận cả giá trị null, đánh dấy 1 nullable bằng dấu ? sau kiểu dữ liệu
int? y = null;
//null là trạng thái ko có j cả, tức là ko có tham chiếu đến địa chỉ nhớ nào

//int x;//khai báo
//int z = 0;
//Console.WriteLine(x);

//Anonimus typed: 
/*
 * Kiểu nặc danh: cho phép chúng ta gán, đóng gói phương tiện
 * Cho phép tạo các type mới
 * Tạo kiểu ẩn danh này = toán tử new
 */
var Sinhvien = new
{
    msv = "ph1234",
    ten = "congooooo",
    lop = "it17331",
    NganhHoc = new
    {
        id = 1,
        ten = "ứng dụng phần mêm",
    }
};

//Anonimus Function
// khi ta tạo 1 function nặc danh thông qua delegate 

InConcho incho = delegate (string tenCho)
  {
      Console.WriteLine("tên: "+tenCho);
  };
incho("husky");


/*
 * Lambda Expression: Biệt thức Lambda
 * Xây dựng dựa trên dạng anonymous method
 */
//cách xây dựng lambda expression
/*
 * dạng 1: full topping
 * (danh sách tham số) => {các câu lênh}
 * dạng 2:
 * (danh sách tham số) => biểu thức thực thi
 */
InConcho inconcho = (string s) => Console.WriteLine("tên: "+s);
inconcho("chó lợn");

TrungBinh intb = (int x, int y, int z) => { Console.WriteLine((x + y + z) / 3.0); };
intb(1, 234, 56789);


//linq có 2 dạng là linq thuần và linq with lambda expression
/*
 * linq =language intergrated query (ngôn ngữ truy vấn tích hợp)
 * Tích hợp các câu lệnh truy vấn (giống với sql), cho phép truy cập tới các nguồn dữ liệu khác nhau (
 * xml, IEnumerable, DBSet, ...)-Những dạng sequence-tập hợp 
 * Ưu điểm: Sự mạch lạc và logic trong câu lệnh, thực hiện dễ dàng hơn, ngắn gọn hơn
 * hỗ trợ nhiều phương thức trong truy vấn
 * 
 * Nhược điểm: tốc độ chậm hơn so với một số cách khác
 * Cấu trúc cơ bản:
 *       from tên_object in sequence
 *       where điều_kiện
 *       select tên_object
 */

int[] arr = { 1, 2, 3, 4, 5, 6, 6, 7, 8 };
//lấy các phần tử >5 và <10 trong arr
int[] items=(from x in arr where x>5 && x<10 select x).ToArray();
Console.WriteLine(String.Join(", ",items));
//sử dụng với lambda
int[] items2=arr.Where(x=>x>5 && x<10).ToArray();
Console.WriteLine(String.Join(", ", items2));

public delegate void InConcho(string id);
public delegate void TrungBinh(int a, int b, int c);




