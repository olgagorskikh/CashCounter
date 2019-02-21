using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashCounter.DataAccessLayer;

namespace CashCounter.UserInterfaceLayer
{
    public partial class EditValue : Form
    {
        private Product product;

        public EditValue(Product _product)
        {
            product = _product;
            InitializeComponent();

            // Bind categories
            var allCategories = Category.GetAllCategories();
            bsCategories.DataSource = allCategories;
            cbCategories.DataSource = bsCategories.DataSource;
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "Name";

            // Bind authors
            var allAuthors = new List<string> { "Name1", "Name2", "Common" };
            bsAuthors.DataSource = allAuthors;
            cbAuthors.DataSource = bsAuthors.DataSource;
            cbAuthors.SelectedIndex = cbAuthors.FindStringExact(product.Author);

            var selectedCategory = Category.GetCategoryById(product.CategoryId);
            cbCategories.SelectedIndex = cbCategories.FindStringExact(selectedCategory.Name);
            

            tbName.Text = product.Name;
            tbPrice.Text = product.Price.ToString();
            dtPicker.Value = product.Date;
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            product.CategoryId = ((Category)cbCategories.SelectedItem).Id;
            product.Date = dtPicker.Value;
            product.Name = tbName.Text;
            product.Author = cbAuthors.SelectedItem.ToString();

            double price = 0;
            var parsePrice = Double.TryParse(tbPrice.Text, out price);

            if (!parsePrice)
                MessageBox.Show("Check the price.");
            else
            {
                product.Price = price;
                var result = Product.UpdateProduct(product);

                if (!result)
                    MessageBox.Show("Couldn't resresh the data.");
                else
                    this.Close();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            var result = Product.RemoveProductById(product.Id);
            if (!result)
                MessageBox.Show("Couldn't resresh the data.");
            else
            {
                TotalAmount total = TotalAmount.GetTotalAmount();
                total = TotalAmount.GetTotalAmount();

                if (product.CategoryId != 25)
                    total.Amount += product.Price;
                else
                    total.Amount -= product.Price;

                TotalAmount.ChangeTotalAmount(total);


                this.Close();
            }
        }

        
    }
}
