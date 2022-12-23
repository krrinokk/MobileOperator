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

namespace WpfAppMaterialDesign.ModelView
{
    class Window1ViewModel : INotifyPropertyChanged

    {
        IDbCrud crudServ;
        private readonly ClientsService _clientService = new ClientsService();
        ObservableCollection<КлиентModel> Клиентs;
        ObservableCollection<ТарифModel> Тарифs;
        ObservableCollection<DogovorModel> Dogovors;
        IDbCrud dbo;
        private КлиентModel selectedClient;
        private ТарифModel selectedTarif;
        Entities dBContext = new Entities();
        System.Windows.Controls.ComboBox comboBox1;
        public DateTime Дата_заключения { get; set; }
        public DateTime Дата_расторжения { get; set; }
        public int Номер_договора { get; set; }
        public string Номер_телефона { get; set; }
        public string Серийный_номер_сим_карты { get; set; }
        public int Код_тарифа_FK { get; set; }
        public int Номер_клиента_FK { get; set; }
        
        public static Action DogovorAdd;

        private RelayCommand addDogovorCommand;
        public RelayCommand AddDogovorCommand
        {

            get
            {
                return addDogovorCommand ??
                  (addDogovorCommand = new RelayCommand(obj =>
                  {

                      Dogovor dogovor = new Dogovor();
                      try
                      {
                          dogovor.Номер_клиента_FK = Номер_клиента_FK;
                          dogovor.Дата_заключения = Дата_заключения;
                          dogovor.Дата_расторжения = Дата_расторжения;
                          dogovor.Код_тарифа_FK = Код_тарифа_FK;
                          dogovor.Номер_договора = Номер_договора;

                          dogovor.Номер_телефона = Номер_телефона;
                          dogovor.Серийный_номер_сим_карты = Серийный_номер_сим_карты;


                          dBContext.Dogovor.Add(dogovor);
                          //       dBContext.Клиент.Add(клиент);
                          dBContext.SaveChanges();


                          dBContext.Dogovor.Load();


                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());
                          OnPropertyChanged(nameof(Dogovor));

                          DogovorAdd?.Invoke();
                          MessageBox.Show("Договор успешно добавлен!");
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }



                  }));
            }
        }



        public Window1ViewModel(IDbCrud dbCrud,System.Windows.Controls.ComboBox comboBox1, System.Windows.Controls.ComboBox comboBox2) {
            dbo = dbCrud;
            LoadComboboxTarif(comboBox1);
            LoadComboboxClient(comboBox2);
        }

        public void LoadComboboxTarif(System.Windows.Controls.ComboBox comboBox1)
        {
           Тарифs = new ObservableCollection<ТарифModel>(dbo.GetAllТариф());
            comboBox1.ItemsSource = Тарифs;
            comboBox1.DisplayMemberPath = "Код_тарифа";
        }
        public void LoadComboboxClient(System.Windows.Controls.ComboBox comboBox2)
        {
            Клиентs = new ObservableCollection<КлиентModel>(dbo.GetAllКлиент());
            comboBox2.ItemsSource = Клиентs;
            comboBox2.DisplayMemberPath = "Номер_клиента";
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
