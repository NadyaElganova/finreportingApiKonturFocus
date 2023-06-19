using FinReportsandAnalitics.Services;
using FinReportsandAnalitics.Views.Windows;
using FinReportsandAnalitics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace FinReportsandAnalitics.Views
{
    /// <summary>
    /// Логика взаимодействия для InnView.xaml
    /// </summary>
    public partial class InnView : Window
    {
        public InnView()
        {
            InitializeComponent();
        }
             
    
         

        private void Windows_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void btnInn_Click(object sender, RoutedEventArgs e)
        {
           //здесь вся логика с апи ключом и вытягиванием информации из контура
           //если все успешно, то открывается главная форма
           KonturSendReciever_ sendReciever = new KonturSendReciever_();
            var a = await KonturSendReciever_.GetRequestBuhFormsAsync(txtInn.Text);
           MyMainView myMainView = new MyMainView(a);
            myMainView.Show();
            
            
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static readonly Regex onlyNumbers = new Regex("[^0-9.-]+");
        private static bool IsTextAllowed(string text)
        {
            return !onlyNumbers.IsMatch(text);
        }
    }
}
