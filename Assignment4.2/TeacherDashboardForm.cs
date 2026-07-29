using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class TeacherDashboardForm : Form
    {
        private readonly BindingList<Student> students = new();
        private readonly BindingSource bindingSource = new();

        public TeacherDashboardForm()
        {
            InitializeComponent();

            bindingSource.DataSource = students;
            dataGridViewStudents.DataSource = bindingSource;

            SeedStudents();
            SortStudentsById();
        }

        private void SeedStudents()
        {
            students.Add(new Student
            {
                StudentId = 5550101,
                StudentName = "Ada Lovelace",
                GPA = 3.7m

            });
            students.Add(new Student
            {
                StudentId = 5550201,
                StudentName = "Grace Hopper",
                GPA = 3.5m
            });
            students.Add(new Student
            {
                StudentId = 5550301,
                StudentName = "Alan Turing",
                GPA = 3.3m
            });
            students.Add(new Student
            {
                StudentId = 5550401,
                StudentName = "Katherine Johnson",
                GPA = 3.1m
            });
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            List<string> _errors = [];

            if (!int.TryParse(textBoxStudentId.Text, out var studentId) || studentId <= 0)
            {
                textBoxStudentId.Text = string.Empty;
                _errors.Add("Student ID must be a whole number greater than 0.");
            }

            if (textBoxName.Text == "")
            {
                _errors.Add("Name cannot be blank.");
            }

            if (numericUpDownGPA.Value < 0.0m || numericUpDownGPA.Value > 4.0m)
            {
                numericUpDownGPA.Value = 0.0m;
                _errors.Add("GPA must be between 0 and 4.");
            }

            if (_errors.Count() > 0)
            {
                MessageBox.Show(string.Join("\n\n", _errors),
                 "Input Errors",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else
            {
                var newStudent = new Student
                {
                    StudentId = studentId,
                    StudentName = textBoxName.Text,
                    GPA = numericUpDownGPA.Value
                };
                students.Add(newStudent);

                SortStudentsById();
                SelectStudentRow(newStudent);
            }

        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            int index = dataGridViewStudents.CurrentCell.RowIndex;

            students.RemoveAt(index);

            SortStudentsById();
            SelectStudentRow(students.First());
        }

        private void SortStudentsById()
        {
            var sorted = students.OrderBy(s => s.StudentId).ToList();

            students.RaiseListChangedEvents = false;
            students.Clear();
            foreach (var student in sorted)
            {
                students.Add(student);
            }
            students.RaiseListChangedEvents = true;
            students.ResetBindings();
        }

        private void SelectStudentRow(Student student)
        {
            var index = students.IndexOf(student);
            if (index < 0)
            {
                return;
            }

            dataGridViewStudents.ClearSelection();
            var row = dataGridViewStudents.Rows[index];
            row.Selected = true;
            dataGridViewStudents.CurrentCell = row.Cells[0];
        }


    }
}
