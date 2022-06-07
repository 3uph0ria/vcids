﻿using vcids.Models;
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
    /// Логика взаимодействия для PageClientService.xaml
    /// </summary>
    public partial class PageClientService : Page
    {
        public PageClientService(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridClientServices.ItemsSource = vcibsEntities.GetContext().ClientService.ToList();
        }

        public void Update()
        {
            var services = vcibsEntities.GetContext().ClientService.ToList();
            services = services.Where(p => p.Clients.Fullname.ToLower().Contains(Search.Text.ToLower())).ToList();
            DGridClientServices.ItemsSource = services;

        }


        private void BtnEditClientService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddClientService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtndelClientService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
