using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hanghoa
    {
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public string chungloai { get; set; }
        public int dongia { get; set; }
        public int soluong { get; set; }
        public hanghoa() { }
        public hanghoa(string mh,string th,string cl,int dg,int sl)
        {
            this.mahang = mh;
            this.tenhang = th;
            this.chungloai = cl;
            this.dongia = dg;
            this.soluong =sl;
        }
    }
}
