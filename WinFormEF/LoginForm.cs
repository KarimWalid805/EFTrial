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
    public partial class LoginForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB; Database = users; TrustServerCertificate = True;");
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
            if (passwordtxt.Text != string.Empty || usernametxt.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + usernametxt.Text + "' and password='" + passwordtxt.Text + "'", con);
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
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
