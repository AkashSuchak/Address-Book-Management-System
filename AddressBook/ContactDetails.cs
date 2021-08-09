using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public interface IAddressBook
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email);
       
    }
    
    class ContactDetails
    {
        //Variables
        public string firstName; 
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string phoneNumber;
        public string email;

        public int zipCode;
        public ContactDetails(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
                                    
        }
    }
}
