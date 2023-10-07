using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    class SanPham
    {
        public int IDSanPham { get; set; }
        public string TenSanPham { get; set; }
        public float GiaSanPham { get; set; }
        public string HinhAnh { get; set; }
        public int IDDanhMuc { get; set; }
        public int IDNhaCungCap { get; set; }

    }
}
