using Library;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestLibrary
{
    public class TestsLibrary
    {
        private Library.Library library;
        private Book book1;
        private Book book2;
        private Book bookThriller;
        private Book bookFantasy;

        [SetUp]
        public void SetUp()
        {
            library = new Library.Library();

            book1 = new Book { Title = "Book A", Author = "Author A", Genre = "Thriller" };
            book2 = new Book { Title = "Book B", Author = "Author B", Genre = "Fantasy" };

            bookThriller = new Book { Title = "Thriller Book", Author = "Author T", Genre = "Thriller" };
            bookFantasy = new Book { Title = "Fantasy Book", Author = "Author F", Genre = "Fantasy" };
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            library.AddBook(book1);

            Assert.That(library.Books, Contains.Item(book1));
        }

        [Test]
        public void ListBooks_ShouldReturnAllBooks()
        {
            library.AddBook(book1);
            library.AddBook(book2);

            var books = library.ListBooks();

            Assert.That(books.Count, Is.EqualTo(2));
            Assert.That(books, Contains.Item(book1));
            Assert.That(books, Contains.Item(book2));
        }

        [Test]
        public void ListBooksByGenre_ShouldReturnOnlyMatchingBooks()
        {
            library.AddBook(bookThriller);
            library.AddBook(bookFantasy);

            var result = library.ListBooksByGenre("Thriller");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Genre, Is.EqualTo("Thriller"));
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed_WhenAvailable()
        {
            library.AddBook(book1);

            var message = library.BorrowBook("Book A");

            Assert.That(message, Is.EqualTo("Book A is successfully borrowed."));
            Assert.That(book1.IsBorrowed, Is.True);
        }

        [Test]
        public void BorrowBook_ShouldReturnUnavailableMessage_IfAlreadyBorrowed()
        {
            book1.IsBorrowed = true;
            library.AddBook(book1);

            var message = library.BorrowBook("Book A");

            Assert.That(message, Is.EqualTo("Book A is not available."));
        }

        [Test]
        public void BorrowBook_ShouldReturnNotFoundMessage_IfTitleDoesNotExist()
        {
            var message = library.BorrowBook("Unknown Book");

            Assert.That(message, Is.EqualTo("No book with the name Unknown Book found."));
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsReturned_WhenBorrowed()
        {
            book1.IsBorrowed = true;
            library.AddBook(book1);

            var message = library.ReturnBook("Book A");

            Assert.That(message, Is.EqualTo("Book A sucessfully returned."));
            Assert.That(book1.IsBorrowed, Is.False);
        }

        [Test]
        public void ReturnBook_ShouldReturnNotFoundMessage_IfBookNotFound()
        {
            var message = library.ReturnBook("Unknown Book");

            Assert.That(message, Is.EqualTo("No book with the name Unknown Book found."));
        }

        [Test]
        public void ReturnBook_ShouldReturnNotFoundMessage_IfBookNotBorrowed()
        {
            library.AddBook(book1);

            var message = library.ReturnBook("Book A");

            Assert.That(message, Is.EqualTo("No book with the name Book A found."));
        }
    }
}
