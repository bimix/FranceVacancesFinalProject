using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    public class CustomerInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }

        public CustomerInfo()
        {
            Name = "";
            Address = "";
            Email = "";
            Phonenumber = "";
            Password = "";
        }

        public CustomerInfo(string name, string address, string email, string phonenumber, string password)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Password = password;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} , Adress: {1} , Email:{2}, Phonenumber{3}:, Passwword: {4},", Name, Address, Email, Phonenumber, Password);
        }
    }

}