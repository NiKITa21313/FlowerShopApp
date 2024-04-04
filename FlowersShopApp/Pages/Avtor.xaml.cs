using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using FlowersShopApp.Model;
namespace FlowersShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Avtor.xaml
    /// </summary>
    public partial class Avtor : Page
    {
        public Avtor()
        {
            InitializeComponent();
            Shop_Model.GetContext();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string inputLogin = txtbLogin.Text.Trim();
            string inputParol = pswbPassword.Password.Trim();
            var context = Shop_Model.GetContext();
            var user = context.Users.Where(u => u.login == inputLogin && u.parol == inputParol).FirstOrDefault();//получение записи о User-е
            if (user != null)
            {
                var sotrudnik = context.Sotrudniki.Where(s => s.id_sotrudnika == user.id_sotrudnika).FirstOrDefault();//получение id сотрудника в таблице Sotrudniki
                int doljnost = sotrudnik.doljnost;//получеине кода должности
                LoadPage(doljnost);
            }
            else 
            {
                MessageBox.Show("Такого пользователя нет хээээх");
            }
        }

        private void btnEnterPokupatel_Click(object sender, RoutedEventArgs e)//переход на страницу покупателя
        {
            NavigationService.Navigate(new Pokupatel());
        }

        private void LoadPage(int id) 
        {
            if (id == 1) NavigationService.Navigate(new Admin());
            if (id == 2) NavigationService.Navigate(new Prodavez());
        }
    }
}
