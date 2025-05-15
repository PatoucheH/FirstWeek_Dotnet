using System.Diagnostics;

namespace StructsRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st
            var s1 = new Point(10, 5);
            var s2 = new Point(10, 5);

            if (s1.Equals(s2))
            {
                Console.WriteLine("The both structs are equal.");
            }
            else
            {
                Console.WriteLine("The both structs aren't equal.");
            }

            //2nd



            //3th

            var r1 = new Person("Pierre", 32);
            var r2 = new Person("Pierre", 32);

            if (r1.Equals(r2)) Console.WriteLine("Record equal ! ");
            else Console.WriteLine("Record don't equal ! ");


            //4th

            Shape shape1 = new(s1, 2d);

            Console.WriteLine($" Radius : {shape1.Radius}\nCenter : x = {shape1.Center.X}; y = {shape1.Center.Y}");

            //5th

            const int N = 1_000_000;

            Console.WriteLine("Struct Performance : ");
            var sw1 = Stopwatch.StartNew();

            PointStruct[] points1 = new PointStruct[N];
            for(int i = 0; i < N; i++)
            {
                points1[i] = new PointStruct(i, i);
            }

            long total1 = 0;
            for(int i = 0; i < N; i++)
            {
                total1 += points1[i].X + points1[i].Y;
            }

            sw1.Stop();
            Console.WriteLine($"Total struct = {total1}\t\tTime struct(ms) = {sw1.ElapsedMilliseconds}");


            Console.WriteLine("Class Performance : ");
            var sw2 = Stopwatch.StartNew();

            PointClass[] points2 = new PointClass[N];
            for (int i = 0; i < N; i++)
            {
                points2[i] = new PointClass(i, i);
            }

            long total2 = 0;
            for (int i = 0; i < N; i++)
            {
                total2 += points2[i].X + points2[i].Y;
            }

            sw1.Stop();
            Console.WriteLine($"Total class = {total2}\t\t Time class(ms) = {sw2.ElapsedMilliseconds}");

            //6th

            var e1 = new Employee("John", 24, "Dev");
            var e2 = e1;
            var p1 = new Person("John", 24);
            var p2 = p1;

            if (e1 == e2) Console.WriteLine("It's the same data employee!");
            else Console.WriteLine("It's not the same data employee...");
            
            if (p1 == p2) Console.WriteLine("It's the same data person !");
            else Console.WriteLine("It's not the same date person...");

            Person p3 = e1;

            if (p1.Equals(p3)) Console.WriteLine("It's the same even with the transformation");
            else Console.WriteLine("NOPE ! ");



        }

    }
}
