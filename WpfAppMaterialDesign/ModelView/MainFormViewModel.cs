using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppMaterialDesign.Commands;
using BLL;
using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
using BLL.Models.ReportModels;
using System.Reflection.Metadata;
using iTextSharp.xmp.impl;
using System.IO;

namespace WpfAppMaterialDesign.ModelView
{
 
    class MainFormViewModel : INotifyPropertyChanged
    {
        IDbCrud crudServ;
        private readonly ClientsService _clientService = new ClientsService();
        ObservableCollection<КлиентModel> Клиентs;
        ObservableCollection<ТарифModel> Тарифs;
        ObservableCollection<DogovorModel> Dogovors;
        ObservableCollection<DogovorModel> Dogovors1;
        ObservableCollection<Dogovors> Dogovori;
        ObservableCollection<Dogovors1> Dogovori1;
        ObservableCollection<CallModel> Calls;
        List<КлиентModel> AllКлиент;
        IDbCrud dbo;
        private КлиентModel selectedClient;
        private ТарифModel selectedTarif;
        private DogovorModel selectedDogovor;
        IReportService reportservice;

        public static Action КлиентSpisanie;



        System.Windows.Controls.DataGrid grid;
        System.Windows.Controls.DataGrid grid1;
        System.Windows.Controls.DataGrid grid11;
        System.Windows.Controls.DataGrid grid2;
        System.Windows.Controls.DataGrid grid22;
        System.Windows.Controls.DataGrid grid33;
        System.Windows.Controls.TextBox Textbox1;
        System.Windows.Controls.TextBox Textbox2;
        System.Windows.Controls.TextBox Textbox3;
        System.Windows.Controls.TextBox Textbox4;
        //  ObservableCollection<Dogovors> Dogovors;
        Entities dBContext = new Entities();

        public MainFormViewModel(IDbCrud dbCrud, System.Windows.Controls.DataGrid  dataGrid1, System.Windows.Controls.DataGrid dataGrid2, System.Windows.Controls.DataGrid dataGrid3, IReportService reportserv, /*System.Windows.Controls.DataGrid dataGrid4,*/ /*System.Windows.Controls.DataGrid dataGrid5,*/ /*System.Windows.Controls.DataGrid dataGrid6,*/ System.Windows.Controls.TextBox textBox1, System.Windows.Controls.TextBox textBox2, System.Windows.Controls.TextBox textBox3, System.Windows.Controls.TextBox textBox4) //IDbCrud dbCrud, DataGrid dataGrid
        {
            //grid =  dataGrid4;
            //grid1 = dataGrid5;
            //grid2 = dataGrid6;
            grid11 = dataGrid1;
            grid22 = dataGrid2;
            grid33 = dataGrid3;
            Textbox1 = textBox1;
            Textbox2 = textBox2;
            Textbox3 = textBox3;
            Textbox4 = textBox4;
            dbo = dbCrud;
            loadClient(grid11);
            loadTarif(dataGrid2);
            loadDogovor(dataGrid3);
            reportservice = reportserv;
            Window2ViewModel.КлиентAdd += OnКлиентAdd;
            КлиентSpisanie += OnКлиентAdd;
            Window1ViewModel.DogovorAdd += OnDogovorAdd;
            Window3ViewModel.ТарифAdd += OnТарифAdd;
            //  Клиент = new ObservableCollection<WpfAppMaterialDesign.Model.Клиент>(_clientService.GetКлиент());

        }

      private void OnКлиентAdd()
        {
    
            loadClient(grid11);
        }
        private void OnDogovorAdd()
        {

            loadDogovor(grid33);
        }
        private void OnТарифAdd()
        {

            loadTarif(grid22);
        }
        public КлиентModel SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
              
                dBContext.SaveChanges();
            }
        }

        public DogovorModel SelectedDogovor
        {
            get { return selectedDogovor; }
            set
            {
                selectedDogovor = value;
                OnPropertyChanged("SelectedDogovor");

                dBContext.SaveChanges();
            }
        }
        private RelayCommand addClientCommand;
        public RelayCommand AddClientCommand
        {

            get
            {
                return addClientCommand ??
                  (addClientCommand = new RelayCommand(obj =>
                  {


                      // SelectedClient = клиент;

                  


                  }));
            }
        }
        private RelayCommand addDogovorCommand;
        public RelayCommand AddDogovorCommand
        {

            get
            {
                return addDogovorCommand ??
                  (addDogovorCommand = new RelayCommand(obj =>
                  {
                     try { }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }
        // команда удаления
        private RelayCommand removeClientCommand;
        public RelayCommand RemoveClientCommand
        {
            get
            {
                return removeClientCommand ??
                  (removeClientCommand = new RelayCommand(obj =>
                  {
                      КлиентModel клиент = obj as КлиентModel;
                      if (клиент != null)
                      {
                          try
                          {

                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();
                              dbo.DeleteКлиент(SelectedClient.Номер_клиента);
                              Клиентs.Remove(клиент);
                              dbo.GetAllКлиент();
                              MessageBox.Show("Клиент успешно удален из базы!");
                              // Клиент.Remove(клиент);
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);

                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }
        private RelayCommand removeDogovorCommand;
        public RelayCommand RemoveDogovorCommand
        {
            get
            {
                return removeDogovorCommand ??
                  (removeDogovorCommand = new RelayCommand(obj =>
                  {
                      DogovorModel dogovor = obj as DogovorModel;
                      if (dogovor != null)
                      {
                          try
                          {

                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();
                              dbo.DeleteDogovor(SelectedDogovor.Номер_договора);
                              Dogovors.Remove(dogovor);
                              dbo.GetAllDogovor();
                       
                              // Клиент.Remove(клиент);
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);

                          }

                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }
        private RelayCommand updateClientCommand;
        public RelayCommand UpdateClientCommand
        {
            get
            {
                return updateClientCommand ??
                  (updateClientCommand = new RelayCommand(obj =>
                  {
                      КлиентModel клиент = obj as КлиентModel;
                      if (клиент != null)
                      {
                          try
                          {
                              dbo.UpdateКлиент(клиент);

                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();

                              // Клиент.Remove(клиент);
                              MessageBox.Show("Данные о клиенте успешно обновлены!");
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }





        private RelayCommand spisanieCommand;
        public RelayCommand SpisanieCommand
        {
            get
            {
                return spisanieCommand ??
                  (spisanieCommand = new RelayCommand(obj =>
                  {
                      КлиентModel клиент = obj as КлиентModel;
                      if (клиент != null)
                      {
                          try
                          {
                              int count = int.Parse(Textbox4.Text);
                              SelectedClient.Баланс -= count;
                              dbo.UpdateКлиент(клиент);


                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();

                              // Клиент.Remove(клиент);
                              MessageBox.Show("Списание произошло успешно!");
                              КлиентSpisanie?.Invoke();

                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }




        private RelayCommand updateDogovorCommand;
        public RelayCommand UpdateDogovorCommand
        {
            get
            {
                return updateDogovorCommand ??
                  (updateDogovorCommand = new RelayCommand(obj =>
                  {
                      DogovorModel dogovor = obj as DogovorModel;
                      if (dogovor != null)
                      {
                          try
                          {
                              dbo.UpdateDogovor(dogovor);

                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();

                              // Клиент.Remove(клиент);
                              MessageBox.Show("Данные о договоре успешно обновлены!");
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }



        private RelayCommand blockCommand;
        public RelayCommand BlockCommand
        {
            get
            {
                return blockCommand ??
                  (blockCommand = new RelayCommand(obj =>
                  {
                  
                
                      {
                          try
                          {
                              
                              Клиентs = new ObservableCollection<КлиентModel>(Клиентs.Where(t => t.Баланс < '0' & t.Баланс !=0));
                              grid11.ItemsSource = Клиентs;
                             
                            
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }




        public void loadClient(System.Windows.Controls.DataGrid grid11)
        {
            Клиентs = new ObservableCollection<КлиентModel>(dbo.GetAllКлиент());
            grid11.ItemsSource = Клиентs;
        }


        public void loadTarif(System.Windows.Controls.DataGrid grid22)
        {
            Тарифs = new ObservableCollection<ТарифModel>(dbo.GetAllТариф());
            grid22.ItemsSource = Тарифs;
        }

        //    
        public void loadDogovor(System.Windows.Controls.DataGrid grid33)
        {
            Dogovors = new ObservableCollection<DogovorModel>(dbo.GetAllDogovor());
            grid33.ItemsSource = Dogovors;
        }
       
        // public List<КлиентModel> Клиентs { get; set; }
        //IDbCrud dbo;



        public ТарифModel SelectedTarif
        {
            get { return selectedTarif; }
            set
            {
                selectedTarif = value;
                OnPropertyChanged("SelectedTarif");

                dBContext.SaveChanges();
            }
        }


        // public void loadClient(DataGrid dataGrid)
        //    {
        //
        ///      Клиентs = dbo.GetAllКлиент();
        //   dataGrid.DataSource = Клиентs;

        // dataGrid.Refresh();
        //dBContext.Клиент.Load();

        // dataGrid.DataSource = Клиентs;


        //  }
        // команда добавления нового объекта
        private RelayCommand addTarifCommand;
        public RelayCommand AddTarifCommand
        { 
       
            get
            {       
                return addTarifCommand ??
                  (addTarifCommand = new RelayCommand(obj =>
                  {
                    try { }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }

        // команда удаления
        private RelayCommand removeTarifCommand;
        public RelayCommand RemoveTarifCommand
        {
            get
            {
                return removeTarifCommand ??
                  (removeTarifCommand = new RelayCommand(obj =>
                  {
                      ТарифModel тариф = obj as ТарифModel;
                      if (тариф != null)
                      {

                          try
                          {
                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();
                              dbo.DeleteТариф(SelectedTarif.Код_тарифа);
                              Тарифs.Remove(тариф);
                              dbo.GetAllТариф();
                              // Клиент.Remove(клиент);
                              MessageBox.Show("Тариф успешно удален!");
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }
        private RelayCommand updateTarifCommand;
        public RelayCommand UpdateTarifCommand
        {
            get
            {
                return updateTarifCommand ??
                  (updateTarifCommand = new RelayCommand(obj =>
                  {
                      ТарифModel тариф = obj as ТарифModel;
                      if (тариф != null)
                      {
                          try
                          {
                              dbo.UpdateТариф(тариф);

                              //    dBContext.Клиент.Remove(клиент);
                              //     dBContext.SaveChanges();
                              //     dBContext.Тариф.Load();

                              // Клиент.Remove(клиент);
                              MessageBox.Show("Данные о тарифе успешно обновлены!");
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                              }
                      }
                  }));
                //      },
                //условие, при котором будет доступна команда
                //     (obj) => (Клиент.Count > 0 && selectedClient != null)));
            }
        }
      
        private RelayCommand report2Command;
        public RelayCommand Report2Command
        {

            get
            {
                return report2Command ??
                  (report2Command = new RelayCommand(obj =>
                  {
                      try
                      {
                          Window6 f6 = new Window6();
                          f6.ShowDialog();
                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();
                      //    CallModel j = new CallModel();
                         // Calls = new ObservableCollection<CallModel>(reportservice.procedd81(Convert.ToInt32(f6.comboBox1.Text)));

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());

                          //grid1.ItemsSource = Calls;
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }
        private RelayCommand report3Command;
        public RelayCommand Report3Command
        {

            get
            {
                return report3Command ??
                  (report3Command = new RelayCommand(obj =>
                  {
                      try
                      {

                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();
                          КлиентModel j = new КлиентModel();
                          Клиентs = new ObservableCollection<КлиентModel>(reportservice.procedd812((Textbox1.Text)));

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());

                          grid11.ItemsSource = Клиентs;
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }



        private RelayCommand report4Command;
        public RelayCommand Report4Command
        {

            get
            {
                return report4Command ??
                  (report4Command = new RelayCommand(obj =>
                  {
                      try
                      {

                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();
                          ТарифModel j = new ТарифModel();
                          Тарифs = new ObservableCollection<ТарифModel>(reportservice.procedd8121((Textbox2.Text)));

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());

                          grid22.ItemsSource = Тарифs;
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }
        private RelayCommand report5Command;
        public RelayCommand Report5Command
        {

            get
            {
                return report5Command ??
                  (report5Command = new RelayCommand(obj =>
                  {
                      try
                      {

                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();
                          Dogovors1 j = new Dogovors1();
                          Dogovori1 = new ObservableCollection<Dogovors1>(reportservice.procedd81211((Textbox3.Text)));

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());

                          grid33.ItemsSource = Dogovori1;
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
                              p.PrintVisual(grid11, "Печать");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }
                  }));
            }
        }


        private RelayCommand print2;
        public RelayCommand Print2
        {
            get
            {
                return print2 ??
                  (print2 = new RelayCommand(obj =>
                  {
                      try
                      {
                          System.Windows.Controls.PrintDialog p = new System.Windows.Controls.PrintDialog();
                          if (p.ShowDialog() == true)
                          {
                              p.PrintVisual(grid, "Печать");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }

                  }));
            }
        }
        private RelayCommand print3;
        public RelayCommand Print3
        {
            get
            {
                return print3 ??
                  (print3 = new RelayCommand(obj =>
                  {
                      try
                      {
                          System.Windows.Controls.PrintDialog p = new System.Windows.Controls.PrintDialog();
                          if (p.ShowDialog() == true)
                          {
                              p.PrintVisual(grid, "Печать");
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
        private RelayCommand copyCommand;
        private IDbCrud db;
       
    }

}
