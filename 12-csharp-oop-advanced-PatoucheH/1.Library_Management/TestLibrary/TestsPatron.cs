using Library;
using NUnit.Framework;
using Intercom.Data;

namespace TestLibrary;
public class TestsPatron
{
    private Patron patron;
    private Book book1;
    private Book book2;

    [SetUp]
    public void SetUp()
    {
        patron = new() { Name = "Test Name" };
        book1 = new() { Title = "Test book one", Author = "Pierre", Genre = "Comics" };
        book2 = new() { Title = "book two", Author = "Author Test", Genre = "Thriller" };
    }


    [Test]
    public void TestBorrowBook_AddsBookToList()
    {
        patron.BorrowBook(book1);

        Assert.That(patron.BorrowedBooks.Count, Is.EqualTo(1));
    }

    [Test]

    public void TestReturnBook_DeleteBookToList()
    {
        patron.ReturnBook(book1);

        Assert.That(patron.BorrowedBooks.Count, Is.EqualTo(0));
    }
}
