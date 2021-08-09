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

            //Variables
            string firstName, lastName, address, city, state, email, phoneNumber;
            int zipCode;

            Console.WriteLine("Fill the Contact Details to add in Address Book:");
            Console.WriteLine("------------------------------------------------");

            //User Inputs
            Console.WriteLine("Enter First Name : "); 
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            address = Console.ReadLine();

            Console.WriteLine("Enter City Name : ");
            city = Console.ReadLine();

            Console.WriteLine("Enter State Name : ");
            state = Console.ReadLine();

            Console.WriteLine("Enter Zip-Code/ Pin-Code : ");
            zipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number : ");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email-ID : ");
            email = Console.ReadLine();                        
            
            //Add Contact
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            addressBookBuilder.AddContact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            
        }
    }
}
