namespace RİVERTRASLATEJSON
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.KEYLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txten = new System.Windows.Forms.TextBox();
            this.txtfl = new System.Windows.Forms.TextBox();
            this.txtgr = new System.Windows.Forms.TextBox();
            this.txtfr = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.txtaz = new System.Windows.Forms.TextBox();
            this.txtar = new System.Windows.Forms.TextBox();
            this.txtıt = new System.Windows.Forms.TextBox();
            this.btnjson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnjson);
            this.groupBox1.Controls.Add(this.txtıt);
            this.groupBox1.Controls.Add(this.txtar);
            this.groupBox1.Controls.Add(this.txtaz);
            this.groupBox1.Controls.Add(this.txtde);
            this.groupBox1.Controls.Add(this.txtfr);
            this.groupBox1.Controls.Add(this.txten);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtfl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtgr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtkey);
            this.groupBox1.Controls.Add(this.txtvalue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.KEYLBL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data İnput";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // KEYLBL
            // 
            this.KEYLBL.AutoSize = true;
            this.KEYLBL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KEYLBL.Location = new System.Drawing.Point(16, 45);
            this.KEYLBL.Name = "KEYLBL";
            this.KEYLBL.Size = new System.Drawing.Size(46, 24);
            this.KEYLBL.TabIndex = 0;
            this.KEYLBL.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish";
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(411, 44);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(164, 27);
            this.txtvalue.TabIndex = 2;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(119, 45);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(126, 27);
            this.txtkey.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsave.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(37, 377);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 38);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "EKLE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnupdate.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(169, 377);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 38);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "GÜNCELLE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(297, 377);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 38);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "SİL";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(630, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 415);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(639, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "LİST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1117, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(863, 435);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(234, 33);
            this.txtsearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Englısh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "German";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Italian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "French";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Arabic";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Georgia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Azerbaijani";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dutch";
            // 
            // txten
            // 
            this.txten.Location = new System.Drawing.Point(119, 101);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(126, 27);
            this.txten.TabIndex = 15;
            // 
            // txtfl
            // 
            this.txtfl.Location = new System.Drawing.Point(411, 259);
            this.txtfl.Name = "txtfl";
            this.txtfl.Size = new System.Drawing.Size(164, 27);
            this.txtfl.TabIndex = 16;
            // 
            // txtgr
            // 
            this.txtgr.Location = new System.Drawing.Point(411, 207);
            this.txtgr.Name = "txtgr";
            this.txtgr.Size = new System.Drawing.Size(164, 27);
            this.txtgr.TabIndex = 17;
            // 
            // txtfr
            // 
            this.txtfr.Location = new System.Drawing.Point(411, 153);
            this.txtfr.Name = "txtfr";
            this.txtfr.Size = new System.Drawing.Size(164, 27);
            this.txtfr.TabIndex = 18;
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(411, 102);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(164, 27);
            this.txtde.TabIndex = 19;
            // 
            // txtaz
            // 
            this.txtaz.Location = new System.Drawing.Point(119, 256);
            this.txtaz.Name = "txtaz";
            this.txtaz.Size = new System.Drawing.Size(126, 27);
            this.txtaz.TabIndex = 20;
            // 
            // txtar
            // 
            this.txtar.Location = new System.Drawing.Point(119, 204);
            this.txtar.Name = "txtar";
            this.txtar.Size = new System.Drawing.Size(126, 27);
            this.txtar.TabIndex = 21;
            // 
            // txtıt
            // 
            this.txtıt.Location = new System.Drawing.Point(119, 156);
            this.txtıt.Name = "txtıt";
            this.txtıt.Size = new System.Drawing.Size(126, 27);
            this.txtıt.TabIndex = 22;
            // 
            // btnjson
            // 
            this.btnjson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnjson.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnjson.Location = new System.Drawing.Point(418, 377);
            this.btnjson.Name = "btnjson";
            this.btnjson.Size = new System.Drawing.Size(115, 38);
            this.btnjson.TabIndex = 23;
            this.btnjson.Text = "JSON";
            this.btnjson.UseVisualStyleBackColor = false;
            this.btnjson.Click += new System.EventHandler(this.btnjson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1345, 572);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KEYLBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtıt;
        private System.Windows.Forms.TextBox txtar;
        private System.Windows.Forms.TextBox txtaz;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.TextBox txtfr;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.TextBox txtfl;
        private System.Windows.Forms.TextBox txtgr;
        private System.Windows.Forms.Button btnjson;
    }
}

