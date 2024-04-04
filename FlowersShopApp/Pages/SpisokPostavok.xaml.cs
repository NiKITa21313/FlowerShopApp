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
    /// Логика взаимодействия для SpisokPostavok.xaml
    /// </summary>
    public partial class SpisokPostavok : Page
    {
        public SpisokPostavok()
        {
            InitializeComponent();
            var context = Shop_Model.GetContext();
            var postavka = context.Postavki.Include(e => e.id_zvetov).Select(e => new { postavschik = e.Postavschiki.naimenovanie, zvety = e.Zvety.imya, kolichestvo = e.kolichestvo, data = e.data_postavki, id_postavki = e.id_postavki}).ToList();
            lvPostavki.ItemsSource = postavka;

        }

        private void lvPostavki_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)//двойное нажатие на элемент списка
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var postavka = lvPostavki.SelectedItem as dynamic;
                int id = postavka.id_postavki;
                NavigationService.Navigate(new RedaktirovaniePostavki(id));
            }
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)//добавить
        {
            NavigationService.Navigate(new RedaktirovaniePostavki(0));
        }

        private void btnReplace_Click(object sender, System.Windows.RoutedEventArgs e)//удалить
        {
            var post = lvPostavki.SelectedItem as dynamic;
            int id = post.id_postavki;
            try
            {
                var users = Shop_Model.GetContext().Postavki.Find(id);
                Shop_Model.GetContext().Postavki.Remove(users);
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
