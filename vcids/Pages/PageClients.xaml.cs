using vcids.Classes;
using vcids.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageClients.xaml
    /// </summary>
    public partial class PageClients : Page
    {
        public PageClients(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridClients.ItemsSource = vcibsEntities.GetContext().Clients.ToList();
        }

        public void Update()
        {
            var services = vcibsEntities.GetContext().Clients.ToList();
            services = services.Where(p => p.Fullname.ToLower().Contains(Search.Text.ToLower())).ToList();
            DGridClients.ItemsSource = services;

        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCLients((sender as Button).DataContext as Clients));
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCLients(null));
        }

        private void BtndelClient_Click(object sender, RoutedEventArgs e)
        {
            var serviceForDelete = DGridClients.SelectedItems.Cast<Clients>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {serviceForDelete.Count} клинета(ов)?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    vcibsEntities.GetContext().Clients.RemoveRange(serviceForDelete);
                    vcibsEntities.GetContext().SaveChanges();
                    DGridClients.ItemsSource = vcibsEntities.GetContext().Services.ToList();
                    MessageBox.Show("Удаление выделенных элементов прошло успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
