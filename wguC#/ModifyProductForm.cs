using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wguC_.Models;

namespace wguC_
{
    public partial class ModifyProductForm : Form
    {
        private Inventory inventory;
        private Product currentProduct;
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public ModifyProductForm(Inventory passedInventory, Product productToModify)
        {
            InitializeComponent();
            inventory = passedInventory;
            currentProduct = productToModify;
            dgvAvailableParts.DataSource = inventory.AllParts;
            associatedParts = new BindingList<Part>(currentProduct.AssociatedParts.ToList());
            dgvAssociatedParts.DataSource = associatedParts;
            PopulateProductDetails(currentProduct);

            dgvAvailableParts.AutoGenerateColumns = true;
            dgvAssociatedParts.AutoGenerateColumns = true;
        }
        private void PopulateProductDetails(Product product)
        {
            txtID.Text = product.ProductID.ToString();
            txtName.Text = product.Name;
            txtInventory.Text = product.InStock.ToString();
            txtPrice.Text = product.Price.ToString();
            txtMax.Text = product.Max.ToString();
            txtMin.Text = product.Min.ToString();

            associatedParts = new BindingList<Part>(product.AssociatedParts.ToList());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stockLevel, min, max;
            decimal price;

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtInventory.Text, out stockLevel) ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                !int.TryParse(txtMin.Text, out min) ||
                !int.TryParse(txtMax.Text, out max))
            {
                MessageBox.Show("Please ensure all fields are filled in correctly with valid values.");
                return;
            }

            if (stockLevel < min || stockLevel > max)
            {
                MessageBox.Show("Inventory must be between Min and Max values.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min value must be less than or equal to Max value.");
                return;
            }

            currentProduct.Name = txtName.Text;
            currentProduct.InStock = stockLevel;
            currentProduct.Price = price;
            currentProduct.Min = min;
            currentProduct.Max = max;
            currentProduct.AssociatedParts = associatedParts; 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAvailableParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Add(selectedPart);

                dgvAssociatedParts.DataSource = null; 
                dgvAssociatedParts.DataSource = associatedParts; 
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Remove(selectedPart);
                dgvAssociatedParts.DataSource = null; 
                dgvAssociatedParts.DataSource = associatedParts; 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var filteredParts = inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
                dgvAvailableParts.DataSource = filteredParts;
            }
            else
            {
                dgvAvailableParts.DataSource = inventory.AllParts;
            }
        }
    }
}
