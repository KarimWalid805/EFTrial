﻿using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
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
