using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.0 ;
            var y = 20d ;
            var sum = x + y;
            Console.WriteLine(sum);

            var numbers = new double[10];
            numbers[0] = 1d ;
            numbers[1] = 2d ;
            numbers[2] = 3d ;

            System.Console.WriteLine(numbers[0] + numbers[1]);

            // Init arrays without type
            var numbers2 = new []{1d,2d,3d};
            // Sum all elements of array
            var sum2 = 0d ;
            foreach(var number in numbers2) 
            {
                sum2 += number ;
            }
            System.Console.WriteLine($"Sum = {sum2}");

            // Using lists
            List<double> grades = new List<double>() ;
            grades.Add(1d);
            grades.Add(2d);
            grades.Add(3d);

            double average = 0d ;
            foreach(var number in grades) {
                average += number ;
            }
            average = average / grades.Count ;
            System.Console.WriteLine($"Average = {average:N3}");


            // Print args
            if (args.Length == 0) {
                Console.WriteLine("Empty parameters");
            } else {
                Console.WriteLine($"Hello {args[0]} !");
            }
            
        }
    }
}
