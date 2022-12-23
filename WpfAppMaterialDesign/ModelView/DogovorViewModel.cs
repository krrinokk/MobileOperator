using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using BLL;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.Entity;
using Microsoft.SqlServer.Server;
using System.Data.Entity.Infrastructure;
using Microsoft.Win32;


using WpfAppMaterialDesign;
using WpfAppMaterialDesign.Commands;
using WpfAppMaterialDesign.Model;
using WpfAppMaterialDesign.View;

namespace WpfAppMaterialDesign.ModelView
{
    class DogovorViewModel /*: INotifyPropertyChanged*/
    {


        //MainWindow1 f1 = new MainWindow1();

        ////Window3 f3 = new Window3();
        ////Entities dBContext = new Entities();
        ////List<WpfAppMaterialDesign.Model.Dogovor> dogovors;
        ////List<Клиент> клиентs;
        ////List<WpfAppMaterialDesign.Model.Тариф> тарифs;


        //private readonly DogovorsService _dogovorsService = new DogovorsService();
        //public DogovorViewModel()
        //{
        //    Dogovors = new ObservableCollection<Dogovor>(_dogovorsService.GetDogovor());
        //}

        //private RelayCommand _addDogovorCommand;
        //private RelayCommand _addDogovorCommand;
        //private RelayCommand _addTarifCommand;
        //public RelayCommand AddDogovorCommand => _addDogovorCommand ??
        //          (_addDogovorCommand = new RelayCommand(obj =>
        //          {
        //              Window1 f1 = new Window1();
        //              f1.ShowDialog();
        //              Dogovor dogovor = new Dogovor();
        //              dogovor.Дата_заключения = f1.dateTimePicker1.DisplayDate;
        //              dogovor.Дата_расторжения = f1.dateTimePicker2.SelectedDate;
        //              dogovor.Код_тарифа_FK = int.Parse(f1.textBox6.Text);
        //              dogovor.Номер_договора = int.Parse(f1.textBox2.Text);
        //              dogovor.Номер_клиента_FK = int.Parse(f1.textBox7.Text);
        //              dogovor.Номер_телефона = f1.textBox3.Text;
        //              dogovor.Серийный_номер_сим_карты = f1.textBox4.Text;


        //              dBContext.Клиент.Add(newclient);
        //              dBContext.SaveChanges();

        //              f1.DataGridView1.Refresh();
        //              dBContext.Клиент.Load();
        //              клиентs = dBContext.Клиент.ToList();

        //              _dogovorsService.AddDogovor(dogovor);
        //              Dogovors = new ObservableCollection<Dogovor>(_dogovorsService.GetDogovor());
        //              OnPropertyChanged(nameof(Dogovors));



        //          }));



        //public RelayCommand AddDogovorCommand => _addDogovorCommand ??
        //        (_addDogovorCommand = new RelayCommand(obj =>
        //        {


        //            f3.ShowDialog();

        //            Тариф newтариф = new Тариф();
        //            newтариф.Минута_межгород_стоимость = decimal.Parse(f3.textBox60.Text);
        //            newтариф.Минута_международная_стоимость = decimal.Parse(f3.textBox20.Text);
        //            newтариф.Название_тарифа = f3.textBox70.Text;
        //            newтариф.Код_типа_тарифа_FK = int.Parse(f3.textBox30.Text);
        //            newтариф.Код_тарифа = int.Parse(f3.textBox40.Text);
        //            newтариф.Год_начала = int.Parse(f3.textBox90.Text);
        //            newтариф.Стоимость_перехода = int.Parse(f3.textBox10.Text);


        //            dBContext.Тариф.Add(newтариф);
        //            dBContext.SaveChanges();

        //            //  DataGridView1.Refresh();
        //            dBContext.Тариф.Load();
        //            тарифs = dBContext.Тариф.ToList();
        //            f1.DataGridView2.ItemsSource = тарифs;


        //        }));





        //private RelayCommand _saveClientCommand;
        //public RelayCommand SaveCommand => _saveClientCommand ??
        //          (_saveClientCommand = new RelayCommand(obj =>
        //          {
        //              _dogovorsService.Update(SelectedDogovor);
        //          }));

        //public ObservableCollection<Dogovor> Dogovors { get; set; }

        //private Клиент _selectedDogovor;
        //public Клиент SelectedDogovor
        //{
        //    get
        //    {
        //        return _selectedDogovor;
        //    }
        //    set
        //    {
        //        _selectedDogovor = value;
        //        OnPropertyChanged(nameof(SelectedDogovor));
        //    }
        //}

        //#region Ovverides of INotifyPropertyChanged
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //#endregion


    }
}
