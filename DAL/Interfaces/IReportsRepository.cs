using System;
using System.Collections.Generic;

using DAL.Models;
namespace DAL.Interfaces
{
    public interface IReportsRepository
    {

        List<Dogovors> procedd8(DateTime start, DateTime end);
        List<Calls> procedd81(int kod);
        List<Clients> procedd812(string s);
        List<Tarifs> procedd8121(string s);
        List<Dogovors1> procedd81211(string s);
        List<Dogovors2> procedd813(int kod);


    }
}
