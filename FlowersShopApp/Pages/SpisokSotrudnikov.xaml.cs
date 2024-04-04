using FlowersShopApp.Model;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlowersShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SpisokSotrudnikov.xaml
    /// </summary>
    public partial class SpisokSotrudnikov : Page
    {
        public SpisokSotrudnikov()
        {
            InitializeComponent();
            var context = Shop_Model.GetContext();
            var sotrudnik = context.Sotrudniki.Include(e => e.doljnost).Select(e => new { familiya = e.familiya, doljnost = e.Doljnosti.nazvanie, id_sotrudnika = e.id_sotrudnika }).ToList();
            lvSotrudniki.ItemsSource = sotrudnik;

        }

        private void myListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var sotr = lvSotrudniki.SelectedItem as dynamic;
                int id = sotr.id_sotrudnika;
                NavigationService.Navigate(new RedaktirovanieSotrudnika(id));
            }
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedaktirovanieSotrudnika(0));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var sotr = lvSotrudniki.SelectedItem as dynamic;
            int id = sotr.id_sotrudnika;
            try 
            {
                var users = Shop_Model.GetContext().Sotrudniki.Find(id);
                Shop_Model.GetContext().Sotrudniki.Remove(users);
                Shop_Model.GetContext().SaveChanges();
                MessageBox.Show("Удаление завершено");
                Shop_Model.GetContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
