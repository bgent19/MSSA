using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4._2
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"{StudentName} (id: {StudentId}) - GPA: {GPA}";
        }
    }
}
