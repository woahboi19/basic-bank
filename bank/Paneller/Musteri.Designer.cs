namespace AnilLab.Paneller
{
    partial class Musteri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlGuncelleBilgi = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.pnlHesaplar = new System.Windows.Forms.Panel();
            this.btnYeniHesap = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dgwHesaplar = new System.Windows.Forms.DataGridView();
            this.hesapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlGuncelleBilgi.SuspendLayout();
            this.pnlHesaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.lblBilgi);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 202);
            this.panel1.TabIndex = 0;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(6, 166);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(60, 23);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilgi.Location = new System.Drawing.Point(81, 50);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(152, 152);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Adı\r\ntelefon \r\neposta\r\nadres";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(3, 50);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(75, 68);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Adı Soyadı\r\nTelefon \r\nE-posta\r\nAdres";
            // 
            // pnlGuncelleBilgi
            // 
            this.pnlGuncelleBilgi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlGuncelleBilgi.Controls.Add(this.btnKapat);
            this.pnlGuncelleBilgi.Controls.Add(this.btnGuncelle);
            this.pnlGuncelleBilgi.Controls.Add(this.label1);
            this.pnlGuncelleBilgi.Controls.Add(this.tbSifre);
            this.pnlGuncelleBilgi.Controls.Add(this.tbEposta);
            this.pnlGuncelleBilgi.Controls.Add(this.tbAdres);
            this.pnlGuncelleBilgi.Controls.Add(this.tbTelefon);
            this.pnlGuncelleBilgi.Location = new System.Drawing.Point(12, 220);
            this.pnlGuncelleBilgi.Name = "pnlGuncelleBilgi";
            this.pnlGuncelleBilgi.Size = new System.Drawing.Size(236, 257);
            this.pnlGuncelleBilgi.TabIndex = 1;
            this.pnlGuncelleBilgi.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(201, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(32, 23);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(97, 195);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(97, 144);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(100, 20);
            this.tbSifre.TabIndex = 0;
            // 
            // tbEposta
            // 
            this.tbEposta.Location = new System.Drawing.Point(97, 75);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(100, 20);
            this.tbEposta.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(97, 107);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 0;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(97, 41);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 0;
            // 
            // pnlHesaplar
            // 
            this.pnlHesaplar.Controls.Add(this.btnYeniHesap);
            this.pnlHesaplar.Controls.Add(this.btnYenile);
            this.pnlHesaplar.Controls.Add(this.dgwHesaplar);
            this.pnlHesaplar.Location = new System.Drawing.Point(254, 14);
            this.pnlHesaplar.Name = "pnlHesaplar";
            this.pnlHesaplar.Size = new System.Drawing.Size(506, 463);
            this.pnlHesaplar.TabIndex = 2;
            // 
            // btnYeniHesap
            // 
            this.btnYeniHesap.Location = new System.Drawing.Point(12, 32);
            this.btnYeniHesap.Name = "btnYeniHesap";
            this.btnYeniHesap.Size = new System.Drawing.Size(131, 33);
            this.btnYeniHesap.TabIndex = 2;
            this.btnYeniHesap.Text = "Yeni Hesap Ekle";
            this.btnYeniHesap.UseVisualStyleBackColor = true;
            this.btnYeniHesap.Click += new System.EventHandler(this.btnYeniHesap_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(394, 32);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 33);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dgwHesaplar
            // 
            this.dgwHesaplar.AllowUserToAddRows = false;
            this.dgwHesaplar.AllowUserToDeleteRows = false;
            this.dgwHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHesaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapID,
            this.bakiye});
            this.dgwHesaplar.Location = new System.Drawing.Point(3, 82);
            this.dgwHesaplar.Name = "dgwHesaplar";
            this.dgwHesaplar.Size = new System.Drawing.Size(500, 374);
            this.dgwHesaplar.TabIndex = 0;
            this.dgwHesaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hesapID
            // 
            this.hesapID.HeaderText = "Hesap ID";
            this.hesapID.Name = "hesapID";
            // 
            // bakiye
            // 
            this.bakiye.HeaderText = "Bakiye";
            this.bakiye.Name = "bakiye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon \r\n\r\nE-posta\r\n\r\nAdres\r\n\r\nŞifre";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 482);
            this.Controls.Add(this.pnlHesaplar);
            this.Controls.Add(this.pnlGuncelleBilgi);
            this.Controls.Add(this.panel1);
            this.Name = "Musteri";
            this.Text = "Musteri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGuncelleBilgi.ResumeLayout(false);
            this.pnlGuncelleBilgi.PerformLayout();
            this.pnlHesaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Panel pnlGuncelleBilgi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel pnlHesaplar;
        private System.Windows.Forms.DataGridView dgwHesaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiye;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnYeniHesap;
        private System.Windows.Forms.Label label1;
    }
}