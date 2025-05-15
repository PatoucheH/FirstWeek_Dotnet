using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibrarySystem
    {
        public Library Library = new Library();
        public List<Patron> Patrons = new List<Patron>();

        public void AddPatron(Patron patron)
        {
            Patrons.Add(patron);
        }

        public void BorrowBook(string patronName, string title)
        {
            Book bookToBorrow = Library.ListBooks()
                .FirstOrDefault(book => book.Title == title);

            if(bookToBorrow == null)
            {
                Console.WriteLine($"No book with the title {title}.");
                return;
            }
            if(bookToBorrow.IsBorrowed)
            {
                Console.WriteLine($"The book {title} is already borrowed.");
                return;
            }

            Patron patronWhoBorrow = Patrons.FirstOrDefault(patron => patron.Name == patronName);
            if(patronWhoBorrow == null)
            {
                Console.WriteLine($"No patron with the name {patronName} found.");
                return;
            }

            patronWhoBorrow.BorrowBook(bookToBorrow);
            Console.WriteLine(Library.BorrowBook(title));

        }

        public void ReturnBook(string patronName, string title)
        {
            Book bookToBorrow = Library.ListBooks()
                .FirstOrDefault(book => book.Title == title);
            if (bookToBorrow == null)
            {
                Console.WriteLine($"No book with the title {title}.");
                return;
            }
            if (!bookToBorrow.IsBorrowed)
            {
                Console.WriteLine($"The book {title} is already borrowed.");
                return;
            }

            Patron patronWhoBorrow = Patrons.FirstOrDefault(patron => patron.Name == patronName);
            if (patronWhoBorrow == null)
            {
                Console.WriteLine($"No patron with the name {patronName} found.");
                return;
            }

            patronWhoBorrow.ReturnBook(bookToBorrow);
            Console.WriteLine(Library.ReturnBook(title));
        }

        public void ListBorrowedBoks(string patronName)
        {
            Patron patronToPrintBookBorrowed = Patrons.FirstOrDefault(patron => patron.Name == patronName);
            foreach (Book book in patronToPrintBookBorrowed.BorrowedBooks)
            {
                Console.WriteLine($"Title : {book.Title} - Author : {book.Author} - Genre : {book.Genre} - " +
                    $"Status : {(book.IsBorrowed ? "Borrowed" : "Not borrowed")}");
            }
        }
    }
}
