using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Dogovors
    {
        public int Код_тарифа_FK { get; set; }
        public DateTime Дата_заключения { get; set; }

           public string Номер_телефона { get; set; }
    }
    public class Calls
    {
        public DateTime Дата_и_время { get; set; }
        public int Длительность { get; set; }
        public decimal Стоимость { get; set; }
        public int Номер_договора_FK { get; set; }
        public int Код_типа_звонка_FK { get; set; }
    }
    public class Clients
    {
        public int Номер_клиента { get; set; }
        public string ФИО { get; set; }
        public decimal Баланс { get; set; }
    }
    public class Tarifs
    {
        public decimal Минута_межгород_стоимость { get; set; }
        public decimal Минута_международная_стоимость { get; set; }
        public string Название_тарифа { get; set; }
        public decimal Стоимость_перехода { get; set; }
        public int Код_типа_тарифа_FK  { get; set; }
        public int Код_тарифа { get; set; }
        public int Год_начала { get; set; }

    }
    public class Dogovors1
    {
        public DateTime Дата_заключения { get; set; }
        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }
        public string Серийный_номер_сим_карты { get; set; }
        public DateTime Дата_расторжения { get; set; }
        public int Код_тарифа_FK { get; set; }
        public int Номер_клиента_FK { get; set; }
    }
    public class Dogovors2
    {
 
        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }
  
        public int Код_тарифа_FK { get; set; }
     
    }
    public class Result6
    {

        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }

        public int Код_тарифа_FK { get; set; }

    }
    public class Result5
    {
        public DateTime Дата_заключения { get; set; }
        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }
        public string Серийный_номер_сим_карты { get; set; }
        public DateTime Дата_расторжения { get; set; }
        public int Код_тарифа_FK { get; set; }
        public int Номер_клиента_FK { get; set; }
    }
    public class Result4
    {
        public decimal Минута_межгород_стоимость { get; set; }
        public decimal Минута_международная_стоимость { get; set; }
        public string Название_тарифа { get; set; }
        public decimal Стоимость_перехода { get; set; }
        public int Код_типа_тарифа_FK { get; set; }
        public int Код_тарифа { get; set; }
        public int Год_начала { get; set; }

    }
    public class Result2
    {
        public DateTime Дата_и_время { get; set; }
        public int Длительность { get; set; }
        public decimal Стоимость { get; set; }
        public int Номер_договора_FK { get; set; }
        public int Код_типа_звонка_FK { get; set; }
    }
    public class Result3
    {
        public int Номер_клиента { get; set; }
        public string ФИО { get; set; }
        public decimal Баланс { get; set; }
    
    }
    public class Result
    {
        public int Код_тарифа_FK { get; set; }
        public DateTime Дата_заключения { get; set; }
        public string Номер_телефона { get; set; }

        public int Номер_договора { get; set; }
    }
}
