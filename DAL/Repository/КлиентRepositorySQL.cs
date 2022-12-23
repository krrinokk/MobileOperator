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
    public class КлиентRepositorySQL : IRepository<Клиент>
    {
        private Model1 db;

        public КлиентRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Клиент> GetList()
        {
            return db.Клиент.ToList();
        }

        public Клиент GetItem(int id)
        {
            return db.Клиент.Find(id);
        }

        public void Create(Клиент Клиент)
        {
            db.Клиент.Add(Клиент);
        }

        public void Update(Клиент Клиент)
        {
            db.Entry(Клиент).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Клиент item = db.Клиент.Find(id);
            if (item != null)
                db.Клиент.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}