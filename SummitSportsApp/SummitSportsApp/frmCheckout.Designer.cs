namespace SummitSportsApp
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.tbxCard = new System.Windows.Forms.TextBox();
            this.tbxCCV = new System.Windows.Forms.TextBox();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCheckout
            // 
            this.lblCheckout.BackColor = System.Drawing.Color.DimGray;
            this.lblCheckout.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(12, 9);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(486, 112);
            this.lblCheckout.TabIndex = 6;
            this.lblCheckout.Text = "Enter Your Payment Information";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.BackColor = System.Drawing.Color.Transparent;
            this.lblCard.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lblCard.ForeColor = System.Drawing.Color.Crimson;
            this.lblCard.Location = new System.Drawing.Point(98, 141);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(218, 36);
            this.lblCard.TabIndex = 7;
            this.lblCard.Text = "Card Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lblDate.ForeColor = System.Drawing.Color.Crimson;
            this.lblDate.Location = new System.Drawing.Point(259, 239);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(158, 36);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Exp. Date";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCCV.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lblCCV.ForeColor = System.Drawing.Color.Crimson;
            this.lblCCV.Location = new System.Drawing.Point(98, 239);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(86, 36);
            this.lblCCV.TabIndex = 9;
            this.lblCCV.Text = "CCV";
            // 
            // tbxCard
            // 
            this.tbxCard.Font = new System.Drawing.Font("Rockwell", 24F);
            this.tbxCard.Location = new System.Drawing.Point(98, 180);
            this.tbxCard.MaxLength = 19;
            this.tbxCard.Name = "tbxCard";
            this.tbxCard.Size = new System.Drawing.Size(319, 45);
            this.tbxCard.TabIndex = 10;
            this.tbxCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCard_KeyPress);
            this.tbxCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCard_KeyUp);
            // 
            // tbxCCV
            // 
            this.tbxCCV.Font = new System.Drawing.Font("Rockwell", 24F);
            this.tbxCCV.Location = new System.Drawing.Point(98, 278);
            this.tbxCCV.MaxLength = 3;
            this.tbxCCV.Name = "tbxCCV";
            this.tbxCCV.Size = new System.Drawing.Size(86, 45);
            this.tbxCCV.TabIndex = 11;
            this.tbxCCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCCV_KeyPress);
            this.tbxCCV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCCV_KeyUp);
            // 
            // tbxDate
            // 
            this.tbxDate.Font = new System.Drawing.Font("Rockwell", 24F);
            this.tbxDate.Location = new System.Drawing.Point(259, 278);
            this.tbxDate.MaxLength = 5;
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(158, 45);
            this.tbxDate.TabIndex = 12;
            this.tbxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDate_KeyPress);
            this.tbxDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxDate_KeyUp);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(90, 380);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 50);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(196, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "◀ Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(352, 380);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 50);
            this.btnCheckout.TabIndex = 15;
            this.btnCheckout.Text = "Checkout ▶";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(12, 338);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(486, 30);
            this.lblError.TabIndex = 18;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCheckout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(514, 442);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.tbxCCV);
            this.Controls.Add(this.tbxCard);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblCheckout);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox tbxCard;
        private System.Windows.Forms.TextBox tbxCCV;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblError;
    }
}