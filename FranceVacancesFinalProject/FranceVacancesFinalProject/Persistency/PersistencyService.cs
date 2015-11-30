using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using FranceVacancesFinalProject.Model;
using Newtonsoft.Json;

namespace FranceVacancesFinalProject.Persistency
{
    //Json.Net er downloaded til projektet via NuGet: Højreklik på projektet -> Manage NuGet Package

    public class PersistencyService
    {
        private static string JsonFileName = "CustomerInfosAsJson.dat";

        public static async void SaveCustomerInfosAsJsonAsync(ObservableCollection<CustomerInfo> customerInfos)
        {
            string customerInfosJsonString = JsonConvert.SerializeObject(customerInfos);
            SerializeCustomerInfosFileAsync(customerInfosJsonString, JsonFileName);
        }

        public static async Task<List<CustomerInfo>> LoadCustomerInfosFromJsonAsync()
        {
            string customerInfosJsonString = await DeserializeCustomerInfosFileAsync(JsonFileName);
            if (customerInfosJsonString != null)
            {
                return (List<CustomerInfo>)JsonConvert.DeserializeObject(customerInfosJsonString, typeof(List<CustomerInfo>));
            }
            return null;
        }

        private static async void SerializeCustomerInfosFileAsync(string customerInfosJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, customerInfosJsonString);
        }


        private static async Task<string> DeserializeCustomerInfosFileAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {
                MessageDialogHelper.Show("Loading for the first time? - Try Add and Save some Notes before trying to Save for the first time", "File not Found");
                return null;
            }
        }
        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }

    }
}



