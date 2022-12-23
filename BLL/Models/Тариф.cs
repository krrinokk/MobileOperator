using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
 public class ТарифModel
    {

        public decimal? Минута_межгород_стоимость { get; set; }
        public decimal Минута_международная_стоимость { get; set; }
        public string Название_тарифа { get; set; }
        public decimal Стоимость_перехода { get; set; }
        public int Код_типа_тарифа_FK { get; set; }
        public int Код_тарифа { get; set; }
        public int? Год_начала { get; set; }
        public ТарифModel() { }

        public ТарифModel(Тариф m)
        {
            Минута_межгород_стоимость = m.Минута_межгород_стоимость;
            Минута_международная_стоимость = m.Минута_международная_стоимость;
            Название_тарифа = m.Название_тарифа;
            Код_типа_тарифа_FK = m.Код_типа_тарифа_FK;
            Код_тарифа = m.Код_тарифа;
            Год_начала = m.Год_начала;
            Стоимость_перехода = m.Стоимость_перехода;
        }
    }
}