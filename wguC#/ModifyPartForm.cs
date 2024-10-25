using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using wguC_.Models;

namespace wguC_
{
    public partial class ModifyPartForm : Form
    {
        private Inventory inventory;
        private Part currentPart;
        public ModifyPartForm(Inventory passedInventory, Part partToModify)
        {
            {
                InitializeComponent();
                inventory = passedInventory;
                currentPart = partToModify;

                PopulatePartDetails(currentPart); 
            }
        }
        private void PopulatePartDetails(Part part)
        {
            txtID.Text = part.PartID.ToString();
            txtName.Text = part.Name;
            txtInventory.Text = part.InStock.ToString();
            txtPrice.Text = part.Price.ToString();
            txtMax.Text = part.Max.ToString();
            txtMin.Text = part.Min.ToString();

            if (part is Inhouse inhousePart)
            {
                rbInHouse.Checked = true;
                ShowInHouse();
                txtMachineID.Text = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                rbOutsourced.Checked = true;
                ShowOutsourced();
                txtCompanyName.Text = outsourcedPart.CompanyName;
            }
        }


        private void ModifyPartForm_Load(object sender, EventArgs e)
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
                if (currentPart is Inhouse inhousePart)
                {
                    inhousePart.Name = txtName.Text;
                    inhousePart.Price = price;
                    inhousePart.InStock = stockLevel;
                    inhousePart.Min = min;
                    inhousePart.Max = max;
                    inhousePart.MachineID = machineID;
                }
            }
            else if (rbOutsourced.Checked)
            {
                string companyName = txtCompanyName.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Please enter a valid Company Name.");
                    return;
                }
                if (currentPart is Outsourced outsourcedPart)
                {
                    outsourcedPart.Name = txtName.Text;
                    outsourcedPart.Price = price;
                    outsourcedPart.InStock = stockLevel;
                    outsourcedPart.Min = min;
                    outsourcedPart.Max = max;
                    outsourcedPart.CompanyName = companyName;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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

    }
}
