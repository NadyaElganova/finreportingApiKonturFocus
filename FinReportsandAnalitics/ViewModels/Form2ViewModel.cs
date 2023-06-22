using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Views.Windows;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FinReportsandAnalitics.ViewModels
{
    public class Form2ViewModel : ViewModelBase
    {


        private List<OrganizationData> _organization;
        private ObservableCollection<FinResultReport> _finResultReports;
        private FinResultReport _FinResultReport = new FinResultReport();

        public ICommand ShowForm2ViewCommand { get; }

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

        public Form2ViewModel(List<OrganizationData> organizations)

        {
            Organization = organizations;

            _finResultReports = new ObservableCollection<FinResultReport>();
            FinResultReports = _FinResultReport.BuildFinResultReport(organizations);
            //  MessageBox.Show(FinResultReports[0].DateOfBalanse.ToString());
            ShowForm2ViewCommand = new ViewModelCommand(ExecuteShowForm2ViewCommand);
        }



        private void ExecuteShowForm2ViewCommand(object obj)
        {
            Form2Window form2Window = new Form2Window(Organization);
            form2Window.Show();
        }


    }


}
