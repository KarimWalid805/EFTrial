using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace WinFormEF
{
    public partial class DriversForm : Form
    {
        private DriversContext dbContext;
        private BindingSource driversBindingSource; // Declare driversBindingSource

        public DriversForm()
        {
            InitializeComponent();
            this.driversBindingSource = new BindingSource(); // Initialize driversBindingSource
        }

       

     
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            VehicleBox.Items.AddRange(new string[] { "Train", "Car", "Truck" });

            this.dbContext = new DriversContext();

            //Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Drivers.Load();
            Driver driver = new Driver
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text
            };
            //loads database table categories into the categories DataGridView
            this.driversBindingSource.DataSource = dbContext.Drivers.Local.ToBindingList();
            this.DriverGridView.DataSource = this.driversBindingSource;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            int Age = (int)Agetxt.Value;
            string vehicleType = VehicleBox.SelectedItem?.ToString();

            Driver driver = new Driver { firstName = firstName, lastName = lastName, age = Age, vehicleType = vehicleType };
            dbContext.Drivers.Local.Add(driver);
            dbContext.SaveChanges();
    }
    }
}
