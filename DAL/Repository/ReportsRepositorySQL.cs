using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repository
{
    public class ReportsRepositorySQL : IReportsRepository
    {

        public Model1 dB;
        private class Result
        {
            public int Код_тарифа_FK { get; set; }

            public DateTime Дата_заключения  { get; set; }
          
            public string Номер_телефона { get; set; }
       
          
        }
        private class Result2
        {
            public DateTime Дата_и_время { get; set; }
            public int Длительность { get; set; }
            public decimal Стоимость { get; set; }
           public int Номер_договора_FK { get; set; }
           public int Код_типа_звонка_FK { get; set; }
        }
        private class Result3
        {
            public int Номер_клиента { get; set; }
            public string ФИО { get; set; }
            public decimal Баланс { get; set; }
        }
        public ReportsRepositorySQL(Model1 dBContext)
        {
            this.dB = dBContext;
        }

     
        public List<Dogovors> procedd8(DateTime start, DateTime end)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@start", start);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@end", end);

            var result = dB.Database.SqlQuery<Result>("procedd8 @start, @end", new[] { param1, param2 }).ToList();
              var data = result.Select(i => new Dogovors
              { 
                 Код_тарифа_FK = i.Код_тарифа_FK,
                 Дата_заключения = i.Дата_заключения,
            
               Номер_телефона = i.Номер_телефона
             }).ToList();

             return data;
            
        }

        public List<Calls> procedd81(int kod)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@kod", kod);
            var result = dB.Database.SqlQuery<Result2>("procedd81 @kod", new[] { param1}).ToList();
            var data = result.Select(i => new Calls
            {
            Дата_и_время=i.Дата_и_время,
                 Длительность=i.Длительность,
                Код_типа_звонка_FK=i.Код_типа_звонка_FK,
                Номер_договора_FK=i.Номер_договора_FK,
                 Стоимость=i.Стоимость
            }).ToList();

            return data;

        }
        public List<Clients> procedd812(string s)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@s", s);
            var result = dB.Database.SqlQuery<Result3>("procedd812 @s", new[] { param1 }).ToList();
            var data = result.Select(i => new Clients
            {
         Номер_клиента=i.Номер_клиента,
         ФИО=i.ФИО,
         Баланс=i.Баланс
            }).ToList();

            return data;

        }

        public List<Tarifs> procedd8121(string s)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@s", s);
            var result = dB.Database.SqlQuery<Result4>("procedd8121 @s", new[] { param1 }).ToList();
            var data = result.Select(i => new Tarifs
            {
                Минута_межгород_стоимость = i.Минута_межгород_стоимость,
                Минута_международная_стоимость = i.Минута_международная_стоимость,
                Название_тарифа = i.Название_тарифа,
                Стоимость_перехода = i.Стоимость_перехода,
                Код_типа_тарифа_FK = i.Код_типа_тарифа_FK,
                Код_тарифа = i.Код_тарифа,
                Год_начала = i.Год_начала
            }).ToList();

            return data;

        }
        public List<Dogovors1> procedd81211(string s)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@s", s);
            var result = dB.Database.SqlQuery<Result5>("procedd81211 @s", new[] { param1 }).ToList();
            var data = result.Select(i => new Dogovors1
            {
               Дата_заключения=i.Дата_заключения,
               Номер_договора=i.Номер_договора,
               Номер_телефона=i.Номер_телефона,
               Серийный_номер_сим_карты=i.Серийный_номер_сим_карты,
               Дата_расторжения=i.Дата_расторжения,
               Код_тарифа_FK=i.Код_тарифа_FK,
               Номер_клиента_FK=i.Номер_клиента_FK


            }).ToList();

            return data;

        }




        public List<Dogovors2> procedd813(int kod)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@kod", kod);
            var result = dB.Database.SqlQuery<Result6>("procedd813 @kod", new[] { param1 }).ToList();
            var data = result.Select(i => new Dogovors2
            {
          
                Номер_договора = i.Номер_договора,
                Номер_телефона = i.Номер_телефона,
              
                Код_тарифа_FK = i.Код_тарифа_FK


            }).ToList();

            return data;

        }



    }
}
