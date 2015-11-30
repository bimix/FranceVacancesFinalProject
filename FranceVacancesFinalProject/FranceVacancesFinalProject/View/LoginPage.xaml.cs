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
using FranceVacancesFinalProject.Model;
using FranceVacancesFinalProject.Persistency;
using FranceVacancesFinalProject.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FranceVacancesFinalProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        public RoutedEventHandler loginButton_Click { get; private set; }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dataList = await PersistencyService.LoadCustomerInfosFromJsonAsync();
            string name = txtUserName.Text;
            string pass = txtPass.Password;


            foreach (var list in dataList)
            {
                if ((list.Name == name) && (list.Password == pass))
                {
                    Frame.Navigate(typeof(MainPage), null);
                }
                else
                {
                    MessageDialog dialog = new MessageDialog("password is incorrect !");
                    await dialog.ShowAsync();
                }

            }


        }


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
