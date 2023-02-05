/*
 * xử lý exception: ngoại lệ
 * exception là những vấn đề phát sinh trong quá trình code và thường là những vấn đề gây ra
 * lỗi khiến cho chương trình chết hoặc ko thực hiện đúng chức năng
 * Trong c#, chúng ta có thể xử lý exception thông qua việc sử dụng khối lênh try-catch
 * hoặc tự định nghĩa những exception
 * try-catch finally
 * try:
 * catch: thực hiện sửa lỗi hawojc thông báo lỗi
 * finally: luôn chạy trong mọi trường hợp dù lỗi hay không
 */

int number;
bool x=int.TryParse("1234", out number);
Console.WriteLine(x);


int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7 };
try
{
    Console.WriteLine("nhập vị trí mà bạn muốn chia");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(5 / arr[index]);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("nhập vị trí mà bạn muốn chia");
    Console.WriteLine(ex.Message);
}
static bool TryParse(string input, out int number)
{
    try
    {
        number=Convert.ToInt32(input);
        return true;
    }
    catch(Exception)
    {
        number = -1;
        return false;
    }
    finally { Console.WriteLine("okk"); }
}


//định nghĩa exception trong hàm
static void ThongTinSinhVien(string mssv, int tuoi)
{
    if (mssv.StartsWith("PH"))
    {
        Exception e = new Exception("bạn ko phải sinh viên cntt");
        throw e;
    }
    if (tuoi < 18)
    {
        Exception e = new Exception("lượn");
    }
    Console.WriteLine("chúc mừng đã đc xác nhận");
}

ThongTinSinhVien("PH27488", 18);