using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using WinFormEF.CatPro;
using WinFormEF.Customers;
using WinFormEF;


namespace WinFormEF
{
    public partial class CustomersForm : MaterialForm
    {


        public ApplicationDbContext dbCustomerContext;
        private ApplicationDbContext dbProductContext;

        private BindingSource customersBindingSource;
        public BindingSource ordersBindingSource;
        public CustomersForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // or DARK

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,  // Primary colors
                Primary.Blue200,                   // Darker shade
                Accent.LightBlue200,               // Accent color
                TextShade.WHITE                    // Text color
            );

            this.customersBindingSource = new BindingSource();

            this.ordersBindingSource = new BindingSource();


        }

        protected override void OnLoad(EventArgs e)
        {
   
            base.OnLoad(e);


            this.dbCustomerContext = new ApplicationDbContext();


            this.dbCustomerContext.Database.EnsureCreated();



            this.dbCustomerContext.Customers.Load();



            Customer customer = new Customer
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text,
                Address = Address.Text,
                age = (int)agenum.Value
            };



            //loads database table categories into the categories DataGridView
            this.customersBindingSource.DataSource = dbCustomerContext.Customers.Local.ToBindingList();
            this.customersDataGridView.DataSource = this.customersBindingSource;



            //-----------------------------------------------------------------------------------------------------------------------------








            this.ordersBindingSource.DataSource = dbCustomerContext.Orders.Local.ToBindingList();

            this.OrderGridView.DataSource = this.ordersBindingSource;

            //---------------------------------------------------------------------------------------------------------------------------


            dbProductContext = new ApplicationDbContext();




            dbProductContext.Products.Load();


            var productNames = dbProductContext.Products
                                       .Select(p => p.Name)
                                       .ToList();

            ProductListBox.Items.Clear();
            ProductListBox.Items.AddRange(productNames.ToArray());




            //---------------------------------------------------------------------------------------------------------------

            if (Session.UserType == "Admin")
            {

                customersDataGridView.Visible = true;
            }
            else
            {
                CustomersTablelbl.Visible = false;
                customersDataGridView.Visible = false;

            }
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {

            // Customers fields
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            string Address = Addresstxt.Text.Trim();
            int Age = (int)agenum.Value;

            //Order fields
            string OrderAddress = Addresstxt.Text.Trim();
            string orderDate = DateTime.Now.ToString();
            var selectedProducts = ProductListBox.SelectedItems.Cast<string>().ToList();
            string productList = string.Join(",", selectedProducts);


            Customer customer = new Customer { firstName = firstName, lastName = lastName, Address = Address, age = Age };
            Orders order = new Orders { Address = OrderAddress, orderDate = DateTime.Now, Customer = customer, products_list = productList };

            dbCustomerContext.Customers.Add(customer);
            dbCustomerContext.Orders.Add(order);

            dbCustomerContext.SaveChanges();

            MessageBox.Show("Your order of "+ productList + " to address: "+ Address +" has been placed!", "Order Confirmation",
    MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

       
    }
}
