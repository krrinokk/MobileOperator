using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WpfAppMaterialDesign.Model;
using DAL;



namespace WpfAppMaterialDesign
{
  public  class ClientsService
    {


        public ClientsService()
        {
            using (ClientContext db = new ClientContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public List<Model.Клиент> GetКлиент()
        {
            using (ClientContext db = new ClientContext())
            {
               return db.Клиент.Select(u => new Model.Клиент()).ToList();
            }
        }

      

        public void Update(Model.Клиент клиент)
        {
            using (ClientContext db = new ClientContext())
            {
                var dbКлиент = db.Клиент.FirstOrDefault(u => u.Номер_клиента == клиент.Номер_клиента);
                dbКлиент.Баланс = клиент.Баланс;
                dbКлиент.ФИО = клиент.ФИО;
                db.SaveChanges();
            }
        }

        public void AddКлиент(Model.Клиент клиент)
        {
            var dbКлиент = new DAL.Models.Клиент()
            {
                Баланс = клиент.Баланс,
                ФИО = клиент.ФИО,
                Номер_клиента = клиент.Номер_клиента

            };

           using (ClientContext db = new ClientContext())
        {
             db.Клиент.Add(dbКлиент);
                db.SaveChanges();
          }
       }



        public void SaveChanges()
        {
            using (ClientContext db = new ClientContext())
            {
                db.SaveChanges();
            }
        }

      
    }
}
