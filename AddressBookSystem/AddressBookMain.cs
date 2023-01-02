namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t===*===  Welcome to Address Book Program  ===*===\n\n");
            Console.WriteLine("1].Add Contact \n2].Display Details \n3].Edit Contact \n4].Delete Contact \n5].Add Multiple Contacts");
            int option = Convert.ToInt32(Console.ReadLine());
            AddressBook2 address = new AddressBook2();
            switch (option)
            {
                case 1:
                    address.AddContacts();       //UC1-Create Contacts 
                    break;
                case 2:
                    address.Toprint();
                    break;
                 case 3:                  
                    address.EditContact();
                    break;
                case 4:
                    address.DeleteContact();
                    break;
                case 5:
                    Console.WriteLine("Enter the number of Contact you wanted to add");
                    int numofContact = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numofContact; i++)
                    {
                        address.AddContacts(); 
                        address.Toprint();
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect option Entered\n");
                    break;
            }

        }
        
    }
   
}