using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_khachhang
    {
        DAL_khachhang KhachHang= new DAL_khachhang();

        public void Insert(khachhang s)
        {
            KhachHang.Insert(s);
        }

        public void Update(khachhang s)
        {
            KhachHang.Update(s);
        }

        public void Delete(khachhang s)
        {
            KhachHang.Delete(s);
        }

        public DataTable Load()
        {
            return KhachHang.Load();
        }
    }
}
