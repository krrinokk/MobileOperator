using DAL;
using BLL;
using BLL.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        //    List<Dogovors> procedd8(DateTime start, DateTime end);
        List<Dogovors> procedd8(DateTime start, DateTime end);
        List<BLL.Models.CallModel> procedd81(int kod);
        List<BLL.Models.КлиентModel> procedd812(string s);
        List<BLL.Models.ТарифModel> procedd8121(string s);
        List<Dogovors1> procedd81211(string s);
      
        List<Dogovors2> procedd813(int kod);

   
    }
}
