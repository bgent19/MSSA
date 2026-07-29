namespace Assignment4._2
{
    partial class TeacherDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddStudent = new Button();
            buttonDeleteStudent = new Button();
            textBoxStudentId = new TextBox();
            textBoxName = new TextBox();
            numericUpDownGPA = new NumericUpDown();
            labelStudentId = new Label();
            labelName = new Label();
            labelGpa = new Label();
            dataGridViewStudents = new DataGridView();
            buttonSaveTopStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(41, 111);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(120, 30);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.Location = new Point(41, 206);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(120, 30);
            buttonDeleteStudent.TabIndex = 1;
            buttonDeleteStudent.Text = "Delete Student";
            buttonDeleteStudent.UseVisualStyleBackColor = true;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(96, 12);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(125, 27);
            textBoxStudentId.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(96, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 3;
            // 
            // numericUpDownGPA
            // 
            numericUpDownGPA.DecimalPlaces = 2;
            numericUpDownGPA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownGPA.Location = new Point(96, 78);
            numericUpDownGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownGPA.Name = "numericUpDownGPA";
            numericUpDownGPA.Size = new Size(125, 27);
            numericUpDownGPA.TabIndex = 4;
            // 
            // labelStudentId
            // 
            labelStudentId.AutoSize = true;
            labelStudentId.Location = new Point(14, 16);
            labelStudentId.Name = "labelStudentId";
            labelStudentId.Size = new Size(79, 20);
            labelStudentId.TabIndex = 5;
            labelStudentId.Text = "Student ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(41, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Name";
            // 
            // labelGpa
            // 
            labelGpa.AutoSize = true;
            labelGpa.Location = new Point(57, 85);
            labelGpa.Name = "labelGpa";
            labelGpa.Size = new Size(36, 20);
            labelGpa.TabIndex = 7;
            labelGpa.Text = "GPA";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.AllowUserToResizeRows = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(227, 12);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(403, 224);
            dataGridViewStudents.TabIndex = 8;
            // 
            // buttonSaveTopStudent
            // 
            buttonSaveTopStudent.Location = new Point(349, 242);
            buttonSaveTopStudent.Name = "buttonSaveTopStudent";
            buttonSaveTopStudent.Size = new Size(149, 30);
            buttonSaveTopStudent.TabIndex = 9;
            buttonSaveTopStudent.Text = "Save Top Student";
            buttonSaveTopStudent.UseVisualStyleBackColor = true;
            buttonSaveTopStudent.Click += buttonSaveTopStudent_Click;
            // 
            // TeacherDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 284);
            Controls.Add(buttonSaveTopStudent);
            Controls.Add(dataGridViewStudents);
            Controls.Add(labelGpa);
            Controls.Add(labelName);
            Controls.Add(labelStudentId);
            Controls.Add(numericUpDownGPA);
            Controls.Add(textBoxName);
            Controls.Add(textBoxStudentId);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(buttonAddStudent);
            Name = "TeacherDashboardForm";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddStudent;
        private Button buttonDeleteStudent;
        private TextBox textBoxStudentId;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownGPA;
        private Label labelStudentId;
        private Label labelName;
        private Label labelGpa;
        private DataGridView dataGridViewStudents;
        private Button buttonSaveTopStudent;
    }
}