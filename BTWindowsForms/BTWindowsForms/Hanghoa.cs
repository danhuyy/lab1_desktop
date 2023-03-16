using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsForms
{
    internal class Hanghoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public Hanghoa()
        {

        }
        public string Hienthi()
        {
            return string.Format("{0},{1},{2},{3},{4},", MaHang, TenHang, DVT, SoLuong, DonGia);

        }
    }
}
