using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows;
using BLL.Interfaces;
namespace WpfAppMaterialDesign.Model
{
   
    public class Клиент : INotifyPropertyChanged
    {



        public Клиент()
        { }
        public Клиент(DAL.Models.Клиент клиент)
        {
            Баланс = (int)клиент.Баланс;
            ФИО = клиент.ФИО;
            Номер_клиента = клиент.Номер_клиента;
        
        }
        private int номер_клиента;
        private string фио;
        private decimal баланс;

        public int Номер_клиента
        {
            // get { return номер_клиента; }
                get => номер_клиента;
            set
            {
                номер_клиента = value;
                //  OnPropertyChanged("номер");
                OnPropertyChanged(nameof(Номер_клиента));
            }
        }
        public string ФИО
        {
            get => фио;
            set
            {
                фио = value;
                OnPropertyChanged(nameof(ФИО));
            }
        }
        public int Баланс
        {
            get => (int)баланс;
            set
            {
                баланс = value;
                OnPropertyChanged(nameof(Баланс));
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
