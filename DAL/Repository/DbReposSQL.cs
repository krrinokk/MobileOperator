using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private Model1 dbContext;
        private ReportsRepositorySQL reportRepository;
        private КлиентRepositorySQL клиентRepository;
        private ТарифRepositorySQL тарифRepository;
        private DogovorRepositorySQL dogovorRepository;
        private Тип_тарифаRepositorySQL тип_тарифаRepository;
        public DbReposSQL()
        {
            dbContext = new Model1();
        }
        public IRepository<Клиент> Клиент
        {
            get
            {
                if (клиентRepository == null)
                    клиентRepository = new КлиентRepositorySQL(dbContext);
                return клиентRepository;
            }
        }

        public IReportsRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportsRepositorySQL(dbContext);
                return reportRepository;
            }
        }

        public IRepository<Dogovor> Dogovor
        {
            get
            {
                if (dogovorRepository == null)
                    dogovorRepository = new DogovorRepositorySQL(dbContext);
                return dogovorRepository;
            }
        }



        public IRepository<Тариф> Тариф
        {
            get
            {
                if (тарифRepository == null)
                    тарифRepository = new ТарифRepositorySQL(dbContext);
                return тарифRepository;
            }
        }



        public IRepository<Тип_тарифа> Тип_тарифа
        {
            get
            {
                if (тип_тарифаRepository == null)
                    тип_тарифаRepository = new Тип_тарифаRepositorySQL(dbContext);
                return тип_тарифаRepository;
            }
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }
    }
}
