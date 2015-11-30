using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    public class Accommodation
    {
        private int _accommodationID;
        private string _size;
        private string _location;
        private string _address;
        private string _priceForOneNight;
        private string _details;
        private string _imgUrl;


        public Accommodation(int accommodatonID, string size, string location, string priceForOneNight)
        {
            _accommodationID = accommodatonID;
            _size = size;
            _location = location;
            _priceForOneNight = priceForOneNight;

        }

        public Accommodation()
        {
        }

        public int AccommodationID
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
        public string PriceForOneNight
        {
            get { return _priceForOneNight; }
            set { _priceForOneNight = value; }
        }
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
        public string ImgUrl
        {
            get { return _imgUrl; }
            set { _imgUrl = value; }
        }
        public override string ToString()
        {
            return string.Format(Location);
        }


        // Methods -------------------------


        //Method to add a picture URL.



    }
}
