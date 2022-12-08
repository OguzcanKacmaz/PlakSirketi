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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {

        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.KullaniciAdi).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.KullaniciAdi).IsUnique();
            builder.Property(x => x.Sifre).IsRequired();
        }
    }
}
