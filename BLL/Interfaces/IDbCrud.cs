using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
namespace BLL.Interfaces
{
    public interface IDbCrud
    {

        //   List   <DogovorModel> GetAllDogovor();

        //   DogovorModel GetDogovor(int dogvId);
        //       void CreateDogovor(DogovorModel dogv);
        //       void UpdateDogovor(DogovorModel dogv);
        //      void DeleteDogovor(int Id);

      List<КлиентModel> GetAllКлиент();

        КлиентModel GetКлиент(int clvId);
        void CreateКлиент(КлиентModel cl);
        void UpdateКлиент(КлиентModel cl);
        void DeleteКлиент(int id);




        List<ТарифModel> GetAllТариф();

        ТарифModel GetТариф(int trfId);
        void CreateТариф(ТарифModel trf);
        void UpdateТариф(ТарифModel trf);
        void DeleteТариф(int id);


        List<DogovorModel> GetAllDogovor();

        DogovorModel GetDogovor(int dgvId);
        void CreateDogovor(DogovorModel dgv);
        void UpdateDogovor(DogovorModel dgv);
        void DeleteDogovor(int id);


        List<Тип_тарифаModel> GetAllTip_tarifa();

        Тип_тарифаModel GetTip_tarifa(int dgvId);
        void CreateTip_tarifa(Тип_тарифаModel dgv);
        void UpdateTip_tarifa(Тип_тарифаModel dgv);
        void DeleteTip_tarifa(int id);



        //    BLL.Models.DogovorModel GetDogovor(int dogovorId);
        //     void CreateDogovor(BLL.Models.DogovorModel dogv);
        //void UpdateDogovor(BLL.Models.DogovorModel dogv);
        //    void DeleteDogovor(int id);
    }

}