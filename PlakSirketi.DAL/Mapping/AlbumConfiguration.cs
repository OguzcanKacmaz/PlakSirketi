using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakSirketi.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakSirketi.DAL.Mapping
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {

        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.AlbumAdi).IsRequired().HasMaxLength(30);
            builder.Property(x => x.AlbumSanatci).IsRequired().HasMaxLength(30);
            builder.Property(x => x.AlbumCikisTarihi).IsRequired().HasMaxLength(25);
            builder.Property(x => x.AlbumFiyat).IsRequired().HasMaxLength(25);
            builder.Property(x => x.AlbumIndirimOrani).IsRequired(required: false).HasMaxLength(25);
            builder.Property(x => x.AlbumSatistaMi).IsRequired().HasMaxLength(25);
        }
    }
}
