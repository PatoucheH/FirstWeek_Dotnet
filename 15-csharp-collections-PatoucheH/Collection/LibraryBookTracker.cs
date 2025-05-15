using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class LibraryBookTracker
    {
        HashSet<string> AvailableBooks = new();
        HashSet<string> BorrowedBooks = new();

        public void AddNewBooks(string bookName)
        {
            AvailableBooks.Add(bookName);
        }

        public void BorrowBooks(string bookName)
        {
            AvailableBooks.Remove(bookName);
            BorrowedBooks.Add(bookName);
        }

        public void ReturnBooks(string bookName)
        {
            BorrowedBooks.Remove(bookName);
            AvailableBooks.Add(bookName);
        }

        public string SearchForABook(string bookName)
        {
            if(AvailableBooks.Contains(bookName)) return "Book Available ! ";
            else if(BorrowedBooks.Contains(bookName)) return "Book Borrowed ! ";
            else return "Book don't exists ! ";
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All the Available Books : ");
            foreach (var book in AvailableBooks) Console.WriteLine(book);

            Console.WriteLine("All the borrowed Books : ");
            foreach (var book in BorrowedBooks) Console.WriteLine(book);
        }
    }
}
