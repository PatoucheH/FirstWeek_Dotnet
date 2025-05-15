namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // First 

            InventoryManagementSystem inventoryManSys = new();

            inventoryManSys.AddItems("poire", 15);
            inventoryManSys.AddItems("banane", 19);
            inventoryManSys.AddItems("pomme", 5);
            inventoryManSys.AddItems("fraise", 25);
            inventoryManSys.AddItems("pêche", 20);
            inventoryManSys.AddItems("poire", 10);
            inventoryManSys.AddItems("figues", 8);

            inventoryManSys.RemoveItems("pêche");

            Console.WriteLine("Item with a mininma value : ");
            inventoryManSys.CheckLowStock(10);


            Console.WriteLine("All the item in alphabetical order : ");
            inventoryManSys.DisplayAllItems();


            // Second
            LibraryBookTracker library = new();

            library.AddNewBooks("1984");
            library.AddNewBooks("Harry Potter");
            library.AddNewBooks("Learn C#");
            library.AddNewBooks("Island");
            library.AddNewBooks("Memo");

            library.BorrowBooks("1984");
            library.BorrowBooks("Learn C");
            library.BorrowBooks("Memo");

            library.ReturnBooks("Memo");

            Console.WriteLine(library.SearchForABook("1984"));

            library.DisplayAllBooks();



            // Third

            EventRegistration eventList = new();

            eventList.RegisterAttendee("Big fiesta", "Bob");
            eventList.RegisterAttendee("Big fiesta", "Jean");
            eventList.RegisterAttendee("Big fiesta", "Pierre");
            eventList.RegisterAttendee("Big fiesta", "Paul");
            eventList.RegisterAttendee("Big fiesta", "Jacques");

            eventList.RegisterAttendee("Fun cup", "Bob");
            eventList.RegisterAttendee("Fun cup", "Hugo");
            eventList.RegisterAttendee("Fun cup", "Paul");
            eventList.RegisterAttendee("Fun cup", "Pauline");
            eventList.RegisterAttendee("Fun cup", "Huguette");

            eventList.RemoveRegistration("Big fiesta", "Jean");

            Console.WriteLine("Show all the attendee for an event : ");
            eventList.ListEventRegistration("Big fiesta");


            Console.WriteLine("Show all the attendee with their event : ");
            eventList.ShowAllRegistration();

        }
    }
}
