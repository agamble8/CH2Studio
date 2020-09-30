using System;

namespace CH2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string input;
            float mileage;
            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            while (radius < 0)
            {
                Console.WriteLine("Enter a radius that is POSITIVE: ");
                input = Console.ReadLine();
                radius = double.Parse(input);
            }

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.Area(radius));
            Console.WriteLine("The circumference of the circle of radius " + radius + " is: " + Circle.Circumference(radius));
            Console.WriteLine("The diameter of the circle of radius " + radius + " is: " + Circle.Diameter(radius));
            Console.WriteLine("What kind of gas milage does your car get?");
            input = Console.ReadLine();
            mileage = float.Parse(input);
            Console.WriteLine("It will take you " + (Circle.Circumference(radius) / mileage) + " gallons to go around that circle!");
            //Console.WriteLine("Enter a radius: ");
            //input = Console.ReadLine();
            //radius = double.Parse(input);

            //do
            //{
            //    Console.WriteLine("Enter a positive radius: ");
            //    input = Console.ReadLine();
            //    radius = double.Parse(input);

            //}
            //while (radius < 0);

            //Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.Area(radius));
            //Console.WriteLine("The circumference of the circle of radius " + radius + " is: " + Circle.Circumference(radius));
            //Console.WriteLine("The diameter of the circle of radius " + radius + " is: " + Circle.Diameter(radius));
            //Console.WriteLine("What kind of gas milage does your car get?");
            //input = Console.ReadLine();
            //mileage = float.Parse(input);
            //Console.WriteLine("It will take you " + (Circle.Circumference(radius) / mileage) + " gallons to go around that circle!");

        }
    }
}
