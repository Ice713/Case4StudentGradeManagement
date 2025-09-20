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
                    MessageBox.Show(
                        $"The GPA entered for student \"{Name}\" is invalid.\n\nIt will be set to 0.0 by default.",
                        "Invalid GPA Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

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
            MessageBox.Show(                
                $"Name:   {Name}\n" +
                $"Course: {Course}\n" +
                $"GPA:    {Gpa:F2}",
                "Student Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
