using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace BLL.Models
{
    public class DogovorModel
    {
        public DateTime Дата_заключения { get; set; }
        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }
        public string Серийный_номер_сим_карты { get; set; }
        public DateTime Дата_расторжения { get; set; }
        public int Код_тарифа_FK { get; set; }
        public int Номер_клиента_FK { get; set; }
        public DogovorModel() { }
        public DogovorModel(Dogovor m)
        {
            Номер_телефона = m.Номер_телефона;
            Дата_заключения = m.Дата_заключения;
            Дата_расторжения = m.Дата_расторжения;
            Номер_договора = m.Номер_договора;
            Серийный_номер_сим_карты = m.Серийный_номер_сим_карты;
            Код_тарифа_FK = m.Код_тарифа_FK;
            Номер_клиента_FK = m.Номер_клиента_FK;

        }
    }
}
