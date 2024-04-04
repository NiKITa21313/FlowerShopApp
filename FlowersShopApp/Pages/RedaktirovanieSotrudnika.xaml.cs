using FlowersShopApp.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace FlowersShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для RedaktirovanieSotrudnika.xaml
    /// </summary>
    public partial class RedaktirovanieSotrudnika : Page
    {
        public Sotrudniki sotrudnik;
        public Shop_Model context;
        public RedaktirovanieSotrudnika(int id)
        {
            InitializeComponent();
            btnAdd.Visibility = Visibility.Collapsed;
            btnSave.Visibility = Visibility.Collapsed;
            if (id != 0)
            {
                btnSave.Visibility = Visibility.Visible;
                context = Shop_Model.GetContext();
                sotrudnik = Shop_Model.GetContext().Sotrudniki.Where(s => s.id_sotrudnika == id).FirstOrDefault();
                txbFamiliya.Text = sotrudnik.familiya;
                txbImya.Text = sotrudnik.imya;
                txbOtchestvo.Text = sotrudnik.otchestvo;
                txbDoljnost.Text = GetDolgnost(sotrudnik.doljnost);
                txbZarplata.Text = sotrudnik.zarplata.ToString();
            }
            else
            {
                btnAdd.Visibility = Visibility.Visible;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                sotrudnik.familiya = IsFIO(txbFamiliya.Text);
                sotrudnik.imya = IsFIO(txbImya.Text);
                sotrudnik.otchestvo = IsFIO(txbOtchestvo.Text);
                sotrudnik.doljnost = GetDolgnostId(txbDoljnost.Text);
                sotrudnik.zarplata = Convert.ToDouble(txbZarplata.Text);
                context.Entry(sotrudnik).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Данные изменены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetDolgnost(int id)
        {
            string doljnost = "";
            if (id == 1) doljnost = "Администратор";
            else if (id == 2) doljnost = "Продавец-консультант";
            return doljnost;
        }

        private int GetDolgnostId(string doljnost)
        {
            int id = 0;
            if (doljnost == "Администратор") id = 1;
            else if (doljnost == "Продавец-консультант") id = 2;
            else MessageBox.Show("Такой должности нет");
            return id;
        }
        private string IsFIO(string str)
        {
            Regex formatFIO = new Regex("[а-яА-Я]");
            if (formatFIO.Match(str).Success)
            {
                return str;
            }
            else
            {
                MessageBox.Show("Используйте кириллицу, без дополнительных символов!!!");
                return "";
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Sotrudniki sotrud = new Sotrudniki();
                var context = Shop_Model.GetContext();
                sotrud.id_sotrudnika = new Random().Next(300, 1000);
                sotrud.familiya = IsFIO(txbFamiliya.Text);
                sotrud.imya = IsFIO(txbImya.Text);
                sotrud.otchestvo = IsFIO(txbOtchestvo.Text);
                sotrud.doljnost = GetDolgnostId(txbDoljnost.Text);
                sotrud.zarplata = Convert.ToDouble(txbZarplata.Text);
                if (context != null)
                {
                    context.Sotrudniki.Add(sotrud);
                    context.SaveChanges();
                    MessageBox.Show("Сотрудник добавлен");
                }
                else 
                {
                    MessageBox.Show("Повторите попытку");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
