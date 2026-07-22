namespace Assignment3._3._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StudentGridView = new DataGridView();
            studentBindingSource = new BindingSource(components);
            btnAddRecord = new Button();
            btnDeleteRecord = new Button();
            pnlButtonPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)StudentGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            pnlButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StudentGridView
            // 
            StudentGridView.AllowUserToAddRows = false;
            StudentGridView.AllowUserToDeleteRows = false;
            StudentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGridView.Dock = DockStyle.Fill;
            StudentGridView.Location = new Point(0, 60);
            StudentGridView.Name = "StudentGridView";
            StudentGridView.RowHeadersWidth = 51;
            StudentGridView.Size = new Size(800, 390);
            StudentGridView.TabIndex = 0;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(12, 12);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(120, 40);
            btnAddRecord.TabIndex = 1;
            btnAddRecord.Text = "Add New Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += BtnAddRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(138, 12);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(120, 40);
            btnDeleteRecord.TabIndex = 2;
            btnDeleteRecord.Text = "Delete Record";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += BtnDeleteRecord_Click;
            // 
            // pnlButtonPanel
            // 
            pnlButtonPanel.Controls.Add(btnAddRecord);
            pnlButtonPanel.Controls.Add(btnDeleteRecord);
            pnlButtonPanel.Dock = DockStyle.Top;
            pnlButtonPanel.Location = new Point(0, 0);
            pnlButtonPanel.Name = "pnlButtonPanel";
            pnlButtonPanel.Size = new Size(800, 60);
            pnlButtonPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentGridView);
            Controls.Add(pnlButtonPanel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)StudentGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            pnlButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StudentGridView;
        private BindingSource studentBindingSource;
        private Button btnAddRecord;
        private Button btnDeleteRecord;
        private Panel pnlButtonPanel;
    }
}
