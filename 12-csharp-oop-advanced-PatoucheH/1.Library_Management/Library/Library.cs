using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> ListBooks()
        {
            List<Book> listToDisplay = new List<Book>();

            foreach (Book book in Books)
            {
                listToDisplay.Add(book);
                //Console.WriteLine($"Title : {book.Title} - Author : {book.Author} - Genre : {book.Genre} - " +
                //    $"Status : {(book.IsBorrowed ? "Borrowed" : "Not borrowed")}");
            }
            return listToDisplay;
        }

        public List<Book> ListBooksByGenre(string genre)
        {
            List<Book> listToDisplay = new List<Book>(); 
            foreach (Book book in Books)
            {
                if (book.Genre == genre)
                {
                    listToDisplay.Add(book);
                    Console.WriteLine($"Title : {book.Title} - Author : {book.Author} - Genre : {book.Genre} - " +
                    $"Status : {(book.IsBorrowed ? "Borrowed" : "Not borrowed")}");
                }
            }
            return listToDisplay;
        }

        public string BorrowBook(string title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == title && !book.IsBorrowed)
                {
                    book.Borrow();
                    return $"{book.Title} is successfully borrowed.";
                } else if (book.Title == title && book.IsBorrowed)
                {
                    return $"{book.Title} is not available.";
                }
            }
            return $"No book with the name {title} found.";
        }

        public string ReturnBook(string title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == title && book.IsBorrowed)
                {
                    book.ReturnBook();
                    return $"{book.Title} sucessfully returned.";
                }
            }
            return $"No book with the name {title} found.";

        }
    }
}


