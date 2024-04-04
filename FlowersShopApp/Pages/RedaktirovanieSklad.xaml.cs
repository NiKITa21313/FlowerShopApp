using FlowersShopApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RedaktirovanieSklad.xaml
    /// </summary>
    public partial class RedaktirovanieSklad : Page
    {
        public Sklad sklad;
        public Shop_Model context;
        public RedaktirovanieSklad(int id)
        {
            InitializeComponent();
            btnAdd.Visibility = Visibility.Collapsed;
            btnSave.Visibility = Visibility.Collapsed;
            if (id != 0)
            {
                btnSave.Visibility = Visibility.Visible;
                context = Shop_Model.GetContext();
                sklad = Shop_Model.GetContext().Sklad.Where(s => s.id_sklada == id).FirstOrDefault();
                txbAdres.Text = sklad.adres;
                txbZvety.Text = sklad.Zvety.imya;
                txbKolichestvo.Text = sklad.kolichestvo.ToString();
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
                var zvetok = context.Zvety.Where(z => z.imya == txbZvety.Text).FirstOrDefault();
                if (zvetok != null)
                {
                    sklad.id_zvetov = zvetok.id_zvetov;
                }
                else
                {
                    MessageBox.Show("Таких цветов нет в базе данных");
                }
                sklad.adres = IsAddres(txbAdres.Text);
                sklad.kolichestvo = Convert.ToInt32(txbKolichestvo.Text);
                context.Entry(sklad).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Данные изменены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string IsAddres(string addres)
        {
            Regex format = new Regex(@"[а-яА-Я*\s]*\s\d+");
            if (format.Match(addres).Success)
            {
                return addres;
            }
            else
            {
                MessageBox.Show("Сначала введите улицу, а затем номер дома!!!");
                return "";
            }
        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sklad sklad = new Sklad();
                var context = Shop_Model.GetContext();
                sklad.id_sklada = new Random().Next(300, 1000);
                sklad.adres = IsAddres(txbAdres.Text);
                var zvetok = context.Zvety.Where(z => z.imya == txbZvety.Text).FirstOrDefault();
                if (zvetok != null)
                {
                    sklad.id_zvetov = zvetok.id_zvetov;
                }
                else
                {
                    MessageBox.Show("Таких цветов нет в базе данных");
                }
                sklad.kolichestvo = Convert.ToInt32(txbKolichestvo.Text);
                if (context != null)
                {
                    context.Sklad.Add(sklad);
                    context.SaveChanges();
                    MessageBox.Show("Склад добавлен");
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
