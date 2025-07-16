using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace WinFormEF
{
    public partial class DriversForm : Form
    {
        private DriversContext dbContext;
        private BindingSource driversBindingSource; // Declare driversBindingSource

        public DriversForm()
        {
            InitializeComponent();
            this.driversBindingSource = new BindingSource(); // Initialize driversBindingSource
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new DriversContext();

            //Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Drivers.Load();

            //loads database table categories into the categories DataGridView
            this.driversBindingSource.DataSource = dbContext.Drivers.Local.ToBindingList();
            this.DriverGridView.DataSource = this.driversBindingSource;
        }
    }
}
