using System.ComponentModel;

namespace Assignment4._1
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Person> contacts = new();
        private readonly BindingSource bindingSource = new();

        public Form1()
        {
            InitializeComponent();

            bindingSource.DataSource = contacts;
            bindingSource.Sort = "LastName, FirstName";
            bindingSource.CurrentChanged += bindingSource_CurrentChanged;
            dataGridView1.DataSource = bindingSource;

            SeedContacts();
        }

        private void SeedContacts()
        {
            contacts.Add(new Person
            {
                FirstName = "Ada",
                LastName = "Lovelace",
                MobilePhone = "555-0101",
                WorkPhone = "555-0102",
                Address = "12 Analytical Engine Ave, London"
            });
            contacts.Add(new Person
            {
                FirstName = "Grace",
                LastName = "Hopper",
                MobilePhone = "555-0201",
                WorkPhone = "555-0202",
                Address = "1 Compiler Court, Arlington, VA"
            });
            contacts.Add(new Person
            {
                FirstName = "Alan",
                LastName = "Turing",
                MobilePhone = "555-0301",
                WorkPhone = "555-0302",
                Address = "45 Bletchley Park Rd, Milton Keynes"
            });
            contacts.Add(new Person
            {
                FirstName = "Katherine",
                LastName = "Johnson",
                MobilePhone = "555-0401",
                WorkPhone = "555-0402",
                Address = "300 Trajectory Ln, Hampton, VA"
            });
        }

        private static string BuildKey(string firstName, string lastName)
        {
            return $"{firstName.Trim()} {lastName.Trim()}".Trim();
        }

        private Person? FindByKey(string key)
        {
            return contacts.FirstOrDefault(p =>
                BuildKey(p.FirstName, p.LastName).Equals(key, StringComparison.OrdinalIgnoreCase));
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("First name and last name are required.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string key = BuildKey(firstName, lastName);

            if (FindByKey(key) is not null)
            {
                MessageBox.Show($"A contact named \"{key}\" already exists.", "Duplicate Contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                MobilePhone = txtMobilePhone.Text.Trim(),
                WorkPhone = txtWorkPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            contacts.Add(person);
            bindingSource.Position = bindingSource.IndexOf(person);
            ClearInputs();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (bindingSource.Current is not Person person)
            {
                MessageBox.Show("Select a contact in the grid to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string key = BuildKey(person.FirstName, person.LastName);
            var confirm = MessageBox.Show($"Are you sure you want to delete \"{key}\"?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                ClearInputs();
                txtDetails.Clear();
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Enter a name to search for.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var person = FindByKey(key);

            if (person is not null)
            {
                int index = bindingSource.IndexOf(person);
                bindingSource.Position = index;
                txtDetails.Text = person.ToString();
            }
            else
            {
                txtDetails.Clear();
                MessageBox.Show($"No contact named \"{key}\" was found.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            txtDetails.Clear();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void bindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (bindingSource.Current is Person person)
            {
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtMobilePhone.Text = person.MobilePhone;
                txtWorkPhone.Text = person.WorkPhone;
                txtAddress.Text = person.Address;
                txtDetails.Text = person.ToString();
            }
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMobilePhone.Clear();
            txtWorkPhone.Clear();
            txtAddress.Clear();
        }
    }
}
