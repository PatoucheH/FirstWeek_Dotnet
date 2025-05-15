using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestLibrary;

[TestFixture]
public class TestsLibrarySystem
{
    private LibrarySystem system;
    private Patron patron;
    private Book book;

    [SetUp]
    public void Setup()
    {
        system = new LibrarySystem();
        patron = new Patron() { Name = "Patron A" };
        book = new Book() { Title = "A", Author = "Author A", Genre = "Thriller" };
    }

    [Test]
    public void AddPatron_ShouldAddPatronToList()
    {
        system.AddPatron(patron);

        Assert.That(system.Patrons, Does.Contain(patron));
    }

    [Test]
    public void BorrowBook_ShouldBorrowBookIfAvailable()
    {
        system.Library.AddBook(book);
        system.AddPatron(patron);

        system.BorrowBook("Patron A", "A");

        Assert.That(book.IsBorrowed, Is.True);
        Assert.That(patron.BorrowedBooks, Does.Contain(book));
    }


    [Test]
    public void BorrowBook_ShouldNotBorrowIfBookAlreadyBorrowed()
    {
        book.IsBorrowed = true;
        system.Library.AddBook(book);
        system.AddPatron(patron);

        system.BorrowBook("Patron A", "A");

        Assert.That(patron.BorrowedBooks, Does.Not.Contain(book));
    }


    [Test]
    public void ReturnBook_ShouldNotReturnIfNotBorrowed()
    {
        system.Library.AddBook(book);
        system.AddPatron(patron);

        system.ReturnBook("Patron A", "A");

        Assert.That(book.IsBorrowed, Is.False);
        Assert.That(patron.BorrowedBooks, Is.Empty);
    }
}
