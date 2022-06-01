using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;

            int b = 4;

            int quotient = a/b;

            int remainder = a%b;

            Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            double Pi = 3.1415926;

            double areaOfCircle = (Pi * radius * radius);

            Console.WriteLine(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

            Console.ReadKey();
        }
    }
}
