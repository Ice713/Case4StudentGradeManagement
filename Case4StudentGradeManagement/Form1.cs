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
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                List<Student> students = new List<Student>
                {
                    new Student("Alice", "Computer Science", 3.8),
                    new Student("Bob", "Engineering", 5.5),
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
            
        }
    }
}
