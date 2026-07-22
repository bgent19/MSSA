using Assignment3._3._2.Models;
using System.ComponentModel;

namespace Assignment3._3._2
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> students;


        public Form1()
        {
            InitializeComponent();

            students =
            [
                new Student() {FirstName = "Brett", LastName = "Gentile", MonthOfAdmission = Month.July},
                new Student() {FirstName = "Dan", LastName = "Roche", MonthOfAdmission = Month.July},
                new Student() {FirstName = "Nate", LastName = "Chambers", MonthOfAdmission = Month.July}
            ];

            //studentBindingSource.DataSource = students;
            //StudentGridView.DataSource = studentBindingSource;
            StudentGridView.DataSource = students;

            ConfigureDropdowns();
        }

        private void ConfigureDropdowns()
        {
            // Configure Month of Admission dropdown
            var monthColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "MonthOfAdmission",
                HeaderText = "Month of Admission",
                Name = "MonthOfAdmissionColumn",
                DataSource = Enum.GetValues<Month>(),
                DropDownWidth = 150
            };

            // Configure Grade dropdown
            var gradeColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Grade",
                HeaderText = "Grade",
                Name = "GradeColumn",
                DataSource = Enum.GetValues<Grade>(),
                DropDownWidth = 100
            };

            // Remove auto-generated columns and add the combo box columns
            StudentGridView.Columns.Clear();
            StudentGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Student ID" });
            StudentGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name" });
            StudentGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name" });
            StudentGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Address", HeaderText = "Address" });
            StudentGridView.Columns.Add(monthColumn);
            StudentGridView.Columns.Add(gradeColumn);
        }

        private void BtnAddRecord_Click(object? sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student() {FirstName = "", LastName = "" };
                students.Add(newStudent);
                MessageBox.Show("New record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteRecord_Click(object? sender, EventArgs e)
        {
            try
            {
                if (StudentGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmDelete = MessageBox.Show(
                    "Are you sure you want to delete the selected record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedRow = StudentGridView.SelectedRows[0];
          
                    if (selectedRow.DataBoundItem is Student student)
                    {
                        students.Remove(student);
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
