using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades ;
        private string name ;

        internal Book(string name) {
            this.name = name ;
            this.grades = new List<double>() ;
        }

        internal void AddGrade(double grade)
        {
            grades.Add(grade) ;
        }

        internal void ShowStatistics()
        {
            var sum2 = 0d ;
            var highGrade = double.MinValue ;
            foreach(var number in grades) 
            {
                highGrade = Math.Max(number,highGrade) ;
                sum2 += number ;
            }
            System.Console.WriteLine($"Sum = {sum2}");
            System.Console.WriteLine($"Highest grade = {highGrade}");
        }
    }

}