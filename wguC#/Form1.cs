using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using wguC_.Models;

namespace wguC_
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
            LoadSampleData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataToDataGridViews();
            RefreshPartsList();
            RefreshProductsList();
        }

        private void LoadSampleData()
        {
            Product product1 = new Product { ProductID = 1, Name = "Product 1", Price = 29.99M, InStock = 5, Min = 1, Max = 10 };
            Part part1 = new Inhouse { PartID = 1, Name = "Part 1", Price = 9.99M, InStock = 3, Min = 1, Max = 5, MachineID = 101 };

            inventory.addProduct(product1);
            inventory.addPart(part1);
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm(inventory);

            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                RefreshPartsList();
            }
        }

        private void BindDataToDataGridViews()
        {
            lstParts.DataSource = new BindingSource { DataSource = inventory.AllParts };
            lstParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstParts.Columns["PartID"].HeaderText = "Part ID";
            lstParts.Columns["Name"].HeaderText = "Name";
            lstParts.Columns["InStock"].HeaderText = "Inventory";
            lstParts.Columns["Price"].HeaderText = "Price";
            lstParts.Columns["Min"].HeaderText = "Min";
            lstParts.Columns["Max"].HeaderText = "Max";

            lstProducts.DataSource = new BindingSource { DataSource = inventory.Products };
            lstProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            lstProducts.Columns["ProductID"].HeaderText = "Product ID";
            lstProducts.Columns["Name"].HeaderText = "Name";
            lstProducts.Columns["InStock"].HeaderText = "Inventory";
            lstProducts.Columns["Price"].HeaderText = "Price";
            lstProducts.Columns["Min"].HeaderText = "Min";
            lstProducts.Columns["Max"].HeaderText = "Max";
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (lstParts.CurrentRow != null && lstParts.CurrentRow.DataBoundItem is Part selectedPart)
            {
                ModifyPartForm modifyPartForm = new ModifyPartForm(inventory, selectedPart);
                if (modifyPartForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshPartsList();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

            private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (lstParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                bool isPartAssociated = inventory.Products.Any(p => p.AssociatedParts.Contains(selectedPart));

                if (isPartAssociated)
                {
                    MessageBox.Show($"The part '{selectedPart.Name}' is associated with a product and cannot be deleted.");
                    return;
                }
                var result = MessageBox.Show($"Are you sure you want to delete '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    inventory.deletePart(selectedPart);

                    RefreshPartsList();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            int partID;
            if (int.TryParse(txtSearchParts.Text, out partID))
            {
                Part foundPart = inventory.lookupPart(partID);
                if (foundPart != null)
                {
                    lstParts.DataSource = new BindingList<Part> { foundPart };
                }
                else
                {
                    MessageBox.Show("Part not found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid part ID.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(inventory);

            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                RefreshProductsList(); 
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                ModifyProductForm modifyProductForm = new ModifyProductForm(inventory, selectedProduct);

                if (modifyProductForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshProductsList();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.CurrentRow != null && lstProducts.CurrentRow.DataBoundItem is Product selectedProduct)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedProduct.Name}?", "Delete Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    inventory.removeProduct(selectedProduct.ProductID);
                    RefreshProductsList();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            int productID;
            if (int.TryParse(txtSearchProducts.Text, out productID))
            {
                Product foundProduct = inventory.lookupProduct(productID);
                if (foundProduct != null)
                {
                    lstProducts.DataSource = new BindingList<Product> { foundProduct };
                }
                else
                {
                    MessageBox.Show("Product not found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
            }
        }

        private void RefreshPartsList()
        {
            lstParts.DataSource = null;
            lstParts.DataSource = inventory.AllParts;
        }

        private void RefreshProductsList()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = inventory.Products;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchParts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
