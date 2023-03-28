using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigData.Operasyon
{
    public class DataAccessLayer : Base.Yardim
    {
        SqlConnection con; // C# ile sql aarasındaki bağlantıyı sağlamak
        SqlCommand cmd; // SqlConnection ile sağlanan bağlantı üzerinden t-sql sorgularımızı sql server a göndermemize ve çalıştırmamıza yarıyor.
        SqlDataReader reader; // Sql tarafından çekmiş olduğumuz datamızı C# tarafında karşıladığımız bir nesnemiz.

        public DataAccessLayer()
        {
            con = new SqlConnection("data source = DESKTOP-I299EIT\\SQLEXPRESS; initial catalog = BuyukDatalarIleCalismak; user Id = sa; password = 123456;");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }

        public int KayitEkle(Entities.Kisi kisi)
        {
            int returnValue = 0; // bu int değişkenini ise ; etkilenen kayıt sayılarını, yani; insert-update-delete işlemlerimde etkilenen kayıt sayılarımı sql tarafından C# tarafına aktarılınca bu değişiklikleri tutabilmek için 
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("KisiEkle", con); // insert yazmaktansa sql de yaptığım procedur u kullanıyorum.
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // proc u kullandığımı burda söylüyorum.
                cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = kisi.Isim;
                cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = kisi.Soyisim;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = kisi.EmailAdres;
                cmd.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = kisi.Tel;
                cmd.Parameters.Add("@Resim", SqlDbType.VarBinary).Value = kisi.Resim;
                BaglantiAyarla();
                returnValue = cmd.ExecuteNonQuery(); // Proc e yazdığım sorguyu sql server a göndereceğim.
                BaglantiAyarla();
            });
            return returnValue;

        }
        public SqlDataReader KisiDetayGetir(int id)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("Select * from Kisiler where Id = @id", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
        public SqlDataReader KisilerListe()
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("Select * from Kisiler", con);
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
    }
}
