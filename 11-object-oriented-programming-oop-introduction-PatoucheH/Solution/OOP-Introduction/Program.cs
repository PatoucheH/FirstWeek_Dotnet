namespace OOP_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book()
            {
                Author = "Me",
                Title = "My first book",
                Page = 150
            };

            Console.WriteLine(firstBook.Display());


            Person person = new Person("James Cameron", 19);


            Console.WriteLine(person.Display());


            RectangleEx rect = new RectangleEx();
            rect.Width = 3;
            rect.Length = 5;
            Console.WriteLine(rect.CalculateArea());


            Console.ReadLine();


        }
    }
}
