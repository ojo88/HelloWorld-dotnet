using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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
            foreach(double number in grades){
                result +=number;
            }
            result = result/grades.Count;
            System.Console.WriteLine($"The average grade is {result:N1}");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else{
                Console.WriteLine("Hello!");
            }

        }
    }
}
