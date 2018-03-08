using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Book
    {
        private String author, title;
        private int isbn, numberOfPages;
        private Boolean checkedOut = false;
        private Book() { }


        public static Book CreateBook (String author="", int isbn=0, String title="", int numberOfPages=0)
        {
            Book book = new Book();
            book.author = (author == "") ? Helper.Prompt("author") : author;
            book.isbn = (isbn == 0) ? int.Parse(Helper.Prompt("isbn")) : isbn;
            book.title = (title == "") ? Helper.Prompt("title") : title;
            book.numberOfPages = (numberOfPages == 0) ? int.Parse(Helper.Prompt("number of pages")) : numberOfPages;

            return book;
        }

        public Boolean IsCheckedOut() { return checkedOut; }

        public override string ToString()
        {
            return String.Format("\ntitle: {0}, by {1}\nisbn: {2}\nnumber of pages: {3}\n", title, author, isbn, numberOfPages);
        }

        public void CheckOut() { checkedOut = true; } 

        public void CheckIn() {checkedOut = false; }

        public String GetTitle() { return title; }

        public String GetAuthor() {return author; }

    }
}
