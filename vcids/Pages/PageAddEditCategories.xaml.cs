using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для PageAddEditCategories.xaml
    /// </summary>
    public partial class PageAddEditCategories : Page
    {
        private Categoris _ccurrnetServices = new Categoris();
        public PageAddEditCategories(Categoris selectService)
        {
            InitializeComponent();
            if (selectService != null)
            {
                _ccurrnetServices = selectService;
            }

            DataContext = _ccurrnetServices;
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_ccurrnetServices.Id == 0)
                    vcibsEntities.GetContext().Categoris.Add(_ccurrnetServices);

                vcibsEntities.GetContext().SaveChanges();
                MessageBox.Show("Категория успешно сохранена");
                NavManager.AccountFrame.Navigate(new PageCategories());
            }
            catch (DbEntityValidationException ex)
            {
                if (ApplicationConfig.IsDev)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
