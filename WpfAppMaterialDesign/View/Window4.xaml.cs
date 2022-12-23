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
using WpfAppMaterialDesign.ModelView;

namespace WpfAppMaterialDesign.View
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
 

        public Window4()
        {
            InitializeComponent();
        
            DataContext = new Window4ViewModel();
        }
     
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Application.Current.Shutdown();
            this.Close();        }

            private void btnMinimize_Click(object sender, RoutedEventArgs e)
            {
                WindowState = WindowState.Minimized;
            }
            private void Window_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
            }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            MainWindow1 f0 = new MainWindow1();
            this.Close();
            f0.ShowDialog();

        }
    }
}
