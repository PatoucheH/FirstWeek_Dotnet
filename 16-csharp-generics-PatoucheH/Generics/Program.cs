namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First

            Box <string> box1 = new("Jacques");

            box1.DisplayValue();


            // Second

            string a = "10";
            string b = "Jean";

            box1.Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Third

            var list = new MyList<string>();

            list.Add("Paul");

            Console.WriteLine(list.Get(0));

            // Fourth 



            // Fifth


            var names = new List<string> { "Jean", "Paul", "Jacques", "Luc", "Marc", "Hugo", "Jules" };
            
            var filtered = Filter(names, name => name.StartsWith("J"));
            
            foreach(var name in filtered)
            {
                Console.WriteLine(name);
            }

        }
            public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> condition)
            {
                return items.Where(condition);
            }
    }
}
