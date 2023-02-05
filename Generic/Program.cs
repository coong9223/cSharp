// See https://aka.ms/new-console-template for more information
/*Generic: tổng quát hóa các kiểu dữ liệu theo cùng 1 format
 * đã từng làm quen với Generic qua List
 * List: là một collection Generic
 * + khái niệm: lập trình Generic là 1 dạng lập trình trong đó kiểu dữ liệu (của biến truyền vào, cục bộ, tham số
 * hoặc kiểu trả về không được xác định rõ ràng trong quá trình viết hàm, class (xây dựng hàm) mà được xác định khi chúng 
 * gọi hàm hoặc class (quá trình sử dụng)
 * Bản chất chính là tham số hóa kiểu dữ liệu
 * Tuy nhiên khi xây dựng hàm hoặc class, chúng ta ko thể loại bỏ kiểu dữ liệu => sử dụng kiểu dữ liệu giả
 */

//phương thức Gểnic
void TinhCong<T>(T x, T y)//T là kiểu dữ liệu giả - đại diện cho các kiểu dữ liệu khác
{//ngoài main
    Console.WriteLine($"x={x},y={y}");
}

//trong main
TinhCong<int>(12, 15);