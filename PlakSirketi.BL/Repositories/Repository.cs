using Microsoft.EntityFrameworkCore;
using PlakSirketi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakSirketi.BL.Repositories
{
    public class Repository<T> where T : class
    {
        private PlakSirketiContext _db;
        private DbSet<T> _dbSet;
        public Repository(PlakSirketiContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }
        public void Ekle(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }
        public void Sil(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }
        public void Guncelle()
        {
            _db.SaveChanges();
        }
        public List<T> TumunuGetir()
        {
            return _dbSet.ToList();
        }
        public T IdYeGoreGetir(int id)
        {
            return _dbSet.Find(id);
        }

    }
}
