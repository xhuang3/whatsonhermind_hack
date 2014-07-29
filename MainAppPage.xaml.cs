﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WhatsOnHerMind
{
    public partial class MainAppPage : PhoneApplicationPage
    {
        public MainAppPage()
        {
            InitializeComponent();
            ConclusionMade.DataContext = new MakeConclusion();
            DateListBox.ItemsSource = DateList.GetDateList();
        }

        private void EnterNewDateClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DatePicker.xaml", UriKind.Relative));
        }
    }
}