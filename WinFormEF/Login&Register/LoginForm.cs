using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEF
{
    public partial class LoginForm : MaterialForm
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public LoginForm()
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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=KARIMSPC;Database=OnlineDeliveryDB;Integrated Security=True;TrustServerCertificate=True;");
            con.Open();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registration = new RegisterForm();
            registration.ShowDialog();
        }

        private async void loginbtn_Click(object sender, EventArgs e)
        {
            if (customerRadio.Checked)
            {
                Session.UserType = "Customer";
                if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
                {
                    bool loginSuccess = await LoginCustomerAsync(usernametxt.Text, passwordtxt.Text);
                    if (loginSuccess)
                    {
                        this.Hide();

                        CustomersForm Customer = new CustomersForm();
                        Customer.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No customer's Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (driverRadio.Checked)
            {
                Session.UserType = "Driver";

                if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
                {

                    bool loginSuccess = await LoginDriverAsync(usernametxt.Text, passwordtxt.Text);
                    if (loginSuccess)
                    {
                        this.Hide();

                        DriversForm Driver = new DriversForm();
                        Driver.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No driver's Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (adminRadio.Checked)
            {
                Session.UserType = "Admin";

                if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
                {

                    bool loginSuccess = await LoginDriverAsync(usernametxt.Text, passwordtxt.Text);
                    if (loginSuccess)
                    {
                        this.Hide();

                        DriversForm Driver = new DriversForm();
                        Driver.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No driver's Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class LoginDto
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }


        // Customer Login

        public async Task<bool> LoginCustomerAsync(string username, string password)
        {
            using var client = new HttpClient();
            var login = new LoginDto { Username = username, Password = password };

            var response = await client.PostAsJsonAsync("https://localhost:7294/api/auth/customer", login);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<CustomerResult>();
                // Set session values
                Session.UserName = result.Username;
                Session.UserFirstName = result.FirstName;
                Session.UserLastName = result.LastName;
                Session.Address = result.Address;
                Session.UserType = "Customer";
                return true;
            }
            else
            {
                // Handle error (e.g., show message)
                return false;
            }
        }

        public class CustomerResult
        {
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        //----------------------------------------------------------------

        // Driver Login
        public async Task<bool> LoginDriverAsync(string username, string password)
        {
            using var client = new HttpClient();
            var login = new LoginDto { Username = username, Password = password };

            var response = await client.PostAsJsonAsync("https://localhost:7294/api/auth/driver", login);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<DriverResult>();
                // Set session values
                Session.UserName = result.Username;
                Session.UserFirstName = result.FirstName;
                Session.UserLastName = result.LastName;
                Session.Address = result.Address;
                Session.UserType = "Driver";
                return true;
            }
            else
            {
                // Handle error (e.g., show message)
                return false;
            }
        }

        public class DriverResult
        {
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        //---------------------------------------------------------------

        // Admin Login

        public async Task<bool> LoginAdminAsync(string username, string password)
        {
            using var client = new HttpClient();
            var login = new LoginDto { Username = username, Password = password };
            var response = await client.PostAsJsonAsync("https://localhost:7294/api/auth/admin", login);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AdminResult>();
                // Set session values
                Session.UserName = result.Username;
                Session.UserFirstName = result.FirstName;
                Session.UserLastName = result.LastName;
                Session.Address = result.Address;
                Session.UserType = "Admin";
                return true;
            }
            else
            {
                // Handle error (e.g., show message)
                return false;
            }
        }

        public class AdminResult
        {
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

    }
}


