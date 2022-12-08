using PlakSirketi.BL.Repositories;
using PlakSirketi.DAL.Context;
using PlakSirketi.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakSirketi.UI
{
    public partial class KayitOl : Form
    {
        GirisPanel frmGiris;
        PlakSirketiContext _db;
        Repository<Admin> _repo;
        public KayitOl(GirisPanel _frmGiris, PlakSirketiContext db)
        {
            InitializeComponent();
            frmGiris = _frmGiris;
            _db = db;
            _repo = new Repository<Admin>(_db);
        }

        private void pb_SifreGoster_MouseUp(object sender, MouseEventArgs e)
        {            
            txt_KayitSifre.PasswordChar = '*';
            txt_KayitSifreTekrar.PasswordChar = '*';
        }

        private void pb_SifreGoster_MouseDown(object sender, MouseEventArgs e)
        {
            txt_KayitSifre.PasswordChar = default;
            txt_KayitSifreTekrar.PasswordChar = default;
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                string KullaniciAdi = txt_KayitKullaniciAdi.Text;
                string Sifre = txt_KayitSifre.Text;
                string SifreTekrar = txt_KayitSifreTekrar.Text;
                if (Sifre != SifreTekrar)
                {
                    lbl_Bilgilendirme.Text = "Şifreler Uyuşmuyor";
                }
                else if (SifreKontrol.SifreGecerliMi(Sifre))
                {
                    _repo.Ekle(new Admin() { KullaniciAdi = KullaniciAdi, Sifre = Sifre });
                    MessageBox.Show("Kayıt Başarılı.");
                    frmGiris.Show();
                    this.Close();
                }
                else
                {
                    lbl_SifreBilgilendirme.Visible = true;
                    lbl_Bilgilendirme.Text = "Girdiğiniz Şifre Geçersizdir.";
                }
            }
            catch (Exception)
            {
                lbl_Bilgilendirme.Text = "Bu Kullanıcı Adı Başkası Tarafından Kullanılıyor!";
            }
        }

        private void txt_KayitKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            lbl_SifreBilgilendirme.Visible = false;
            lbl_Bilgilendirme.Text = string.Empty;
        }
    }
}
