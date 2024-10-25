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
    public partial class AddProductForm : Form
    {
        private Inventory inventory;
        private BindingList<Part> associatedParts = new BindingList<Part>(); 
        public AddProductForm(Inventory passedInventory)
        {
            InitializeComponent();
            inventory = passedInventory;
            dgvAvailableParts.DataSource = inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts; 

            dgvAvailableParts.AutoGenerateColumns = true;
            dgvAssociatedParts.AutoGenerateColumns = true;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

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

            Product newProduct = new Product
            {
                ProductID = GenerateProductID(),
                Name = txtName.Text,
                Price = price,
                InStock = stockLevel,
                Min = min,
                Max = max,
                AssociatedParts = associatedParts
            };

            inventory.addProduct(newProduct); 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddProductForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAvailableParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Add(selectedPart);
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Remove(selectedPart);
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
        private int GenerateProductID()
        {
            return inventory.Products.Count + 1;
        }
    }
}
