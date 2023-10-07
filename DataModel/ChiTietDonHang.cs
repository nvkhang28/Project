using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    class ChiTietDonHang
    {
        public int IDChiTietDonHang { get; set; }
        public int IDSanPham { get; set; }
        public int IDDonHang { get; set; }
        public float GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public float TongTien { get; set; }

    }
}
