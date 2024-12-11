namespace SummitSportsApp
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnResetItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.hlpHelp = new System.Windows.Forms.HelpProvider();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRetail = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRestock = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxThreshold = new System.Windows.Forms.TextBox();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.inventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDollar1 = new System.Windows.Forms.Label();
            this.lblDollar2 = new System.Windows.Forms.Label();
            this.pbxItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryID,
            this.itemName,
            this.retailPrice,
            this.cost,
            this.quantity,
            this.restockThreshold,
            this.categoryName,
            this.discontinued});
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(318, 9);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(869, 350);
            this.dgvItems.TabIndex = 4;
            this.dgvItems.TabStop = false;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DimGray;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 36);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxSearch.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(12, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(275, 36);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.DimGray;
            this.lblSort.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(12, 147);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(275, 36);
            this.lblSort.TabIndex = 11;
            this.lblSort.Text = "Sort by Category:";
            // 
            // clbCategories
            // 
            this.clbCategories.BackColor = System.Drawing.Color.Gainsboro;
            this.clbCategories.CheckOnClick = true;
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Location = new System.Drawing.Point(12, 186);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(275, 438);
            this.clbCategories.TabIndex = 2;
            this.clbCategories.SelectedIndexChanged += new System.EventHandler(this.clbCategories_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(12, 709);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 50);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "◀ Go Back";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(187, 709);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 50);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(937, 709);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(250, 50);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Create New Item ▶";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnResetItem
            // 
            this.btnResetItem.Enabled = false;
            this.btnResetItem.ForeColor = System.Drawing.Color.Black;
            this.btnResetItem.Location = new System.Drawing.Point(697, 597);
            this.btnResetItem.Name = "btnResetItem";
            this.btnResetItem.Size = new System.Drawing.Size(210, 50);
            this.btnResetItem.TabIndex = 7;
            this.btnResetItem.Text = "Reset Item";
            this.btnResetItem.UseVisualStyleBackColor = true;
            this.btnResetItem.Click += new System.EventHandler(this.btnResetItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Enabled = false;
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateItem.Location = new System.Drawing.Point(697, 653);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(210, 50);
            this.btnUpdateItem.TabIndex = 8;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(12, 630);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(275, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // hlpHelp
            // 
            this.hlpHelp.HelpNamespace = "SummitSportsHelp.chm";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.DimGray;
            this.lblItemName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblItemName.Location = new System.Drawing.Point(318, 370);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(139, 27);
            this.lblItemName.TabIndex = 20;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.DimGray;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDescription.Location = new System.Drawing.Point(318, 404);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(149, 27);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description:";
            // 
            // lblRetail
            // 
            this.lblRetail.AutoSize = true;
            this.lblRetail.BackColor = System.Drawing.Color.DimGray;
            this.lblRetail.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetail.Location = new System.Drawing.Point(318, 594);
            this.lblRetail.Name = "lblRetail";
            this.lblRetail.Size = new System.Drawing.Size(146, 27);
            this.lblRetail.TabIndex = 22;
            this.lblRetail.Text = "Retail Price:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.DimGray;
            this.lblCost.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCost.Location = new System.Drawing.Point(318, 636);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(193, 27);
            this.lblCost.TabIndex = 23;
            this.lblCost.Text = "Wholesale Cost:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(318, 678);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 27);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblRestock
            // 
            this.lblRestock.AutoSize = true;
            this.lblRestock.BackColor = System.Drawing.Color.DimGray;
            this.lblRestock.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRestock.Location = new System.Drawing.Point(318, 720);
            this.lblRestock.Name = "lblRestock";
            this.lblRestock.Size = new System.Drawing.Size(226, 27);
            this.lblRestock.TabIndex = 25;
            this.lblRestock.Text = "Restock Threshold:";
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(473, 365);
            this.tbxItemName.MaxLength = 100;
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(458, 36);
            this.tbxItemName.TabIndex = 26;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(318, 434);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(613, 145);
            this.tbxDescription.TabIndex = 27;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(564, 589);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.ShortcutsEnabled = false;
            this.tbxPrice.Size = new System.Drawing.Size(125, 36);
            this.tbxPrice.TabIndex = 28;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(564, 631);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.ShortcutsEnabled = false;
            this.tbxCost.Size = new System.Drawing.Size(125, 36);
            this.tbxCost.TabIndex = 29;
            this.tbxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCost_KeyPress);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(564, 673);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.ShortcutsEnabled = false;
            this.tbxQuantity.Size = new System.Drawing.Size(125, 36);
            this.tbxQuantity.TabIndex = 30;
            this.tbxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // tbxThreshold
            // 
            this.tbxThreshold.Location = new System.Drawing.Point(564, 715);
            this.tbxThreshold.Name = "tbxThreshold";
            this.tbxThreshold.ShortcutsEnabled = false;
            this.tbxThreshold.Size = new System.Drawing.Size(125, 36);
            this.tbxThreshold.TabIndex = 31;
            this.tbxThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxThreshold_KeyPress);
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Enabled = false;
            this.btnDiscontinue.ForeColor = System.Drawing.Color.Black;
            this.btnDiscontinue.Location = new System.Drawing.Point(697, 709);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(210, 50);
            this.btnDiscontinue.TabIndex = 32;
            this.btnDiscontinue.Text = "Discontinue Item";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnImage
            // 
            this.btnImage.Enabled = false;
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(937, 618);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(250, 50);
            this.btnImage.TabIndex = 33;
            this.btnImage.Text = "Change Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // inventoryID
            // 
            this.inventoryID.HeaderText = "ID";
            this.inventoryID.MinimumWidth = 6;
            this.inventoryID.Name = "inventoryID";
            this.inventoryID.ReadOnly = true;
            this.inventoryID.Width = 62;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 102;
            // 
            // retailPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.retailPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.retailPrice.HeaderText = "Price";
            this.retailPrice.MinimumWidth = 6;
            this.retailPrice.Name = "retailPrice";
            this.retailPrice.ReadOnly = true;
            this.retailPrice.Width = 95;
            // 
            // cost
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.cost.DefaultCellStyle = dataGridViewCellStyle3;
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 87;
            // 
            // quantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantity.HeaderText = "Qty.";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 84;
            // 
            // restockThreshold
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.restockThreshold.DefaultCellStyle = dataGridViewCellStyle5;
            this.restockThreshold.HeaderText = "Th.";
            this.restockThreshold.Name = "restockThreshold";
            this.restockThreshold.ReadOnly = true;
            this.restockThreshold.Width = 72;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 142;
            // 
            // discontinued
            // 
            this.discontinued.HeaderText = "Discontinued";
            this.discontinued.Name = "discontinued";
            this.discontinued.ReadOnly = true;
            this.discontinued.Width = 185;
            // 
            // lblDollar1
            // 
            this.lblDollar1.AutoSize = true;
            this.lblDollar1.BackColor = System.Drawing.Color.Transparent;
            this.lblDollar1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDollar1.Location = new System.Drawing.Point(538, 594);
            this.lblDollar1.Name = "lblDollar1";
            this.lblDollar1.Size = new System.Drawing.Size(25, 27);
            this.lblDollar1.TabIndex = 34;
            this.lblDollar1.Text = "$";
            // 
            // lblDollar2
            // 
            this.lblDollar2.AutoSize = true;
            this.lblDollar2.BackColor = System.Drawing.Color.Transparent;
            this.lblDollar2.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDollar2.Location = new System.Drawing.Point(538, 636);
            this.lblDollar2.Name = "lblDollar2";
            this.lblDollar2.Size = new System.Drawing.Size(25, 27);
            this.lblDollar2.TabIndex = 35;
            this.lblDollar2.Text = "$";
            // 
            // pbxItem
            // 
            this.pbxItem.Image = global::SummitSportsApp.Properties.Resources.iconNormal;
            this.pbxItem.InitialImage = null;
            this.pbxItem.Location = new System.Drawing.Point(937, 362);
            this.pbxItem.Name = "pbxItem";
            this.pbxItem.Size = new System.Drawing.Size(250, 250);
            this.pbxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxItem.TabIndex = 16;
            this.pbxItem.TabStop = false;
            // 
            // frmInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1199, 771);
            this.Controls.Add(this.lblDollar2);
            this.Controls.Add(this.lblDollar1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnDiscontinue);
            this.Controls.Add(this.tbxThreshold);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxItemName);
            this.Controls.Add(this.lblRestock);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblRetail);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnResetItem);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pbxItem);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.clbCategories);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvItems);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Manage Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventory_FormClosed);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbxItem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnResetItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.HelpProvider hlpHelp;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRetail;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRestock;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxThreshold;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinued;
        private System.Windows.Forms.Label lblDollar1;
        private System.Windows.Forms.Label lblDollar2;
    }
}