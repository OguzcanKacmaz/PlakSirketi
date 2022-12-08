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
    public partial class GirisPanel : Form
    {
        PlakSirketiContext _db;
        public GirisPanel()
        {
            InitializeComponent();
            _db = new PlakSirketiContext();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string _kullaniciAdi = txt_KullaniciAdi.Text;
            string _sifre = txt_Sifre.Text;
            var GirisYapanAdmin = _db.Adminler.FirstOrDefault(x => x.KullaniciAdi == _kullaniciAdi);

            if (GirisYapanAdmin != null && GirisYapanAdmin.Sifre == Admin.sha256_hash(_sifre))
            {
                MessageBox.Show("Giriş Başarılı.");
                AdminPaneli adminPanelForm = new AdminPaneli(_db);
                adminPanelForm.Show();
                this.Hide();
            }
            else
            {
                lbl_GirisBilgilendirme.Visible = true;
            }
        }

        private void lnk_UyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOlForm = new KayitOl(this, _db);
            kayitOlForm.Show();
            this.Hide();
        }

        private void txt_KullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            lbl_GirisBilgilendirme.Visible = false;
        }

        private void GirisPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
