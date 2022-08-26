using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_hoadon : ketnoi
    {
        public DataTable Load()
        {
            return Load_Table("select * from hoadon");
        }

        public void Insert(hoadon s)
        {
            string sql = "INSERT INTO hoadon VALUES ('" + s.mahd + "','" + s.ngaymua + "','" + s.makh + "','" + s.mahang + "','" + s.soluong + "')";
            Excecute(sql);
        }

        public void Update(hoadon s)
        {
            string sql = "UPDATE hoadon SET ngaymua='" + s.ngaymua + "',makh='" + s.makh + "',mahang='" + s.mahang + "',soluong='" + s.soluong + "' where mahd='" + s.mahd + "'";
            Excecute(sql);
        }

        public void Delete(hoadon s)
        {
            string sql = "DELETE from hoadon WHERE mahd='" + s.mahd + "'";
            Excecute(sql);
        }
    }
}
