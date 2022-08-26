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
    public class BUS_hoadon
    {
        DAL_hoadon HoaDon = new DAL_hoadon();

        public void Insert(hoadon s)
        {
            HoaDon.Insert(s);
        }

        public void Update(hoadon s)
        {
            HoaDon.Update(s);
        }

        public void Delete(hoadon s)
        {
            HoaDon.Delete(s);
        }

        public DataTable Load()
        {
            return HoaDon.Load();
        }
    }
}
