namespace Assignment4._1
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

            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblMobilePhone = new Label();
            txtMobilePhone = new TextBox();
            lblWorkPhone = new Label();
            txtWorkPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();

            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();

            grpDetails = new GroupBox();
            txtDetails = new TextBox();

            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDetails.SuspendLayout();
            SuspendLayout();

            // lblFirstName
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 20);
            lblFirstName.Text = "First Name:";

            // txtFirstName
            txtFirstName.Location = new Point(120, 17);
            txtFirstName.Size = new Size(180, 23);

            // lblLastName
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 52);
            lblLastName.Text = "Last Name:";

            // txtLastName
            txtLastName.Location = new Point(120, 49);
            txtLastName.Size = new Size(180, 23);

            // lblMobilePhone
            lblMobilePhone.AutoSize = true;
            lblMobilePhone.Location = new Point(20, 84);
            lblMobilePhone.Text = "Mobile Phone:";

            // txtMobilePhone
            txtMobilePhone.Location = new Point(120, 81);
            txtMobilePhone.Size = new Size(180, 23);

            // lblWorkPhone
            lblWorkPhone.AutoSize = true;
            lblWorkPhone.Location = new Point(20, 116);
            lblWorkPhone.Text = "Work Phone:";

            // txtWorkPhone
            txtWorkPhone.Location = new Point(120, 113);
            txtWorkPhone.Size = new Size(180, 23);

            // lblAddress
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 148);
            lblAddress.Text = "Address:";

            // txtAddress
            txtAddress.Location = new Point(120, 145);
            txtAddress.Size = new Size(180, 23);

            // btnAdd
            btnAdd.Location = new Point(20, 185);
            btnAdd.Size = new Size(90, 30);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            // btnDelete
            btnDelete.Location = new Point(120, 185);
            btnDelete.Size = new Size(90, 30);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;

            // btnClear
            btnClear.Location = new Point(210, 185);
            btnClear.Size = new Size(90, 30);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;

            // lblSearch
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 235);
            lblSearch.Text = "Search by Name:";

            // txtSearch
            txtSearch.Location = new Point(140, 232);
            txtSearch.Size = new Size(160, 23);

            // btnSearch
            btnSearch.Location = new Point(20, 265);
            btnSearch.Size = new Size(90, 30);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            // btnShowAll
            btnShowAll.Location = new Point(120, 265);
            btnShowAll.Size = new Size(90, 30);
            btnShowAll.Text = "Show All";
            btnShowAll.Click += btnShowAll_Click;

            // grpDetails
            grpDetails.Location = new Point(20, 305);
            grpDetails.Size = new Size(280, 150);
            grpDetails.Text = "Search Result";
            grpDetails.Controls.Add(txtDetails);

            // txtDetails
            txtDetails.Location = new Point(15, 25);
            txtDetails.Size = new Size(250, 110);
            txtDetails.Multiline = true;
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;

            // dataGridView1
            dataGridView1.Location = new Point(320, 20);
            dataGridView1.Size = new Size(550, 500);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            MinimumSize = new Size(750, 450);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblMobilePhone);
            Controls.Add(txtMobilePhone);
            Controls.Add(lblWorkPhone);
            Controls.Add(txtWorkPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnShowAll);
            Controls.Add(grpDetails);
            Controls.Add(dataGridView1);
            Text = "Personal Phone / Address Book";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblMobilePhone;
        private TextBox txtMobilePhone;
        private Label lblWorkPhone;
        private TextBox txtWorkPhone;
        private Label lblAddress;
        private TextBox txtAddress;

        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;

        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;

        private GroupBox grpDetails;
        private TextBox txtDetails;

        private DataGridView dataGridView1;
    }
}
