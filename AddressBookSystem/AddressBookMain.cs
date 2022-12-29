namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t=-=-=-=-=-Welcome to Address Book Program-=-=-=-=-=\n");
            Console.WriteLine("Choose a option from below List");
            Console.WriteLine("1. Create Contact\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    AddressBookMain.CreateContacts();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Value \n");
                    break;
            }
        }
        static void CreateContacts()
        {
            Console.Write("Enter First Name:-");
            string firstName = Console.ReadLine();
            Console.Write("Enter Second Name:-");
            string secondName = Console.ReadLine();
            Console.Write("Enter Address:-");
            string address = Console.ReadLine();
            Console.Write("Enter City:-");
            string city = Console.ReadLine();
            Console.Write("Enter State:-");
            string state = Console.ReadLine();
            Console.Write("Enter Zip:-");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number:-");
            long phoneNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email Id:-");
            string email = Console.ReadLine();
            Contacts conObj = new Contacts(firstName, secondName, address, city, state, zip, phoneNo, email);
            Console.WriteLine("Contact has been Created..!!");
            Console.ReadLine();
        }
    }
        
        public class Contacts 
        {
            public string firstName;  //used get and set method
            public string secondName;
            public string address;
            public string city;
            public string state;
            public int zip;
            public long phoneNo;
            public string email;
            public Contacts(string firstName, string secondName, string address, string city, string state, int zip, long phoneNo, string email)
            {
                this.firstName = firstName;      
                this.secondName = secondName;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.phoneNo = phoneNo;
                this.email = email;
                Console.ReadLine();
            }
        }

    
}