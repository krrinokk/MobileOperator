using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppMaterialDesign.Commands;

namespace WpfAppMaterialDesign.ModelView
{
    class Window3ViewModel
    {
        Entities dBContext = new Entities();
        public decimal Минута_межгород_стоимость { get; set; }
        public decimal Минута_международная_стоимость { get; set; }
        public string Название_тарифа { get; set; }
        public decimal Стоимость_перехода { get; set; }
        public int Код_типа_тарифа_FK { get; set; }
        public int Код_тарифа { get; set; }
        public int Год_начала { get; set; }
        ObservableCollection<КлиентModel> Клиентs;
        ObservableCollection<ТарифModel> Тарифs;
        ObservableCollection<Тип_тарифаModel> Тип_тарифаs;
        IDbCrud dbo;
        private КлиентModel selectedClient;
        private ТарифModel selectedTarif;
        public static Action ТарифAdd;
        System.Windows.Controls.ComboBox comboBox2;
        public Window3ViewModel(IDbCrud dbCrud,  System.Windows.Controls.ComboBox comboBox2)
        {
            dbo = dbCrud;
          
            LoadComboboxTip_tarifa(comboBox2);
        }
        private RelayCommand addTarifCommand;
        public RelayCommand AddTarifCommand
        {

            get
            {
                return addTarifCommand ??
                  (addTarifCommand = new RelayCommand(obj =>
                  {
                      //try
                      //{
                          Тариф тариф = new Тариф();
                          тариф.Год_начала = Год_начала;
                          тариф.Код_тарифа = Код_тарифа;
                          тариф.Код_типа_тарифа_FK = Код_типа_тарифа_FK;
                          тариф.Минута_межгород_стоимость = Минута_межгород_стоимость;
                          тариф.Минута_международная_стоимость = Минута_международная_стоимость;
                          тариф.Название_тарифа = Название_тарифа;
                          тариф.Стоимость_перехода = Стоимость_перехода;

                          dBContext.Тариф.Add(тариф);

                          dBContext.SaveChanges();


                          dBContext.Тариф.Load();


                          //  _clientService.AddКлиент(клиент);
                          //  dBContext.SaveChanges();

                          //
                          //  Клиент = new ObservableCollection<Model.Клиент>(_clientService.GetКлиент());
                          OnPropertyChanged(nameof(Тариф));
                          MessageBox.Show("Тариф успешно добавлен в базу!");
                          ТарифAdd?.Invoke();
                      //}
                      //catch (Exception ex)
                      //{
                      //    MessageBox.Show(ex.Message);

                      //}

                  }));
            }
        }
        public void LoadComboboxTip_tarifa(System.Windows.Controls.ComboBox comboBox2)
        {
            Тип_тарифаs = new ObservableCollection<Тип_тарифаModel>(dbo.GetAllTip_tarifa());
            comboBox2.ItemsSource = Тип_тарифаs;
            comboBox2.DisplayMemberPath = "Код_типа_тарифа";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
