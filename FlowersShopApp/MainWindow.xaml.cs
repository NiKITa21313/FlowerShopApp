using System;
using System.Windows;
using FlowersShopApp.Model;
using FlowersShopApp.Pages;

namespace FlowersShopApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMain.Navigate(new Avtor());
            Shop_Model.GetContext();
        }

        private void FrameMain_ContentRendered(object sender, EventArgs e)
        {
            if (FrameMain.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
            else 
            {
                btnBack.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.GoBack();
        }
    }
}
