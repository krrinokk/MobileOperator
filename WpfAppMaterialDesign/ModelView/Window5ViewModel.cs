using BLL.Interfaces;
using BLL.Models;
using BLL.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using WpfAppMaterialDesign.Commands;

namespace WpfAppMaterialDesign.ModelView
{
    class Window5ViewModel : INotifyPropertyChanged
    {
        System.Windows.Controls.Grid printGrid;
        System.Windows.Controls.DataGrid grid;
        System.Windows.Controls.DatePicker DateTimePicker1;
        System.Windows.Controls.DatePicker DateTimePicker2;
        ObservableCollection<DogovorModel> Dogovors;
        ObservableCollection<Dogovors> Dogovori;
        IReportService reportservice;
        private RelayCommand reportCommand;
     public  Window5ViewModel(IReportService report, System.Windows.Controls.DataGrid dataGrid5, System.Windows.Controls.DatePicker dateTimePicker1, System.Windows.Controls.DatePicker dateTimePicker2, System.Windows.Controls.Grid PrintGrid)
        {
            reportservice = report;
            grid = dataGrid5;
            DateTimePicker1 = dateTimePicker1;
            DateTimePicker2 = dateTimePicker2;
            printGrid = PrintGrid;
            

        }
        public RelayCommand ReportCommand
        {

            get
            {
                return reportCommand ??
                  (reportCommand = new RelayCommand(obj =>
                  {

                      try
                      {
                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());
                          Dogovors j = new Dogovors();
                          Dogovori = new ObservableCollection<Dogovors>(reportservice.procedd8((DateTime)DateTimePicker1.SelectedDate, (DateTime)DateTimePicker2.SelectedDate));

                          grid.ItemsSource = Dogovori;
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
