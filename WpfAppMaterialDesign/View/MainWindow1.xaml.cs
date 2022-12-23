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

using System.Windows.Forms;
using Ninject;
using System.Data.Entity;
using Microsoft.SqlServer.Server;
using System.Data.Entity.Infrastructure;
using WpfAppMaterialDesign.ModelView;
using WpfAppMaterialDesign.Commands;
using BLL.Interfaces;
//using DataGrid = System.Windows.Forms.DataGrid;
using DAL.Models;
using WpfAppMaterialDesign.ModelView.Util;
using BLL.Util;
namespace WpfAppMaterialDesign.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
      //  private DataGrid dataGrid;
      //  private IDbCrud dbCrud;
        //Entities dBContext = new Entities();
        //List<Dogovor> dogovors;
        //List<Клиент> клиентs;
        //List<Тариф> тарифs;
        // public IDbCrud dbo;
        //    public DataGrid dataGrid;
        public MainWindow1()
        {
            InitializeComponent();
       
            var kernel = new StandardKernel(new NinjectRegistration(), new ServiceModule("Entities"));
            IDbCrud db = kernel.Get<IDbCrud>();
            IReportService reportService = kernel.Get<IReportService>();
            //  DataContext = new ClientViewModel();
            //      IDbCrud db = kernel.Get<IDbCrud>();

          
            DataContext = new MainFormViewModel(db, DataGridView1, DataGridView2, DataGridView3, reportService, /*DataGridView4,*//* DataGridView5,*//* DataGridView6,*/ textBox1, textBox2, textBox3, textBox4);


        }
        //public void MainWindow1_Loaded()
        //{
        //    //DataGridView1.ItemsSource = dogovors.ToList();
        //}
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //   System.Windows.Application.Current.Shutdown();
            this.Close();
        }
        private void btnTarif_Click(object sender, RoutedEventArgs e)
        {


        }
        //private void btn3_Click(object sender, RoutedEventArgs e) //добавить нового клиента
        //{
        //    Window2 f2 = new Window2();
        //    f2.ShowDialog();

        //    Клиент newclient = new Клиент();
        //    newclient.Баланс = decimal.Parse(f2.textBox3.Text);
        //    newclient.Номер_клиента = int.Parse(f2.textBox2.Text);
        //    newclient.ФИО = f2.textBox1.Text;



        //    dBContext.Клиент.Add(newclient);
        //    dBContext.SaveChanges();

        //    //  DataGridView1.Refresh();
        //    dBContext.Клиент.Load();
        //    клиентs = dBContext.Клиент.ToList();
        //    DataGridView1.ItemsSource = клиентs;

        //    //   MessageBox.Show("Договор успешно заключен!");
        //    //   if (result == DialogResult.Cancel)
        //    //    {
        //    //        return;
        //    //    }
        //}
        private void btnKlient_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        //    private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        //    {
        //       this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        //    }
        //  private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //   {
        //       WindowInteropHelper helper = new WindowInteropHelper(this);
        //       SendMessage(helper.Handle, 161, 2, 0);
        //   }

        private void btn30_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn4_Click(object sender, RoutedEventArgs e) //заключить новый договор
        {
            //Window1 f = new Window1();
            //f.ShowDialog();


            //Dogovor newdogovor = new Dogovor();
            //newdogovor.Дата_заключения = f.dateTimePicker1.DisplayDate;
            //newdogovor.Дата_расторжения = f.dateTimePicker2.SelectedDate;
            //newdogovor.Код_тарифа_FK = int.Parse(f.textBox6.Text);
            //newdogovor.Номер_договора = int.Parse(f.textBox2.Text);
            //newdogovor.Номер_клиента_FK = int.Parse(f.textBox7.Text);
            //newdogovor.Номер_телефона = f.textBox3.Text;
            //newdogovor.Серийный_номер_сим_карты = f.textBox4.Text;

            //dBContext.Dogovor.Add(newdogovor);
            //dBContext.SaveChanges();

            ////  DataGridView1.Refresh();
            //dBContext.Dogovor.Load();
            //dogovors = dBContext.Dogovor.ToList();
            //DataGridView1.ItemsSource = dogovors;

            ////   MessageBox.Show("Договор успешно заключен!");
            ////   if (result == DialogResult.Cancel)
            ////    {
            ////        return;
            ////    }

        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn40_Click(object sender, RoutedEventArgs e)//добавить новый тариф
        {
            View.Window3 f3 = new View.Window3();
            f3.ShowDialog();


        }

        private void DataGridView1_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void AddClientCommand_Click(object sender, RoutedEventArgs e)
        {
            View.Window2 f2 = new View.Window2();
            f2.ShowDialog();
        }

        private void btn200_Click(object sender, RoutedEventArgs e)
        {
            View.Window1 f1 = new View.Window1();
            f1.ShowDialog();
        }

        private void ReportCommand1_Click(object sender, RoutedEventArgs e)
        {
            View.Window5 f5 = new View.Window5();
            f5.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ReportCommand11_Click(object sender, RoutedEventArgs e)
        {



            View.Window8 f8 = new View.Window8();
            f8.ShowDialog();

        }
    }
}
