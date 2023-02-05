/*
 * Collection là các lớp đặc biệt được sử dụng để lưu trữ dữ liệu và cũng là để thu hồi (quản lý)
 * Các Collection có kích thước không cố định, có thể tăng giảm kích thước 1 cách linh hoạt
 * Có rất nhiều phương thức mà chúng ta có thể dùng với Collection
 * Collection chia làm 2 loại: Generic Collection, Non-Generic Collection
 * Generic Collection cần khai báo kiểu dữ liệu mà nó chứa
 * Non-Generic Collection chấp nhận mọi kiểu dữ liệu
 * 
 */

/*
 * List là 1 Generic Collection cho phép chúng ta lưu trữ và quản lý các đối tượng cũng kiểu dữ liệu
 */

List<int> listSo;//khai báo: null
// khởi tạo
List<string> listChuoi = new List<string>();
Console.WriteLine(listChuoi.Count);
//Một số phương thức với List
// Các phương thức thêm:
//
listChuoi.Add("abc");//thêm vào cuối List
listChuoi.Add("xyz");
listChuoi.Add("add");
listChuoi.Add("aksdjfh");
listChuoi.Add("abfajf");
listChuoi.Add("cong");
listChuoi.Add("xoa");
listChuoi.Add("del");
//
listChuoi.Insert(1, "1");//thêm vào vị trí nào đó 1 giá trị nào đó
//
listChuoi.InsertRange(2,new List<string>() { "123","456"} );//thêm vào 1 vị trí nào đó hẳn 1 Collection cùng loại
//
//in list
Console.WriteLine(listChuoi);
Console.WriteLine(String.Join(", ", listChuoi));//tạo 1 string từ list

//sửa các phần tử trong List - truy xuất đến phần tử xong sửa
//xóa các phần tử trong List
listChuoi.Remove("123");//xóa phần tử theo giá trị
Console.WriteLine(String.Join(", ", listChuoi));
//
listChuoi.RemoveAt(3);//xóa phần tử theo vị trí
Console.WriteLine(String.Join(", ", listChuoi));
//
listChuoi.RemoveAll(p => p.StartsWith("1"));//xóa by linq
Console.WriteLine(String.Join(", ", listChuoi));
//
listChuoi.Clear();//xóa tất cả các phần tử trong List
Console.WriteLine(String.Join(", ", listChuoi));


//viết 1 phương thức cho phép nhập 1 chuỗi, truyền vào 1 list string
//sau đó xóa hết các phần tử trong List mà chứa chuỗi đó
//cách 1
Console.WriteLine("nhập chuỗi");
string xoa=Console.ReadLine();
for(int i = 0; i < listChuoi.Count; )
{
    if (listChuoi[i].Contains(xoa))
    {
        listChuoi.RemoveAt(i);
    }
    else
    {
        i++;
    }
}
Console.WriteLine(String.Join(", ",listChuoi));

//cách 2
Console.WriteLine("nhập chuỗi muốn xóa:");
string del=Console.ReadLine();
foreach(string s in listChuoi)
{
    if (s.Contains(del))
    {
        listChuoi.Remove(s);
    }
}
Console.WriteLine(String.Join(", ", listChuoi));

//Một số dạng collection đặc biệt hơn
//dạng key-value
//Dictionary (Generic), HashTable (Non-Generic)
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "13");
dict.Add(2, "cong");
dict.Add(3, "nguyen");
dict.Add(123124, "abc");
dict.Add(4, "xyz");
foreach(var item in dict)
{
    Console.WriteLine(item);
}


Dictionary<string, string> tuDien=new Dictionary<string, string>();
tuDien.Add("what", "cái j");
tuDien.Add("why", "tại sao");
Console.WriteLine(tuDien.ContainsKey("why"));



//viết hàm truyền vào 1 dictionary cho phép bạn nhập 1 từ tiếng anh sau đó đưa ra nghĩa của từ đó
// nếu ko có, cho người dùng nhập thêm nghĩa
//sử dụng hàm ContainKay để kiểm tra cái key có nằm trong dictionary ko


