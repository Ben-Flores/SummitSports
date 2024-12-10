namespace SummitSportsApp
{
    partial class frmPOSCart
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
            this.lblCart = new System.Windows.Forms.Label();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.lblTaxTitle = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.lblDiscountedTotalTitle = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountedTotal = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.hlpHelp = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.DimGray;
            this.lblCart.Font = new System.Drawing.Font("Rockwell", 36F);
            this.lblCart.Location = new System.Drawing.Point(12, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(250, 54);
            this.lblCart.TabIndex = 10;
            this.lblCart.Text = "Your Cart:";
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblSubtotalTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalTitle.Location = new System.Drawing.Point(12, 461);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(143, 36);
            this.lblSubtotalTitle.TabIndex = 12;
            this.lblSubtotalTitle.Text = "Subtotal:";
            // 
            // lblTaxTitle
            // 
            this.lblTaxTitle.AutoSize = true;
            this.lblTaxTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblTaxTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTitle.Location = new System.Drawing.Point(12, 599);
            this.lblTaxTitle.Name = "lblTaxTitle";
            this.lblTaxTitle.Size = new System.Drawing.Size(200, 36);
            this.lblTaxTitle.TabIndex = 13;
            this.lblTaxTitle.Text = "Tax (8.25%):";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblTotalTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(12, 645);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(162, 36);
            this.lblTotalTitle.TabIndex = 14;
            this.lblTotalTitle.Text = "Total Due:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubtotal.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(334, 461);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(186, 36);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "$999,999.99";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTax.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(334, 599);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(186, 36);
            this.lblTax.TabIndex = 16;
            this.lblTax.Text = "$999,999.99";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(334, 645);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(186, 36);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "$999,999.99";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.Location = new System.Drawing.Point(12, 507);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(151, 36);
            this.lblDiscountTitle.TabIndex = 18;
            this.lblDiscountTitle.Text = "Discount:";
            // 
            // lblDiscountedTotalTitle
            // 
            this.lblDiscountedTotalTitle.AutoSize = true;
            this.lblDiscountedTotalTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblDiscountedTotalTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotalTitle.Location = new System.Drawing.Point(12, 553);
            this.lblDiscountedTotalTitle.Name = "lblDiscountedTotalTitle";
            this.lblDiscountedTotalTitle.Size = new System.Drawing.Size(316, 36);
            this.lblDiscountedTotalTitle.TabIndex = 19;
            this.lblDiscountedTotalTitle.Text = "Discounted Subtotal:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDiscount.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(334, 507);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(186, 36);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "$999,999.99";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountedTotal
            // 
            this.lblDiscountedTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDiscountedTotal.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotal.Location = new System.Drawing.Point(334, 553);
            this.lblDiscountedTotal.Name = "lblDiscountedTotal";
            this.lblDiscountedTotal.Size = new System.Drawing.Size(186, 36);
            this.lblDiscountedTotal.TabIndex = 21;
            this.lblDiscountedTotal.Text = "$999,999.99";
            this.lblDiscountedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.Location = new System.Drawing.Point(12, 66);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(960, 364);
            this.dgvCart.TabIndex = 22;
            this.dgvCart.TabStop = false;
            this.dgvCart.SelectionChanged += new System.EventHandler(this.dgvCart_SelectionChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinue.Location = new System.Drawing.Point(543, 541);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(429, 50);
            this.btnContinue.TabIndex = 23;
            this.btnContinue.Text = "◀ Continue Shopping";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckout.Location = new System.Drawing.Point(543, 709);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(429, 50);
            this.btnCheckout.TabIndex = 26;
            this.btnCheckout.Text = "Check Out ▶";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Crimson;
            this.btnClear.Location = new System.Drawing.Point(543, 653);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(429, 50);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(543, 597);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(429, 50);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelp.Location = new System.Drawing.Point(543, 461);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(429, 50);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscount.Location = new System.Drawing.Point(12, 711);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(228, 45);
            this.tbxDiscount.TabIndex = 27;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Enabled = false;
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiscount.Location = new System.Drawing.Point(246, 709);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(274, 50);
            this.btnDiscount.TabIndex = 28;
            this.btnDiscount.Text = "Apply Discount Code";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // hlpHelp
            // 
            this.hlpHelp.HelpNamespace = "SummitSportsHelp.chm";
            // 
            // frmPOSCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 771);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblDiscountedTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountedTotalTitle);
            this.Controls.Add(this.lblDiscountTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.lblTaxTitle);
            this.Controls.Add(this.lblSubtotalTitle);
            this.Controls.Add(this.lblCart);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPOSCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Cart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOSCart_FormClosed);
            this.Load += new System.EventHandler(this.frmPOSCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.Label lblTaxTitle;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label lblDiscountedTotalTitle;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountedTotal;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.HelpProvider hlpHelp;
    }
}