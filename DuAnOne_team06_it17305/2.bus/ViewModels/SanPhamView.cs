﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.dal.Table;

namespace _2.bus.ViewModels
{
    public class SanPhamView
    {
        public SanPham sp { get; set; }
        public LoaiSp lsp { get; set; }
        public Guid id { get; set; }
        public Guid idLsp { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public decimal giaBan { get; set; }

        public string maLsp { get; set; }
        public string tenLsp { get; set; }
    }
}
