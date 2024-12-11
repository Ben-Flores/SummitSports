namespace SummitSportsApp
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.hlpHelp = new System.Windows.Forms.HelpProvider();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCustomerReset = new System.Windows.Forms.Button();
            this.btnDisableUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnResetUser = new System.Windows.Forms.Button();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.tbxPhone1 = new System.Windows.Forms.TextBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxAddress3 = new System.Windows.Forms.TextBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxPhone2 = new System.Windows.Forms.TextBox();
            this.btnNewManager = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Location = new System.Drawing.Point(12, 709);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "◀ Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnCart.Location = new System.Drawing.Point(1297, 709);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(175, 50);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "Go to Cart ▶";
            this.btnCart.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name});
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 146);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(275, 551);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
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
            // btnCustomerReset
            // 
            this.btnCustomerReset.Font = new System.Drawing.Font("Rockwell", 16F);
            this.btnCustomerReset.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerReset.Location = new System.Drawing.Point(12, 90);
            this.btnCustomerReset.Name = "btnCustomerReset";
            this.btnCustomerReset.Size = new System.Drawing.Size(275, 50);
            this.btnCustomerReset.TabIndex = 1;
            this.btnCustomerReset.Text = "Reset Customer Search";
            this.btnCustomerReset.UseVisualStyleBackColor = true;
            this.btnCustomerReset.Click += new System.EventHandler(this.btnCustomerReset_Click);
            // 
            // btnDisableUser
            // 
            this.btnDisableUser.Enabled = false;
            this.btnDisableUser.ForeColor = System.Drawing.Color.Black;
            this.btnDisableUser.Location = new System.Drawing.Point(439, 676);
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(210, 50);
            this.btnDisableUser.TabIndex = 50;
            this.btnDisableUser.Text = "Disable User";
            this.btnDisableUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(439, 620);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(210, 50);
            this.btnUpdateUser.TabIndex = 37;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnResetUser
            // 
            this.btnResetUser.Enabled = false;
            this.btnResetUser.ForeColor = System.Drawing.Color.Black;
            this.btnResetUser.Location = new System.Drawing.Point(439, 564);
            this.btnResetUser.Name = "btnResetUser";
            this.btnResetUser.Size = new System.Drawing.Size(210, 50);
            this.btnResetUser.TabIndex = 36;
            this.btnResetUser.Text = "Reset User";
            this.btnResetUser.UseVisualStyleBackColor = true;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone2.ForeColor = System.Drawing.Color.Black;
            this.lblPhone2.Location = new System.Drawing.Point(319, 362);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(137, 19);
            this.lblPhone2.TabIndex = 75;
            this.lblPhone2.Text = "Secondary Phone";
            // 
            // tbxPhone1
            // 
            this.tbxPhone1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone1.Location = new System.Drawing.Point(655, 333);
            this.tbxPhone1.MaxLength = 14;
            this.tbxPhone1.Name = "tbxPhone1";
            this.tbxPhone1.ShortcutsEnabled = false;
            this.tbxPhone1.Size = new System.Drawing.Size(330, 26);
            this.tbxPhone1.TabIndex = 74;
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone1.ForeColor = System.Drawing.Color.Black;
            this.lblPhone1.Location = new System.Drawing.Point(655, 311);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(117, 19);
            this.lblPhone1.TabIndex = 73;
            this.lblPhone1.Text = "Primary Phone";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(319, 333);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(330, 26);
            this.tbxEmail.TabIndex = 72;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(319, 311);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 19);
            this.lblEmail.TabIndex = 71;
            this.lblEmail.Text = "Email";
            // 
            // tbxState
            // 
            this.tbxState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxState.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxState.Location = new System.Drawing.Point(655, 207);
            this.tbxState.MaxLength = 2;
            this.tbxState.Name = "tbxState";
            this.tbxState.ShortcutsEnabled = false;
            this.tbxState.Size = new System.Drawing.Size(174, 26);
            this.tbxState.TabIndex = 70;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(655, 185);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(130, 19);
            this.lblState.TabIndex = 69;
            this.lblState.Text = "State (Required)";
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(655, 156);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(330, 26);
            this.tbxCity.TabIndex = 68;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Crimson;
            this.lblCity.Location = new System.Drawing.Point(655, 134);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(123, 19);
            this.lblCity.TabIndex = 67;
            this.lblCity.Text = "City (Required)";
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress3.Location = new System.Drawing.Point(319, 258);
            this.tbxAddress3.MaxLength = 30;
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(330, 26);
            this.tbxAddress3.TabIndex = 66;
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress3.ForeColor = System.Drawing.Color.Black;
            this.lblAddress3.Location = new System.Drawing.Point(319, 236);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(117, 19);
            this.lblAddress3.TabIndex = 65;
            this.lblAddress3.Text = "Address Line 3";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress2.Location = new System.Drawing.Point(319, 207);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(330, 26);
            this.tbxAddress2.TabIndex = 64;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.Black;
            this.lblAddress2.Location = new System.Drawing.Point(319, 185);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(117, 19);
            this.lblAddress2.TabIndex = 63;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.Location = new System.Drawing.Point(319, 156);
            this.tbxAddress1.MaxLength = 30;
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(330, 26);
            this.tbxAddress1.TabIndex = 62;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddress1.Location = new System.Drawing.Point(319, 134);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(201, 19);
            this.lblAddress1.TabIndex = 61;
            this.lblAddress1.Text = "Address Line 1 (Required)";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSuffix.Location = new System.Drawing.Point(655, 81);
            this.tbxSuffix.MaxLength = 20;
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(174, 26);
            this.tbxSuffix.TabIndex = 60;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.ForeColor = System.Drawing.Color.Black;
            this.lblSuffix.Location = new System.Drawing.Point(655, 59);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(174, 19);
            this.lblSuffix.TabIndex = 59;
            this.lblSuffix.Text = "Suffix (e.g. \"Jr.\", \"Sr.\")";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMiddleName.Location = new System.Drawing.Point(655, 31);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(330, 26);
            this.tbxMiddleName.TabIndex = 58;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(655, 9);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(112, 19);
            this.lblMiddleName.TabIndex = 57;
            this.lblMiddleName.Text = "Middle Name ";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(319, 81);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(330, 26);
            this.tbxLastName.TabIndex = 56;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Crimson;
            this.lblLastName.Location = new System.Drawing.Point(319, 59);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(170, 19);
            this.lblLastName.TabIndex = 55;
            this.lblLastName.Text = "Last Name (Required)";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(319, 31);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(330, 26);
            this.tbxFirstName.TabIndex = 54;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Crimson;
            this.lblFirstName.Location = new System.Drawing.Point(319, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(173, 19);
            this.lblFirstName.TabIndex = 53;
            this.lblFirstName.Text = "First Name (Required)";
            // 
            // tbxPhone2
            // 
            this.tbxPhone2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone2.Location = new System.Drawing.Point(319, 384);
            this.tbxPhone2.MaxLength = 14;
            this.tbxPhone2.Name = "tbxPhone2";
            this.tbxPhone2.ShortcutsEnabled = false;
            this.tbxPhone2.Size = new System.Drawing.Size(330, 26);
            this.tbxPhone2.TabIndex = 76;
            // 
            // btnNewManager
            // 
            this.btnNewManager.Enabled = false;
            this.btnNewManager.ForeColor = System.Drawing.Color.Black;
            this.btnNewManager.Location = new System.Drawing.Point(713, 667);
            this.btnNewManager.Name = "btnNewManager";
            this.btnNewManager.Size = new System.Drawing.Size(210, 50);
            this.btnNewManager.TabIndex = 79;
            this.btnNewManager.Text = "New Manager ▶";
            this.btnNewManager.UseVisualStyleBackColor = true;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Enabled = false;
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Location = new System.Drawing.Point(713, 611);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(210, 50);
            this.btnNewEmployee.TabIndex = 78;
            this.btnNewEmployee.Text = "New Employee ▶";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Enabled = false;
            this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.Location = new System.Drawing.Point(713, 555);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(210, 50);
            this.btnNewCustomer.TabIndex = 77;
            this.btnNewCustomer.Text = "New Customer ▶";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // frmUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1199, 771);
            this.Controls.Add(this.btnNewManager);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.tbxPhone2);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.tbxPhone1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxAddress3);
            this.Controls.Add(this.lblAddress3);
            this.Controls.Add(this.tbxAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.tbxAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.tbxSuffix);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnDisableUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnResetUser);
            this.Controls.Add(this.btnCustomerReset);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.tbxCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Rockwell", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summit Sports - Manage Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsers_FormClosed);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.HelpProvider hlpHelp;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustomerReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnDisableUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnResetUser;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox tbxPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxAddress3;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxPhone2;
        private System.Windows.Forms.Button btnNewManager;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnNewCustomer;
    }
}