using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinReportsandAnalitics.ViewModels
{
    internal class AnaliticViewModel : ViewModelBase
    {

        //---- листы с коэффциента "[0]= базовый год, [1] базовый год-1 и так далее, приходят из словаря,
        //который возвращает метод в AnaliticServise.GetBasicBalanceСoefficients:-----------
        private List<double> _absoluteLiquidity;
        private List<double> _urgentLiquidity;
        private List<double> _autonomy;
        private List<double> _coefficientCoverageFixedAssetsOwnFunds;
        
        
        //-----вспомогательные данные
        private List<Dictionary<string, double>> _keyValuePairs;
        private List<OrganizationData> _organization;
        private AnaliticServise analiticServise;
        private ObservableCollection<FinResultReport> _finResultReports;
        private FinResultReport _FinResultReport = new FinResultReport();
        private string _conclusion { get; set; }
        private BalanceRepot _BalanceRepot = new BalanceRepot();
        private ObservableCollection<BalanceRepot> _balanceRepots;
        #region Propertis:
        public string Conclusion
        {
            get
            {
                return _conclusion;
            }
            set
            {
                _conclusion = value;
                OnPropertyChanged(nameof(_conclusion));
            }
        }

        public List<double> AbsoluteLiquidity
        {
            get
            {
                return _absoluteLiquidity;
            }
            set
            {
                _absoluteLiquidity = value;
                OnPropertyChanged(nameof(_absoluteLiquidity));
            }
        }
        public List<double> UrgentLiquidity
        {
            get
            {
                return _urgentLiquidity;
            }
            set
            {
                _urgentLiquidity = value;
                OnPropertyChanged(nameof(_urgentLiquidity));
            }
        }
        public List<double> Autonomy
        {
            get
            {
                return _autonomy;
            }
            set
            {
                _autonomy = value;
                OnPropertyChanged(nameof(_autonomy));
            }
        }
        public List<double> CoefficientCoverageFixedAssetsOwnFunds
        {
            get
            {
                return _coefficientCoverageFixedAssetsOwnFunds;
            }
            set
            {
                _coefficientCoverageFixedAssetsOwnFunds = value;
                OnPropertyChanged(nameof(_coefficientCoverageFixedAssetsOwnFunds));
            }
        }

        public List<Dictionary<string, double>> KeyValuePairs
        {
            get
            {
                return _keyValuePairs;
            }
            set
            {
                _keyValuePairs = value;
                OnPropertyChanged(nameof(_keyValuePairs));
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
        #endregion


        public AnaliticViewModel(List<OrganizationData>? organizations)
        {

          _absoluteLiquidity = new List<double>();
          _urgentLiquidity = new List<double>();
          _autonomy = new List<double>();
          _coefficientCoverageFixedAssetsOwnFunds= new List<double>();

             analiticServise = new AnaliticServise();
            _finResultReports= _FinResultReport.BuildFinResultReport(organizations);
            _balanceRepots= _BalanceRepot.BuildBalanse(organizations);
            _keyValuePairs= analiticServise.GetBasicBalanceСoefficients(FinResultReports, BalanceReports);
            _keyValuePairs.ForEach(x =>
            {
                AbsoluteLiquidity.Add(x["AbsoluteLiquidity"]);
                UrgentLiquidity.Add(x["UrgentLiquidity"]);
                Autonomy.Add(x["Autonomy"]);
                CoefficientCoverageFixedAssetsOwnFunds.Add(x["CoefficientCoverageFixedAssetsOwnFunds"]);
            }
            );

                         
            Conclusion=analiticServise.GetSimpleAnaliticalReport(FinResultReports, BalanceReports);
           
           // MessageBox.Show(AbsoluteLiquidity[0].ToString());
        }





    }
}
