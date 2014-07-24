using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WhatsOnHerMind.Resources;

namespace WhatsOnHerMind
{
    public partial class LandingPage : PhoneApplicationPage
    {
        // Constructor
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            if(Helper.login(usernametextbox.Text, passwordtextbox.Password))
            {
                NavigationService.Navigate(new Uri("/MainAppPage.xaml", UriKind.Relative));
            }
            else
            {
                // TODO: POPUP APPEAR
            } 
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegisterPage.xaml", UriKind.Relative));
        }
    }
}