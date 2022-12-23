using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Тип_тарифаRepositorySQL : IRepository<Тип_тарифа>
    {
        private Model1 db;

        public Тип_тарифаRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Тип_тарифа> GetList()
        {
            return db.Тип_тарифа.ToList();
        }

        public Тип_тарифа GetItem(int id)
        {
            return db.Тип_тарифа.Find(id);
        }

        public void Create(Тип_тарифа Клиент)
        {
            db.Тип_тарифа.Add(Клиент);
        }

        public void Update(Тип_тарифа Клиент)
        {
            db.Entry(Клиент).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Тип_тарифа item = db.Тип_тарифа.Find(id);
            if (item != null)
                db.Тип_тарифа.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
