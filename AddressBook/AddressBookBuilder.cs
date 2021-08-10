using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder : IAddressBook
    {
        //LinkedList 
        private List<ContactDetails> contactDetailsList; 

        //Constructor
        public AddressBookBuilder()
        {
            this.contactDetailsList = new List<ContactDetails>();
        }

        // Add contact in AddressBook 
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email)
        {
            //Variable
            string userConfirmation;

            //Object Created to Add Contact to List
            ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            this.contactDetailsList.Add(contactDetails);
            Console.WriteLine("Contact Details Added SuccessFully !\n");
            Console.WriteLine("-------------------------------");

            //Asking to Add More Contact
            while (true)
            {
                
                Console.WriteLine("Want to Add New Contact ? ");
                Console.WriteLine("Enter 'Yes' to Add New Contact");
                Console.WriteLine("Enter 'No' to Continue");
                Console.WriteLine("-------------------------------");
                userConfirmation = Console.ReadLine();

                if (string.Equals(userConfirmation, "yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Add Contact
                    ContactDetails contactDetails1 = new ContactDetails();
                    this.contactDetailsList.Add(contactDetails1);
                    Console.WriteLine("Contact Details Added SuccessFully !\n");
                    Console.WriteLine("-------------------------------");
                }
                else if (string.Equals(userConfirmation, "no", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Thank You");
                    break;
                }
            }                        
        }

        //Modify Contact from AddressBook
        public void ModifyContact()
        {
            //Variables 
            string userFirstName, dataFirstName;            

            //User-Input To Modify Data
            Console.WriteLine("Enter First Name To Modify Data : ");
            userFirstName = Console.ReadLine();

            //Check User-Input Match from AddressBook
            foreach (var item in this.contactDetailsList)
            {
                dataFirstName = item.firstName;
                
                //Modify Data
                if (dataFirstName == userFirstName)
                {                   
                    Console.WriteLine("Data Matched :");
                    Display();
                    Console.WriteLine("Enter What You Wnat to Modify :");
                    Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode, Phone Number, Email");
                    Console.WriteLine("Example :: Phone number ::");
                    Console.WriteLine("---------------------------------------------------");
                    string userModifyInput = Console.ReadLine();

                    if (string.Equals(userModifyInput, "First Name", StringComparison.CurrentCultureIgnoreCase ))
                    {
                        Console.WriteLine("Enter First Name : ");
                        item.firstName = Console.ReadLine();
                        Console.WriteLine("Updated First Name : " + item.firstName);
                    }
                    else if (string.Equals(userModifyInput, "Last Name", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Last Name : ");
                        item.lastName = Console.ReadLine();
                        Console.WriteLine("Updated Last Name : " + item.lastName);
                    } 
                    else if (string.Equals(userModifyInput, "Address", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Address : ");
                        item.address = Console.ReadLine();
                        Console.WriteLine("Updated Address : " + item.address);
                    }
                    else if (string.Equals(userModifyInput, "City", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter City Name : ");
                        item.city = Console.ReadLine();
                        Console.WriteLine("Updated City  : " + item.city);
                    }
                    else if (string.Equals(userModifyInput, "state", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter State : ");
                        item.state = Console.ReadLine();
                        Console.WriteLine("Updated State : " + item.state);
                    }
                    else if (string.Equals(userModifyInput, "ZipCode", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Zip-Code : ");
                        item.zipCode = int.Parse(Console.ReadLine());
                        Console.WriteLine("Updated Zip-Code : " + item.zipCode);
                    }
                    else if (string.Equals(userModifyInput, "phone Number", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Phone Number: ");
                        item.phoneNumber = Console.ReadLine();
                        Console.WriteLine("Updated Phone Number : " + item.phoneNumber);
                    }
                    else if (string.Equals(userModifyInput, "Email", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Email - ID: ");
                        item.email = Console.ReadLine();
                        Console.WriteLine("Updated Email- ID : " + item.email);
                    }
                }
                else
                {
                    //Display Message
                    Console.WriteLine("Entered Name : " + userFirstName + " not Found!");
                }
            }            
        }
        //Delete Contact from AddressBook
        public void DeleteContact()
        {
            //Variables 
            string userFirstName, dataFirstName;
            string userConfirmation;

            //User-Input To Modify Data
            Console.WriteLine("Enter First Name To Delete Contact : ");
            userFirstName = Console.ReadLine();

            //Check User-Input Match from AddressBook
            for (int i = 0; i < contactDetailsList.Count; i++)
            {
                dataFirstName = contactDetailsList[i].firstName;
                Console.WriteLine("Firstname : " + contactDetailsList[i].firstName);

                if (userFirstName == dataFirstName)
                {
                    Console.WriteLine("Are You Sure want to Delete This Contact ? ");
                    Console.WriteLine("Enter 'Yes' to delete Contact");
                    Console.WriteLine("Enter 'No' to avoid delete Contact");
                    userConfirmation = Console.ReadLine();
                    if (string.Equals(userConfirmation, "yes", StringComparison.CurrentCultureIgnoreCase))
                    {
                        contactDetailsList.RemoveAt(i);
                        Console.WriteLine("Contact Details deleted SuccessFully");
                    }
                    else
                    {
                        Console.WriteLine("Contact Details Not Deleted");
                    }
                }                        
            }            
        }
        //Display Data
        public void Display()
        {
            //Display Message
            Console.WriteLine("-----------------------");
            Console.WriteLine("Your Contact Details  :");
            Console.WriteLine("-----------------------");

            foreach (var item in this.contactDetailsList)
            {
                Console.WriteLine("First Name : " + item.firstName);
                Console.WriteLine("Last Name : " + item.lastName);
                Console.WriteLine("Address : " + item.address);
                Console.WriteLine("City : " + item.city);
                Console.WriteLine("State : " + item.state);
                Console.WriteLine("Zip-Code : " + item.zipCode);
                Console.WriteLine("Phone Number : " + item.phoneNumber);
                Console.WriteLine("Email-ID : " + item.email);
                Console.WriteLine("-----------------------");
            }
        }
        
    }
}
