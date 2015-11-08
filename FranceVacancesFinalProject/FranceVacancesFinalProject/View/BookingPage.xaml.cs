using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class BookingPage : Page
    {
        public BookingPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            startDatePicker.Date = DateTimeOffset.Now.AddDays(1);
            endDatePicker.Date = DateTimeOffset.Now.AddDays(2);
        }


        private void checkAvailabilityButton_Click(object sender, RoutedEventArgs e)
        {
            commentTextBlock.Text = "Start: " + startDatePicker.Date.Value.ToString("dd MMMM yyyy") + "\nEnd: " +
                                    endDatePicker.Date.Value.ToString("dd MMMM yyyy");
        }



        // Methods to Navigate
        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (PaymentPage), null);
        }

        private void cancelPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
    
            Frame.Navigate(typeof(LoginPage), null);
        }

     
    }
}

