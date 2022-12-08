using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakSirketi.ENTITIES.Entities
{
    public class Album
    {
        public int ID { get; set; }
        public string AlbumAdi { get; set; } = null!;
        public string AlbumSanatci { get; set; } = null!;
        public string AlbumCikisTarihi { get; set; }
        public decimal AlbumFiyat { get; set; }
        public decimal? AlbumIndirimOrani { get; set; } = 0.0M;
        public bool AlbumSatistaMi { get; set; }
    }
}
