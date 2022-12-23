﻿using BLL.Interfaces;
using BLL.Util;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppMaterialDesign.ModelView;
using WpfAppMaterialDesign.ModelView.Util;

namespace WpfAppMaterialDesign.View
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            var kernel = new StandardKernel(new NinjectRegistration(), new ServiceModule("Entities"));
            IDbCrud db = kernel.Get<IDbCrud>();
            IReportService report = kernel.Get<IReportService>();
            DataContext = new Window5ViewModel(report, dataGrid5, dateTimePicker1, dateTimePicker2, PrintGrid);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // System.Windows.Application.Current.Shutdown();
            this.Close();
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
    }
}
