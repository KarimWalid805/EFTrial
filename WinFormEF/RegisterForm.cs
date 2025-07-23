using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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
    public partial class RegisterForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB; Database = users; TrustServerCertificate = True;");
            con.Open();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (customerRadio.Checked)
            {
                if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
                {
                    if (txtpassword.Text == txtconfirmpassword.Text)
                    {
                        cmd = new SqlCommand("select * from customeraccount where username='" + txtusername.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            dr.Close();
                            cmd = new SqlCommand("insert into customeraccount values(@username,@password)", con);
                            cmd.Parameters.AddWithValue("username", txtusername.Text);
                            cmd.Parameters.AddWithValue("password", txtpassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your customer Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (driverRadio.Checked)
            {
                if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
                {
                    if (txtpassword.Text == txtconfirmpassword.Text)
                    {
                        cmd = new SqlCommand("select * from driveraccount where username='" + txtusername.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            dr.Close();
                            cmd = new SqlCommand("insert into driveraccount values(@username,@password)", con);
                            cmd.Parameters.AddWithValue("username", txtusername.Text);
                            cmd.Parameters.AddWithValue("password", txtpassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your drivers Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
