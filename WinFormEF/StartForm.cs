using MaterialSkin;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using WinFormEF.Customers;
using WinFormEF.Customers;
using WinFormEF.Drivers;
using WinFormEF.Drivers;

namespace WinFormEF
{
    public partial class StartForm : MaterialForm
    {
        public DriversContext dbDriversContext;
        public CustomerContext customerContext;

        public BindingSource driversBindingSource; // Declare driversBindingSource
        private BindingSource customersBindingSource;

        public StartForm()
        {
            InitializeComponent();

            this.driversBindingSource = new BindingSource(); // Initialize driversBindingSource
            this.customersBindingSource = new BindingSource(); // Initialize customersBindingSource

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // or DARK

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,  // Primary colors
                Primary.Blue200,                   // Darker shade
                Accent.LightBlue200,               // Accent color
                TextShade.WHITE                    // Text color
            );

            if (Session.UserType == "Customer")
            {
                CustomersForm costumerForm = new CustomersForm();
                costumerForm.ShowDialog();
            }

            if (Session.UserType == "Driver")
            {
                DriversForm driversForm = new DriversForm();
                driversForm.ShowDialog();
            }

            if (Session.UserType == "Driver")
            {
                DriversForm driversForm = new DriversForm();
                driversForm.ShowDialog();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbDriversContext = new DriversContext();
            this.customerContext = new CustomerContext();

            this.dbDriversContext.Database.EnsureCreated();
            this.customerContext.Database.EnsureCreated();



            this.dbDriversContext.Drivers.Load();
            this.customerContext.Customers.Load();



            this.driversBindingSource.DataSource = dbDriversContext.Drivers.Local.ToBindingList();
            this.DriverDataGrid.DataSource = this.driversBindingSource;

            this.customersBindingSource.DataSource = customerContext.Customers.Local.ToBindingList();
            this.CustomerDataGrid.DataSource = this.customersBindingSource;

            int custCount = customerContext.Customers.Count(); // EF Core LINQ Count()
            CustCount.Text = custCount.ToString();

            int driversCount = dbDriversContext.Drivers.Count(); // EF Core LINQ Count()
            DriverCount.Text = driversCount.ToString();


        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void catpronavbtn_Click(object sender, EventArgs e)
        {
            CatProForm catproForm = new CatProForm();
            catproForm.ShowDialog();
        }

        private void drivernavbtn_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.ShowDialog();

        }

        private void deliverynavbtn_Click(object sender, EventArgs e)
        {
            DeliveriesForm deliveryForm = new DeliveriesForm();
            deliveryForm.ShowDialog();
        }

        private void customernavbtn_Click(object sender, EventArgs e)
        {
            CustomersForm costumerForm = new CustomersForm();
            costumerForm.ShowDialog();
        }

       
    }


}
