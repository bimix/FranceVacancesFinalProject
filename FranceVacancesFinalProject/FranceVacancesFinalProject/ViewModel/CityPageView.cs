using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranceVacancesFinalProject.Model;

namespace FranceVacancesFinalProject.ViewModel
{
    
    /*
    This code is just for testing, we need to add data binding to CityPage.
    */
    internal class CityPageView : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Accommodation> aList { get; set; }

        public CityPageView()
        {

            aList = new ObservableCollection<Accommodation>();
            Accommodation acc1 = new Accommodation(123, 44, "paris", 852.2);
            Accommodation acc2 = new Accommodation(1234, 44, "Lyon", 852.2);
            aList.Add(acc1);
            aList.Add(acc2);
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
