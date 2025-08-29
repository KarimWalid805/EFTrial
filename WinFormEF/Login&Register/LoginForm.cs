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
            con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB; Database = OnlineDeliveryDB; TrustServerCertificate = True;");
            con.Open();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registration = new RegisterForm();
            registration.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (customerRadio.Checked)
            {
                Session.UserType = "Customer";
                if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from customeraccount where username='" + usernametxt.Text + "' and password='" + passwordtxt.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        StartForm home = new StartForm();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No customer's Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    cmd = new SqlCommand("select * from driveraccount where username='" + usernametxt.Text + "' and password='" + passwordtxt.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        StartForm home = new StartForm();
                        home.ShowDialog();
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

            if (adminRadio.Checked)
            {
                Session.UserType = "Admin";

                if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from adminaccount where username='" + usernametxt.Text + "' and password='" + passwordtxt.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        StartForm home = new StartForm();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("You are not an Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
