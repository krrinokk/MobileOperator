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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BLL;
using BLL.Interfaces;
using BLL.Models;
using System.Collections.ObjectModel;
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
using BLL.Models.ReportModels;

namespace WpfAppMaterialDesign.ModelView
{
    class Window8ViewModel : INotifyPropertyChanged

    {
        IDbCrud crudServ;
        System.Windows.Controls.Grid printGrid;
        private readonly ClientsService _clientService = new ClientsService();
        ObservableCollection<КлиентModel> Клиентs;
        ObservableCollection<ТарифModel> Тарифs;
   
        ObservableCollection<DogovorModel> Dogovors2;
        ObservableCollection<Dogovors2> Dogovori2;
        IDbCrud dbo;
        IReportService reportservice;
        ObservableCollection<CallModel> Calls;
        private КлиентModel selectedClient;
        private ТарифModel selectedTarif;
        Entities dBContext = new Entities();
        System.Windows.Controls.ComboBox ComboBox1;
        System.Windows.Controls.DataGrid grid;
        private RelayCommand report;

        public Window8ViewModel(IReportService report, IDbCrud dbCrud, System.Windows.Controls.DataGrid dataGrid7, System.Windows.Controls.ComboBox comboBox1, System.Windows.Controls.Grid PrintGrid)
        {
            reportservice = report;
            grid = dataGrid7;
            dbo = dbCrud;
            ComboBox1 = comboBox1;
            LoadComboboxTarif(ComboBox1);
            printGrid = PrintGrid;




        }
        public RelayCommand Report
        {

            get
            {
                return report ??
                  (report = new RelayCommand(obj =>
                  {
                      try
                      {
                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();
                          Dogovors2 j = new Dogovors2();
                          Dogovori2 = new ObservableCollection<Dogovors2>(reportservice.procedd813(Convert.ToInt32(ComboBox1.Text)));

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());

                          grid.ItemsSource = Dogovori2;
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));

            }
        }


        private RelayCommand print;
        public RelayCommand Print
        {
            get
            {
                return print ??
                  (print = new RelayCommand(obj =>
                  {
                      try
                      {
                          System.Windows.Controls.PrintDialog p = new System.Windows.Controls.PrintDialog();
                          if (p.ShowDialog() == true)
                          {
                              p.PrintVisual(printGrid, "Печать");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }
                  }));
            }
        }

        public void LoadComboboxTarif(System.Windows.Controls.ComboBox ComboBox1)
        {
          Тарифs = new ObservableCollection<ТарифModel>(dbo.GetAllТариф());
            ComboBox1.ItemsSource = Тарифs;
            ComboBox1.DisplayMemberPath = "Код_тарифа";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private RelayCommand copyCommand;
        private IDbCrud db;

    }
}