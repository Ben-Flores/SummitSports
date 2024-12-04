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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.dgvItems = new System.Windows.Forms.DataGridView();
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
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.pbxCart = new System.Windows.Forms.PictureBox();
            this.pbxItem = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInCart = new System.Windows.Forms.Label();
            this.lblCartQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(318, 9);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(869, 350);
            this.dgvItems.TabIndex = 4;
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
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Items.AddRange(new object[] {
            "Snow Sports Clothing",
            "Placeholder"});
            this.clbCategories.Location = new System.Drawing.Point(12, 186);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(275, 500);
            this.clbCategories.TabIndex = 3;
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
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(318, 709);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(289, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
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
            this.lblItemName.Size = new System.Drawing.Size(418, 27);
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
            this.lblItemDescription.Text = "...and see more details here";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(12, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(275, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblCartItems
            // 
            this.lblCartItems.AutoSize = true;
            this.lblCartItems.BackColor = System.Drawing.Color.Transparent;
            this.lblCartItems.Location = new System.Drawing.Point(956, 721);
            this.lblCartItems.Name = "lblCartItems";
            this.lblCartItems.Size = new System.Drawing.Size(25, 27);
            this.lblCartItems.TabIndex = 23;
            this.lblCartItems.Text = "0";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.DimGray;
            this.lblUnitPrice.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblUnitPrice.Location = new System.Drawing.Point(318, 575);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(127, 27);
            this.lblUnitPrice.TabIndex = 24;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(318, 617);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 27);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Location = new System.Drawing.Point(462, 613);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(145, 35);
            this.cbxQuantity.TabIndex = 26;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F);
            this.label2.Location = new System.Drawing.Point(318, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Price:";
            // 
            // lblInCart
            // 
            this.lblInCart.AutoSize = true;
            this.lblInCart.BackColor = System.Drawing.Color.DimGray;
            this.lblInCart.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblInCart.Location = new System.Drawing.Point(681, 594);
            this.lblInCart.Name = "lblInCart";
            this.lblInCart.Size = new System.Drawing.Size(94, 27);
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
            this.lblCartQty.Text = "0";
            this.lblCartQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1199, 771);
            this.Controls.Add(this.lblCartQty);
            this.Controls.Add(this.lblInCart);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
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
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInCart;
        private System.Windows.Forms.Label lblCartQty;
    }
}