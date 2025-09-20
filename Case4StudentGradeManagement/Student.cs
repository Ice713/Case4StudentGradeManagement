using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            get { return course; }
            set { course = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4.0)
                {
                    gpa = 0;
                    MessageBox.Show($"Invalid GPA for {Name}! Setting GPA to 0.0");
                }
                else
                    gpa = value;
            }
        }

        public Student (string name, string course, double gpa)
        {
            Name = name;
            Course = course;
            Gpa = gpa;
        }

        public void Display()
        {
            MessageBox.Show($"Student: {Name}\nCourse: {Course}\nGPA: {Gpa.ToString("F2")}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
