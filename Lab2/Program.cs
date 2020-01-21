using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continues = true;
            Console.WriteLine("Welcome To Grand Circus' Room Detail Generator!");

            do
            {
                
                
                Console.WriteLine("Enter Length:");
                double length = double.Parse(Console.ReadLine());
               

                Console.WriteLine("Enter Width:");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height:");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);
                double volume = length * width * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Would you like to restart this program? [y/n]");
                string willContinue = Console.ReadLine();
                if (willContinue == "y" || willContinue == "Y")
                {
                    continues = true;
                }
                else if (willContinue == "n" || willContinue == "N")
                {
                    continues = false;
                    Console.WriteLine("Goodbye!");
                }
               
            } while (continues);
           


        }
    }
}
