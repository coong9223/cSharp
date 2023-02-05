void Bai1( double x)
{
    double y = Math.Sqrt(x);
    int count = 0;
    int max = 0;
    for (int i = 0; i < y; i++)
    {
        count++;
    }
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = i;
        if(max< arr[i])
        {
            max = arr[i];   
        }
    }
    Console.WriteLine(max);
    Console.WriteLine(x);
}

double a = 40;
Bai1 (a);
Console.WriteLine(a);




try
{
    Console.WriteLine("mời nhập số: ");
    int n=Convert.ToInt32(Console.ReadLine());
}catch (Exception ex)
{
    Console.WriteLine("lỗi!");
    Console.WriteLine(ex.Message);
}





