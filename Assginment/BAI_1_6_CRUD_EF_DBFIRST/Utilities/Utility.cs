using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Utilities
{
    public class Utility
    {
        public static string GenMaTuDong(string s)
        {
            string temp = s.Trim().ToLower();
            string[] arr = temp.Split(' ');
            string result = VietHoaChuCaiDau(arr[arr.Length - 1]).Trim();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                result += LayChuCaiDau(arr[i]);
            }
            return LoaiBoDauTiengViet(result);
        }
        public static string GenMa2(string s)
        {
            string temp = s.Trim().ToLower();
            string[] arr = temp.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += LayChuCaiDau(VietHoaChuCaiDau(arr[i]));
            }
            return LoaiBoDauTiengViet(result).Trim();
        }
        public static string VietHoaFullName(string s)
        {
            string temp = s.Trim().ToLower();
            string[] arr = temp.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += VietHoaChuCaiDau(arr[i]);
            }
            return result;
        }
        public static string LayChuCaiDau(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return Convert.ToString(s[0]);
        }
        public static string VietHoaChuCaiDau(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return Convert.ToString(s[0]).ToUpper() + s.Substring(1) + " ";
        }
        public static string LoaiBoDauTiengViet(string s)
        {
            string sFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(sFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark) sb.Append(sFormD[i]);
            }
            sb.Replace('Đ', 'D'); sb.Replace('đ', 'd');
            return sb.ToString().Normalize(NormalizationForm.FormD);
        }
    }
}
