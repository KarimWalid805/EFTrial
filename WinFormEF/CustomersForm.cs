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

        private CustomerContext dbCustomerContext;
        private OrdersContext dbOrdersContext;
        private ProductsContext dbProductContext;

        private BindingSource customersBindingSource;
        private BindingSource ordersBindingSource;
        public CustomersForm()
        {
            InitializeComponent();
            this.customersBindingSource = new BindingSource();

            this.ordersBindingSource = new BindingSource();


        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            this.dbCustomerContext = new CustomerContext();

           

            this.dbCustomerContext.Database.EnsureDeleted();
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


            this.dbOrdersContext = new OrdersContext();


            this.dbOrdersContext.Database.EnsureDeleted();
            this.dbOrdersContext.Database.EnsureCreated();


            this.dbOrdersContext.Orders.Load();


            Orders order = new Orders
            {
                Address = Address.Text,
                orderDate = DateTime.Now.ToString(),
                CustomerId = customer.CustomerId,
                
            };



            this.ordersBindingSource.DataSource = dbOrdersContext.Orders.Local.ToBindingList();
            this.OrderGridView.DataSource = this.ordersBindingSource;

            //---------------------------------------------------------------------------------------------------------------------------


            dbProductContext = new ProductsContext();
            dbProductContext.Database.EnsureCreated();
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

                customersDataGridView.Visible = false;

            }
        }

        private void AddCust_Click(object sender, EventArgs e)
        {

            // Customers fields
            string firstName = FirstNametxt.Text.Trim();
            string lastName = LastNametxt.Text.Trim();
            string Address = Addresstxt.Text.Trim();
            int Age = (int)agenum.Value;


            Customer customer = new Customer { firstName = firstName, lastName = lastName, Address = Address, age = Age };
            dbCustomerContext.Customers.Local.Add(customer);
            dbCustomerContext.SaveChanges();

            //Order fields
            string Address2 = Addresstxt.Text.Trim();
            string orderDate = DateTime.Now.ToString();
            var selectedProducts = ProductListBox.SelectedItems.Cast<string>().ToList();
            string productList = string.Join(",", selectedProducts);


            Orders order = new Orders { Address = Address2, orderDate = orderDate, CustomerId =  customer.CustomerId, products_list = productList };
            dbOrdersContext.Orders.Local.Add(order);
            dbOrdersContext.SaveChanges();
        }
    }
}
