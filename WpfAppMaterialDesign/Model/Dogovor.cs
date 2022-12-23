using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace WpfAppMaterialDesign.Model
{
    //public class Dogovor
    //{
    //    public DateTime Дата_заключения { get; set; }
    //    public int Номер_договора { get; set; }
    //    public string Номер_телефона { get; set; }
    //    public string Серийный_номер_сим_карты { get; set; }
    //    public DateTime Дата_расторжения { get; set; }
    //    public int Код_тарифа_FK { get; set; }
    //    public int Номер_клиента_FK { get; set; }
    //    public Dogovor() { }
    //    public Dogovor(Dogovor m)
    //    {
    //        Дата_заключения = m.Дата_заключения;
    //        Дата_расторжения = m.Дата_расторжения;
    //        Номер_договора = m.Номер_договора;
    //        Серийный_номер_сим_карты = m.Серийный_номер_сим_карты;
    //        Код_тарифа_FK = m.Код_тарифа_FK;
    //        Номер_клиента_FK = m.Номер_клиента_FK;

    //    }
    //}


    public class Dogovor : INotifyPropertyChanged
    {
        public Dogovor()
        { }
        public Dogovor(DAL.Models.Dogovor m)
       {
           Дата_заключения = m.Дата_заключения;
           Дата_расторжения = m.Дата_расторжения;
           Номер_договора = m.Номер_договора;
           Серийный_номер_сим_карты = m.Серийный_номер_сим_карты;
          Код_тарифа_FK = m.Код_тарифа_FK;
           Номер_клиента_FK = m.Номер_клиента_FK;

           }



        private DateTime дата_заключения;
        private DateTime дата_расторжения;
        private int номер_договора;
        private string серийный_номер_сим_карты;
        private int код_тарифа_FK;
        private int номер_клиента_FK;

        
        public DateTime Дата_заключения
        {
            get => дата_заключения;
            set
            {
                дата_заключения = value;
                OnPropertyChanged(nameof(Дата_заключения));
            }
        }
        public DateTime Дата_расторжения
        {
            get => дата_расторжения;
            set
            {
                дата_расторжения = value;
                OnPropertyChanged(nameof(Дата_расторжения));
            }
        }
        public int Номер_договора
        {
            get => номер_договора;
            set
            {
                номер_договора = value;
                OnPropertyChanged(nameof(Номер_договора));
            }
        }
        public string Серийный_номер_сим_карты
        {
            get => серийный_номер_сим_карты;
            set
            {
                серийный_номер_сим_карты = value;
                OnPropertyChanged(nameof(Серийный_номер_сим_карты));
            }
        }



        public int Код_тарифа_FK
        {
            get => код_тарифа_FK;
            set
            {
                код_тарифа_FK = value;
                OnPropertyChanged(nameof(Код_тарифа_FK));
            }
        }

        public int Номер_клиента_FK
        {
            get => номер_клиента_FK;
            set
            {
                номер_клиента_FK = value;
                OnPropertyChanged(nameof(Номер_клиента_FK));
            }
        }



        public ObservableCollection<string> Models { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }


}
