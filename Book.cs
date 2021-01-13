using System;
using System.Collections.Generic;
using System.Text;

namespace gradebook
{
    class Book
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade); 
        }
        List<double> grades;
    }
}
