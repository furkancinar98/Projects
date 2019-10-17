using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestSınavıOtomasyonu
{
    class DatabaseClass
    {
        ConnectionClass conn = new ConnectionClass();
       
        
        
      //  SqlConnection connection = new SqlConnection(@"Data Source=PC-FURKAN\MSSQLSERVER02;Initial Catalog=TestSınavıDegerlendirme;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
       
        public void login(object ad,object parola)
        {
            conn.baglanti();
            command = new SqlCommand("select * from Kullanicilar where  kullanici_adi='" + ad + "' and sifre = '" + parola + "'",conn);
         //   connection.Open();
            
            reader = command.ExecuteReader();
            if (reader.Read())        
            MessageBox.Show("Hoşgeldiniz");
       
            else
           MessageBox.Show("Hatalı Giriş","Error",MessageBoxButtons.OK);

        //    connection.Close();

            
            
        
        }
    }
}
