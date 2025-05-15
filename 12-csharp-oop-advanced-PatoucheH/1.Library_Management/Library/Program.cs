
namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibrarySystem Library = new LibrarySystem();

            Book book1 = new()
            {
                Title = "first book",
                Author = "me",
                Genre = "Thriller"
            };
            Book book2 = new()
            {
                Title = "second book",
                Author = "me",
                Genre = "History"
            };
            Book book3 = new()
            {
                Title = "third book",
                Author = "me",
                Genre = "Thriller"
            };

            Library.Library.AddBook(book1);
            Library.Library.AddBook(book2);
            Library.Library.AddBook(book3);

            Patron patron1 = new()
            {
                Name = "Georges Patou"
            };
            Patron patron2 = new()
            {
                Name = "You"
            };

            Library.AddPatron(patron2);

            Library.BorrowBook("You", "third book");
            Console.WriteLine("------");
            Library.BorrowBook("You", "first book");

            Console.WriteLine("------");
            Library.ReturnBook("You", "first book");

            Console.WriteLine("---------");

            Library.Library.ListBooksByGenre("Thriller");

        }
    }
}
