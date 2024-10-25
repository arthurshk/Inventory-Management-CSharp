namespace wguC_
{
    partial class ModifyPartForm
    {
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.Label lblCompanyName;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbInHouse
            // 
            this.rbInHouse.Location = new System.Drawing.Point(27, 12);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(114, 38);
            this.rbInHouse.TabIndex = 0;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.Location = new System.Drawing.Point(147, 12);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(132, 38);
            this.rbOutsourced.TabIndex = 1;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.rbOutsourced_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(135, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(90, 26);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(135, 150);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(90, 26);
            this.txtInventory.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(165, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(90, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(135, 230);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(90, 26);
            this.txtMax.TabIndex = 6;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(297, 230);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(90, 26);
            this.txtMin.TabIndex = 7;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(177, 271);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(90, 26);
            this.txtMachineID.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(177, 271);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(90, 26);
            this.txtCompanyName.TabIndex = 9;
            this.txtCompanyName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(36, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 27);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(36, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 27);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.Location = new System.Drawing.Point(36, 150);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(90, 27);
            this.lblInventory.TabIndex = 14;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(36, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 27);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(36, 230);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(90, 23);
            this.lblMax.TabIndex = 16;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(245, 234);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(90, 27);
            this.lblMin.TabIndex = 17;
            this.lblMin.Text = "Min";
            // 
            // lblMachineID
            // 
            this.lblMachineID.Location = new System.Drawing.Point(36, 270);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(90, 27);
            this.lblMachineID.TabIndex = 18;
            this.lblMachineID.Text = "Machine ID";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(36, 270);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(90, 27);
            this.lblCompanyName.TabIndex = 19;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Visible = false;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 600);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMachineID);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
