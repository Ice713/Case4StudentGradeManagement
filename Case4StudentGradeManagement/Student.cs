using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case4StudentGradeManagement
{
    internal class Student
    {
        private string name;
        private string course;
        private double gpa;

        public string Name
        { 
            get { return name; } 
            set { name = value; } 
        }

        public string Course
        {
            get { return name; }
            set { name = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4.0)
                {
                    gpa = 0;
                    throw new ArgumentOutOfRangeException("Invalid GPA! Setting GPA to 0.0");
                }
                else
                    gpa = value;
            }
        }

    }
}
