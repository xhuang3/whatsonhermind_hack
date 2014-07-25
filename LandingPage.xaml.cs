using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Navigation;

namespace WhatsOnHerMind
{
    public partial class LandingPage : PhoneApplicationPage
    {
        // Constructor
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            //var messageDialog = new ContentDialog();
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