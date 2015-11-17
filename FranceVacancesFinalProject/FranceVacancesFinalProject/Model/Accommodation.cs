using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    class Accommodation
    {
        private int _accommodationID;
        private int _size;
        private string _location;
        private string _address;
        private double _priceForOneNight;
        private List<string> _pictureURLList;
        private Availability _availability;

        public Accommodation(int accommodatonID, int size, string location, double priceForOneNight)
        {
            _accommodationID = accommodatonID;
            _size = size;
            _location = location;
            _priceForOneNight = priceForOneNight;

        }

        public int AccommodationID
        {
            get { return _accommodationID; }
            set { _accommodationID = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public double PriceForOneNight
        {
            get { return _priceForOneNight; }
            set { _priceForOneNight = value; }
        }

        public Availability Availability
        {
            get { return _availability;}
        }
        
        
        
        // Methods -------------------------


        //Method to add a picture URL.
        public void AddPictureURL(string URL)
        {
            _pictureURLList.Add(URL);
        }

        public void GetAvailability(int accommodationID)
        {
           
        }

    }
}
