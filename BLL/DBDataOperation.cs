using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using BLL.Models;
using DAL.Models;
using System.Collections.ObjectModel;

namespace BLL
{
    public class DBDataOperation : IDbCrud
    {
        IDbRepos db;
        public DBDataOperation(IDbRepos repos)
        {
            db = repos;
        }




        public List<КлиентModel> GetAllКлиент()
        {
            return db.Клиент.GetList().Select(i => new КлиентModel(i)).ToList();
        }

        public КлиентModel GetКлиент(int id)
        {
            return new КлиентModel(db.Клиент.GetItem(id));
        }

        public void CreateКлиент(КлиентModel cl)
        {
            db.Клиент.Create(new Клиент() { ФИО = cl.ФИО, Баланс = cl.Баланс, Номер_клиента = cl.Номер_клиента });
            Save();
        }

        public void UpdateКлиент(КлиентModel cl)
        {
            Клиент client = db.Клиент.GetItem(cl.Номер_клиента);
            client.ФИО = cl.ФИО;
            client.Баланс = cl.Баланс;
            client.Номер_клиента = cl.Номер_клиента;

            Save();
        }

        public void DeleteКлиент(int id)
        {
            Клиент cl = db.Клиент.GetItem(id);
            if (cl != null)
            {
                db.Клиент.Delete(cl.Номер_клиента);
                Save();
            }
        }
        //tarif

        public List<ТарифModel> GetAllТариф()
        {
            return db.Тариф.GetList().Select(i => new ТарифModel(i)).ToList();
        }

        public ТарифModel GetТариф(int id)
        {
            return new ТарифModel(db.Тариф.GetItem(id));
        }

        public void CreateТариф(ТарифModel trf)
        {
            db.Тариф.Create(new Тариф() { Год_начала = trf.Год_начала, Код_тарифа = trf.Код_тарифа, Код_типа_тарифа_FK = trf.Код_типа_тарифа_FK, Минута_межгород_стоимость = trf.Минута_межгород_стоимость, 
                Минута_международная_стоимость = trf.Минута_международная_стоимость, Стоимость_перехода = trf.Стоимость_перехода, Название_тарифа = trf.Название_тарифа });
            Save();
        }

        public void UpdateТариф(ТарифModel trf)
        {
            Тариф тариф = db.Тариф.GetItem(trf.Код_тарифа);
            тариф.Год_начала = trf.Год_начала;
            тариф.Код_тарифа = trf.Код_тарифа;
            тариф.Код_типа_тарифа_FK = trf.Код_типа_тарифа_FK;
            тариф.Минута_межгород_стоимость = trf.Минута_межгород_стоимость;
            тариф.Минута_международная_стоимость = trf.Минута_международная_стоимость;
         

            Save();
        }

        public void DeleteТариф(int id)
        {
            Тариф trf = db.Тариф.GetItem(id);
            if (trf != null)
            {
                db.Тариф.Delete(trf.Код_тарифа);
                Save();
            }
        }

        //dogovor


        public List<DogovorModel> GetAllDogovor()
        {
            return db.Dogovor.GetList().Select(i => new DogovorModel(i)).ToList();
        }

        public DogovorModel GetDogovor(int id)
        {
            return new DogovorModel(db.Dogovor.GetItem(id));
        }

        public void CreateDogovor(DogovorModel dgv)
        {
            db.Dogovor.Create(new Dogovor()
            {
                Дата_заключения = dgv.Дата_заключения,
                Дата_расторжения = dgv.Дата_расторжения,
                 Код_тарифа_FK=dgv.Код_тарифа_FK,
                  Номер_договора=dgv.Номер_договора,
                   Номер_клиента_FK=dgv.Номер_клиента_FK,
                    Номер_телефона=dgv.Номер_телефона,
                     Серийный_номер_сим_карты=dgv.Серийный_номер_сим_карты
            }) ;
            Save();
        }

        public void UpdateDogovor(DogovorModel dgv)
        {
            Dogovor dogovor = db.Dogovor.GetItem(dgv.Номер_договора);

            Тариф тариф = db.Тариф.GetItem(dgv.Номер_договора);
            dogovor.Дата_заключения = dgv.Дата_заключения;
            dogovor.Дата_расторжения = dgv.Дата_расторжения;
            dogovor.Код_тарифа_FK = dgv.Код_тарифа_FK;

            dogovor.Номер_клиента_FK = dgv.Номер_клиента_FK;
            dogovor.Номер_телефона = dgv.Номер_телефона;
            dogovor.Серийный_номер_сим_карты = dgv.Серийный_номер_сим_карты;

            Save();
        }

        public void DeleteDogovor(int id)
        {
            Dogovor dgv = db.Dogovor.GetItem(id);
            if (dgv != null)
            {
                db.Dogovor.Delete(dgv.Номер_договора);
                Save();
            }
        }







        public List<Тип_тарифаModel> GetAllTip_tarifa()
        {
            return db.Тип_тарифа.GetList().Select(i => new Тип_тарифаModel(i)).ToList();
        }

        public Тип_тарифаModel GetTip_tarifa(int id)
        {
            return new Тип_тарифаModel(db.Тип_тарифа.GetItem(id));
        }

        public void CreateTip_tarifa (Тип_тарифаModel dgv)
        {
            db.Тип_тарифа.Create(new Тип_тарифа()
            {
                Название_типа_тарифа=dgv.Название_типа_тарифа,
                Код_типа_тарифа=dgv.Код_типа_тарифа
            });
            Save();
        }

        public void UpdateTip_tarifa(Тип_тарифаModel dgv)
        {
            Тип_тарифа dogovor = db.Тип_тарифа.GetItem(dgv.Код_типа_тарифа);

          
            dogovor.Код_типа_тарифа = dgv.Код_типа_тарифа;
            dogovor.Название_типа_тарифа= dgv.Название_типа_тарифа;


            Save();
        }

        public void DeleteTip_tarifa(int id)
        {
            Тип_тарифа dgv = db.Тип_тарифа.GetItem(id);
            if (dgv != null)
            {
                db.Тип_тарифа.Delete(dgv.Код_типа_тарифа);
                Save();
            }
        }











        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        
    }
}