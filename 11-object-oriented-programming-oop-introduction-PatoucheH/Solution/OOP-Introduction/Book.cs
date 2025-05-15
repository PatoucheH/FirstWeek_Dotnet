namespace OOP_Introduction
{
    public class Book
    {
        public string Title {get;init;}
        public string Author { get; set;}
        public int Page { get; set;}

        public string Display()
        {
            return $"Author : {Author} - Title : {Title} - Page : {Page}";
        }

    }
}
