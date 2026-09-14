namespace Assignment10._3
{
    public partial class Form1 : Form
    {
        // Id of the car currently selected in the grid. 0 means nothing selected.
        private int _selectedCarId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadCars();
        }

        // READ - load all cars from the database into the grid
        private void LoadCars()
        {
            using (var db = new CarContext())
            {
                List<Car> cars = db.Cars.OrderBy(c => c.Make).ThenBy(c => c.Model).ToList();
                dgvCars.DataSource = cars;
            }

            // Hide the Id column, the user does not need to see it.
            DataGridViewColumn? idColumn = dgvCars.Columns["Id"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
            }

            // Show price as currency.
            DataGridViewColumn? priceColumn = dgvCars.Columns["Price"];
            if (priceColumn != null)
            {
                priceColumn.DefaultCellStyle.Format = "C2";
            }

            ClearForm();
        }

        // CREATE - add a new car
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car? car = ReadCarFromForm();
            if (car == null)
            {
                return; // validation failed, message already shown
            }

            try
            {
                using (var db = new CarContext())
                {
                    db.Cars.Add(car);
                    db.SaveChanges();
                }

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add car. Make sure the VIN is unique.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE - save changes to the selected car
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCarId == 0)
            {
                MessageBox.Show("Please select a car in the grid first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Car? input = ReadCarFromForm();
            if (input == null)
            {
                return;
            }

            try
            {
                using (var db = new CarContext())
                {
                    Car? car = db.Cars.Find(_selectedCarId);
                    if (car == null)
                    {
                        MessageBox.Show("That car no longer exists.", "Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadCars();
                        return;
                    }

                    // Copy the new values onto the tracked entity
                    car.VIN = input.VIN;
                    car.Make = input.Make;
                    car.Model = input.Model;
                    car.Year = input.Year;
                    car.Price = input.Price;
                    car.Mileage = input.Mileage;
                    car.Color = input.Color;

                    db.SaveChanges();
                }

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update car. Make sure the VIN is unique.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE - remove the selected car
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCarId == 0)
            {
                MessageBox.Show("Please select a car in the grid first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show("Are you sure you want to delete this car?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (var db = new CarContext())
                {
                    Car? car = db.Cars.Find(_selectedCarId);
                    if (car != null)
                    {
                        db.Cars.Remove(car);
                        db.SaveChanges();
                    }
                }

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete car.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // When the user clicks a row, copy its values into the text boxes.
        private void dgvCars_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null || dgvCars.CurrentRow.DataBoundItem is not Car car)
            {
                return;
            }

            _selectedCarId = car.Id;
            txtVIN.Text = car.VIN;
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtYear.Text = car.Year.ToString();
            txtPrice.Text = car.Price.ToString("0.00");
            txtMileage.Text = car.Mileage.ToString();
            txtColor.Text = car.Color;
        }

        // Reads the text boxes, validates them, and returns a Car.
        // Returns null (and shows a message) if something is wrong.
        private Car? ReadCarFromForm()
        {
            string vin = txtVIN.Text.Trim().ToUpper();
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            string color = txtColor.Text.Trim();

            if (vin.Length == 0 || make.Length == 0 || model.Length == 0)
            {
                MessageBox.Show("VIN, Make and Model are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Please enter a valid year.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!int.TryParse(txtMileage.Text, out int mileage) || mileage < 0)
            {
                MessageBox.Show("Please enter a valid mileage.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Car
            {
                VIN = vin,
                Make = make,
                Model = model,
                Year = year,
                Price = price,
                Mileage = mileage,
                Color = color
            };
        }

        private void ClearForm()
        {
            _selectedCarId = 0;
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            txtMileage.Clear();
            txtColor.Clear();
            dgvCars.ClearSelection();
            txtVIN.Focus();
        }
    }
}
