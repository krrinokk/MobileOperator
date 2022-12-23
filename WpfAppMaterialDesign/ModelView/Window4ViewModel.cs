using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppMaterialDesign.Commands;
using BLL;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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

namespace WpfAppMaterialDesign.ModelView
{
    class Window4ViewModel

    {
        public Window4ViewModel() {}

        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {

            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {

                     
                        
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);

                      }


                  }));
            }
        }

    }
}
