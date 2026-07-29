namespace Assignment4._2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserId.Text == "Teacher" && textBoxPassword.Text == "Admin")
            {
                this.Hide();
                TeacherDashboardForm form = new(); // instantiiate Form

                form.FormClosed += (s, args) => this.Close(); // Link Closing of dashboard to this form

                form.Show(); // Display dashboard
                form.Activate(); // focus dashboard
            }
            else
            {
                textBoxPassword.Text = string.Empty;
            }
        }
    }
}
