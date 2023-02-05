using ThaoTacVoiFile;
/*
 * File: Tệp tin là những dữ liệu được lưu trữ đóng gói trong một tệp
 * Namespace System.io hỗ trợ chúng ta nhiều cách thức để thao tác với file
 * một số lớp hỗ trợ thao tác với file
 * Binary (Writer-Reader): đọc và ghi dữ liệu dưới dạng Binary (mã nhị phân)
 * Buffer Stream: Nhớ đệm cho stream
 * File Info & File Stream: thực hiện cách hoạt động trên file
 * Stream (Reader/Writer): đọcvà ghi dữ liệu ký tự trên stream
 * String (Reader/Writer): đọc và ghi dữ liệu trên Buffer
 */
//Đọc-Ghi đối tượng ( là đọc và ghi thông tin của các đối tượng

//Đọc-Ghi vào xml
string path = @"D:\console\ThaoTacVoiFile";
List<SinhVien> sinhviens=new List<SinhVien>();
new SinhVien("ph27488", "khánh pg", 19, 9);

static List<SinhVien> ReadSVfromXML(string path)
{
    if(!File.Exists(path))//kiểm tra xem file có tồn tại hay ko
    {
        Console.WriteLine("file ko tồn tại");
    }else
    {
        XmlSerializer xs = new XmlSerializer(typeof(SinhVien));
        using (FileStream fs = new FileStream(path, FileMode.Open)) ;
        {
            var listSV = (List<SinhVien>)xs.Deserialize(fs);
            return listSV;
        }
    }
}
static void WriteSVtoXML(string path, List<SinhVien>)
{
    if (!File.Exists(path))
    {
        Console.WriteLine("file k tồn tại");
        return null;
    }else { 
        XmlSerializer xs = new XmlSerializer(typeoff(SinhVien));
        using (TextWriter tw=StreamWriter(path))
        {
            xs.Serialize(tw, list);
            tw.Close();
        }    }
}