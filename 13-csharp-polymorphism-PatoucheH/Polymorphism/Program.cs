using Polymorphism.FirstExercise;
using Polymorphism.FourthExercise;
using Polymorphism.SecondExercise;
using Polymorphism.ThirdExercise;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // First Exercise Abstract and Polymorphism

            List<Vehicle> listVehicle = new()
            {
                new Car(),
                new Motorcycle(),
                new Car(),
                new Motorcycle()
            };

            foreach(Vehicle v in listVehicle)
            {
                v.Start();
            }

            //Second Interface and Polymorphism

            List<IAnimal> animals = new()
            {
                new Dog(),
                new Cat(),
                new Dog(),
                new Dog()
            };

            foreach(IAnimal a in animals)
            {
                a.MakeNoise();
            }


            //Third Abstract Class and Interface

            Shape circle1 = new Circle(2.5);
            Shape circle2 = new Circle(10);
            Shape square1 = new Square(7.5);
            Shape square2 = new Square(5);

            Console.WriteLine(circle1.CalculateArea());
            Console.WriteLine(circle2.CalculateArea());
            Console.WriteLine(square1.CalculateArea());
            Console.WriteLine(square2.CalculateArea());

            circle1.Paint("Red");
            circle2.Paint("Green");
            square1.Paint("Blue");
            square2.Paint("Yellow");

            // Fourth Dependency Injection

            Engine gasoline = new GasolineEngine();
            Engine diesel = new DieselEngine();

            Car2 car10 = new Car2(gasoline);
            Car2 car11 = new Car2(diesel);

            car10.Start();
            car11.Start();
        }
    }
}
