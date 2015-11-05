using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesFinalProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PaymentPage : Page
    {
        public PaymentPage()
        {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (CityPage), null);
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {
           
            Frame.Navigate(typeof (MainPage), null);
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage), null);

        }
    }
}
