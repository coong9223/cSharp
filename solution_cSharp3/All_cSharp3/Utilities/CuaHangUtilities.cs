using System;
using System.Collections.Generic;
using System.Text;

namespace All_cSharp3.Utilities
{
    public class CuaHangUtilities
    {
        public static string GetChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]);
        }

        public static string VietHoaChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1) + " ";
        }

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

        public static string VietHoaTuDong(string fullName)
        {
            string temp = fullName.Trim().ToLower();//fullName viết thường hết: nguyễn thành công
            string[]arr=temp.Split(' ');//cắt chuỗi temp thành các mảng theo dấu " ";
            string value = "";
            for(int i=0; i<arr.Length; i++)
            {
                value += VietHoaChuCaiDau(arr[i]);
            }return value;
        }

        public static string GenMaAuTo(string fullName)
        {
            string temp = fullName.Trim().ToLower();
            string[] arr = temp.Split(' ');
            string value = VietHoaChuCaiDau(arr[arr.Length-1]).Trim();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                value += GetChuCaiDau(arr[i]);
            }return value;
        }
    }
}
