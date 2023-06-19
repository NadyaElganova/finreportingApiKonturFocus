using FinReportsandAnalitics.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.ViewModels
{
   public class Form2ViewModel:ViewModelBase
    {


        private List<OrganizationData> _organization;      
        private ObservableCollection<FinResultReport> _finResultReports;
        private FinResultReport _FinResultReport = new FinResultReport();


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
            _finResultReports = new ObservableCollection<FinResultReport>();     
            FinResultReports = _FinResultReport.BuildFinResultReport(organizations);

        }

        public Form2ViewModel()
        {
        

        }




    }
}
