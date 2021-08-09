using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder : IAddressBook
    {
        private LinkedList<ContactDetails> contactDetailsList; 

        public AddressBookBuilder()
        {
            this.contactDetailsList = new LinkedList<ContactDetails>();
        }

        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email)
        {
            ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            this.contactDetailsList.AddLast(contactDetails);
        }
       
    }
}
