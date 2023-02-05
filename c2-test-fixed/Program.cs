// See https://aka.ms/new-console-template for more information

//Bài 1
//bước 1: tìm căn bậc 2 và ép về int
//bước 2: kiểm tra xem căn bậc đó khi ép kiểu có thay đổi không
//nếu có thì giảm đi 1 vì yêu cầu tìm số nguyên gần nhất nhỏ hơn
void CanBacHai (int x, out int y)
{
    y = (int)Math.Sqrt(x);
        if (y * y == x)
    {
        y -= 1;
    }
}
int z;
CanBacHai(17, out z);
Console.WriteLine(z);

//Bài 2
void NhapSoNg()
{
    while (true)
    {
        try
        {
            Console.WriteLine("hãy nhập 1 số nguyên: ");
            int x = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("nhập lại: ");
        }
    }
}
NhapSoNg();
