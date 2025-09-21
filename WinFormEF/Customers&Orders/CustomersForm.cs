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
        private List<string> allProducts;

        protected override void OnLoad(EventArgs e)
        {
            FirstNametxt.Text = Session.UserFirstName;
            LastNametxt.Text = Session.UserLastName;
            Addresstxt.Text = Session.Address;
            firstnamewelcome.Text = Session.UserFirstName + "!";
            usernametxt.Text = Session.UserName;



            base.OnLoad(e);


            this.dbCustomerContext = new ApplicationDbContext();


            this.dbCustomerContext.Database.EnsureCreated();



            this.dbCustomerContext.Customers.Load();



            Customer customer = new Customer
            {
                firstName = FirstNametxt.Text,
                lastName = LastNametxt.Text,
                Address = Address.Text,
            };







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

            allProducts = dbProductContext.Products
                              .Select(p => p.Name)
                              .ToList();


            LoadProducts(allProducts);

            SearchBox.TextChanged += SearchBox_TextChanged;
        }

        private void LoadProducts(List<string> products)
        {
            ProductListBox.Items.Clear();
            ProductListBox.Items.AddRange(products.ToArray());
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string query = SearchBox.Text.Trim().ToLower();

            var filtered = allProducts
                .Where(p => p.ToLower().Contains(query))
                .ToList();

            LoadProducts(filtered);
        }


        //---------------------------------------------------------------------------------------------------------------




        private void MakeOrder_Click(object sender, EventArgs e)
        {
            // Customers fields
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            string Address = Addresstxt.Text.Trim();

            //Order fields
            string OrderAddress = Addresstxt.Text.Trim();
            string orderDate = DateTime.Now.ToString();
            var selectedProducts = ProductListBox.CheckedItems.Cast<string>().ToList();
            string productList = string.Join(",", selectedProducts);

            if (productList == string.Empty)
            {
                MessageBox.Show("Please choose products to order!");
            }
            else
            {
                Customer customer = new Customer { firstName = firstName, lastName = lastName, Address = Address };
                Orders order = new Orders { Address = OrderAddress, orderDate = DateTime.Now, Customer = customer, products_list = productList };
                dbCustomerContext.Customers.Add(customer);
                dbCustomerContext.Orders.Add(order);

                dbCustomerContext.SaveChanges();

                MessageBox.Show("Your order of " + productList + " to address: " + Address + " has been placed!", "Order Confirmation",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cancelorderbtn_Click(object sender, EventArgs e)
        {

            if (OrderGridView.CurrentRow != null)
            {
                string PMessage = "Are you sure you want to delete this order?";
                string PTitle = "Delete Confirmation";
                var SelectedOrder = OrderGridView.CurrentRow.DataBoundItem as Orders;


                if (SelectedOrder != null)
                {


                    if (MessageBox.Show(PMessage, PTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbCustomerContext.Orders.Attach(SelectedOrder);
                        dbCustomerContext.Orders.Remove(SelectedOrder);
                        dbCustomerContext.SaveChanges();
                    }

                }

            }


        }
    }
}
