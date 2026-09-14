namespace Assignment10._3
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
            dgvCars = new DataGridView();
            lblVIN = new Label();
            txtVIN = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblMileage = new Label();
            txtMileage = new TextBox();
            lblColor = new Label();
            txtColor = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            //
            // dgvCars
            //
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(12, 12);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(776, 250);
            dgvCars.TabIndex = 0;
            dgvCars.SelectionChanged += dgvCars_SelectionChanged;
            //
            // lblVIN
            //
            lblVIN.AutoSize = true;
            lblVIN.Location = new Point(12, 280);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(28, 15);
            lblVIN.Text = "VIN";
            //
            // txtVIN
            //
            txtVIN.Location = new Point(80, 277);
            txtVIN.MaxLength = 17;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(200, 23);
            txtVIN.TabIndex = 1;
            //
            // lblMake
            //
            lblMake.AutoSize = true;
            lblMake.Location = new Point(12, 310);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(36, 15);
            lblMake.Text = "Make";
            //
            // txtMake
            //
            txtMake.Location = new Point(80, 307);
            txtMake.MaxLength = 50;
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(200, 23);
            txtMake.TabIndex = 2;
            //
            // lblModel
            //
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 340);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.Text = "Model";
            //
            // txtModel
            //
            txtModel.Location = new Point(80, 337);
            txtModel.MaxLength = 50;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 3;
            //
            // lblYear
            //
            lblYear.AutoSize = true;
            lblYear.Location = new Point(12, 370);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.Text = "Year";
            //
            // txtYear
            //
            txtYear.Location = new Point(80, 367);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(200, 23);
            txtYear.TabIndex = 4;
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(320, 280);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.Text = "Price";
            //
            // txtPrice
            //
            txtPrice.Location = new Point(388, 277);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            //
            // lblMileage
            //
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(320, 310);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(50, 15);
            lblMileage.Text = "Mileage";
            //
            // txtMileage
            //
            txtMileage.Location = new Point(388, 307);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(200, 23);
            txtMileage.TabIndex = 6;
            //
            // lblColor
            //
            lblColor.AutoSize = true;
            lblColor.Location = new Point(320, 340);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.Text = "Color";
            //
            // txtColor
            //
            txtColor.Location = new Point(388, 337);
            txtColor.MaxLength = 30;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(200, 23);
            txtColor.TabIndex = 7;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(620, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 28);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(620, 311);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 28);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(620, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 28);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // btnClear
            //
            btnClear.Location = new Point(620, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(168, 28);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(dgvCars);
            Controls.Add(lblVIN);
            Controls.Add(txtVIN);
            Controls.Add(lblMake);
            Controls.Add(txtMake);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblYear);
            Controls.Add(txtYear);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblMileage);
            Controls.Add(txtMileage);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            MinimumSize = new Size(816, 459);
            Name = "Form1";
            Text = "Car Inventory";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCars;
        private Label lblVIN;
        private TextBox txtVIN;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblMileage;
        private TextBox txtMileage;
        private Label lblColor;
        private TextBox txtColor;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
