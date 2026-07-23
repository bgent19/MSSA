namespace Assignment3._4._1
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
            dgvCoffees = new DataGridView();
            grpDetails = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSize = new Label();
            cmbSize = new ComboBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblRoast = new Label();
            cmbRoast = new ComboBox();
            lblShots = new Label();
            numShots = new NumericUpDown();
            chkHasMilk = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShots).BeginInit();
            SuspendLayout();
            // 
            // dgvCoffees
            // 
            dgvCoffees.AllowUserToAddRows = false;
            dgvCoffees.AllowUserToDeleteRows = false;
            dgvCoffees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCoffees.ColumnHeadersHeight = 29;
            dgvCoffees.Dock = DockStyle.Top;
            dgvCoffees.Location = new Point(0, 0);
            dgvCoffees.Margin = new Padding(3, 4, 3, 4);
            dgvCoffees.Name = "dgvCoffees";
            dgvCoffees.ReadOnly = true;
            dgvCoffees.RowHeadersVisible = false;
            dgvCoffees.RowHeadersWidth = 51;
            dgvCoffees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoffees.Size = new Size(782, 400);
            dgvCoffees.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblName);
            grpDetails.Controls.Add(txtName);
            grpDetails.Controls.Add(lblSize);
            grpDetails.Controls.Add(cmbSize);
            grpDetails.Controls.Add(lblPrice);
            grpDetails.Controls.Add(numPrice);
            grpDetails.Controls.Add(lblRoast);
            grpDetails.Controls.Add(cmbRoast);
            grpDetails.Controls.Add(lblShots);
            grpDetails.Controls.Add(numShots);
            grpDetails.Controls.Add(chkHasMilk);
            grpDetails.Controls.Add(btnAdd);
            grpDetails.Controls.Add(btnDelete);
            grpDetails.Dock = DockStyle.Bottom;
            grpDetails.Location = new Point(0, 400);
            grpDetails.Margin = new Padding(3, 4, 3, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(3, 4, 3, 4);
            grpDetails.Size = new Size(782, 215);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Coffee Details";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 36);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 27);
            txtName.TabIndex = 1;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(297, 40);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size:";
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.Location = new Point(377, 36);
            cmbSize.Margin = new Padding(3, 4, 3, 4);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(125, 28);
            cmbSize.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(526, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(583, 36);
            numPrice.Margin = new Padding(3, 4, 3, 4);
            numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(103, 27);
            numPrice.TabIndex = 5;
            // 
            // lblRoast
            // 
            lblRoast.AutoSize = true;
            lblRoast.Location = new Point(16, 88);
            lblRoast.Name = "lblRoast";
            lblRoast.Size = new Size(49, 20);
            lblRoast.TabIndex = 6;
            lblRoast.Text = "Roast:";
            // 
            // cmbRoast
            // 
            cmbRoast.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoast.Location = new Point(103, 84);
            cmbRoast.Margin = new Padding(3, 4, 3, 4);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(171, 28);
            cmbRoast.TabIndex = 7;
            // 
            // lblShots
            // 
            lblShots.AutoSize = true;
            lblShots.Location = new Point(297, 88);
            lblShots.Name = "lblShots";
            lblShots.Size = new Size(109, 20);
            lblShots.TabIndex = 8;
            lblShots.Text = "Espresso Shots:";
            // 
            // numShots
            // 
            numShots.Location = new Point(433, 84);
            numShots.Margin = new Padding(3, 4, 3, 4);
            numShots.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numShots.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numShots.Name = "numShots";
            numShots.Size = new Size(69, 27);
            numShots.TabIndex = 9;
            numShots.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkHasMilk
            // 
            chkHasMilk.AutoSize = true;
            chkHasMilk.Location = new Point(526, 87);
            chkHasMilk.Margin = new Padding(3, 4, 3, 4);
            chkHasMilk.Name = "chkHasMilk";
            chkHasMilk.Size = new Size(88, 24);
            chkHasMilk.TabIndex = 10;
            chkHasMilk.Text = "Has Milk";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 147);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Coffee";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(171, 147);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected";
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 615);
            Controls.Add(dgvCoffees);
            Controls.Add(grpDetails);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(797, 651);
            Name = "Form1";
            Text = "Coffee Menu Manager";
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShots).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCoffees;
        private GroupBox grpDetails;
        private Label lblName;
        private TextBox txtName;
        private Label lblSize;
        private ComboBox cmbSize;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblRoast;
        private ComboBox cmbRoast;
        private Label lblShots;
        private NumericUpDown numShots;
        private CheckBox chkHasMilk;
        private Button btnAdd;
        private Button btnDelete;
    }
}
