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
    public class BUS_hanghoa
    {
        DAL_hanghoa HangHoa = new DAL_hanghoa();

        public void Insert(hanghoa s)
        {
            HangHoa.Insert(s);
        }

        public void Update(hanghoa s)
        {
            HangHoa.Update(s);
        }

        public void Delete(hanghoa s)
        {
            HangHoa.Delete(s);
        }

        public DataTable Load()
        {
            return HangHoa.Load();
        }
    }
}
