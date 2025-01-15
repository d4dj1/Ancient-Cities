using System;
using System.Security.Cryptography.X509Certificates;

namespace SquareFootageCostCalculator
{
    class Program
    {
        double square;
        public bool Calculating = true;
        static void Main(string[] args)
        {
            double square = 0;
            double triangle = 0;
            double circle = 0;
            double total = 0;
            //asks which shape to calculate
            for (int i = 0; i < 1000000; i++)
            {

            
                Console.WriteLine("What shape would you like to calculate the area for?");

                string shape = Console.ReadLine();

                if(shape == "Square")
                {
                    Console.WriteLine("What is the first side length?");
                    double sq1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the second side length?");
                    double sq2 = int.Parse(Console.ReadLine());
                    // calculates and stores the result
                    square = sq1 * sq2;  
                }

                if(shape == "Triangle")
                {
                    Console.WriteLine("What is the height of the triangle?");
                    double tr1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the length of the base?");
                    double tr2 = int.Parse(Console.ReadLine());
                    // calculates and stores the result
                    triangle = ((tr1 * tr2) / 2);

                
                }

                if(shape == "Circle")
                {
                    Console.WriteLine("What is the radius of the circle?");
                    double cr1 = int.Parse(Console.ReadLine());
                    
                    // calculates and stores the result
                    circle = Math.Pow((3.14 * cr1), 2);

                    
                }

                Console.WriteLine("Any more shapes?(y/n)");
                string more = Console.ReadLine();

                if(more == "n")
                {
                    total = circle + triangle + square;
                    Console.WriteLine("The total area is " + total);
                    i = 1000001;
                }
                if(more == "y")
                {
                   i ++;
                   
                }
            }    
        }
    }
}