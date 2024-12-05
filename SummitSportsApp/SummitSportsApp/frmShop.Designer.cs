namespace SummitSportsApp
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.inventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCartItems = new System.Windows.Forms.Label();
            this.lblRetailPriceLabel = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.pbxCart = new System.Windows.Forms.PictureBox();
            this.pbxItem = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceLabel = new System.Windows.Forms.Label();
            this.lblInCart = new System.Windows.Forms.Label();
            this.lblCartQty = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).BeginInit();
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
            this.quantity,
            this.categoryName});
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
            // inventoryID
            // 
            this.inventoryID.HeaderText = "InventoryID";
            this.inventoryID.MinimumWidth = 6;
            this.inventoryID.Name = "inventoryID";
            this.inventoryID.ReadOnly = true;
            this.inventoryID.Visible = false;
            this.inventoryID.Width = 150;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 125;
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
            this.retailPrice.Width = 116;
            // 
            // quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.HeaderText = "Qty.";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 103;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 175;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DimGray;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(158, 46);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxSearch.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(12, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(275, 43);
            this.tbxSearch.TabIndex = 1;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.DimGray;
            this.lblSort.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(12, 147);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(348, 46);
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
            this.clbCategories.Size = new System.Drawing.Size(275, 460);
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
            this.btnLogout.Text = "◀ Log Out";
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
            // btnCart
            // 
            this.btnCart.Enabled = false;
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(1012, 709);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(175, 50);
            this.btnCart.TabIndex = 9;
            this.btnCart.Text = "Go to Cart ▶";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(318, 709);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(289, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(613, 709);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(230, 50);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.DimGray;
            this.lblItemName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblItemName.Location = new System.Drawing.Point(318, 365);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(521, 35);
            this.lblItemName.TabIndex = 20;
            this.lblItemName.Text = "Select an item from the grid above ▲";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemDescription.Location = new System.Drawing.Point(318, 395);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(525, 167);
            this.lblItemDescription.TabIndex = 21;
            this.lblItemDescription.Text = "...and see more details here.";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(12, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(275, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCartItems
            // 
            this.lblCartItems.AutoSize = true;
            this.lblCartItems.BackColor = System.Drawing.Color.Transparent;
            this.lblCartItems.Location = new System.Drawing.Point(956, 721);
            this.lblCartItems.Name = "lblCartItems";
            this.lblCartItems.Size = new System.Drawing.Size(31, 35);
            this.lblCartItems.TabIndex = 23;
            this.lblCartItems.Text = "0";
            // 
            // lblRetailPriceLabel
            // 
            this.lblRetailPriceLabel.AutoSize = true;
            this.lblRetailPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.lblRetailPriceLabel.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetailPriceLabel.Location = new System.Drawing.Point(318, 575);
            this.lblRetailPriceLabel.Name = "lblRetailPriceLabel";
            this.lblRetailPriceLabel.Size = new System.Drawing.Size(159, 35);
            this.lblRetailPriceLabel.TabIndex = 24;
            this.lblRetailPriceLabel.Text = "Unit Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(318, 617);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(142, 35);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.IntegralHeight = false;
            this.cbxQuantity.Location = new System.Drawing.Point(462, 613);
            this.cbxQuantity.MaxDropDownItems = 10;
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(145, 43);
            this.cbxQuantity.TabIndex = 6;
            this.cbxQuantity.SelectedIndexChanged += new System.EventHandler(this.cbxQuantity_SelectedIndexChanged);
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRetailPrice.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetailPrice.Location = new System.Drawing.Point(462, 575);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(145, 27);
            this.lblRetailPrice.TabIndex = 27;
            this.lblRetailPrice.Text = "$0.00";
            this.lblRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxCart
            // 
            this.pbxCart.Image = global::SummitSportsApp.Properties.Resources.cart;
            this.pbxCart.InitialImage = null;
            this.pbxCart.Location = new System.Drawing.Point(900, 709);
            this.pbxCart.Name = "pbxCart";
            this.pbxCart.Size = new System.Drawing.Size(50, 50);
            this.pbxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCart.TabIndex = 22;
            this.pbxCart.TabStop = false;
            // 
            // pbxItem
            // 
            this.pbxItem.Image = global::SummitSportsApp.Properties.Resources.iconNormal;
            this.pbxItem.InitialImage = null;
            this.pbxItem.Location = new System.Drawing.Point(849, 365);
            this.pbxItem.Name = "pbxItem";
            this.pbxItem.Size = new System.Drawing.Size(338, 338);
            this.pbxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxItem.TabIndex = 16;
            this.pbxItem.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalPrice.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblTotalPrice.Location = new System.Drawing.Point(462, 659);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(145, 27);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "$0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPriceLabel
            // 
            this.lblTotalPriceLabel.AutoSize = true;
            this.lblTotalPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.lblTotalPriceLabel.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblTotalPriceLabel.Location = new System.Drawing.Point(318, 659);
            this.lblTotalPriceLabel.Name = "lblTotalPriceLabel";
            this.lblTotalPriceLabel.Size = new System.Drawing.Size(172, 35);
            this.lblTotalPriceLabel.TabIndex = 28;
            this.lblTotalPriceLabel.Text = "Total Price:";
            // 
            // lblInCart
            // 
            this.lblInCart.AutoSize = true;
            this.lblInCart.BackColor = System.Drawing.Color.DimGray;
            this.lblInCart.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblInCart.Location = new System.Drawing.Point(681, 594);
            this.lblInCart.Name = "lblInCart";
            this.lblInCart.Size = new System.Drawing.Size(119, 35);
            this.lblInCart.TabIndex = 30;
            this.lblInCart.Text = "In Cart:";
            // 
            // lblCartQty
            // 
            this.lblCartQty.BackColor = System.Drawing.Color.Transparent;
            this.lblCartQty.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCartQty.Location = new System.Drawing.Point(681, 636);
            this.lblCartQty.Name = "lblCartQty";
            this.lblCartQty.Size = new System.Drawing.Size(94, 27);
            this.lblCartQty.TabIndex = 31;
            this.lblCartQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblGuest.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblGuest.ForeColor = System.Drawing.Color.Crimson;
            this.lblGuest.Location = new System.Drawing.Point(399, 721);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(451, 35);
            this.lblGuest.TabIndex = 32;
            this.lblGuest.Text = "Please Log In to Purchase Items";
            this.lblGuest.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(12, 661);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(275, 34);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmShop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1199, 771);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblCartQty);
            this.Controls.Add(this.lblInCart);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceLabel);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRetailPriceLabel);
            this.Controls.Add(this.lblCartItems);
            this.Controls.Add(this.pbxCart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCart);
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
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShop_FormClosed);
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).EndInit();
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
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbxCart;
        private System.Windows.Forms.Label lblCartItems;
        private System.Windows.Forms.Label lblRetailPriceLabel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceLabel;
        private System.Windows.Forms.Label lblInCart;
        private System.Windows.Forms.Label lblCartQty;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    }
}