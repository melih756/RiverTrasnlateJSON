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


        public RIVER()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T1738DH\\SQLEXPRESS01;Initial Catalog=RİVERLANGUAGE;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adapter;
        DataTable tbl = new DataTable();

        DataTable getlist()
        {
            adapter = new SqlDataAdapter("select * from testtbl", con);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
           
        }
        //void lnglist()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("select * from tbllang1", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}
        private void btnsave_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into tbllang2(keystr,trtr,enen,dede,ıtıt,arar,frfr,flfl,grgr,azaz) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", con);
            //cmd.Parameters.AddWithValue("@p1", txtkey.Text);
            //cmd.Parameters.AddWithValue("@p2", txtvalue.Text);
            //cmd.Parameters.AddWithValue("@p3", txten.Text);
            //cmd.Parameters.AddWithValue("@p4", txtde.Text);
            //cmd.Parameters.AddWithValue("@p5", txtıt.Text);
            //cmd.Parameters.AddWithValue("@p6", txtar.Text);
            //cmd.Parameters.AddWithValue("@p7", txtfr.Text);
            //cmd.Parameters.AddWithValue("@p8", txtfl.Text);
            //cmd.Parameters.AddWithValue("@p9", txtgr.Text);
            //cmd.Parameters.AddWithValue("@p10", txtaz.Text);

            ////StreamWriter sw = new StreamWriter("dosya.txt");
            ////sw.WriteLine(txtkey.Text + ":" + txtvalue.Text);
            ////sw.Close();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //lnglist();
            //SqlCommand cmd = new SqlCommand("select * from tbllangs where keystr=@keystr");
      


            try
            {
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(tbl);
                MessageBox.Show("Ekleme yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("update tbllang2 set keystr=@p1,trtr=@p2,enen=@p3,dede=@p4,ıtıt=@p5,frfr=@p6,arar=@p7,grgr=@p8,azaz=@p9,flfl=@p10 where keystr=@keystr", con);
            //cmd.Parameters.AddWithValue("@p1", txtkey.Text);
            //cmd.Parameters.AddWithValue("@p2", txtvalue.Text);
            //cmd.Parameters.AddWithValue("@p3", txten.Text);
            //cmd.Parameters.AddWithValue("@p4", txtde.Text);
            //cmd.Parameters.AddWithValue("@p5", txtıt.Text);
            //cmd.Parameters.AddWithValue("@p6", txtfr.Text);
            //cmd.Parameters.AddWithValue("@p7", txtar.Text);
            //cmd.Parameters.AddWithValue("@p8", txtgr.Text);
            //cmd.Parameters.AddWithValue("@p9", txtaz.Text);
            //cmd.Parameters.AddWithValue("@p10", txtfl.Text);
            //cmd.Parameters.AddWithValue("@keystr", txtkey.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
            ////lnglist();
            //MessageBox.Show("Güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void btnjson_Click(object sender, EventArgs e)
        {
            List<trtr> tr = new List<trtr>();
            List<enen> languageDataListen = new List<enen>();
            List<de> languageDataListde = new List<de>();
            List<ıtıt> languageDataListıt = new List<ıtıt>();
            List<grgr> languageDataListgr = new List<grgr>();
            List<frfr> languageDataListfr = new List<frfr>();
            List<flfl> languageDataListfl = new List<flfl>();
            List<azaz> languageDataListaz = new List<azaz>();
            List<arar> languageDataListar = new List<arar>();
            con.Open();


            //supportlangs = ["TR",]
            SqlCommand cmd = new SqlCommand("SELECT * FROM testtbl", con);
            SqlDataReader reader = cmd.ExecuteReader();

            JObject _item;

            while (reader.Read())
            {
                trtr datatr = new trtr
                {
                    Key = reader["keystr"].ToString(),
                    Turkish = reader["trtr"].ToString(),

                };
                //string name = (string)jObject["keystr"]["enen"];
                enen dataen = new enen
                {

                    Key = reader["keystr"].ToString(),
                    English = reader["enen"].ToString(),
                };
                de datade = new de
                {
                    Key = reader["keystr"].ToString(),
                    German = reader["dede"].ToString(),

                };
                ıtıt dataıt = new ıtıt
                {
                    Key = reader["keystr"].ToString(),
                    Italian = reader["ıtıt"].ToString(),

                };
                frfr datafr = new frfr
                {
                    Key = reader["keystr"].ToString(),
                    French = reader["frfr"].ToString(),

                };
                arar dataar = new arar
                {
                    Key = reader["keystr"].ToString(),
                    Arabic = reader["arar"].ToString(),

                };
                grgr datagr = new grgr
                {
                    Key = reader["keystr"].ToString(),
                    Georgia = reader["grgr"].ToString(),

                };
                azaz dataaz = new azaz
                {
                    Key = reader["keystr"].ToString(),
                    Azerbajani = reader["azaz"].ToString(),
                };
                flfl datafl = new flfl
                {
                    Key = reader["keystr"].ToString(),
                    Dutch = reader["flfl"].ToString()
                };

                tr.Add(datatr);
                languageDataListen.Add(dataen);
                languageDataListde.Add(datade);
                languageDataListaz.Add(dataaz);
                languageDataListfr.Add(datafr);
                languageDataListgr.Add(datagr);
                languageDataListar.Add(dataar);
                languageDataListfl.Add(datafl);

            }

            con.Close();

            //JSON verisini dosyaya kaydet
            string json = JsonConvert.SerializeObject(tr, Formatting.Indented);
            string json1 = JsonConvert.SerializeObject(languageDataListen, Formatting.Indented);
            string json2 = JsonConvert.SerializeObject(languageDataListde, Formatting.Indented);
            string json3 = JsonConvert.SerializeObject(languageDataListar, Formatting.Indented);
            string json4 = JsonConvert.SerializeObject(languageDataListaz, Formatting.Indented);
            string json5 = JsonConvert.SerializeObject(languageDataListıt, Formatting.Indented);

            File.WriteAllText("tr.json", json);
            File.WriteAllText("az.json", json4);
            File.WriteAllText("en.json", json1);
            File.WriteAllText("de.json", json2);

            MessageBox.Show("Veri JSON dosyasına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void button3_Click(object sender, EventArgs e, string @string)
        //{
        //    List<trtr> tr = new List<trtr>();
        //    List<enen> languageDataListen = new List<enen>();
        //    List<de> languageDataListde = new List<de>();
        //    List<ıtıt> languageDataListıt = new List<ıtıt>();
        //    List<grgr> languageDataListgr = new List<grgr>();
        //    List<frfr> languageDataListfr = new List<frfr>();
        //    List<flfl> languageDataListfl = new List<flfl>();
        //    List<azaz> languageDataListaz = new List<azaz>();
        //    List<arar> languageDataListar = new List<arar>();

        //    //supportlangs = ["TR",]
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM TBLLANG2", con);
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        trtr datatr = new trtr
        //        {
        //            Key = reader["keystr"].ToString(),
        //            Turkish = reader["trtr"].ToString(),

        //        };
        //        //string name = (string)jObject["keystr"]["enen"];

        //        enen dataen = new enen
        //        {

        //            Key = reader["keystr"].ToString(),
        //            English = reader["enen"].ToString(),

        //        };
        //        de datade = new de
        //        {
        //            Key = reader["keystr"].ToString(),
        //            German = reader["dede"].ToString(),

        //        };
        //        ıtıt dataıt = new ıtıt
        //        {
        //            Key = reader["keystr"].ToString(),
        //            Italian = reader["ıtıt"].ToString(),


        //        };
        //        frfr datafr = new frfr
        //        {
        //            Key = reader["keystr"].ToString(),
        //            French = reader["frfr"].ToString(),


        //        };
        //        arar dataar = new arar
        //        {
        //            Key = reader["keystr"].ToString(),
        //            Arabic = reader["arar"].ToString(),

        //        };
        //        grgr datagr = new grgr
        //        {
        //            Key = reader["keystr"].ToString(),
        //            Georgia = reader["grgr"].ToString(),

        //        };
        //        azaz dataaz = new azaz
        //        {
        //            Key = reader["keystr"].ToString(),
        //            Azerbajani = reader["azaz"].ToString(),
        //        };

        //        tr.Add(datatr);
        //        languageDataListen.Add(dataen);
        //        languageDataListde.Add(datade);
        //        languageDataListaz.Add(dataaz);
        //        languageDataListfr.Add(datafr);
        //        languageDataListgr.Add(datagr);
        //        languageDataListar.Add(dataar);

        //    }

        //    con.Close();

        //    //JSON verisini dosyaya kaydet
        //    string json = JsonConvert.SerializeObject(tr, Formatting.Indented);
        //    string json1 = JsonConvert.SerializeObject(languageDataListen, Formatting.Indented);
        //    string json2 = JsonConvert.SerializeObject(languageDataListde, Formatting.Indented);
        //    string json3 = JsonConvert.SerializeObject(languageDataListar, Formatting.Indented);
        //    string json4 = JsonConvert.SerializeObject(languageDataListaz, Formatting.Indented);
        //    string json5 = JsonConvert.SerializeObject(languageDataListıt, Formatting.Indented);

        //    File.WriteAllText("tr.json", json);
        //    File.WriteAllText("az.json", json4);
        //    File.WriteAllText("en.json", json1);
        //    File.WriteAllText("de.json", json2);

        //    MessageBox.Show("Veri JSON dosyasına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbl.Clear();
        }
    }
}



    




