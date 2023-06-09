﻿using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Views.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinReportsandAnalitics.ViewModels
{
    public class Form1ViewModel : ViewModelBase
    {

        private List<OrganizationData> _organization;

        private ObservableCollection<string> _names;

        private ObservableCollection<BalanceRepot> _balanceRepots;


        private ObservableCollection<FinResultReport> _finResultReports;

        private BalanceRepot _BalanceRepot = new BalanceRepot();

        private FinResultReport _FinResultReport = new FinResultReport();


        public ICommand OpenForm1ViewCommand { get; }
      


        public ObservableCollection<FinResultReport> FinResultReports
        {
            get
            {
                return _finResultReports;
            }
            set
            {
                _finResultReports = value;
                OnPropertyChanged(nameof(_finResultReports));
            }
        }

        public ObservableCollection<BalanceRepot> BalanceReports
        {
            get
            {
                return _balanceRepots;
            }
            set
            {
                _balanceRepots = value;
                OnPropertyChanged(nameof(_balanceRepots));
            }
        }

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


     




        public Form1ViewModel(List<OrganizationData> organizations)
        {
            Organization = organizations;
            BalanceReports = new ObservableCollection<BalanceRepot>();


            _finResultReports= new ObservableCollection<FinResultReport>();

            _finResultReports = new ObservableCollection<FinResultReport>();


            FinResultReports = _FinResultReport.BuildFinResultReport(organizations);

            BalanceReports = _BalanceRepot.BuildBalanse(organizations);
         
            OpenForm1ViewCommand = new ViewModelCommand(ExecuteOpenForm1ViewCommand);
           
        }



        private void ExecuteOpenForm1ViewCommand(object obj)
        {
            Form1Window form1Window = new Form1Window(Organization);
            form1Window.Show();
        }






    }
}
