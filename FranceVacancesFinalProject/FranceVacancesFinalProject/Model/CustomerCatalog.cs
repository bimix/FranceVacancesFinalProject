using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FranceVacancesFinalProject.Common;
using FranceVacancesFinalProject.Model;
using FranceVacancesFinalProject.Persistency;

namespace FranceVacancesFinalProject.Model
{

    public class CustomerCatalog
    {
        public ObservableCollection<CustomerInfo> CustomerInfos { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public int SelectedIndex { get; set; }


        // Commented out because this should be in the LoginPageView !
        // public RelayCommand AddCustomerInfoCommand { get; set; }
        // public RelayCommand RemoveCustomerInfoCommand { get; set; }
        // public RelayCommand GetCustomerInfoCommand { get; set; }
        // public RelayCommand SaveCustomerInfoCommand { get; set; }

        public CustomerCatalog()
        {
            // AddCustomerInfoCommand = new RelayCommand(Add);
            // RemoveCustomerInfoCommand = new RelayCommand(RemoveAt);
            // GetCustomerInfoCommand = new RelayCommand(LoadCustomerInfos);
            // SaveCustomerInfoCommand = new RelayCommand(SaveCustomerInfos);


            CustomerInfos = new ObservableCollection<CustomerInfo>();
            CustomerInfos.Add(new CustomerInfo("David", "45", "davi@gmail.com", "34554667", "23456"));
            CustomerInfos.Add(new CustomerInfo("Jerry", "78", "jerry@yahoomail.com", "6778998", "345678"));
            CustomerInfos.Add(new CustomerInfo("Jame", "320", "james@hotmail.com", "4567788", "567899"));
        }

        public void Add()
        {
            CustomerInfos.Add(new CustomerInfo(Name, Address, Email, Phonenumber, Password));
        }

        public void RemoveAt()
        {
            if (SelectedIndex > -1)
            {
                CustomerInfos.RemoveAt(SelectedIndex);
            }
        }

        private async void LoadCustomerInfos()
        {
            var customerInfos = await PersistencyService.LoadCustomerInfosFromJsonAsync();
            if (customerInfos != null)
            {
                CustomerInfos.Clear();
                foreach (var customerInfo in customerInfos)
                {
                    CustomerInfos.Add(customerInfo);
                }
            }
        }

        private async void SaveCustomerInfos()

        {
            PersistencyService.SaveCustomerInfosAsJsonAsync(CustomerInfos);
        }
    }
}


