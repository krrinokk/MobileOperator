using BLL;
using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMaterialDesign.ModelView.Util
{
    class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {

            Bind<IReportService>().To<ReportsService>();
            Bind<IDbCrud>().To<DBDataOperation>();

        }
    }
}
