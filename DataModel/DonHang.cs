using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    class DonHang
    {
        public int IDDonHang { get; set; }
        public int IDKhachHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public float Pay { get; set; }
    }
}
