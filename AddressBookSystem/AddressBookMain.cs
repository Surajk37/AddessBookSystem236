namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\tWelcome to Address Book Program\n");
            Console.WriteLine("Enter 1 to Add Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    AddressBook2 address = new AddressBook2();
                    address.AddContacts();
                    address.Toprint();
                    break;

                default:
                    Console.WriteLine("Incorrect option Entered\n");
                    break;
            }

        }
        
    }
   
}