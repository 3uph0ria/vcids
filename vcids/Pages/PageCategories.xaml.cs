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
using vcids.Classes;
using vcids.Models;

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCategories.xaml
    /// </summary>
    public partial class PageCategories : Page
    {
        public PageCategories()
        {
            InitializeComponent();
            DGridServices.ItemsSource = vcibsEntities.GetContext().Categoris.ToList();
            Header.Text = "Категории";
        }

        public void Update()
        {
            var services = vcibsEntities.GetContext().Categoris.ToList();
            services = services.Where(p => p.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            DGridServices.ItemsSource = services;

        }

 

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategories(null));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            var serviceForDelete = DGridServices.SelectedItems.Cast<Categoris>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {serviceForDelete.Count} элементов?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    vcibsEntities.GetContext().Categoris.RemoveRange(serviceForDelete);
                    vcibsEntities.GetContext().SaveChanges();
                    DGridServices.ItemsSource = vcibsEntities.GetContext().Services.ToList();
                    MessageBox.Show("Удаление выделенных элементов прошло успешно");
                    NavManager.AccountFrame.Navigate(new PageCategories());
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



        private void BtnEditCategories_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategories((sender as Button).DataContext as Categoris));
        }
    }
}
