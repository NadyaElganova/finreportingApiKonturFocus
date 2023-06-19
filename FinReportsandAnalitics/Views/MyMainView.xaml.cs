using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.ViewModels;
using FinReportsandAnalitics.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinReportsandAnalitics.Views
{
    /// <summary>
    /// Логика взаимодействия для MyMainView.xaml
    /// </summary>
    public partial class MyMainView : Window

    {
        List<OrganizationData> _Organization;
        public MyMainView(List<OrganizationData> Organization)
        {
            InitializeComponent();
            var viewModel = new MyMainViewModel();
            _Organization = new List<OrganizationData>();

            _Organization = Organization;

            // Присвоение значения переданного списка свойству OrganizationList в ViewModel
            viewModel.Organization = Organization;

            // Установка DataContext для окна на экземпляр ViewModel
            DataContext = viewModel;


        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper=new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void pnlControlBar_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else this.WindowState= WindowState.Normal;              
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Form1Window form1Window = new Form1Window(_Organization);
            form1Window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Form2Window form2Window = new Form2Window(_Organization);
            form2Window.Show();


        }
    }
}
