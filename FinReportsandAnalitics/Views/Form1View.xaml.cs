using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinReportsandAnalitics.Views
{
    /// <summary>
    /// Логика взаимодействия для Form1View.xaml
    /// </summary>
    public partial class Form1View : UserControl
    {
        public Form1View(List<OrganizationData> Organization)
        {
            InitializeComponent();
          
                
            var viewModel = new Form1ViewModel(Organization);

            
            
            // Установка DataContext для окна на экземпляр ViewModel
           DataContext = viewModel;


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
