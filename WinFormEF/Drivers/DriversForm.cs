using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using WinFormEF.Customers;
using WinFormEF.Drivers;

namespace WinFormEF
{
    public partial class DriversForm : MaterialForm
    {
        public DriversContext dbDriversContext;
        public CustomerContext dbOrdersContext;

        public BindingSource driversBindingSource; // Declare driversBindingSource

        public DriversForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // or DARK

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green300, Primary.Green400,  // Primary colors
                Primary.Green500,                   // Darker shade
                Accent.LightBlue200,               // Accent color
                TextShade.WHITE                    // Text color
            );

            this.driversBindingSource = new BindingSource(); // Initialize driversBindingSource
            this.ordersBindingSource = new BindingSource();
        }




        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            VehicleBox.Items.AddRange(new string[] { "Train", "Car", "Truck" });

            this.dbDriversContext = new DriversContext();
            this.dbOrdersContext = new CustomerContext();


            this.dbDriversContext.Database.EnsureCreated();


            this.dbDriversContext.Drivers.Load();
            this.dbOrdersContext.Orders.Load();

            Driver driver = new Driver
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text,
                age = (int)Agetxt.Value,
                vehicleType = VehicleBox.ToString()

            };
            this.driversBindingSource.DataSource = dbDriversContext.Drivers.Local.ToBindingList();
            this.DriverGridView.DataSource = this.driversBindingSource;

            this.ordersBindingSource.DataSource = dbOrdersContext.Orders.Local.ToBindingList();
            this.OrderGridView.DataSource = this.ordersBindingSource;
            if (Session.UserType == "Admin")
            {
                
                DriverGridView.Visible = true;
            }
            else
            {
                
                DriverGridView.Visible = false;

            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            int Age = (int)Agetxt.Value;
            string vehicleType = VehicleBox.SelectedItem?.ToString();

            Driver driver = new Driver { firstName = firstName, lastName = lastName, age = Age, vehicleType = vehicleType };
            dbDriversContext.Drivers.Local.Add(driver);
            dbDriversContext.SaveChanges();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (DriverGridView.CurrentRow != null)
            {
                string PMessage = "Are you sure you want to remove this driver?";
                string PTitle = "Delete Confirmation";
                var SelectedDriver = DriverGridView.CurrentRow.DataBoundItem as Driver;


                if (SelectedDriver != null)
                {


                    if (MessageBox.Show(PMessage, PTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbDriversContext.Drivers.Attach(SelectedDriver);
                        dbDriversContext.Drivers.Remove(SelectedDriver);
                        dbDriversContext.SaveChanges();
                    }

                }

            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            dbDriversContext.SaveChanges();
        }

     

    }
}
