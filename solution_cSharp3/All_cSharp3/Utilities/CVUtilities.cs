using System;
using System.Collections.Generic;
using System.Text;

namespace All_cSharp3.Utilities
{
    public class CVUtilities
    {
        public string GetChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]);
        }

        public string VietHoaChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1) + " ";
        }

        public string VietHoaFullName(string value)
        {
            string temp=value.Trim().ToLower();
            string[]arr=temp.Split(' ');
            string all = "";
            for(int i = 0; i < arr.Length; i++)
            {
                all += VietHoaChuCaiDau(arr[i]);
            }return all;
        }

        public string GenMaTuDong(string value)
        {
            string temp = value.Trim().ToLower();
            string[] arr = temp.Split(' ');
            string all = VietHoaChuCaiDau(arr[arr.Length - 1]);
            for(int i=0; i < arr.Length-1; i++)
            {
                all += GetChuCaiDau(arr[i]);
            }return all;
        }
    }
}
