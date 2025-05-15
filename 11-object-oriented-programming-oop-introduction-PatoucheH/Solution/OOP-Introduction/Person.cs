namespace OOP_Introduction
{
    public class Person
    {
        public string Name { get; private set;}
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public bool IsAdult()
        {
            return Age >= 18;
        }

        public string Display()
        {
            return $"{Name} is {Age} years old : {(IsAdult() ? "Adult" : "Teenager")}";
        }
    }
}
