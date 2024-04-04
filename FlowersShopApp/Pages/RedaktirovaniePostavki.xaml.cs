using FlowersShopApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для RedaktirovaniePostavki.xaml
    /// </summary>
    public partial class RedaktirovaniePostavki : Page
    {
        public Postavki postavka;
        public Shop_Model context;
        public RedaktirovaniePostavki(int id)
        {
            InitializeComponent();
            btnAdd.Visibility = Visibility.Collapsed;
            btnSave.Visibility = Visibility.Collapsed;
            if (id != 0)
            {
                btnSave.Visibility = Visibility.Visible;
                context = Shop_Model.GetContext();
                postavka = Shop_Model.GetContext().Postavki.Where(s => s.id_postavki == id).FirstOrDefault();
                txbPostavschik.Text = postavka.Postavschiki.naimenovanie;
                txbZvety.Text = postavka.Zvety.imya;
                txbData.Text = postavka.data_postavki.ToString();
                txbKolichestvo.Text = postavka.kolichestvo.ToString();
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
                var postavschik = context.Postavschiki.Where(p => p.naimenovanie == txbPostavschik.Text).FirstOrDefault();
                if (postavschik != null)
                {
                    postavka.id_postavschika = postavschik.id_postavschika;
                }
                else
                {
                    MessageBox.Show("Такого поставщика нет в базе данных");
                }
                var zvetok = context.Zvety.Where(z => z.imya == txbZvety.Text).FirstOrDefault();
                if (zvetok != null)
                {
                    postavka.id_zvetov = zvetok.id_zvetov;
                }
                else
                {
                    MessageBox.Show("Таких цветов нет в базе данных");
                }
                postavka.data_postavki = IsDate(txbData.Text);
                postavka.kolichestvo = Convert.ToInt32(txbKolichestvo.Text);
                context.Entry(postavka).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Данные изменены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DateTime IsDate(string dateInput)
        {
            DateTime date;
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            if (DateTime.TryParseExact(dateInput, "yyyy-mm-dd", cultureInfo, DateTimeStyles.None, out date))
            {

            }
            else
            {
                MessageBox.Show("Используйте правильный формат yyyy-mm-dd ");
            }

            return date;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context = Shop_Model.GetContext();
                Postavki postavka = new Postavki();
                postavka.id_postavki = new Random().Next(150, 1000);
                var postavschik = context.Postavschiki.Where(p => p.naimenovanie == txbPostavschik.Text).FirstOrDefault();
                if (postavschik != null)
                {
                    postavka.id_postavschika = postavschik.id_postavschika;
                }
                else
                {
                    MessageBox.Show("Такого поставщика нет в базе данных");
                }
                var zvetok = context.Zvety.Where(z => z.imya == txbZvety.Text).FirstOrDefault();
                if (zvetok != null)
                {
                    postavka.id_zvetov = zvetok.id_zvetov;
                }
                else
                {
                    MessageBox.Show("Таких цветов нет в базе данных");
                }
                postavka.data_postavki = IsDate(txbData.Text);
                postavka.kolichestvo = postavka.kolichestvo = Convert.ToInt32(txbKolichestvo.Text);
                if (context != null)
                {
                    context.Postavki.Add(postavka);
                    context.SaveChanges();
                    MessageBox.Show("Поставка добавлена");
                }
                else 
                {
                    MessageBox.Show("Попробуйте снова");
                }
                
                
            }
            catch (Exception ex) 
            { 
            
            }
            
        }
    }
}
