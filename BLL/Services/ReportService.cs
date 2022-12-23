using BLL.Interfaces;
using BLL.Models;
using BLL.Models.ReportModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class ReportsService : IReportService
    {

        private IDbRepos dB;
        public ReportsService(IDbRepos Model1)
        {
            dB = Model1;
        }

        //выполнить ХП
        //Dogovors
        public List<Dogovors> procedd8(DateTime start, DateTime end)
        {

            return dB.Reports.procedd8(start, end).Select(i => new Dogovors { Код_тарифа_FK = i.Код_тарифа_FK, Номер_телефона= i.Номер_телефона, Дата_заключения = i.Дата_заключения }).ToList();
        }

        public List<CallModel> procedd81(int kod)
        {

            return dB.Reports.procedd81(kod).Select(i => new CallModel {  Дата_и_время=i.Дата_и_время, Длительность=i.Длительность, Код_типа_звонка_FK=i.Код_типа_звонка_FK , Номер_договора_FK=i.Номер_договора_FK , Стоимость=i.Стоимость }).ToList();
        }
        public List<КлиентModel> procedd812(string s)
        {

            return dB.Reports.procedd812(s).Select(i => new КлиентModel { ФИО = i.ФИО, Баланс = i.Баланс, Номер_клиента = i.Номер_клиента}).ToList();
        }

        public List<ТарифModel> procedd8121(string s)
        {

            return dB.Reports.procedd8121(s).Select(i => new ТарифModel { Минута_межгород_стоимость=i.Минута_межгород_стоимость, Минута_международная_стоимость=i.Минута_международная_стоимость, Название_тарифа=i.Название_тарифа, Стоимость_перехода=i.Стоимость_перехода, Код_типа_тарифа_FK=i.Код_типа_тарифа_FK, Код_тарифа=i.Код_тарифа, Год_начала=i.Год_начала }).ToList();
        }
        public List<Dogovors1> procedd81211(string s)
        {
            return dB.Reports.procedd81211(s).Select(i => new Dogovors1 { Дата_заключения=i.Дата_заключения, Номер_договора=i.Номер_договора, Номер_телефона=i.Номер_телефона, Серийный_номер_сим_карты=i.Серийный_номер_сим_карты, Дата_расторжения=i.Дата_расторжения, Код_тарифа_FK=i.Код_тарифа_FK, Номер_клиента_FK=i.Номер_клиента_FK }).ToList();
        }


        public List<Dogovors2> procedd813(int kod)
        {
            return dB.Reports.procedd813(kod).Select(i => new Dogovors2 {  Номер_договора = i.Номер_договора, Номер_телефона = i.Номер_телефона,  Код_тарифа_FK = i.Код_тарифа_FK}).ToList();
        }


    }

}
