using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using FranceVacancesFinalProject.Common;
using FranceVacancesFinalProject.Model;
using FranceVacancesFinalProject.View;

namespace FranceVacancesFinalProject.ViewModel
{
    class BookingPageView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Public fields.
        public DateTimeOffset StartTimeFromCalendar { get; set; }
        public DateTimeOffset EndTimeFromCalendar { get; set; }
        public ObservableCollection<Availability> Availabilities { get; set; }

        private Accommodation _selectedAccommodation;
        

        // Relay commands.
        public RelayCommand GetStartTime { get; set; }
        public RelayCommand GetEndTime { get; set; }
        public RelayCommand BookButtonClicked { get; set; }


        public BookingPageView()
        {
           _selectedAccommodation = new Accommodation();
        }

        public int DoGetDays(DateTimeOffset start, DateTimeOffset end)
        {
            int days;
            TimeSpan howManyDays = end - start;
            days = Int32.Parse(howManyDays.Days.ToString("D"));
            return days;
        }

        public static void ReadSelectedAccommodation()
        {
            
        }

        public void WriteSelectedAccommodation()
        {
            Stream writeSteam = new FileStream("SelectedAccommodation.txt",FileMode.Create,FileAccess.Write, FileShare.Write);
            
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
