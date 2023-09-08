using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RİVERTRASLATEJSON
{
    public partial class RIVER : Form
    {

        string[] array = new string[] { "TR","EN","DE","IT","FR","AR","GR","AZ","FL"};
    
        public RIVER()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //sql con kullanılarak veri tabanı bağlantısı yapılmıştır
        //sql commmand builder,adappter ve datatable global olarak tanımlanarak datagridview üzerinden işlem yapılmıştır,global olarak tanımlamamızın sebebi belirli bir metoda bağlı olunmadan datagridview üzerinden crud işlemlerinin rahatlıkla yapılabilmesini sağlamaktır.

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T1738DH\\SQLEXPRESS01;Initial Catalog=RİVERLANGUAGE;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adapter;
        DataTable tbl = new DataTable();

        //datatable türünde getlist metodu tanımlanarak database de bulunan verilerin table türünde listelenmesini sağlamaktır.
        //adapter nesnesi veri tabanına veri kaydetmek için kullanılmaktadır
        //adapter.fill() metodu database verilerini tanımladığımız tabloya doldurmaya yarar.
        
        DataTable getlist()
        {
            adapter = new SqlDataAdapter("select * from testtbl", con);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
        }

        
        
        private void btnsave_Click(object sender, EventArgs e)
        {

            //commandbuilder bizim için crud işlemlerini hazırlar ve adapter nesnesi ile ilişkilendirir.

            try
            {
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(tbl);
                MessageBox.Show("İşlem yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hata Kodu: " + ex.Number + "\nHata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try catch bloğu kullanılarak hata alındığında catch içerisinde hata mesajı ve hata kodu birlikte fırlatılmaktadır.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lnglist();
            getlist();
            //list butonu ile ilişkilendirilerek buton listeleme yapabilmek için işlevsel hale getirilmiştir.
        }

        private void button2_Click(object sender, EventArgs e)
        {

                //search butonunun metodudur sqlcommand ile sql komutlarımız sayesinde tablonun içinde bulunan keystr ile parametre olan keystr eşleşmesi durumunda ekranda o veri dönmektedir.
                con.Open();
            
                SqlCommand cmd = new SqlCommand("SELECT * FROM testtbl WHERE KEYSTR=@KEYSTR", con);
                cmd.Parameters.AddWithValue("@KEYSTR", txtsearch.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Kayıt Bulundu", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                con.Close();
                //getlist();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand VeriSil = new SqlCommand("Delete from tbllang2 where keystr=@keystr", con);
            //VeriSil.Parameters.AddWithValue("@keystr", txtkey.Text);
            //VeriSil.ExecuteNonQuery();
            //con.Close();
            ////lnglist();
            //MessageBox.Show("Veri silindi");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //json türünde verileri kayıt edebilmek için her dil için ayrı bir model oluşturulmuştur.Liste türünde nesneler tanımlanarak liste paramtresi için 
        //dil modellerimiz kullanılmıştır.listeler yardımıyla belirlenen dil öğeleri liste türünde tutulmuştur.
        //sqldatareader nesnesi yardımıyla satır satır okuma işlemi yapımıştır.datareader nesnesinin sağlıklı çalışabilmesi için veritabanı bağlantısı açık kalmalıdır.
        private void btnjson_Click(object sender, EventArgs e)
        {
        
            con.Open();

            
            //sqlcommand sayesinde veritabanına gerekli komut iletilerek veri çağrılması işlemi gerçekleştirilmiştir.
            //bir veya birden fazla satır dönüleceği zaman sqlcommandın executereader metodu kullanılarak datareader türünde veri dönülmesi sağlanmaktadır.
            SqlCommand cmd = new SqlCommand("SELECT * FROM testtbl", con);
            SqlDataReader reader = cmd.ExecuteReader();

            //Jobject kullanılarak istenilen json formatına geçiş sağlanmıştır jobject nesnelerini oluşturduk.
            JObject jsonObjecttr = new JObject();
            JObject jsonObjecten = new JObject();
            JObject jsonObjectde = new JObject();
            JObject jsonObjectıt = new JObject();
            JObject jsonObjectfr = new JObject();
            JObject jsonObjectar = new JObject();
            JObject jsonObjectgr = new JObject();
            JObject jsonObjectaz = new JObject();
            JObject jsonObjectfl = new JObject();
            
            
            JObject jsonObjecttrtr = new JObject();
            JObject jsonObjectenen = new JObject();
            JObject jsonObjectdede = new JObject();
            JObject jsonObjectıtıt = new JObject();
            JObject jsonObjectfrfr = new JObject();
            JObject jsonObjectarar = new JObject();
            JObject jsonObjectgrgr = new JObject();
            JObject jsonObjectazaz = new JObject();
            JObject jsonObjectflfl = new JObject();

            //oluşturğumuz nesnenin içerisine lang:tr şeklinde eklememizi yaptık
            jsonObjecttr.Add("LANG", "TR");
            jsonObjecten.Add("LANG", "EN");
            jsonObjectde.Add("LANG", "DE");
            jsonObjectıt.Add("LANG", "IT");
            jsonObjectfr.Add("LANG", "FR");
            jsonObjectar.Add("LANG", "AR");
            jsonObjectgr.Add("LANG", "GR");
            jsonObjectaz.Add("LANG", "AZ");
            jsonObjectfl.Add("LANG", "FL");
            //whle metodu koşul true olduğu sürece işleme devam edecektir.reader.read metodu kullanılarak while döngüsünün içinde bulunan koşul sağlandığı müddetçe işlem sürekli tekrar edecektir.
            while (reader.Read())
            { 
                //jsonobjectler oluşturularak içeriğine reader ile okuduğumuz keystr ve value değerlerini tostring metoduyla stringe dönüştürdük.
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft. Json.JsonSerializer();
          
                jsonObjecttrtr.Add(reader["keystr"].ToString(), reader["trtr"].ToString());
                jsonObjectenen.Add(reader["keystr"].ToString(), reader["enen"].ToString());
                jsonObjectdede.Add(reader["keystr"].ToString(), reader["dede"].ToString());
                jsonObjectıtıt.Add(reader["keystr"].ToString(), reader["ıtıt"].ToString());
                jsonObjectfrfr.Add(reader["keystr"].ToString(), reader["frfr"].ToString());
                jsonObjectarar.Add(reader["keystr"].ToString(), reader["arar"].ToString());
                jsonObjectgrgr.Add(reader["keystr"].ToString(), reader["grgr"].ToString());
                jsonObjectazaz.Add(reader["keystr"].ToString(), reader["azaz"].ToString());
                jsonObjectflfl.Add(reader["keystr"].ToString(), reader["flfl"].ToString());

                //okunan veriler dilleri liste türünde tuttuğumuz yerlere eklenmiştir.
                //tr.Add(datatr)
                //languageDataListen.Add(dataen);

            }
            //ilk başta oluşturduğumuz jobject nesnesinin içeriğine data keyi ekleyerek ve aynı zamanda sonradan oluşturduğumuz jObject nesnelerini kullandık.
            //sonradan oluşturulan jobject'ler verilerin doldurulacağı jobjectlerdir.
            jsonObjecttr.Add("data", jsonObjecttrtr);
            jsonObjecten.Add("data", jsonObjectenen);
            jsonObjectde.Add("data", jsonObjectdede);
            jsonObjectıt.Add("data", jsonObjectıtıt);
            jsonObjectfr.Add("data", jsonObjectfrfr);
            jsonObjectar.Add("data", jsonObjectarar);
            jsonObjectgr.Add("data", jsonObjectgrgr);
            jsonObjectaz.Add("data", jsonObjectazaz);
            jsonObjectfl.Add("data", jsonObjectflfl);

          
            con.Close();

            //okunup listelerde tuttuğumuz veriler newtonsoft.json kütüphanesi yardımıyla json formatına dönüştürülerek kaydedilmiştir.
            //JSON verisini dosyaya kaydet
            string json = JsonConvert.SerializeObject(jsonObjecttr, Formatting.Indented);
            string json1 = JsonConvert.SerializeObject(jsonObjecten, Formatting.Indented);
            string json2 = JsonConvert.SerializeObject(jsonObjectde, Formatting.Indented);
            string json3 = JsonConvert.SerializeObject(jsonObjectar, Formatting.Indented);
            string json4 = JsonConvert.SerializeObject(jsonObjectaz, Formatting.Indented);
            string json5 = JsonConvert.SerializeObject(jsonObjectıt, Formatting.Indented);
            string json6 = JsonConvert.SerializeObject(jsonObjectgr, Formatting.Indented);
            string json7 = JsonConvert.SerializeObject(jsonObjectfl, Formatting.Indented);
            string json8 = JsonConvert.SerializeObject(jsonObjectfr, Formatting.Indented);

            //var x;
            // StringBuilder sb;
            // sb.Append(F);
            //string z = $"{D}"
            //JArray jArray = JArray.Parse(json1);

            //stringbuilder sınıfı string birleştirme yapmaktadır.+ operatörüyle aynı işleve sahiptir tek farkı performans açısından stringbuilder kullanılması daha avantajlıdır

            //enen enen = new enen();
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(enen.Key + ":" + enen.English);

            //listede tutup sonrasında json formatına dönüştürdüğümüz veriler belirttiğimiz json dosyalarına yazılmıştır.
            File.WriteAllText("tr.json", json);
            File.WriteAllText("en.json", json1);
            File.WriteAllText("de.json", json2);
            File.WriteAllText("ar.json", json3);
            File.WriteAllText("az.json", json4);
            File.WriteAllText("ıt.json", json5);
            File.WriteAllText("gr.json", json6);
            File.WriteAllText("flfl.json", json7);
            File.WriteAllText("fr.json", json8);

            MessageBox.Show("Veri JSON dosyasına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
        //clear metodu kullanılarak tablodaki verilerin temizlenmesi sağlanmıştır.
        private void button3_Click(object sender, EventArgs e)
        {
            tbl.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        //    string keystrToUpdate = txtsearch.Text; 
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("update testtbl set keystr=@p1,trtr=@p2,enen=@p3,dede=@p4,ıtıt=@p5,frfr=@p6,arar=@p7,grgr=@p8,azaz=@p9,flfl=@p10 where keystr=@keystr", con);
        //    cmd.Parameters.AddWithValue("@p1", keystrToUpdate); 
        //    cmd.Parameters.AddWithValue("@p2", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p3", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p4", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p5", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p6", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p7", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p8", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p9", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@p10", txtsearch.Text);
        //    cmd.Parameters.AddWithValue("@keystr", keystrToUpdate); 
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }
    }
}



    




