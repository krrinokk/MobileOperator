using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfAppMaterialDesign.Model
{
    class Тариф : INotifyPropertyChanged
    {
        public Тариф()
        { }
        public Тариф(DAL.Models.Тариф тариф)
        {
            Минута_межгород_стоимость = (int)тариф.Минута_межгород_стоимость;
            Минута_международная_стоимость = (int)тариф.Минута_международная_стоимость;
            Название_тарифа = тариф.Название_тарифа;
            Код_типа_тарифа_FK = тариф.Код_типа_тарифа_FK;
            Код_тарифа = тариф.Код_тарифа;
            Год_начала = (int)тариф.Год_начала;
            Стоимость_перехода = тариф.Стоимость_перехода;

        }
        private decimal минута_межгород_стоимость;
        private decimal минута_международная_стоимость;
        private string название_тарифа;
        private int код_типа_тарифа_FK;
        private int год_начала;
        private decimal стоимость_перехода;
        private int код_тарифа;


        public decimal Стоимость_перехода
        {
            // get { return номер_клиента; }
            get => стоимость_перехода;
            set
            {
                минута_межгород_стоимость = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(Стоимость_перехода));
            }
        }

        public int Год_начала
        {
            // get { return номер_клиента; }
            get => год_начала;
            set
            {
                минута_межгород_стоимость = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(год_начала));
            }
        }



        public int Код_тарифа
        {
            // get { return номер_клиента; }
            get => код_тарифа;
            set
            {
                минута_межгород_стоимость = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(Код_тарифа));
            }
        }



        public int Код_типа_тарифа_FK
        {
            // get { return номер_клиента; }
            get => (int)код_типа_тарифа_FK;
            set
            {
                минута_межгород_стоимость = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(Код_типа_тарифа_FK));
            }
        }


        public int Минута_межгород_стоимость
        {
            // get { return номер_клиента; }
            get => (int)минута_межгород_стоимость;
            set
            {
                минута_межгород_стоимость = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(Минута_межгород_стоимость));
            }
        }
        public int Минута_международная_стоимость
        {
            get => (int)минута_международная_стоимость;
            set
            {
                минута_международная_стоимость = value;
                OnPropertyChanged(nameof(Минута_международная_стоимость));
            }
        }
        public string Название_тарифа
        {
            get => название_тарифа;
            set
            {
                название_тарифа = value;
                OnPropertyChanged(nameof(Название_тарифа));
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