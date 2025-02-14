﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowersShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnSklady_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SpisokSkladov());
        }

        private void btnPostavki_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SpisokPostavok());
        }

        private void btnSotrudniki_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SpisokSotrudnikov());
        }
    }
}
