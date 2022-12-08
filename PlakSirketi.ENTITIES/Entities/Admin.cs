using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakSirketi.ENTITIES.Entities
{
    public class Admin
    {
        public int ID { get; set; }
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = value.Trim(); }
        }
        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = sha256_hash(value); }
        }

        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
