﻿using FinReportsandAnalitics.Models;
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
using System.Windows.Shapes;

namespace FinReportsandAnalitics.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для Form2Window.xaml
    /// </summary>
    public partial class Form2Window : Window
    {
        public Form2Window(List<OrganizationData> organizations)
        {

            InitializeComponent();
            var viewModel = new Form2ViewModel(organizations);

            // Установка DataContext для окна на экземпляр ViewModel
            DataContext = viewModel;


        }
    }
}
