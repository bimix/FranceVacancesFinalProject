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
using FranceVacancesFinalProject.Model;

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
            StartDatePicker.MinDate = DateTime.Now;
            EndDatePicker.MinDate = DateTime.Now;

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }


        // Navigation methods.
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


        // Calendar picker methods.
        private void StartDatePicker_OnCalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            if (args.Item.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                args.Item.IsBlackout = true;
            }
        }

        private void EndDatePicker_OnCalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {

        }




        // Button click methods.
        private void checkAvailabilityButton_Click(object sender, RoutedEventArgs e)
        {
            priceInfoTextBlock.Text = PriceInfoText();
        }


        private int GetNumberOfDays()
        {
            int days;
            
            DateTimeOffset start = StartDatePicker.Date.Value;
            DateTimeOffset end = EndDatePicker.Date.Value;
            TimeSpan howManyDays = end - start;
            
            days = Int32.Parse(howManyDays.Days.ToString("D"));
            return days;
        }

        private double CalculatePrice()
        {
            double totalCost = 0;
            int days = GetNumberOfDays();
            // Here we need to get the price according to accommodation ID and calulate the total price.
            
            // double price = AccommodationID.PriceForOneNight
            //totalCost = days * price;
            return totalCost;
        }

        private string PriceInfoText()
        {
            string output = "";
            output += "Your chosen start date: " + StartDatePicker.Date.Value.ToString("dd MMMM yy");
            output += "\nYour chosen end date: " + EndDatePicker.Date.Value.ToString("dd MMMM yy");
            output += "\n\nTotal price for " + GetNumberOfDays() + " nights is: " + CalculatePrice();
            return output;
        }
    }
}

