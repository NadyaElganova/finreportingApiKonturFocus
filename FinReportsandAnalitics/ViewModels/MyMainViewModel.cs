using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Services;
using FinReportsandAnalitics.Views;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public MyMainViewModel()
        {
            //Initialize commands
            
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowSearchViewCommand = new ViewModelCommand(ExecuteShowSearchViewCommand);
            ShowForm1ViewCommand = new ViewModelCommand(ExecuteShowForm1ViewCommand);
            ShowForm2ViewCommand = new ViewModelCommand(ExecuteShowForm2ViewCommand);
            
            //Default view
            ExecuteShowHomeViewCommand(null);
            
        [ObservableProperty]
        private ObservableCollection<CodRow> form1 = new ObservableCollection<CodRow>();

        [ObservableProperty]
        private ObservableCollection<CodRow> form2 = new ObservableCollection<CodRow>();

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
    }
}
