using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2_cSharp2
{
    internal class MayTinh
    {
        private string Id;
        private string Name;
        private float TrongLuong;

        public MayTinh()
        {
        }

        public MayTinh(string id, string name, float trongLuong)
        {
            Id1 = id;
            Name1 = name;
            TrongLuong1 = trongLuong;
        }

        public string Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public float TrongLuong1 { get => TrongLuong; set => TrongLuong = value; }

        public void InThongTin()
        {
            Console.WriteLine($"id: {Id1},name: {Name1},trọng lượng: {TrongLuong}");
        }
    }
}
