namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t===*===  Welcome to Address Book Program  ===*===\n\n");
            Console.WriteLine("1].Add Contact \n2].Edit Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            AddressBook2 address = new AddressBook2();
            switch (option)
            {
                case 1:
                    address.AddContacts();
                    address.Toprint();
                    break;
                 case 2:                  
                    address.EditContact();
                    break;


                default:
                    Console.WriteLine("Incorrect option Entered\n");
                    break;
            }

        }
        
    }
   
}