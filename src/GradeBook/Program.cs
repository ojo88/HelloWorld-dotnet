using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Joseph's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

           /* var x = 34.1;  //like javascript, i can use var. var is an implicit data type and is defiend by the data stored in the vairable.  
            var y = 10.3;  //Basically it tells the compiler to figure out the type by what's stored in the variable at compilation. x and y become double 
            var result = x + y;
            */

            //double[] numbers = new double[3];
            //var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            //List<double> grades = new List<double>();
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                // if(number > highGrade) {
                //     highGrade = number;
                // } The following code below is the equivalent.
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result +=number;
            }
            result = result/grades.Count;
            System.Console.WriteLine($"The highest grade is {highGrade:N1}. \nThe lowest grade is {lowGrade:N1}. \nThe average grade is {result:N1}.");


        }
    }
}
