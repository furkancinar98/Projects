using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestSınavıOtomasyonu
{
    class ConnectionClass
    {
        public void baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=PC-FURKAN\MSSQLSERVER02;Initial Catalog=TestSınavıDegerlendirme;Integrated Security=True");
            baglanti.Open();
        }
       
    }
}
