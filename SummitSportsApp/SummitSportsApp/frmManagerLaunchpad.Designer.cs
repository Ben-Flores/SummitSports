namespace SummitSportsApp
{
    partial class frmManagerLaunchpad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerLaunchpad));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsiPOS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelect = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(12, 339);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 50);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "◀ Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 30F);
            this.lblWelcome.Location = new System.Drawing.Point(12, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(209, 46);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Welcome,";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(187, 339);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 50);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.DimGray;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 30F);
            this.lblName.Location = new System.Drawing.Point(12, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(510, 46);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Really Long Longish Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPOS,
            this.tsiManage,
            this.tsiReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 27);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "mstMenu";
            // 
            // tsiPOS
            // 
            this.tsiPOS.Name = "tsiPOS";
            this.tsiPOS.Size = new System.Drawing.Size(125, 23);
            this.tsiPOS.Text = "Point-Of-Sales";
            this.tsiPOS.Click += new System.EventHandler(this.tsiPOS_Click);
            // 
            // tsiManage
            // 
            this.tsiManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiProducts,
            this.tsiUsers});
            this.tsiManage.Name = "tsiManage";
            this.tsiManage.Size = new System.Drawing.Size(156, 23);
            this.tsiManage.Text = "Manage Inventory";
            // 
            // tsiProducts
            // 
            this.tsiProducts.Name = "tsiProducts";
            this.tsiProducts.Size = new System.Drawing.Size(206, 24);
            this.tsiProducts.Text = "Manage Products";
            this.tsiProducts.Click += new System.EventHandler(this.tsiProducts_Click);
            // 
            // tsiUsers
            // 
            this.tsiUsers.Name = "tsiUsers";
            this.tsiUsers.Size = new System.Drawing.Size(206, 24);
            this.tsiUsers.Text = "Manage Users";
            this.tsiUsers.Click += new System.EventHandler(this.tsiUsers_Click);
            // 
            // tsiReports
            // 
            this.tsiReports.Name = "tsiReports";
            this.tsiReports.Size = new System.Drawing.Size(152, 23);
            this.tsiReports.Text = "Generate Reports";
            this.tsiReports.Click += new System.EventHandler(this.tsiReports_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.BackColor = System.Drawing.Color.DimGray;
            this.lblSelect.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 173);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(366, 109);
            this.lblSelect.TabIndex = 23;
            this.lblSelect.Text = "Select an administrative option from the menu above";
            // 
            // frmManagerLaunchpad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "frmManagerLaunchpad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Welcome Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManagerLaunchpad_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiPOS;
        private System.Windows.Forms.ToolStripMenuItem tsiManage;
        private System.Windows.Forms.ToolStripMenuItem tsiProducts;
        private System.Windows.Forms.ToolStripMenuItem tsiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsiReports;
        private System.Windows.Forms.Label lblSelect;
    }
}