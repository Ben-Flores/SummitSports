namespace SummitSportsApp
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
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
            this.btnReset = new System.Windows.Forms.Button();
            this.hlpHelp = new System.Windows.Forms.HelpProvider();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.btnCustomerReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
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
            this.dgvItems.Location = new System.Drawing.Point(603, 9);
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
            // quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.HeaderText = "Qty.";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 84;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 142;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DimGray;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(297, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(261, 36);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search Products:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxSearch.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(297, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(275, 36);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.DimGray;
            this.lblSort.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(297, 147);
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
            this.clbCategories.Location = new System.Drawing.Point(297, 186);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(275, 438);
            this.clbCategories.TabIndex = 2;
            this.clbCategories.TabStop = false;
            this.clbCategories.SelectedIndexChanged += new System.EventHandler(this.clbCategories_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(12, 709);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "◀ Close POS";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCart
            // 
            this.btnCart.Enabled = false;
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(1297, 709);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(175, 50);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "Go to Cart ▶";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(603, 709);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(289, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(898, 709);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(230, 50);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.DimGray;
            this.lblItemName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblItemName.Location = new System.Drawing.Point(603, 365);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(418, 27);
            this.lblItemName.TabIndex = 20;
            this.lblItemName.Text = "Select an item from the grid above ▲";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemDescription.Location = new System.Drawing.Point(603, 395);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(525, 167);
            this.lblItemDescription.TabIndex = 21;
            this.lblItemDescription.Text = "...and see more details here.";
            // 
            // lblCartItems
            // 
            this.lblCartItems.AutoSize = true;
            this.lblCartItems.BackColor = System.Drawing.Color.Transparent;
            this.lblCartItems.Location = new System.Drawing.Point(1241, 721);
            this.lblCartItems.Name = "lblCartItems";
            this.lblCartItems.Size = new System.Drawing.Size(25, 27);
            this.lblCartItems.TabIndex = 23;
            this.lblCartItems.Text = "0";
            // 
            // lblRetailPriceLabel
            // 
            this.lblRetailPriceLabel.AutoSize = true;
            this.lblRetailPriceLabel.BackColor = System.Drawing.Color.DimGray;
            this.lblRetailPriceLabel.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetailPriceLabel.Location = new System.Drawing.Point(603, 575);
            this.lblRetailPriceLabel.Name = "lblRetailPriceLabel";
            this.lblRetailPriceLabel.Size = new System.Drawing.Size(127, 27);
            this.lblRetailPriceLabel.TabIndex = 24;
            this.lblRetailPriceLabel.Text = "Unit Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(603, 617);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 27);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.IntegralHeight = false;
            this.cbxQuantity.Location = new System.Drawing.Point(747, 613);
            this.cbxQuantity.MaxDropDownItems = 10;
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(145, 35);
            this.cbxQuantity.TabIndex = 4;
            this.cbxQuantity.SelectedIndexChanged += new System.EventHandler(this.cbxQuantity_SelectedIndexChanged);
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRetailPrice.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetailPrice.Location = new System.Drawing.Point(747, 575);
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
            this.pbxCart.Location = new System.Drawing.Point(1185, 709);
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
            this.pbxItem.Location = new System.Drawing.Point(1134, 365);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(747, 659);
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
            this.lblTotalPriceLabel.Location = new System.Drawing.Point(603, 659);
            this.lblTotalPriceLabel.Name = "lblTotalPriceLabel";
            this.lblTotalPriceLabel.Size = new System.Drawing.Size(138, 27);
            this.lblTotalPriceLabel.TabIndex = 28;
            this.lblTotalPriceLabel.Text = "Total Price:";
            // 
            // lblInCart
            // 
            this.lblInCart.AutoSize = true;
            this.lblInCart.BackColor = System.Drawing.Color.DimGray;
            this.lblInCart.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblInCart.Location = new System.Drawing.Point(966, 594);
            this.lblInCart.Name = "lblInCart";
            this.lblInCart.Size = new System.Drawing.Size(94, 27);
            this.lblInCart.TabIndex = 30;
            this.lblInCart.Text = "In Cart:";
            // 
            // lblCartQty
            // 
            this.lblCartQty.BackColor = System.Drawing.Color.Transparent;
            this.lblCartQty.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCartQty.Location = new System.Drawing.Point(966, 636);
            this.lblCartQty.Name = "lblCartQty";
            this.lblCartQty.Size = new System.Drawing.Size(94, 27);
            this.lblCartQty.TabIndex = 31;
            this.lblCartQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(297, 636);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(275, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Product Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // hlpHelp
            // 
            this.hlpHelp.HelpNamespace = "SummitSportsHelp.chm";
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.BackColor = System.Drawing.Color.DimGray;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(240, 36);
            this.lblSearchCustomer.TabIndex = 32;
            this.lblSearchCustomer.Text = "Find Customer:";
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxCustomer.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomer.Location = new System.Drawing.Point(12, 48);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(275, 36);
            this.tbxCustomer.TabIndex = 0;
            this.tbxCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCustomer_KeyUp);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name});
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 186);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(275, 435);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 62;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 102;
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.BackColor = System.Drawing.Color.DimGray;
            this.lblSelectCustomer.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCustomer.Location = new System.Drawing.Point(12, 147);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(264, 36);
            this.lblSelectCustomer.TabIndex = 34;
            this.lblSelectCustomer.Text = "Select Customer:";
            // 
            // btnCustomerReset
            // 
            this.btnCustomerReset.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnCustomerReset.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerReset.Location = new System.Drawing.Point(12, 636);
            this.btnCustomerReset.Name = "btnCustomerReset";
            this.btnCustomerReset.Size = new System.Drawing.Size(275, 50);
            this.btnCustomerReset.TabIndex = 1;
            this.btnCustomerReset.Text = "Reset Customer Search";
            this.btnCustomerReset.UseVisualStyleBackColor = true;
            this.btnCustomerReset.Click += new System.EventHandler(this.btnCustomerReset_Click);
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1484, 771);
            this.Controls.Add(this.btnCustomerReset);
            this.Controls.Add(this.lblSelectCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.tbxCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.btnReset);
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
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.pbxItem);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
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
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOS_FormClosed);
            this.Load += new System.EventHandler(this.frmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbxItem;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDescription;
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.HelpProvider hlpHelp;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.Button btnCustomerReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}