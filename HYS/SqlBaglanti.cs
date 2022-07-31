using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HYS
{
    class SqlBaglanti
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-5627S7J;Initial Catalog=HastaneYönetimSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}
