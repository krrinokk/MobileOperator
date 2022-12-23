using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMaterialDesign.Model
{
    public class Call : INotifyPropertyChanged
    {
        public Call()
        { }
        public Call(DAL.Models.Call m)
        {
            Дата_и_время = m.Дата_и_время;
            Длительность = m.Длительность;
            Стоимость = m.Стоимость;
            Номер_договора_FK = m.Номер_договора_FK;
            Код_типа_звонка_FK = m.Код_типа_звонка_FK;

        }



        public DateTime дата_и_время { get; set; }
        public int длительность { get; set; }
        public decimal стоимость { get; set; }
        public int номер_договора_FK { get; set; }
        public int код_типа_звонка_FK { get; set; }


        public DateTime Дата_и_время
        {
            get => дата_и_время;
            set
            {
                дата_и_время = value;
                OnPropertyChanged(nameof(Дата_и_время));
            }
        }
        public int Длительность
        {
            get => длительность;
            set
            {
                длительность = value;
                OnPropertyChanged(nameof(Длительность));
            }
        }
        public decimal Стоимость
        {
            get => стоимость;
            set
            {
                стоимость = value;
                OnPropertyChanged(nameof(Стоимость));
            }
        }
        public int Номер_договора_FK
        {
            get => номер_договора_FK;
            set
            {
                номер_договора_FK = value;
                OnPropertyChanged(nameof(Номер_договора_FK));
            }
        }



        public int Код_типа_звонка_FK
        {
            get => код_типа_звонка_FK;
            set
            {
                код_типа_звонка_FK = value;
                OnPropertyChanged(nameof(Код_типа_звонка_FK));
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
