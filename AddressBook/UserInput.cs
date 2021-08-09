using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UserInput
    {
        public UserInput()
        {
            //Variables
            string firstName, lastName, address, city, state, email, phoneNumber;
            long zipCode ;

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

            //Display Entered Details
            Console.WriteLine("----------------------------------");
            Console.WriteLine("You have entered below Details :: ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("First Name : " + firstName);
            Console.WriteLine("Last Name : " + lastName);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("City Name : " + city);
            Console.WriteLine("State Name : " + state);
            Console.WriteLine("Zip-Code: " + zipCode);
            Console.WriteLine("Phone Number : " + phoneNumber);
            Console.WriteLine("Email - ID : " + email);
        }
    }
}
