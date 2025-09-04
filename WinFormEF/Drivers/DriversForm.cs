using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Windows.Forms;
using WinFormEF.Customers;
using WinFormEF.Drivers;

namespace WinFormEF
{
    public partial class DriversForm : MaterialForm
    {
        public DriversContext dbDriversContext;
        public CustomerContext dbOrdersContext;
        public DriversContext dbDeliveryContext;


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
            this.dbDeliveryContext = new DriversContext();



            this.dbDriversContext.Database.EnsureCreated();

            this.dbDeliveryContext.Database.EnsureCreated();

            this.dbOrdersContext.Orders.Load();
            

            this.ordersBindingSource.DataSource = dbOrdersContext.Orders.Local.ToBindingList();
            this.OrderGridView.DataSource = this.ordersBindingSource;

            this.dbDriversContext.Drivers.Load();

            Driver driver = new Driver
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text,
                age = (int)Agetxt.Value,
                vehicleType = VehicleBox.ToString()

            };
           





        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            int Age = (int)Agetxt.Value;
            string vehicleType = VehicleBox.SelectedItem?.ToString();


            //get the orderId from the datagridview
            DataGridViewRow selectedRow1 = OrderGridView.SelectedRows[0];

            string cellValue = selectedRow1.Cells["OrderId"].Value.ToString();

            DataGridViewRow currentRow = OrderGridView.CurrentRow;

            string OrderIdCellValue = currentRow.Cells["OrderId"].Value.ToString();


            //get the DOA from the datagridview
            DataGridViewRow selectedRow2 = OrderGridView.SelectedRows[0];

            DateTime cellValue2 = (DateTime)selectedRow2.Cells["orderDate"].Value;

           
            




            Driver driver = new Driver { firstName = firstName, lastName = lastName, age = Age, vehicleType = vehicleType };
            dbDriversContext.Drivers.Local.Add(driver);
            dbDriversContext.SaveChanges();

           // Delivery delivery = new Delivery( driver.DriverId, OrderIdCellValue, cellValue2, C);

            

        }



        private void Savebtn_Click(object sender, EventArgs e)
        {
            dbDriversContext.SaveChanges();
        }

        private void DriverGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
