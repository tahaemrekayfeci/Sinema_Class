namespace Sinema_Class
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.btn_bakiye = new System.Windows.Forms.Button();
            this.rdb_indirimliiptal = new System.Windows.Forms.RadioButton();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_satis = new System.Windows.Forms.Button();
            this.rdb_indirimlialis = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_koltukyarat = new System.Windows.Forms.TextBox();
            this.btn_yarat = new System.Windows.Forms.Button();
            this.btn_koltuksorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_yarat);
            this.groupBox1.Controls.Add(this.txt_koltukyarat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Yarat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_satis);
            this.groupBox2.Controls.Add(this.rdb_indirimlialis);
            this.groupBox2.Location = new System.Drawing.Point(188, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Alış";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_iptal);
            this.groupBox3.Controls.Add(this.rdb_indirimliiptal);
            this.groupBox3.Location = new System.Drawing.Point(188, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet İptal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_koltuksorgula);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(364, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 110);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Koltuk Sayısı";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_bakiye);
            this.groupBox5.Controls.Add(this.lbl_bakiye);
            this.groupBox5.Location = new System.Drawing.Point(364, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(170, 110);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bakiye Öğren";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(50, 26);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(61, 13);
            this.lbl_bakiye.TabIndex = 3;
            this.lbl_bakiye.Text = "..................";
            // 
            // btn_bakiye
            // 
            this.btn_bakiye.Location = new System.Drawing.Point(21, 62);
            this.btn_bakiye.Name = "btn_bakiye";
            this.btn_bakiye.Size = new System.Drawing.Size(115, 23);
            this.btn_bakiye.TabIndex = 3;
            this.btn_bakiye.Text = "Bakiye Sorgula";
            this.btn_bakiye.UseVisualStyleBackColor = true;
            this.btn_bakiye.Click += new System.EventHandler(this.btn_bakiye_Click);
            // 
            // rdb_indirimliiptal
            // 
            this.rdb_indirimliiptal.AutoSize = true;
            this.rdb_indirimliiptal.Location = new System.Drawing.Point(54, 26);
            this.rdb_indirimliiptal.Name = "rdb_indirimliiptal";
            this.rdb_indirimliiptal.Size = new System.Drawing.Size(55, 17);
            this.rdb_indirimliiptal.TabIndex = 3;
            this.rdb_indirimliiptal.TabStop = true;
            this.rdb_indirimliiptal.Text = "İndirim";
            this.rdb_indirimliiptal.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(24, 66);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(125, 23);
            this.btn_iptal.TabIndex = 4;
            this.btn_iptal.Text = "Bilet İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(24, 70);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(125, 23);
            this.btn_satis.TabIndex = 6;
            this.btn_satis.Text = "Bilet Satış";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // rdb_indirimlialis
            // 
            this.rdb_indirimlialis.AutoSize = true;
            this.rdb_indirimlialis.Location = new System.Drawing.Point(54, 30);
            this.rdb_indirimlialis.Name = "rdb_indirimlialis";
            this.rdb_indirimlialis.Size = new System.Drawing.Size(55, 17);
            this.rdb_indirimlialis.TabIndex = 5;
            this.rdb_indirimlialis.TabStop = true;
            this.rdb_indirimlialis.Text = "İndirim";
            this.rdb_indirimlialis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Sayısı";
            // 
            // txt_koltukyarat
            // 
            this.txt_koltukyarat.Location = new System.Drawing.Point(32, 90);
            this.txt_koltukyarat.Name = "txt_koltukyarat";
            this.txt_koltukyarat.Size = new System.Drawing.Size(82, 20);
            this.txt_koltukyarat.TabIndex = 5;
            // 
            // btn_yarat
            // 
            this.btn_yarat.Location = new System.Drawing.Point(32, 173);
            this.btn_yarat.Name = "btn_yarat";
            this.btn_yarat.Size = new System.Drawing.Size(125, 23);
            this.btn_yarat.TabIndex = 5;
            this.btn_yarat.Text = "Koltuk Yarat";
            this.btn_yarat.UseVisualStyleBackColor = true;
            this.btn_yarat.Click += new System.EventHandler(this.btn_yarat_Click);
            // 
            // btn_koltuksorgula
            // 
            this.btn_koltuksorgula.Location = new System.Drawing.Point(21, 70);
            this.btn_koltuksorgula.Name = "btn_koltuksorgula";
            this.btn_koltuksorgula.Size = new System.Drawing.Size(115, 23);
            this.btn_koltuksorgula.TabIndex = 4;
            this.btn_koltuksorgula.Text = "Boş Koltuk Sorgula";
            this.btn_koltuksorgula.UseVisualStyleBackColor = true;
            this.btn_koltuksorgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "..................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_yarat;
        private System.Windows.Forms.TextBox txt_koltukyarat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.RadioButton rdb_indirimlialis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.RadioButton rdb_indirimliiptal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_bakiye;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Button btn_koltuksorgula;
        private System.Windows.Forms.Label label2;
    }
}

