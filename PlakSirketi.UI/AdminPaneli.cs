using PlakSirketi.BL.Repositories;
using PlakSirketi.DAL.Context;
using PlakSirketi.ENTITIES.Entities;

namespace PlakSirketi.UI
{
    public partial class AdminPaneli : Form
    {
        PlakSirketiContext _db;
        Repository<Album> _repos;
        public AdminPaneli(PlakSirketiContext db)
        {
            InitializeComponent();
            _db = db;
            _repos = new Repository<Album>(_db);
            Listele();
        }

        private void Listele()
        {
            dgv_TumAlbumler.DataSource = _repos.TumunuGetir();
            dgv_SistemeEklenenSon.DataSource = _repos.TumunuGetir().OrderByDescending(x => x.ID).Take(10).Select(x => new { x.AlbumAdi, x.AlbumSanatci }).ToList();
            dgv_SatisiDurmusAlbumler.DataSource = _repos.TumunuGetir().Where(x => x.AlbumSatistaMi == false).Select(x => new { x.AlbumAdi, x.AlbumSanatci }).ToList();
            dgv_SatisiDevamEdenAlbumler.DataSource = _repos.TumunuGetir().Where(x => x.AlbumSatistaMi == true).Select(x => new { x.AlbumAdi, x.AlbumSanatci }).ToList();
            dgv_IndirimdekiAlbumler.DataSource = _repos.TumunuGetir().Where(x => x.AlbumIndirimOrani > 0).OrderByDescending(x => x.AlbumIndirimOrani).Select(x => new { x.AlbumAdi, x.AlbumSanatci }).ToList();
        }
        private void TextBoxYazdir(Album secilenAlbum)
        {
            var album = secilenAlbum;
            txt_AlbumAdi.Text = album.AlbumAdi;
            txt_AlbumSanatci.Text = album.AlbumSanatci;
            txt_AlbumCikisTarihi.Text = album.AlbumCikisTarihi.ToString();
            nud_AlbumFiyat.Value = album.AlbumFiyat;
            nud_Album�ndirimOrani.Value = (decimal)album.AlbumIndirimOrani;
            if (album.AlbumSatistaMi)
                rb_Satista.Checked = true;
            else
                rb_SatistaDegil.Checked = true;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!BosAlanVarmi(grp_AlbumIslemleri))
            {
                Album album = new Album();
                album.AlbumAdi = txt_AlbumAdi.Text;
                album.AlbumSanatci = txt_AlbumSanatci.Text;
                album.AlbumCikisTarihi = txt_AlbumCikisTarihi.Text;
                album.AlbumFiyat = nud_AlbumFiyat.Value;
                if (rb_SatistaDegil.Checked)
                {
                    if (nud_Album�ndirimOrani.Value > 0)
                    {
                        album.AlbumIndirimOrani = 0;
                    }
                }
                else if (rb_Satista.Checked)
                {
                    if (nud_Album�ndirimOrani.Value > 0)
                    {
                        album.AlbumIndirimOrani = nud_Album�ndirimOrani.Value;
                    }
                }
                album.AlbumSatistaMi = rb_Satista.Checked;
                _repos.Ekle(album);
                MessageBox.Show("Alb�m Eklenmi�tir.");
                Listele();
                Temizle(grp_AlbumIslemleri);
                secilenAlbum = null;
            }
            else
            {
                MessageBox.Show("L�tfen Bo� Alan B�rakmay�n�z.");
            }
        }
        private bool BosAlanVarmi(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox && ((TextBox)item).Text == string.Empty)
                    return true;
                else if (item is MaskedTextBox && ((MaskedTextBox)item).Text == string.Empty)
                    return true;
                else if (item is NumericUpDown && ((NumericUpDown)item).Value == default)
                    return true;
                else if (item is CheckBox && ((CheckBox)item).Checked == false)
                    return true;
            }
            return false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenAlbum != null)
                {
                    _repos.Sil(secilenAlbum);
                    MessageBox.Show("Alb�m Silinmi�tir.");
                    Listele();
                    secilenAlbum = null;
                    Temizle(grp_AlbumIslemleri);
                    nud_Album�ndirimOrani.Value = 0;
                }
                else
                {

                    MessageBox.Show("L�tfen Silinecek Alb�m� Se�iniz.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("L�tfen Silmek �stedi�iniz Alb�m� Se�iniz.");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
                secilenAlbum.AlbumAdi = txt_AlbumAdi.Text;
                secilenAlbum.AlbumSanatci = txt_AlbumSanatci.Text;
                secilenAlbum.AlbumCikisTarihi = txt_AlbumCikisTarihi.Text;
                secilenAlbum.AlbumFiyat = nud_AlbumFiyat.Value; 
                if (rb_SatistaDegil.Checked)
                {
                    if (nud_Album�ndirimOrani.Value > 0)
                    {
                        secilenAlbum.AlbumIndirimOrani = 0;
                    }
                }
                else if (rb_Satista.Checked)
                {
                    if (nud_Album�ndirimOrani.Value > 0)
                    {
                        secilenAlbum.AlbumIndirimOrani = nud_Album�ndirimOrani.Value;
                    }
                }
                secilenAlbum.AlbumSatistaMi = rb_Satista.Checked;
                _repos.Guncelle();
                MessageBox.Show("Alb�m G�ncellenmi�tir.");
                Listele();
                Temizle(grp_AlbumIslemleri);
                nud_Album�ndirimOrani.Value = 0;
                secilenAlbum = null;
            }
            else
            {
                MessageBox.Show("L�tfen G�ncellenecek Albumu Se�iniz.");
            }
        }

        private void dgv_TumAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Temizle(grp_AlbumIslemleri);
            nud_Album�ndirimOrani.Value = 0;
            rb_Satista.Checked = true;
            secilenAlbum = null;
        }
        private void Temizle(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
                else if (item is MaskedTextBox)
                    ((MaskedTextBox)item).Text = string.Empty;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = default;
                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
            }
            
        }
        Album secilenAlbum;

        private void dgv_TumAlbumler_DoubleClick(object sender, EventArgs e)
        {
            secilenAlbum = _repos.IdYeGoreGetir(Convert.ToInt32(dgv_TumAlbumler.CurrentRow.Cells[0].Value.ToString()));
            TextBoxYazdir(secilenAlbum);
        }
    }
}