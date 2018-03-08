using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Library library = new Library();
            // shortcut customer entries
            Customer cust1 = Customer.CreateCustomer("Jon Lindsey", new Address("123 Fake St","Effingham","IL","62401"),"1234567890");
            library.AddCustomer(cust1);
            Customer cust2 = Customer.CreateCustomer("Sally Smith", new Address("1 Small St", "Carbondale", "IL", "61101"), "5555555555");
            library.AddCustomer(cust2);
            Customer cust3 = Customer.CreateCustomer("Karla Carlson", new Address("121 Really Fake St", "Edwardsville", "IL", "62055"), "9959542121");
            library.AddCustomer(cust3);
            Customer cust4 = Customer.CreateCustomer("Ed Jones", new Address("343 Red St", "Chicago", "IL", "65555"), "8117991212");
            library.AddCustomer(cust4);
            Customer cust5 = Customer.CreateCustomer("Mike Reynolds", new Address("123 Real St", "Effingham", "IL", "62401"), "56522143252");
            library.AddCustomer(cust5);

            // shortcut book entries
            Book book1 = Book.CreateBook("Kim Johnson", 12354, "Life of a Squirrel", 234);
            Book book2 = Book.CreateBook("Bill Edwards", 55555, "Life of a Dog", 65);
            Book book3 = Book.CreateBook("Hank WIlliams Jr.", 454545, "Life of a Skunk", 3001);
            Book book4 = Book.CreateBook("Art Smith", 675333, "Life of a Cow", 888);

            // shortcut add books
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine(book2);

            Console.WriteLine("Public Library Manager");

            Boolean run = true;

            while (run)
            {
                Console.WriteLine("\n1. Add Book to Library " +
                    "\n2. Search for book " +
                    "\n3. Checkout book " +
                    "\n4. Checkin book " +
                    "\n5. Display customer details" +
                    "\n6. Add new customer" +
                    "\n7. Exit\n");

                switch (Console.ReadLine()) {

                    case "1": //Add book

                        library.AddBook(Book.CreateBook());
                        break;
                    case "2": // Search
                        library.HasBook(Helper.Prompt("title"));
                        break;
                    case "3": // Checkout
                        library.CheckOutBook();
                        break;
                    case "4": // Checkin
                        library.CheckInBook();
                        break;
                    case "5": // Display customer
                        library.DisplayCustomer(Helper.Prompt("customer name"));
                        break;
                    case "6": // Add customer
                        library.AddCustomer();
                        break;
                    case "7": //Exit
                        Console.WriteLine("Exiting...");
                        run = false;
                        break;
                    default: //Invalid entry
                        Console.WriteLine("Invalid choice.  Please make another selection...");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
