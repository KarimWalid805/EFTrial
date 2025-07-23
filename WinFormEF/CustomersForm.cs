using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormEF
{
    public partial class CustomersForm : Form
    {

        private CustomerContext dbContext;
        private BindingSource customersBindingSource; // Declare driversBindingSource
        public CustomersForm()
        {
            InitializeComponent();
            this.customersBindingSource = new BindingSource();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CustomerContext();

            //Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Customers.Load();

            Customer customer = new Customer
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text,
                Address = Address.Text,
                age = (int)agenum.Value
            };

            //loads database table categories into the categories DataGridView
            this.customersBindingSource.DataSource = dbContext.Customers.Local.ToBindingList();
            this.customersDataGridView.DataSource = this.customersBindingSource;

            if (Session.UserType == "Admin")
            {

                customersDataGridView.Visible = true;
            }
            else
            {

                customersDataGridView.Visible = false;

            }
        }

        private void AddCust_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            string Address = Addresstxt.Text.Trim();


            int Age = (int)agenum.Value;


            Customer customer = new Customer { firstName = firstName, lastName = lastName, Address = Address, age = Age };
            dbContext.Customers.Local.Add(customer);
            dbContext.SaveChanges();
        }
    }
}
