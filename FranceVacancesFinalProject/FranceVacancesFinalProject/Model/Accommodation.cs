using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    class Accommodation
    {
        private string _accommodationID;
        private string _size;
        private string _location;
        private string _address;
        private string _price;
        private List<string> _pictureURLList;
        private List<Availability> _availabilities;

        public Accommodation(string accommodatonID, string size, string location, string price)
        {
            _accommodationID = accommodatonID;
            _size = size;
            _location = location;
            _price = price;
            
        }

        public string AccommodationID
        {
            get { return _accommodationID; }
            set { _accommodationID = value; }
        }

        public string Size
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
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }




        // Methods -------------------------


        //Method to add a picture URL.
        public void AddPictureURL(string URL)
        {
            _pictureURLList.Add(URL);
        }

    }
}
