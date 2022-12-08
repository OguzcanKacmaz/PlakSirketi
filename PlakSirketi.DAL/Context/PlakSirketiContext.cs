using Microsoft.EntityFrameworkCore;
using PlakSirketi.DAL.Mapping;
using PlakSirketi.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PlakSirketi.DAL.Context
{
    public class PlakSirketiContext : DbContext
    {
        public DbSet<Admin> Adminler => Set<Admin>();
        public DbSet<Album> Albumler => Set<Album>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=PlakSirketiDb;integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
