using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IDbRepos
    {

        IRepository<Клиент> Клиент { get; }
        IRepository<Тариф> Тариф { get; }
        IRepository<Dogovor> Dogovor { get; }
        IRepository<Тип_тарифа> Тип_тарифа { get; }
        IReportsRepository Reports { get; }
        int Save();
    }

}
