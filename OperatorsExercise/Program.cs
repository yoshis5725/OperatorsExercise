using System;

namespace OperatorsExercise
{
    class Program
    {

        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());

            double calculatedArea = (Math.PI * radius * radius);
            Console.WriteLine($"The area of the circle with radius of {radius} is {calculatedArea}");
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine("------- Exercise 1 -------");
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
                Console.WriteLine("");
                Console.WriteLine("------- Exercise 2 -------");
                AreaOfCircle();
            }
        }
    }
}

