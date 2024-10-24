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
    public partial class AddPartForm : Form
    {
        private Inventory inventory;
        public AddPartForm(Inventory passedInventory)
        {
            InitializeComponent();
            ShowInHouse();

            inventory = passedInventory;
        }

        private void AddPartForm_Load(object sender, EventArgs e)
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

            if (rbInHouse.Checked)
            {
                int machineID;

                if (!int.TryParse(txtMachineID.Text, out machineID))
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return;
                }

                Inhouse inhousePart = new Inhouse
                {
                    PartID = GeneratePartID(),
                    Name = txtName.Text,
                    Price = price,
                    InStock = stockLevel, 
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };

                inventory.addPart(inhousePart);  
            }
            else if (rbOutsourced.Checked)
            {
                string companyName = txtCompanyName.Text;

                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Please enter a valid Company Name.");
                    return;
                }

                Outsourced outsourcedPart = new Outsourced
                {
                    PartID = GeneratePartID(),
                    Name = txtName.Text,
                    Price = price,
                    InStock = stockLevel,  
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };

                inventory.addPart(outsourcedPart);  
            }
            else
            {
                MessageBox.Show("Please select either In-House or Outsourced.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInHouse.Checked)
            {
                ShowInHouse();
            }
        }

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutsourced.Checked)
            {
                ShowOutsourced();
            }
        }
        private void ShowInHouse()
        {
            lblMachineID.Visible = true;
            txtMachineID.Visible = true;
            lblCompanyName.Visible = false;
            txtCompanyName.Visible = false;
        }

        private void ShowOutsourced()
        {
            lblMachineID.Visible = false;
            txtMachineID.Visible = false;
            lblCompanyName.Visible = true;
            txtCompanyName.Visible = true;
        }
        private int GeneratePartID()
        {
            return inventory.AllParts.Count + 1;  
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
