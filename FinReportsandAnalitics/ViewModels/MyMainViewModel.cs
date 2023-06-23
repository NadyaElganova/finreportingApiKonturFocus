using CommunityToolkit.Mvvm.Input;
using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Services;
using FinReportsandAnalitics.Views;
using FinReportsandAnalitics.Views.Windows;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FinReportsandAnalitics.ViewModels
{
    public class MyMainViewModel:ViewModelBase
    {
        
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;
        private string _inn;
        private List<OrganizationData> _organization;

        //Properties
       

         public List<OrganizationData> Organization
        {
            get
            {
                return _organization;
            }
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        public string Inn
        {
            get
            {
                return _inn;
            }
            set
            {
                _inn = value;
                OnPropertyChanged(nameof(Inn));
            }
        }

        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowSearchViewCommand { get; }
        public ICommand ShowForm1ViewCommand { get; }
        public ICommand ShowForm2ViewCommand { get; }
        public ICommand ShowAnalViewCommand { get; }
       
       public ICommand OpenForm1ViewCommand { get; }

        public MyMainViewModel()
        {
            //Initialize commands

           
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowSearchViewCommand = new ViewModelCommand(ExecuteShowSearchViewCommand);
            ShowForm1ViewCommand = new ViewModelCommand(ExecuteShowForm1ViewCommand);

            ShowForm2ViewCommand = new ViewModelCommand(ExecuteShowForm2ViewCommand);    
            
            OpenForm1ViewCommand=new ViewModelCommand(ExecuteOpenForm1ViewCommand);

           // ShowAnalViewCommand = new ViewModelCommand(ExecuteOpenForm1ViewCommand);
             ShowAnalViewCommand = new ViewModelCommand(ExecuteShowAnalitcsViewCommand);

            //Default view
            ExecuteShowHomeViewCommand(null);
            


        }

        private void ExecuteOpenForm1ViewCommand(object obj)
        {
            Form1Window form1Window = new Form1Window(Organization);
            form1Window.Show();
        }

        

        private void ExecuteShowForm2ViewCommand(object obj)
        {
            CurrentChildView = new Form2ViewModel(Organization);
            Caption = "Форма 2";
            Icon = IconChar.FileText;
        }

        private void ExecuteShowForm1ViewCommand(object obj)
        {
            
            CurrentChildView =new Form1ViewModel(Organization);
            Caption = "Форма 1";
            Icon = IconChar.FileText;
        }

        private void ExecuteShowSearchViewCommand(object obj)
        {
            CurrentChildView = new SearchViewModel();
            Caption = "История поиска";
            Icon = IconChar.Search;
        }
        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Домашняя";
            Icon = IconChar.Home;

        }

        private void ExecuteShowAnalitcsViewCommand(object obj)
        {
            CurrentChildView = new AnaliticViewModel(Organization);
            Caption = "Анализ";
            Icon = IconChar.FileText;

        }



    }
}
