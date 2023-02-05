using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_1_6_CRUD_EF.Utilities
{
    public class Utility
    {
        //Các phương thức tiện ích
        //Phương thức zen mã tự động: NGUYỄN anh Dũng => Dungna
        public static string ZenMaTuDong(string fullName)
        {
            string temp = fullName.Trim().ToLower();//nguyễn anh dũng
            string[] arrValues = temp.Split(' ');// Cắt chuỗi thành mảng
            string final = GetVietHoaChuCaiDau(arrValues[arrValues.Length - 1]).Trim();//Dũng
            for (int i = 0; i < arrValues.Length - 1; i++)
            {
                final += GetChuCaiDau(arrValues[i]);
            }
            return LoaiBoDauTiengViet(final);//Dungna
        }

        public static string GenMa(string x)
        {
            
            string temp = x.Trim().ToLower();//viet thuong ten
            string[] arrValues = temp.Split(' ');//cat chuoi thanh mang
            string result = "";
            for (int i = 0; i < arrValues.Length; i++)
            {
                result += GetChuCaiDau(GetVietHoaChuCaiDau(arrValues[i]));
            }
            return LoaiBoDauTiengViet(result).Trim();
        }



        //Phương thức viết hoa tự động: NGUYỄN anh Dũng => Nguyễn Anh Dũng
        public static string VietHoaFullName(string fullName)
        {
            string temp = fullName.Trim().ToLower();//nguyễn anh dũng
            string[] arrValues = temp.Split(' ');// Cắt chuỗi thành mảng
            string final = "";
            for (int i = 0; i < arrValues.Length; i++)
            {
                final += GetVietHoaChuCaiDau(arrValues[i]);
            }
            return final;//Nguyễn Anh Dũng
        }

        //Lấy được chữ cái đầu dũng => d
        private static string GetChuCaiDau(string value)//Dũng =>d
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]);//D
        }

        //Viết hoa cái chữ cái đầu: hà => Hà
        public static string GetVietHoaChuCaiDau(string value)//hà
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1) + " ";//Hà_ dấu cách
        }

        //Loại bỏ toàn bộ dấu trong tiếng việt
        private static string LoaiBoDauTiengViet(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
    }
}
