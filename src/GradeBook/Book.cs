using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //explicit constuctor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result +=number;
            }
            result = result/grades.Count;
            System.Console.WriteLine($"The highest grade is {highGrade:N1}. \nThe lowest grade is {lowGrade:N1}. \nThe average grade is {result:N1}.");
        }

        private List<double> grades;
        private string name;
    }
}