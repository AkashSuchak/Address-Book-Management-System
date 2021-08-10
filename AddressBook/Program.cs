using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Address Book Management System Development!");
            Console.WriteLine("======================================================");

            //Object of Contact Details
            ContactDetails CD = new ContactDetails();

            //Add Contact 
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            addressBookBuilder.AddContact(CD.firstName, CD.lastName, CD.address, CD.city, CD.state, CD.zipCode, CD.phoneNumber, CD.email);
            addressBookBuilder.Display(); //Display Contact

            addressBookBuilder.ModifyContact(CD.firstName);
        }
    }
}
