namespace wguC_
{
    partial class ModifyProductForm
    {
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.DataGridView dgvAvailableParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblAvailableParts;
        private System.Windows.Forms.Label lblAssociatedParts;

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.dgvAvailableParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblAvailableParts = new System.Windows.Forms.Label();
            this.lblAssociatedParts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 50);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(98, 150);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 26);
            this.txtInventory.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(75, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(260, 253);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(75, 250);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(525, 250);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 40);
            this.btnAddPart.TabIndex = 8;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(650, 250);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 40);
            this.btnDeletePart.TabIndex = 9;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // dgvAvailableParts
            // 
            this.dgvAvailableParts.ColumnHeadersHeight = 34;
            this.dgvAvailableParts.Location = new System.Drawing.Point(400, 94);
            this.dgvAvailableParts.Name = "dgvAvailableParts";
            this.dgvAvailableParts.RowHeadersWidth = 62;
            this.dgvAvailableParts.Size = new System.Drawing.Size(400, 150);
            this.dgvAvailableParts.TabIndex = 10;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeight = 34;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(400, 300);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 62;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(400, 150);
            this.dgvAssociatedParts.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(400, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(619, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(10, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.Location = new System.Drawing.Point(10, 150);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(100, 23);
            this.lblInventory.TabIndex = 16;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(10, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(197, 253);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 23);
            this.lblMax.TabIndex = 18;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(10, 253);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(100, 23);
            this.lblMin.TabIndex = 19;
            this.lblMin.Text = "Min";
            // 
            // lblAvailableParts
            // 
            this.lblAvailableParts.Location = new System.Drawing.Point(400, 30);
            this.lblAvailableParts.Name = "lblAvailableParts";
            this.lblAvailableParts.Size = new System.Drawing.Size(100, 23);
            this.lblAvailableParts.TabIndex = 20;
            this.lblAvailableParts.Text = "All Candidate Parts";
            // 
            // lblAssociatedParts
            // 
            this.lblAssociatedParts.Location = new System.Drawing.Point(400, 280);
            this.lblAssociatedParts.Name = "lblAssociatedParts";
            this.lblAssociatedParts.Size = new System.Drawing.Size(100, 23);
            this.lblAssociatedParts.TabIndex = 21;
            this.lblAssociatedParts.Text = "Parts Associated with Product";
            // 
            // ModifyProductForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.dgvAvailableParts);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblAvailableParts);
            this.Controls.Add(this.lblAssociatedParts);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
