using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Microsoft.SqlServer.Server;
using System.Data.Entity.Infrastructure;
using BLL.Interfaces;
using BLL.Models;
using WpfAppMaterialDesign.Model;
using WpfAppMaterialDesign.View;
using WpfAppMaterialDesign.Commands;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace WpfAppMaterialDesign.ModelView
{
    class Window2ViewModel : INotifyPropertyChanged

    {
        IDbCrud crudServ;
        private readonly ClientsService _clientService = new ClientsService();
        ObservableCollection<КлиентModel> Клиентs;
        ObservableCollection<ТарифModel> Тарифs;
        IDbCrud dbo;
        private КлиентModel selectedClient;
        private ТарифModel selectedTarif;
        Entities dBContext = new Entities();
        public string ФИО { get; set; }
        public int Номер_клиента { get; set; }
        public decimal Баланс { get; set; }
        public static Action КлиентAdd;
        public Window2ViewModel() { }

        private RelayCommand addClientCommand;
        public RelayCommand AddClientCommand
        {

            get
            {
                return addClientCommand ??
                  (addClientCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          Клиент клиент = new Клиент();
                          клиент.Баланс = Баланс;
                          клиент.ФИО = ФИО;
                          клиент.Номер_клиента = Номер_клиента;
                          // SelectedClient = клиент;


                          //  dBContext.Клиент.Add(клиент);

                          dBContext.Клиент.Add(клиент);
                          //       dBContext.Клиент.Add(клиент);
                          dBContext.SaveChanges();


                          dBContext.Клиент.Load();


                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());
                          OnPropertyChanged(nameof(Клиент));
                          MessageBox.Show("Клиент успешно добавлен в базу!");
                          КлиентAdd?.Invoke();
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }




                  }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
