using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Customer
    {
        private String name;
        private Address address;
        private String telephone;
        private List<Book> books;

        public static Customer CreateCustomer(String name = "", Address address = null, String telephone = "")
        {
            Customer cust = new Customer();
            cust.name = (name == "") ? Helper.Prompt("name") : name;
            cust.address = (address == null) ? Address.ParseToAddress(Helper.Prompt("address (street address,city,state,zip")) : address;
            cust.telephone = (telephone == "") ? Helper.Prompt("telephone") : telephone;
            cust.books = new List<Book>();
            return cust;
        }

        private Customer() { }

        /*
        public static String GetInfo(String info)
        {
            Console.WriteLine("Enter {0}", info);
            return Console.ReadLine();
        }*/

        public override String ToString()
        {
            String outString = String.Format("name: {0}\n\nBooks checked out:", name);

            if(books.Count > 0)
                foreach (Book book in books) outString += String.Format("\n{0}\n", book);
            return outString;
        }

        public String GetName()
        {
            return name;
        }

        public void GetBook(Book book) {
            books.Add(book);
        }

        public Book ReturnBook(Book book)
        {
            books.Remove(book);
            return book;
        }
    }
}
