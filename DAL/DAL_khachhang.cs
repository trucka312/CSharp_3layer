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
    public class DAL_khachhang : ketnoi
    {
        public DataTable Load()
        {
            return Load_Table("select * from khachhang");
        }

        public void Insert(khachhang s)
        {
            string sql = "INSERT INTO khachhang VALUES ('" + s.makh + "','" + s.hoten + "','" + s.ngaysinh + "')";
            Excecute(sql);
        }

        public void Update(khachhang s)
        {
            string sql = "UPDATE khachhang SET hoten='" + s.hoten + "',ngaysinh='" + s.ngaysinh + "' where makh='" + s.makh + "'";
            Excecute(sql);
        }

        public void Delete(khachhang s)
        {
            string sql = "DELETE from khachhang WHERE makh='" + s.makh + "'";
            Excecute(sql);
        }
    }
}
