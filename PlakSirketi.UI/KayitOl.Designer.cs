namespace PlakSirketi.UI
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.lbl_SifreBilgilendirme = new System.Windows.Forms.Label();
            this.lbl_Bilgilendirme = new System.Windows.Forms.Label();
            this.pb_SifreGoster = new System.Windows.Forms.PictureBox();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.txt_KayitSifreTekrar = new System.Windows.Forms.TextBox();
            this.txt_KayitSifre = new System.Windows.Forms.TextBox();
            this.txt_KayitKullaniciAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SifreGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SifreBilgilendirme
            // 
            this.lbl_SifreBilgilendirme.Location = new System.Drawing.Point(69, 289);
            this.lbl_SifreBilgilendirme.Name = "lbl_SifreBilgilendirme";
            this.lbl_SifreBilgilendirme.Size = new System.Drawing.Size(338, 49);
            this.lbl_SifreBilgilendirme.TabIndex = 26;
            this.lbl_SifreBilgilendirme.Text = "Şifreniz en az 8 karakter,2 büyük,3 küçük,2 tane özel karakter(!+:*) olmalıdır.";
            this.lbl_SifreBilgilendirme.Visible = false;
            // 
            // lbl_Bilgilendirme
            // 
            this.lbl_Bilgilendirme.AutoSize = true;
            this.lbl_Bilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.lbl_Bilgilendirme.Location = new System.Drawing.Point(93, 252);
            this.lbl_Bilgilendirme.Name = "lbl_Bilgilendirme";
            this.lbl_Bilgilendirme.Size = new System.Drawing.Size(0, 20);
            this.lbl_Bilgilendirme.TabIndex = 25;
            // 
            // pb_SifreGoster
            // 
            this.pb_SifreGoster.Image = ((System.Drawing.Image)(resources.GetObject("pb_SifreGoster.Image")));
            this.pb_SifreGoster.Location = new System.Drawing.Point(371, 159);
            this.pb_SifreGoster.Name = "pb_SifreGoster";
            this.pb_SifreGoster.Size = new System.Drawing.Size(36, 34);
            this.pb_SifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_SifreGoster.TabIndex = 24;
            this.pb_SifreGoster.TabStop = false;
            this.pb_SifreGoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_SifreGoster_MouseDown);
            this.pb_SifreGoster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_SifreGoster_MouseUp);
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Location = new System.Drawing.Point(65, 341);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(342, 43);
            this.btn_KayitOl.TabIndex = 23;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // txt_KayitSifreTekrar
            // 
            this.txt_KayitSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KayitSifreTekrar.Location = new System.Drawing.Point(65, 215);
            this.txt_KayitSifreTekrar.Name = "txt_KayitSifreTekrar";
            this.txt_KayitSifreTekrar.PasswordChar = '*';
            this.txt_KayitSifreTekrar.PlaceholderText = "Şifre Tekrarı";
            this.txt_KayitSifreTekrar.Size = new System.Drawing.Size(342, 34);
            this.txt_KayitSifreTekrar.TabIndex = 20;
            this.txt_KayitSifreTekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KayitSifreTekrar.TextChanged += new System.EventHandler(this.txt_KayitKullaniciAdi_TextChanged);
            // 
            // txt_KayitSifre
            // 
            this.txt_KayitSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KayitSifre.Location = new System.Drawing.Point(65, 159);
            this.txt_KayitSifre.Name = "txt_KayitSifre";
            this.txt_KayitSifre.PasswordChar = '*';
            this.txt_KayitSifre.PlaceholderText = "Şifre";
            this.txt_KayitSifre.Size = new System.Drawing.Size(342, 34);
            this.txt_KayitSifre.TabIndex = 21;
            this.txt_KayitSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KayitSifre.TextChanged += new System.EventHandler(this.txt_KayitKullaniciAdi_TextChanged);
            // 
            // txt_KayitKullaniciAdi
            // 
            this.txt_KayitKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KayitKullaniciAdi.Location = new System.Drawing.Point(65, 102);
            this.txt_KayitKullaniciAdi.Name = "txt_KayitKullaniciAdi";
            this.txt_KayitKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txt_KayitKullaniciAdi.Size = new System.Drawing.Size(342, 34);
            this.txt_KayitKullaniciAdi.TabIndex = 22;
            this.txt_KayitKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KayitKullaniciAdi.TextChanged += new System.EventHandler(this.txt_KayitKullaniciAdi_TextChanged);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 486);
            this.Controls.Add(this.lbl_SifreBilgilendirme);
            this.Controls.Add(this.lbl_Bilgilendirme);
            this.Controls.Add(this.pb_SifreGoster);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.txt_KayitSifreTekrar);
            this.Controls.Add(this.txt_KayitSifre);
            this.Controls.Add(this.txt_KayitKullaniciAdi);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            ((System.ComponentModel.ISupportInitialize)(this.pb_SifreGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_SifreBilgilendirme;
        private Label lbl_Bilgilendirme;
        private PictureBox pb_SifreGoster;
        private Button btn_KayitOl;
        private TextBox txt_KayitSifreTekrar;
        private TextBox txt_KayitSifre;
        private TextBox txt_KayitKullaniciAdi;
    }
}