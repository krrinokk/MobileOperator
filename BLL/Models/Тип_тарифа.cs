using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
  public  class Тип_тарифаModel
    {

        public int Код_типа_тарифа { get; set; }
        public string Название_типа_тарифа { get; set; }
        public Тип_тарифаModel() { }

        public Тип_тарифаModel(Тип_тарифа m)
        {
            Код_типа_тарифа = m.Код_типа_тарифа;
            Название_типа_тарифа = m.Название_типа_тарифа;

        }
    }
}
