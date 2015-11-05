using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    class Customer
    {
        private string _name;
        private string _address;
        private string _email;
        private string _phonenumber;
        private string _customerID;

        public Customer(string name, string address, string email, string phonenumber, string customerID)
        {
            _name = name;
            _address = address;
            _email = email;
            _phonenumber = phonenumber;
            _customerID = customerID;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address;}
            set { _address = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }



    }
}
