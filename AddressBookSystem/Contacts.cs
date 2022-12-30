
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
            public static List<Contacts> addressBook = new List<Contacts>();

            public void AddContacts()
            {

                Contacts contact = new Contacts();
                //Taking Data from the user
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
                Console.WriteLine("Contact has been Created..!!");
                addressBook.Add(contact);
            }
            public void Toprint()
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
        }
    
}
