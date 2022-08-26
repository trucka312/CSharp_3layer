using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang
    {
        public string makh { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        
        public khachhang() { }
        public khachhang(string mkh, string ht, DateTime ns)
        {
            this.makh = mkh;
            this.hoten = ht;
            this.ngaysinh = ns;
        }
    }
}
