namespace PlakSirketi.UI
{
    partial class GirisPanel
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
            this.lbl_GirisBilgilendirme = new System.Windows.Forms.Label();
            this.lnk_UyeOl = new System.Windows.Forms.LinkLabel();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_GirisBilgilendirme
            // 
            this.lbl_GirisBilgilendirme.AutoSize = true;
            this.lbl_GirisBilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.lbl_GirisBilgilendirme.Location = new System.Drawing.Point(86, 122);
            this.lbl_GirisBilgilendirme.Name = "lbl_GirisBilgilendirme";
            this.lbl_GirisBilgilendirme.Size = new System.Drawing.Size(202, 20);
            this.lbl_GirisBilgilendirme.TabIndex = 13;
            this.lbl_GirisBilgilendirme.Text = "Kullanıcı Adı Veya Şifre Yanlış";
            this.lbl_GirisBilgilendirme.Visible = false;
            // 
            // lnk_UyeOl
            // 
            this.lnk_UyeOl.AutoSize = true;
            this.lnk_UyeOl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnk_UyeOl.Location = new System.Drawing.Point(367, 341);
            this.lnk_UyeOl.Name = "lnk_UyeOl";
            this.lnk_UyeOl.Size = new System.Drawing.Size(61, 23);
            this.lnk_UyeOl.TabIndex = 12;
            this.lnk_UyeOl.TabStop = true;
            this.lnk_UyeOl.Text = "Üye Ol";
            this.lnk_UyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_UyeOl_LinkClicked);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(86, 269);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(342, 43);
            this.btn_GirisYap.TabIndex = 11;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Sifre.Location = new System.Drawing.Point(86, 217);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.PlaceholderText = "Şifre";
            this.txt_Sifre.Size = new System.Drawing.Size(342, 34);
            this.txt_Sifre.TabIndex = 9;
            this.txt_Sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Sifre.TextChanged += new System.EventHandler(this.txt_KullaniciAdi_TextChanged);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(86, 160);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(342, 34);
            this.txt_KullaniciAdi.TabIndex = 10;
            this.txt_KullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KullaniciAdi.TextChanged += new System.EventHandler(this.txt_KullaniciAdi_TextChanged);
            // 
            // GirisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 486);
            this.Controls.Add(this.lbl_GirisBilgilendirme);
            this.Controls.Add(this.lnk_UyeOl);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Name = "GirisPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_GirisBilgilendirme;
        private LinkLabel lnk_UyeOl;
        private Button btn_GirisYap;
        private TextBox txt_Sifre;
        private TextBox txt_KullaniciAdi;
    }
}