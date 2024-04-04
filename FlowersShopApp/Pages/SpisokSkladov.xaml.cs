using FlowersShopApp.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlowersShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SpisokSkladov.xaml
    /// </summary>
    public partial class SpisokSkladov : Page
    {
        public SpisokSkladov()
        {
            InitializeComponent();
            var context = Shop_Model.GetContext();
            var sklad = context.Sklad.Include(e => e.id_zvetov).Select(e => new { adres = e.adres, zvety = e.Zvety.imya, kolichestvo = e.kolichestvo, id_sklada = e.id_sklada }).ToList();
            lvSklady.ItemsSource = sklad;
        }

        private void lvSklady_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)//двойное нажатие на элемент списка
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var sklad = lvSklady.SelectedItem as dynamic;
                int id = sklad.id_sklada;
                NavigationService.Navigate(new RedaktirovanieSklad(id));
            }
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedaktirovanieSklad(0));
        }

        private void btnRemove_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var sotr = lvSklady.SelectedItem as dynamic;
            int id = sotr.id_sklada;
            try
            {
                var sklad = Shop_Model.GetContext().Sklad.Find(id);
                Shop_Model.GetContext().Sklad.Remove(sklad);
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
