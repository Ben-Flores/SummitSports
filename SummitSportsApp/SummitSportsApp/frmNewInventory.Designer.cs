namespace SummitSportsApp
{
    partial class frmNewInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewInventory));
            this.lblDollar2 = new System.Windows.Forms.Label();
            this.lblDollar1 = new System.Windows.Forms.Label();
            this.tbxThreshold = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lblRestock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRetail = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblNewItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDollar2
            // 
            this.lblDollar2.AutoSize = true;
            this.lblDollar2.BackColor = System.Drawing.Color.Transparent;
            this.lblDollar2.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDollar2.Location = new System.Drawing.Point(232, 366);
            this.lblDollar2.Name = "lblDollar2";
            this.lblDollar2.Size = new System.Drawing.Size(25, 27);
            this.lblDollar2.TabIndex = 49;
            this.lblDollar2.Text = "$";
            // 
            // lblDollar1
            // 
            this.lblDollar1.AutoSize = true;
            this.lblDollar1.BackColor = System.Drawing.Color.Transparent;
            this.lblDollar1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDollar1.Location = new System.Drawing.Point(232, 324);
            this.lblDollar1.Name = "lblDollar1";
            this.lblDollar1.Size = new System.Drawing.Size(25, 27);
            this.lblDollar1.TabIndex = 48;
            this.lblDollar1.Text = "$";
            // 
            // tbxThreshold
            // 
            this.tbxThreshold.Location = new System.Drawing.Point(258, 445);
            this.tbxThreshold.Name = "tbxThreshold";
            this.tbxThreshold.ShortcutsEnabled = false;
            this.tbxThreshold.Size = new System.Drawing.Size(125, 36);
            this.tbxThreshold.TabIndex = 47;
            this.tbxThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxThreshold_KeyPress);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(258, 403);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.ShortcutsEnabled = false;
            this.tbxQuantity.Size = new System.Drawing.Size(125, 36);
            this.tbxQuantity.TabIndex = 46;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(258, 361);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.ShortcutsEnabled = false;
            this.tbxCost.Size = new System.Drawing.Size(125, 36);
            this.tbxCost.TabIndex = 45;
            this.tbxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCost_KeyPress);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(258, 319);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.ShortcutsEnabled = false;
            this.tbxPrice.Size = new System.Drawing.Size(125, 36);
            this.tbxPrice.TabIndex = 44;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(12, 164);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(613, 145);
            this.tbxDescription.TabIndex = 43;
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(167, 95);
            this.tbxItemName.MaxLength = 100;
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(458, 36);
            this.tbxItemName.TabIndex = 42;
            // 
            // lblRestock
            // 
            this.lblRestock.AutoSize = true;
            this.lblRestock.BackColor = System.Drawing.Color.DimGray;
            this.lblRestock.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRestock.Location = new System.Drawing.Point(12, 450);
            this.lblRestock.Name = "lblRestock";
            this.lblRestock.Size = new System.Drawing.Size(226, 27);
            this.lblRestock.TabIndex = 41;
            this.lblRestock.Text = "Restock Threshold:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(12, 408);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 27);
            this.lblQuantity.TabIndex = 40;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.DimGray;
            this.lblCost.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCost.Location = new System.Drawing.Point(12, 366);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(193, 27);
            this.lblCost.TabIndex = 39;
            this.lblCost.Text = "Wholesale Cost:";
            // 
            // lblRetail
            // 
            this.lblRetail.AutoSize = true;
            this.lblRetail.BackColor = System.Drawing.Color.DimGray;
            this.lblRetail.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblRetail.Location = new System.Drawing.Point(12, 324);
            this.lblRetail.Name = "lblRetail";
            this.lblRetail.Size = new System.Drawing.Size(146, 27);
            this.lblRetail.TabIndex = 38;
            this.lblRetail.Text = "Retail Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.DimGray;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblDescription.Location = new System.Drawing.Point(12, 134);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(149, 27);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Description:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.DimGray;
            this.lblItemName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblItemName.Location = new System.Drawing.Point(12, 100);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(139, 27);
            this.lblItemName.TabIndex = 36;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblNewItem
            // 
            this.lblNewItem.AutoSize = true;
            this.lblNewItem.BackColor = System.Drawing.Color.DimGray;
            this.lblNewItem.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewItem.Location = new System.Drawing.Point(12, 9);
            this.lblNewItem.Name = "lblNewItem";
            this.lblNewItem.Size = new System.Drawing.Size(660, 54);
            this.lblNewItem.TabIndex = 50;
            this.lblNewItem.Text = "Create a New Inventory Item";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "◀ Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(570, 491);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 50);
            this.btnCreate.TabIndex = 52;
            this.btnCreate.Text = "Create Item ▶";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.DimGray;
            this.lblCategory.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCategory.Location = new System.Drawing.Point(409, 324);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(142, 27);
            this.lblCategory.TabIndex = 53;
            this.lblCategory.Text = "Categories:";
            // 
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(409, 362);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(340, 35);
            this.cbxCategories.TabIndex = 54;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(409, 406);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(354, 71);
            this.lblError.TabIndex = 55;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNewInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewItem);
            this.Controls.Add(this.lblDollar2);
            this.Controls.Add(this.lblDollar1);
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
            this.Controls.Add(this.lblItemName);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "frmNewInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Add Inventory Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewInventory_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDollar2;
        private System.Windows.Forms.Label lblDollar1;
        private System.Windows.Forms.TextBox tbxThreshold;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblRestock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblRetail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblNewItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblError;
    }
}