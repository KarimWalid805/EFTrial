using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Windows.Forms;
using WinFormEF.CatPro;
using WinFormEF.Customers;
using WinFormEF.Drivers;

namespace WinFormEF
{
    public partial class DriversForm : MaterialForm
    {
        public ApplicationDbContext dbDriversContext;
        public ApplicationDbContext dbOrdersContext;
        public ApplicationDbContext dbDeliveryContext;

        public BindingSource driverOrdersBindingSource;
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
            this.driverOrdersBindingSource = new BindingSource();

        }




        protected override void OnLoad(EventArgs e)
        {

            FirstNametxt.Text = Session.UserFirstName;
            LastNametxt.Text = Session.UserLastName;
            usernametxt.Text = Session.UserName;


            base.OnLoad(e);
            VehicleBox.Items.AddRange(new string[] { "Train", "Car", "Truck" });

            this.dbDriversContext = new ApplicationDbContext();
            this.dbOrdersContext = new ApplicationDbContext();
            this.dbDeliveryContext = new ApplicationDbContext();



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
            Driver driver = new Driver { firstName = firstName, lastName = lastName, age = Age, vehicleType = vehicleType };
            dbDriversContext.Drivers.Add(driver);
            dbDriversContext.SaveChanges();

         

            if (OrderGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            var selectedOrder = OrderGridView.SelectedRows[0].DataBoundItem as Orders;
            if (selectedOrder == null)
            {
                MessageBox.Show("Invalid order selection.");
                return;
            }

            int orderId = selectedOrder.OrdersId; // direct access to entity property

            // 4. Load the order (with customer)
            var order = dbOrdersContext.Orders
                .Include(o => o.Customer)
                .FirstOrDefault(o => o.OrdersId == orderId);

            if (order == null)
            {
                MessageBox.Show("Order not found!");
                return;
            }

            // Create delivery
            Delivery delivery = new Delivery
            {
                DriverId = driver.DriverId,
                OrdersId = order.OrdersId,
                DeliveryDate = DateTime.Now, // or some logic
                customersName = order.Customer.firstName,
                customersAddress = order.Customer.Address
            };
            dbDeliveryContext.Deliveries.Add(delivery);
            dbDeliveryContext.SaveChanges();


            MessageBox.Show("Delivery created successfully!");

            









        }



        
    }
}
