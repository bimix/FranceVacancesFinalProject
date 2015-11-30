using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranceVacancesFinalProject.Model;
using FranceVacancesFinalProject.Common;
using FranceVacancesFinalProject.View;
using System.Runtime.CompilerServices;

namespace FranceVacancesFinalProject.ViewModel
{

    /*
    This code is just for testing, we need to add data binding to CityPage.
    */
    class CityPageView : INotifyPropertyChanged
    {
        
        private Accommodation _accommodationOne;
        private Accommodation _accommodationTwo;
        private Accommodation _accommodationThree;
        private ObservableCollection<Accommodation> _accommodations;
        private Accommodation _selectedAccommodation;

        public CityPageView()
        {
            _accommodationOne = new Accommodation();
            _accommodationOne.AccommodationID = 1;
            _accommodationOne.Location = " Île de la Cité";
            _accommodationOne.Address = "blalalala";
            _accommodationOne.Size = "19m^2";
            _accommodationOne.PriceForOneNight = "42€";
            _accommodationOne.Details = "This modern and charming studio is ideal for 2 people and allow you to enjoy an unforgettable stay in the French capital. It has a sofa bed in the living room, a small table to enjoy your meals, a kitchen and a bathroom with shower  42€/night.";
            _accommodationOne.ImgUrl = "/Assets/Nice/Appartments/NiceApp1-2.jpg";

            _accommodationTwo = new Accommodation();
            _accommodationTwo.AccommodationID = 2;
            _accommodationTwo.Location = "Montmartre";
            _accommodationTwo.Size = "50m^2";
            _accommodationTwo.PriceForOneNight = "34€";
            _accommodationTwo.Details = "This magnificent 50m2 Parisian apartment, ideally located just 350m from the Sacré Coeur Basilica, is situated on the second floor of a charming, typical Montmartre building (without a lift) and looks out onto a paved, tree-lined square 34€/night.";
            _accommodationTwo.ImgUrl = "/Assets/Nice/Appartments/NiceApp2-2.jpg";


            _accommodationThree = new Accommodation();
            _accommodationThree.AccommodationID = 3;
            _accommodationThree.Location = "opposite the Louvre";
            _accommodationThree.Size = "21m^2";
            _accommodationThree.PriceForOneNight = "48€";
            _accommodationThree.Details = "This beautiful studio for two people has a sofa bed that will offer you the comfort you’ll need to rest at night, but during the day it can be changed into a couch so you can enjoy the space as a lounge room, where you will also find a wardrobe, a desk, and a kitchen 48€/night.";
            _accommodationTwo.ImgUrl = "/Assets/Nice/Appartments/NiceApp1-1.jpg";

            Accommodation a1 = new Accommodation() { AccommodationID = 1, Location = " Île de la Cité", Size = "19m^2", PriceForOneNight = "42€", Details = "This modern and charming studio is ideal for 2 people and allow you to enjoy an unforgettable stay in the French capital. It has a sofa bed in the living room, a small table to enjoy your meals, a kitchen and a bathroom with shower.  42€/night", ImgUrl = "/Assets/Nice/Appartments/NiceApp1-2.jpg" };
            Accommodation a2 = new Accommodation() { AccommodationID = 2, Location = "Montmartre", Size = "50m^2", PriceForOneNight = "34€", Details = "This magnificent 50m2 Parisian apartment, ideally located just 350m from the Sacré Coeur Basilica, is situated on the second floor of a charming, typical Montmartre building (without a lift) and looks out onto a paved, tree-lined square. 34€/night", ImgUrl = "/Assets/Nice/Appartments/NiceApp2-2.jpg" };
            Accommodation a3 = new Accommodation() { AccommodationID = 3, Location = "opposite the Louvre", Size = "21m^2", PriceForOneNight = "48€", Details = "This beautiful studio for two people has a sofa bed that will offer you the comfort you’ll need to rest at night, but during the day it can be changed into a couch so you can enjoy the space as a lounge room, where you will also find a wardrobe, a desk, and a kitchen. 48€/night", ImgUrl = "/Assets/Nice/Appartments/NiceApp1-1.jpg" };

            _accommodations = new ObservableCollection<Accommodation>();
            _accommodations.Add(a1);
            _accommodations.Add(a2);
            _accommodations.Add(a3);
        }


        public Accommodation AccommodationOne
        {
            get { return _accommodationOne; }
            set
            {
                _accommodationOne = value;
            }
        }

        public Accommodation AccommodationTwo
        {
            get { return _accommodationTwo; }
            set { _accommodationTwo = value; }
        }

        public Accommodation AccommodationThree
        {
            get { return _accommodationThree; }
            set { _accommodationThree = value; }
        }

        public ObservableCollection<Accommodation> Accommodations
        {
            get { return _accommodations; }
            set { _accommodations = value; }
        }
        public Accommodation SelectedAccommodation
        {
            get { return _selectedAccommodation; }
            set
            {
                _selectedAccommodation = value; OnPropertyChanged("SelectedAccommodation");
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
