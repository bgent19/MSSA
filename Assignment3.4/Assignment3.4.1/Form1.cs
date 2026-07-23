using System.ComponentModel;
using Assignment3._4._1.Models;

namespace Assignment3._4._1
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Coffee> _coffees = [];

        public Form1()
        {
            InitializeComponent();

            cmbSize.DataSource = Enum.GetValues<BeverageSize>();
            cmbRoast.DataSource = Enum.GetValues<RoastLevel>();

            dgvCoffees.DataSource = _coffees;

            SeedSampleData();
        }

        private void SeedSampleData()
        {
            _coffees.Add(new Coffee { Name = "Espresso", Size = BeverageSize.Small, Price = 2.50m, Roast = RoastLevel.Dark, EspressoShots = 1, HasMilk = false });
            _coffees.Add(new Coffee { Name = "Latte", Size = BeverageSize.Medium, Price = 4.25m, Roast = RoastLevel.Medium, EspressoShots = 2, HasMilk = true });
            _coffees.Add(new Coffee { Name = "Cappuccino", Size = BeverageSize.Medium, Price = 4.00m, Roast = RoastLevel.Medium, EspressoShots = 2, HasMilk = true });
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name for the coffee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var coffee = new Coffee
            {
                Name = txtName.Text.Trim(),
                Size = (BeverageSize)cmbSize.SelectedItem!,
                Price = numPrice.Value,
                Roast = (RoastLevel)cmbRoast.SelectedItem!,
                EspressoShots = (int)numShots.Value,
                HasMilk = chkHasMilk.Checked
            };

            _coffees.Add(coffee);
            ClearInputs();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCoffees.CurrentRow?.DataBoundItem is Coffee selected)
            {
                _coffees.Remove(selected);
            }
            else
            {
                MessageBox.Show("Please select a coffee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            numPrice.Value = 0;
            cmbSize.SelectedIndex = 0;
            cmbRoast.SelectedIndex = 0;
            numShots.Value = 1;
            chkHasMilk.Checked = false;
            txtName.Focus();
        }
    }
}
