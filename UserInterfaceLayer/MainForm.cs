using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashCounter.DataAccessLayer;
using CashCounter.Properties;

namespace CashCounter.UserInterfaceLayer
{
    public partial class MainForm : Form
    {

        public double initialBalance = 5563.20;       
        public double balance
        {
            get
            {
                var sum = Product.GetSumOfallProducts();
                return (initialBalance - sum);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            var sum = Product.GetSumOfallProducts();

            UpdateWholeForm();            
        }        

        private void bSaveProduct_Click(object sender, EventArgs e)
        {
            var selectedCategory = (Category)cbCategories.SelectedItem;

            double price = 0;
            var parsePrice = Double.TryParse(tbPrice.Text, out price);

            if (!parsePrice)
                MessageBox.Show("Check the price."); 
            else
            {
                var product = new Product(selectedCategory.Id, tbDescription.Text, price,cbAuthors.SelectedItem.ToString());
                var result = Product.InsertProduct(product, dtPicker.Value);

                if (!result)
                    MessageBox.Show("Couldn't save the product.");

                else
                {                
                    UpdateWholeForm();                   
                }

            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            else
            {
                var categoryName = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                var category = Category.GetCategoryByName(categoryName);

                var product = new Product(category.Id,
                                          dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                          Double.Parse(dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString()),
                                          DateTime.Parse(dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                          Int32.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString()),
                                          dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString());


                EditValue editValue = new EditValue(product);
                editValue.ShowDialog();

                //Bind all products
                UpdateWholeForm();

            }

        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

        private void UpdateWholeForm()
        {
            UpdateProductsList();

            lTotal.Text = balance.ToString("0.##");
            
            
            // Current date
            lDate.Text = String.Format("{0:dd.MM.yyyy}", System.DateTime.Now);

            // Bind categories
            var allCategories = Category.GetAllCategories();            
            bsCategories.DataSource = allCategories;
            cbCategories.DataSource = bsCategories.DataSource;            
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "Name";

            var allCategories1 = Category.GetAllCategories(); 
            allCategories1.Insert(0, new Category(""));
            bsCategories1.DataSource = allCategories1;
            cbCategories1.DataSource = bsCategories1.DataSource;
            cbCategories1.DisplayMember = "Name";
            cbCategories1.ValueMember = "Name";

            // Bind authors
            var allAuthors = new List<string> { "Name1", "Name2", "Common" };
            bsAuthors.DataSource = allAuthors;
            cbAuthors.DataSource = bsAuthors.DataSource;

            var allAuthors1 = new List<string> { "", "Name1", "Name2", "Common" };
            bsAuthors1.DataSource = allAuthors1;
            cbPayer1.DataSource = bsAuthors1.DataSource;

            // Renew New product tab
            cbCategories.SelectedIndex = 0;
            tbDescription.Text = string.Empty;
            tbPrice.Text = string.Empty;
            dtPicker.Value = DateTime.Now;
            dtFrom1.Value = new DateTime(2018, 3, 1);

            //Last day products
            var lastDate = DateTime.Now;
            var totalLastDay = Product.GetLastDayProducts(out lastDate);
            lLastDate.Text = String.Format("{0:dd.MM.yyyy}", lastDate);
            lLastTotal.Text = totalLastDay.ToString();


        }

        private void CountSum()
        {
            var products = Product.GetAllProducts();
            //for (var i=0; i<products.)
        }


        private void UpdateProductsList()
        {
            bsAllProducts.DataSource = Product.GetAllProducts();
            dgvProducts.DataSource = bsAllProducts.DataSource;
            dgvProducts.Sort(dgvProducts.Columns[dgvProducts.ColumnCount - 3], ListSortDirection.Descending);
        }

        private void bUpdate_Click_1(object sender, EventArgs e)
        {
            bUpdate_Click(sender, e);
        }

        void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex == this.dgvProducts.Columns["Author"].Index)
            {

                if (e.Value != null)
                {

                    string author = e.Value.ToString();

                    if (author == "Name1")
                    {

                        this.dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;

                    }
                    if (author == "Name2")
                    {

                        this.dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                    }
                    if (author == "Common")
                    {

                        this.dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                    }


                }

            }

        }

        private void tbShow_Click(object sender, EventArgs e)
        {
            var from = dtFrom.Value;
            var to = dtTo.Value;

            if (rbDetails.Checked)
            {
                bsResults.DataSource = Product.GetDetailedProducts(from, to);
            }
            else if (rbGeneral.Checked)
            {
                bsResults.DataSource = Product.GetGeneralProducts(from, to);
            }

            

            dvgResults.DataSource = bsResults.DataSource;
            dvgResults.Sort(dvgResults.Columns[dvgResults.ColumnCount - 1], ListSortDirection.Descending);
        }

       
        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

        private void dtFrom1_ValueChanged(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

        private void dtTo1_ValueChanged(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

        private void cbCategories1_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

        private void cbPayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductsList();
        }

       

    }
}
