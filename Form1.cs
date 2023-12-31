﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RİVERTRASLATEJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T1738DH\\SQLEXPRESS01;Initial Catalog=RİVERLANGUAGE;Integrated Security=True");

        void lnglist()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbllang",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbllang(keystr,trtr,enen,dede,ıtıt,arar,frfr,flfl,grgr,azaz) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",con);
            cmd.Parameters.AddWithValue("@p1",txtkey.Text);
            cmd.Parameters.AddWithValue("@p2","");
            cmd.Parameters.AddWithValue("@p3",txtvalue.Text);
            cmd.Parameters.AddWithValue("@p4", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p5", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p6", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p7", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p8", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p9", txtvalue.Text);
            cmd.Parameters.AddWithValue("@p10", txtvalue.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            lnglist();
            MessageBox.Show("ekleme yapıldı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lnglist();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbllang set keystr=@p1,trtr=@p2,enen=@p3,dede=@p4,ıtıt=@p5,frfr=@p6,arar=@p7,grgr=@p8,azaz=@p9,flfl=@p10 where keystr=@keystr", con);
            cmd.Parameters.AddWithValue("@p1", txtkey.Text);
            cmd.Parameters.AddWithValue("@p2", txtkey.Text);
            cmd.Parameters.AddWithValue("@p3", txtkey.Text);
            cmd.Parameters.AddWithValue("@p4", txtkey.Text);
            cmd.Parameters.AddWithValue("@p5", txtkey.Text);
            cmd.Parameters.AddWithValue("@p6", txtkey.Text);
            cmd.Parameters.AddWithValue("@p7", txtkey.Text);
            cmd.Parameters.AddWithValue("@p8", txtkey.Text);
            cmd.Parameters.AddWithValue("@p9", txtkey.Text);
            cmd.Parameters.AddWithValue("@p10", txtkey.Text);
            cmd.Parameters.AddWithValue("@keystr", txtkey.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            lnglist();
            MessageBox.Show("Güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM WHERE KEYSTR=@KEYSTR", con);
            //cmd.Parameters.AddWithValue("@KEYSTR", txtsearch.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dataGridView1.DataSource = dt;
            //con.Close();
            //MessageBox.Show("BULUNDU", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand VeriSil = new SqlCommand("Delete from tbllang where keystr=@keystr", con);
            VeriSil.Parameters.AddWithValue("@keystr", txtkey.Text);
            VeriSil.ExecuteNonQuery();
            con.Close();
            lnglist();
            MessageBox.Show("Veri silindi");
        }
    }
}
