
using Intercom.Data;
using Library;


namespace TestLibrary;
public class TestsBook
{
        Library.Book book = new()
        {
            Title = "Test",
            Author = "Test Name",
            Genre = "Historic"
        };
    

    [Test]
    public void TestBorrowBook()
    {
        var result = book.Borrow();

        Assert.That(result, Is.EqualTo($"{book.Title} has been borrowed."));
    }

    [Test]
    public void TestReturnBook()
    {
        var result = book.ReturnBook();

        Assert.That(result, Is.EqualTo($"{book.Title} has been succesfully returned."));
    }

    [Test]  
    public void TestReturnBookNotBorrow()
    {
        var result = book.ReturnBook();

        Assert.That(result, Is.EqualTo("Nothing to return ."));
    }
}
