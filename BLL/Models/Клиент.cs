using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace BLL.Models
{
   public class КлиентModel
    {
        public int Номер_клиента { get; set; }

       
        public string ФИО { get; set; }

 
        public decimal? Баланс { get; set; }

        public КлиентModel() { }

        public КлиентModel (Клиент m)
        {
            Номер_клиента = m.Номер_клиента;
            ФИО = m.ФИО;
            Баланс = m.Баланс;
        }


    }
}
