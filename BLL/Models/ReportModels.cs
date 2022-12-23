using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.ReportModels
{

  
    public class Dogovors
    {
        public int Код_тарифа_FK { get; set; }
        public DateTime Дата_заключения { get; set; }

        public string Номер_телефона { get; set; }
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

    public class Result
    {
        public int Код_тарифа_FK { get; set; }
        public DateTime Дата_заключения { get; set; }

        public string Номер_телефона { get; set; }
    }


}
