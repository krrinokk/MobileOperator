using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repository
{
    public class ТарифRepositorySQL : IRepository<Тариф>
    {
        private Model1 db;

        public ТарифRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Тариф> GetList()
        {
            return db.Тариф.ToList();
        }

        public Тариф GetItem(int id)
        {
            return db.Тариф.Find(id);
        }

        public void Create(Тариф тариф)
        {
            db.Тариф.Add(тариф);
        }

        public void Update(Тариф тариф)
        {
            db.Entry(тариф).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Тариф item = db.Тариф.Find(id);
            if (item != null)
                db.Тариф.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}