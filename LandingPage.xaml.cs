using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WhatsOnHerMind
{
    public partial class LandingPage : PhoneApplicationPage
    {
        public string AppIntro
        {
            get
            {
                return "Having trouble understanding your girlfriend's mind?\n Want to know why or when she is getting mad?\n This app is to help you better understand girls by using machine learning!";
            }
        }
        // Constructor
        public LandingPage()
        {
            InitializeComponent();
            IntroText.DataContext = this;
        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            //var messageDialog = new ContentDialog();
            if(Helper.login(usernametextbox.Text, passwordtextbox.Password))
            {
                NavigationService.Navigate(new Uri("/MainAppPage.xaml", UriKind.Relative));
            }
            else
            {
                // TODO: POPUP APPEAR
                LoginPopup.IsOpen = true;
            } 
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegisterPage.xaml", UriKind.Relative));
        }

        private void PasswordBoxKeyup(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                this.LogInButtonClick(sender, e);
            }
        }

        private void UsernameBoxKeyup(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                passwordtextbox.Focus();
            }
        }
    }
}