using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace BLL.Models
{
  public class CallModel
    {
       public DateTime Дата_и_время { get; set; }
        public int Длительность { get; set; }
        public decimal Стоимость { get; set; }
        public int Номер_договора_FK { get; set; }
        public int Код_типа_звонка_FK { get; set; }
        public CallModel() { }
        public CallModel(Call m)
        {
            Дата_и_время = m.Дата_и_время;
            Длительность = m.Длительность;
            Стоимость = m.Стоимость;
            Номер_договора_FK = m.Номер_договора_FK;
            Код_типа_звонка_FK = m.Код_типа_звонка_FK;

        }
    }
}
