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

        private List<double> grades;
        private string name;
    }
}