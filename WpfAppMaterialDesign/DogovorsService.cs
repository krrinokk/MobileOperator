using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DAL;

namespace WpfAppMaterialDesign
{
    class DogovorsService
    {

        public DogovorsService()
        {
            using (DogovorContext db = new DogovorContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public List<Model.Dogovor> GetDogovor()
        {
            using (DogovorContext db = new DogovorContext())
            {
                return db.Dogovors.Select(u => new Model.Dogovor()).ToList();
            }
        }

        public void AddDogovor(Model.Dogovor dogovor)
        {
            var dbDogovor = new Dogovor()
            {
                Дата_заключения = dogovor.Дата_заключения,
                Дата_расторжения = dogovor.Дата_расторжения,
                Номер_договора = dogovor.Номер_договора,
                Серийный_номер_сим_карты = dogovor.Серийный_номер_сим_карты,
                Код_тарифа_FK = dogovor.Код_тарифа_FK,
                Номер_клиента_FK= dogovor.Номер_клиента_FK
            };

           
            //using (DogovorContext db = new DogovorContext())
            //{
            //    db.Dogovors.Add(dbDogovor);
            //    db.SaveChanges();
            //}
        }

        public void Update(Model.Dogovor dogovor)
        {
            using (DogovorContext db = new DogovorContext())
            {
                var dbDogovor = db.Dogovors.FirstOrDefault(u => u.Номер_договора== dogovor.Номер_договора);
                dbDogovor.Дата_заключения = dogovor.Дата_заключения;
                dbDogovor.Дата_расторжения = dogovor.Дата_расторжения;
                dbDogovor.Серийный_номер_сим_карты = dogovor.Серийный_номер_сим_карты;
                dbDogovor.Код_тарифа_FK = dogovor.Код_тарифа_FK;
                dbDogovor.Номер_клиента_FK = dogovor.Номер_клиента_FK;
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
