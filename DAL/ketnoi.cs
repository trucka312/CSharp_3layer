using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ketnoi
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IITVQH3;Initial Catalog=QLKD;Integrated Security=True");

        public DataTable Load_Table(string sql)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void Excecute(string sql)
        {
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            SqlCommand Thuchienlenh = new SqlCommand(sql, con);
            Thuchienlenh.ExecuteNonQuery();
            con.Close();
        }
    }
}
