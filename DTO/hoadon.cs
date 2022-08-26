using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoadon
    {
        public string mahd { get; set; }
        public DateTime ngaymua { get; set; }
        public string makh { get; set; }
        public string mahang { get; set; }
        public int soluong { get; set; }
        public hoadon() { }
        public hoadon(string mhd, DateTime nm, string makh,string mh, int sl)
        {
            this.mahd = mhd;
            this.ngaymua = nm;
            this.makh =makh;
            this.mahang = mh;
            this.soluong = sl;
        }
    }
}
