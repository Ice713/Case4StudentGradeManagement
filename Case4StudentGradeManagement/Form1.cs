using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case4StudentGradeManagement
{
    public partial class Form1 : Form
    {
        private bool isFormLoading = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;

            if (listBox1.SelectedIndex < 0)
                return;
            else if (listBox1.SelectedItem is Student selectedStudent)
            {
                selectedStudent.Display();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                isFormLoading = true;
                List<Student> students = new List<Student>
                {
                    new Student("Alice", "Computer Science", 3.8),
                    new Student("Bob", "Engineering", 4.2),         // Out of range
                    new Student("Charlie", "Mathematics", 3.6),
                    new Student("Diana", "Biology", 3.9),
                    new Student("Ethan", "Physics", 5.0),           // Out of range
                    new Student("Fiona", "Chemistry", 2.7),
                    new Student("George", "History", 4.5),          // Out of range
                    new Student("Hannah", "Art", 3.3),
                    new Student("Ian", "Philosophy", 3.5),
                    new Student("Julia", "Economics", 3.0),
                };
                listBox1.DataSource = students;
                listBox1.DisplayMember = "Name";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally 
            {
                isFormLoading = false;
            }
            
        }
    }
}
