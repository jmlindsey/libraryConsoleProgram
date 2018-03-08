using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Library
    {
        private List<Book> books;
        private List<Customer> customers;

        public Library()
        {
            books = new List<Book>();
            customers = new List<Customer>();
        }

        public void HasBook(String bookName)
        {
            Book toFind = SearchForBook(bookName);

            if (toFind != null && !toFind.IsCheckedOut())
                Console.WriteLine("\nLibrary has a copy of {0}\n", toFind.GetTitle());
            else if (toFind != null && toFind.IsCheckedOut())
                Console.WriteLine("\n{0}, by {1} is currently checked out\n", toFind.GetTitle(), toFind.GetAuthor());
            else
                Console.WriteLine("\nLibrary does not own a copy of this book\n");
        }

        public void AddBook(Book book) { books.Add(book); }

        public int CountBooks() { return books.Count(); }

        public void AddCustomer(Customer customer = null) { customers.Add((customer == null) ? Customer.CreateCustomer() : customer); }

        private Book SearchForBook(String name)
        {
            foreach (Book book in books)
                if (book.GetTitle().ToLower() == name.ToLower()) return book;
            return null;
        }

        private Customer SearchForCustomer(String name)
        {
            foreach (Customer customer in customers)
                if (customer.GetName().ToLower() == name.ToLower()) return customer;
            return null;
        }

        public void DisplayCustomer(String name)
        {
                Customer toFind = SearchForCustomer(name);
                if (toFind != null)
                    Console.WriteLine("Customer found: \n{0}\n", toFind);
                else
                    Console.WriteLine("Customer not found\n");
        }

        public void CheckOutBook(Customer customer=null, Book book=null)
        {
            customer = (customer == null) ? SearchForCustomer(Helper.Prompt("Customer checking out")) : customer;
            book = (book == null) ? SearchForBook(Helper.Prompt("book title")) : book;

            if (customer == null)
                Console.WriteLine("Checkout failed. Customer {0} not found\n", customer.GetName());
            else if (book == null)
                Console.WriteLine("Checkout failed. Book not found\n");
            else if (book.IsCheckedOut())
                Console.WriteLine("Checkout failed.  Book is already checked out\n");
            else 
            {
                customer.GetBook(book);
                book.CheckOut();
                Console.WriteLine("{0} checked out {1}\n", customer.GetName(), book);
            }     
        }

        public void CheckInBook(Customer customer = null, Book book = null)
        {
            customer = (customer == null) ? SearchForCustomer(Helper.Prompt("Customer checking out")) : customer;
            book = (book == null) ? SearchForBook(Helper.Prompt("book title")) : book;

            if (customer == null)
                Console.WriteLine("Checkout failed. Customer not found\n");
            else if (book == null)
                Console.WriteLine("Checkout failed. Book not found\n");
            else if (!book.IsCheckedOut())
                Console.WriteLine("Checkout failed.  Book is already checked in\n");
            else
            {
                Console.WriteLine("{0} checked in {1}\n", customer.GetName(), book);
                customer.ReturnBook(book);
                book.CheckIn();
            }
        }
    }
}
