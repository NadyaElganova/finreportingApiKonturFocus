using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf.Ui.Common.Interfaces;

namespace FinReportsandAnalitics.ViewModels
{
    public partial class MyMainViewModel: ObservableObject, INavigationAware
    {
        public void OnNavigatedFrom()
        {

        }
        public void OnNavigatedTo()
        {

        }
        [ObservableProperty]
        private ObservableCollection<OrganizationData> organizationDatas = new ObservableCollection<OrganizationData> ();

        [ObservableProperty]
        private ObservableCollection<BuhForm> buhForms = new ObservableCollection<BuhForm>();

        [ObservableProperty]
        private ObservableCollection<CodRow> form1 = new ObservableCollection<CodRow>();

        [ObservableProperty]
        private ObservableCollection<CodRow> form2 = new ObservableCollection<CodRow>();

        private readonly ReportService _reportService = new ReportService();

        [RelayCommand]
        public async Task GetBuhForms()
        {
            //после выполнения этой команды в Grid информация не отоброжается!
            string Inn = "6663003127";
            organizationDatas = await _reportService.GetRequestBuhFormsAsync(Inn);
            MessageBox.Show(organizationDatas[0].Ogrn.ToString());
        }

        public MyMainViewModel()
        {
            _reportService = new ReportService();
            organizationDatas = new ObservableCollection<OrganizationData>();
            //так делать нельзя! нужно сделать через команду! Но это работает, а команда нет 
            MessageBox.Show(LoadInfo().GetAwaiter().ToString());
        }

        private async Task LoadInfo()
        {
            string Inn = "6663003127";
            organizationDatas = await _reportService.GetRequestBuhFormsAsync(Inn);
        }
    }
}
