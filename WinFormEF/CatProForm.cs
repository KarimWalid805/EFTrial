
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormEF
{
    public partial class CatProForm : Form
    {
        private ProductsContext dbContext;


        public CatProForm()
        {

            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();

            //Uncommon the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();
            this.dbContext.Products.Load();


            //loads database table categories into the categories DataGridView
            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
            categoryDataGridView.DataSource = categoryBindingSource;

            //loads database table products into the products DataGridView
            this.productsBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            productDataGridView.DataSource = productsBindingSource;

            productDataGridView.ClearSelection();
            categoryDataGridView.ClearSelection();
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            categoryBindingSource.AddNew();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

           


            if (productDataGridView.CurrentRow != null)
            {
                string PMessage = "Are you sure you want to delete this product?";
                string PTitle = "Delete Confirmation";
                var SelectedProduct = productDataGridView.CurrentRow.DataBoundItem as Product;


                if (SelectedProduct != null)
                {


                    if (MessageBox.Show(PMessage, PTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbContext.Products.Attach(SelectedProduct);
                        dbContext.Products.Remove(SelectedProduct);
                        dbContext.SaveChanges();
                    }

                }

            } 


            if (categoryDataGridView.CurrentRow != null)
            {
                string CMessage = "Are you sure you want to delete this Category? (This will delete all corresponding products in the category)";
                string CTitle = "Delete Confirmation";
                var SelectedCategory = categoryDataGridView.CurrentRow.DataBoundItem as Category;


                if (SelectedCategory != null)
                {


                    if (MessageBox.Show(CMessage, CTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbContext.Categories.Attach(SelectedCategory);
                        dbContext.Categories.Remove(SelectedCategory);
                        dbContext.SaveChanges();


                    }

                }

            }

            //dbContext.Dele
        }
    }
}
