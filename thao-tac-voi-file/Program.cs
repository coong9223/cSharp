/*
 * Thác tác với file. C# hỗ trợ chúng ta thao tác với file bằng
 * nhiều cách. Cách tiếp cận dễ nhất là file text .txt
 */
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Đọc file txt
byte[] fromfiles;
string path = @"D:\Class_List\Files\Test.txt";
fromfiles = File.ReadAllBytes(path); // Thêm @
//// Đọc file theo dạng byte
Console.WriteLine(String.Join(", ", fromfiles));
char[] frombyte = new char[fromfiles.Length];
for (int i = 0; i < frombyte.Length; i++)
{
    frombyte[i] = (char)fromfiles[i]; // Ép kiểu byte => char
}
Console.WriteLine(String.Join(", ", frombyte));
File.WriteAllBytes(path, new byte[] { 1, 2, 3, 4, 5, 6, 8 });
// Xóa những thành phần cũ và thêm thành phần mới
// Thao tác với text
string s = File.ReadAllText(path); // Trả về 1 string từ file
Console.WriteLine(s);
string content = "How a ziu, am five thank ciu";
//File.WriteAllText(path, content); // Xóa cũ thêm mới
File.AppendAllText(path, "\nAND ZIU?");
// ĐỌc, ghi theo từng dòng
string[] mangstring = File.ReadAllLines(path);
Console.WriteLine(string.Join("\n", mangstring));
// Ghi từng dòng
File.WriteAllLines(path, mangstring); // Xóa cũ thêm mới
File.AppendAllLines(path, mangstring);
// Đọc ghi đối tượng vào 1 file text bình thường
Nguoi n = new Nguoi("Khánh", 19);
string s = n.TaoChuoiDT();
File.AppendAllText("Nguoi.txt", "\n" + s);
// Xử lý đọc toàn bộ những thông tin trong file => các đối tượng
string[] allPeople = File.ReadAllLines("Nguoi.txt");
List<Nguoi> allNguoi = new List<Nguoi>();
foreach (string t in allPeople)
{
    if (t.Trim().Length > 0) { allNguoi.Add(TaoNguoi(t)); }
}
foreach (Nguoi k in allNguoi) k.InTT();
// Đọc, ghi với file xml
// Ghi
// Khi thao tác với file thì phải biết đường dẫn của file là gì . path2 là đường dẫn tới file xml mà ta dọc-ghi
string path2 = @"C:\Users\DELL\source\repos\ThaoTacVoiFile\ThaoTacVoiFile\bin\Debug\net6.0\Nguois.xml";
var b = new Nguoi { name = "Khá", tuoi = 20 }; // Tạo ra 1 đối tượng để lưu vào file xml
var writer = new System.Xml.Serialization.XmlSerializer(typeof(Nguoi)); // Class XMLSer cho phép nhận diện đối tương
var w2file = new StreamWriter(path2); // Cung cấp 1 luồng để mình đọc cái file xml thao paths
writer.Serialize(w2file, b); // Đẩy thông tin từ thằng b => file mà trỏ đến được thông qua w2file
w2file.Close(); // Đóng cái liên kết lại
// Đọc
System.Xml.Serialization.XmlSerializer reader =
    new System.Xml.Serialization.XmlSerializer(typeof(Nguoi)); // Tạo 1 reader để có thể đọc được
                                                               // đối tượng là người
StreamReader StreamReader = new StreamReader(path2); // Đọc nội dung từ cái file có đường dẫn là path2
Nguoi n = (Nguoi)reader.Deserialize(StreamReader); // Đọc đối tượng từ file
StreamReader.Close();
n.InTT();


static Nguoi TaoNguoi(string data)
{
    string[] pros = data.Split(',');
    //Console.WriteLine(string.Join(", ", pros));
    string name = pros[0].Split(':')[1].Trim();
    int tuoi = Convert.ToInt32(pros[1].Split(':')[1].Trim());
    Nguoi n = new Nguoi(name, tuoi);
    return n;
}
public class Nguoi
{
    public string name;
    public int tuoi;
    public Nguoi(string name, int tuoi)
    {
        this.name = name;
        this.tuoi = tuoi;
    }

    public Nguoi()
    {
    }

    public string TaoChuoiDT()
    {
        return $"Tên: {name}, Tuổi: {tuoi}";
    }
    public void InTT()
    {
        Console.WriteLine($"Tên tôi là {name}, Tôi {tuoi} tuổi ");
    }
}
