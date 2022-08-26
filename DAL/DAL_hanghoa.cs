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
    public class DAL_hanghoa : ketnoi
    {
        public DataTable Load()
        {
            return Load_Table("select * from hanghoa");
        }

        public void Insert(hanghoa s)
        {
            string sql = "INSERT INTO HANGHOA VALUES ('" + s.mahang + "','" + s.tenhang + "','" + s.chungloai + "','" + s.dongia + "','" + s.soluong + "')";
            Excecute(sql);
        }

        public void Update(hanghoa s)
        {
            string sql = "UPDATE HANGHOA SET chungloai='" + s.chungloai + "',tenhang='" + s.tenhang + "',dongia='" + s.dongia + "',soluong='" + s.soluong + "' where mahang='" + s.mahang + "'";
            Excecute(sql);
        }

        public void Delete(hanghoa s)
        {
            string sql = "DELETE from hanghoa WHERE mahang='" + s.mahang + "'";
            Excecute(sql);
        }

    }
}
