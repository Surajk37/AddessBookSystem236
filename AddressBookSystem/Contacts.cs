
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public long phoneNo { get; set; }
        public string email { get; set; }
    }

        public class AddressBook2
        {
          Contacts contact = new Contacts();
          public static List<Contacts> addressBook = new List<Contacts>();    

            public void AddContacts()
            {             
                Console.Write("Enter First Name:- ");
                contact.firstName = Console.ReadLine();
                Console.Write("Enter Last Name:- ");
                contact.lastName = Console.ReadLine();
                Console.Write("Enter Address:- ");
                contact.address = Console.ReadLine();
                Console.Write("Enter City:- ");
                contact.city = Console.ReadLine();
                Console.Write("Enter State:- ");
                contact.state = Console.ReadLine();
                Console.Write("Enter Zip:- ");
                contact.zipcode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number:- ");
                contact.phoneNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Email Id:- ");
                contact.email = Console.ReadLine();
                Console.WriteLine("Contact has been Created..!!\n");
                addressBook.Add(contact);
                
            }
            public void Toprint()   //Printing details taking by the user
            {
                foreach (Contacts person in addressBook)
                {
                    Console.WriteLine("\n\tThe Details of a Person Are Displayed");
                    Console.WriteLine("First Name: \t" + person.firstName);
                    Console.WriteLine("Last Name: \t" + person.lastName);
                    Console.WriteLine("Address: \t" + person.address);
                    Console.WriteLine("City: \t\t" + person.city);
                    Console.WriteLine("State: \t\t" + person.state);
                    Console.WriteLine("Zipcode: \t" + person.zipcode);
                    Console.WriteLine("Phone Number: \t" + person.phoneNo);
                    Console.WriteLine("Email: \t\t" + person.email);

                }
            }
            public  void EditContact()  //Editing Contacts using their first name
            {
              AddContacts();    //To edit the contact need to save the contact details first
              Console.WriteLine("\nTo Edit Contact Enter  First Name");
              string name = Console.ReadLine();
              bool input = false;
              foreach (var person in addressBook)
              {
                if (contact.firstName == name)
                {
                    input = true;
                    Console.WriteLine("\tContact Found...\n");
                    Console.WriteLine("Select option for update Details");
                        Console.WriteLine("\n1:Edit first name\n2:Edit last name \n3:Edit Address\n4:Edit City\n5:Edit State\n6:Edit ZipCode\n7:Edit Phone Number\n8:Edit EmailID");
                    int check = Convert.ToInt32(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Console.Write("Update first name : ");
                            person.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Update last name : ");
                            person.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Update Address : ");
                            person.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Update City : ");
                            person.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Update State : ");
                            person.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Update ZipCode : ");
                            person.zipcode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.Write("Update PhoneNumber : ");
                            person.phoneNo = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.Write("Update EmailID : ");
                            person.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Please Enter valid Option");
                            break;
                    }

                }
              }
               if (input == false)
                Console.WriteLine("\n\tContact not found");
                Toprint();
            }
         public void DeleteContact()
         {
            AddContacts();
            Console.WriteLine("Enter the Firstname of the person you would like to remove.");
            string name = Console.ReadLine();
            foreach (var person in addressBook.ToList())
            {
                if (person.firstName.ToUpper() == name.ToUpper())
                {
                    addressBook.Remove(person);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }
         }

        }       
}
