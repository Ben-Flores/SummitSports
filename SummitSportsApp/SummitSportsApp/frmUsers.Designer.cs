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
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Location = new System.Drawing.Point(12, 709);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 50);
            this.btnBack.TabIndex = 23;
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
            // 
            // hlpHelp
            // 
            this.hlpHelp.HelpNamespace = "SummitSportsManagerHelp.chm";
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
            this.name,
            this.email,
            this.phone1,
            this.phone2});
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
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone1
            // 
            this.phone1.HeaderText = "Phone 1";
            this.phone1.Name = "phone1";
            this.phone1.ReadOnly = true;
            this.phone1.Width = 126;
            // 
            // phone2
            // 
            this.phone2.HeaderText = "Phone 2";
            this.phone2.Name = "phone2";
            this.phone2.ReadOnly = true;
            this.phone2.Width = 126;
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
            this.btnDisableUser.Location = new System.Drawing.Point(667, 709);
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(250, 50);
            this.btnDisableUser.TabIndex = 18;
            this.btnDisableUser.Text = "Disable User";
            this.btnDisableUser.UseVisualStyleBackColor = true;
            this.btnDisableUser.Click += new System.EventHandler(this.btnDisableUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(667, 653);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(250, 50);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnResetUser
            // 
            this.btnResetUser.Enabled = false;
            this.btnResetUser.ForeColor = System.Drawing.Color.Black;
            this.btnResetUser.Location = new System.Drawing.Point(667, 597);
            this.btnResetUser.Name = "btnResetUser";
            this.btnResetUser.Size = new System.Drawing.Size(250, 50);
            this.btnResetUser.TabIndex = 16;
            this.btnResetUser.Text = "Reset User";
            this.btnResetUser.UseVisualStyleBackColor = true;
            this.btnResetUser.Click += new System.EventHandler(this.btnResetUser_Click);
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblPhone2.ForeColor = System.Drawing.Color.Black;
            this.lblPhone2.Location = new System.Drawing.Point(319, 440);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(208, 27);
            this.lblPhone2.TabIndex = 75;
            this.lblPhone2.Text = "Secondary Phone";
            // 
            // tbxPhone1
            // 
            this.tbxPhone1.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxPhone1.Location = new System.Drawing.Point(754, 404);
            this.tbxPhone1.MaxLength = 14;
            this.tbxPhone1.Name = "tbxPhone1";
            this.tbxPhone1.ShortcutsEnabled = false;
            this.tbxPhone1.Size = new System.Drawing.Size(429, 33);
            this.tbxPhone1.TabIndex = 14;
            this.tbxPhone1.TextChanged += new System.EventHandler(this.tbxPhone1_TextChanged);
            this.tbxPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone1_KeyPress);
            this.tbxPhone1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPhone1_KeyUp);
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblPhone1.ForeColor = System.Drawing.Color.Black;
            this.lblPhone1.Location = new System.Drawing.Point(754, 374);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(177, 27);
            this.lblPhone1.TabIndex = 73;
            this.lblPhone1.Text = "Primary Phone";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxEmail.Location = new System.Drawing.Point(319, 404);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(429, 33);
            this.tbxEmail.TabIndex = 13;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            this.tbxEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxEmail_KeyUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(319, 374);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 27);
            this.lblEmail.TabIndex = 71;
            this.lblEmail.Text = "Email";
            // 
            // tbxState
            // 
            this.tbxState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxState.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxState.Location = new System.Drawing.Point(754, 257);
            this.tbxState.MaxLength = 2;
            this.tbxState.Name = "tbxState";
            this.tbxState.ShortcutsEnabled = false;
            this.tbxState.Size = new System.Drawing.Size(199, 33);
            this.tbxState.TabIndex = 11;
            this.tbxState.TextChanged += new System.EventHandler(this.tbxState_TextChanged);
            this.tbxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxState_KeyPress);
            this.tbxState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxState_KeyUp);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(754, 227);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(194, 27);
            this.lblState.TabIndex = 69;
            this.lblState.Text = "State (Required)";
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxCity.Location = new System.Drawing.Point(754, 191);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(429, 33);
            this.tbxCity.TabIndex = 10;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            this.tbxCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCity_KeyUp);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCity.ForeColor = System.Drawing.Color.Crimson;
            this.lblCity.Location = new System.Drawing.Point(754, 161);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(186, 27);
            this.lblCity.TabIndex = 67;
            this.lblCity.Text = "City (Required)";
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxAddress3.Location = new System.Drawing.Point(319, 323);
            this.tbxAddress3.MaxLength = 30;
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(429, 33);
            this.tbxAddress3.TabIndex = 9;
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblAddress3.ForeColor = System.Drawing.Color.Black;
            this.lblAddress3.Location = new System.Drawing.Point(319, 293);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(178, 27);
            this.lblAddress3.TabIndex = 65;
            this.lblAddress3.Text = "Address Line 3";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxAddress2.Location = new System.Drawing.Point(319, 257);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(429, 33);
            this.tbxAddress2.TabIndex = 8;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblAddress2.ForeColor = System.Drawing.Color.Black;
            this.lblAddress2.Location = new System.Drawing.Point(319, 227);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(178, 27);
            this.lblAddress2.TabIndex = 63;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxAddress1.Location = new System.Drawing.Point(319, 191);
            this.tbxAddress1.MaxLength = 30;
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(429, 33);
            this.tbxAddress1.TabIndex = 7;
            this.tbxAddress1.TextChanged += new System.EventHandler(this.tbxAddress1_TextChanged);
            this.tbxAddress1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAddress1_KeyUp);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblAddress1.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddress1.Location = new System.Drawing.Point(319, 161);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(306, 27);
            this.lblAddress1.TabIndex = 61;
            this.lblAddress1.Text = "Address Line 1 (Required)";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxSuffix.Location = new System.Drawing.Point(754, 110);
            this.tbxSuffix.MaxLength = 20;
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(174, 33);
            this.tbxSuffix.TabIndex = 5;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblSuffix.ForeColor = System.Drawing.Color.Black;
            this.lblSuffix.Location = new System.Drawing.Point(754, 80);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(73, 27);
            this.lblSuffix.TabIndex = 59;
            this.lblSuffix.Text = "Suffix";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxMiddleName.Location = new System.Drawing.Point(754, 44);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(429, 33);
            this.tbxMiddleName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(754, 14);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(168, 27);
            this.lblMiddleName.TabIndex = 57;
            this.lblMiddleName.Text = "Middle Name ";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxLastName.Location = new System.Drawing.Point(319, 110);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(429, 33);
            this.tbxLastName.TabIndex = 3;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            this.tbxLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxLastName_KeyUp);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblLastName.ForeColor = System.Drawing.Color.Crimson;
            this.lblLastName.Location = new System.Drawing.Point(319, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(255, 27);
            this.lblLastName.TabIndex = 55;
            this.lblLastName.Text = "Last Name (Required)";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxFirstName.Location = new System.Drawing.Point(319, 44);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(429, 33);
            this.tbxFirstName.TabIndex = 2;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            this.tbxFirstName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxFirstName_KeyUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblFirstName.ForeColor = System.Drawing.Color.Crimson;
            this.lblFirstName.Location = new System.Drawing.Point(319, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(259, 27);
            this.lblFirstName.TabIndex = 53;
            this.lblFirstName.Text = "First Name (Required)";
            // 
            // tbxPhone2
            // 
            this.tbxPhone2.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxPhone2.Location = new System.Drawing.Point(319, 470);
            this.tbxPhone2.MaxLength = 14;
            this.tbxPhone2.Name = "tbxPhone2";
            this.tbxPhone2.ShortcutsEnabled = false;
            this.tbxPhone2.Size = new System.Drawing.Size(429, 33);
            this.tbxPhone2.TabIndex = 15;
            this.tbxPhone2.TextChanged += new System.EventHandler(this.tbxPhone2_TextChanged);
            this.tbxPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone2_KeyPress);
            this.tbxPhone2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPhone2_KeyUp);
            // 
            // btnNewManager
            // 
            this.btnNewManager.ForeColor = System.Drawing.Color.Black;
            this.btnNewManager.Location = new System.Drawing.Point(937, 709);
            this.btnNewManager.Name = "btnNewManager";
            this.btnNewManager.Size = new System.Drawing.Size(250, 50);
            this.btnNewManager.TabIndex = 22;
            this.btnNewManager.Text = "New Manager ▶";
            this.btnNewManager.UseVisualStyleBackColor = true;
            this.btnNewManager.Click += new System.EventHandler(this.btnNewManager_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Location = new System.Drawing.Point(937, 653);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(250, 50);
            this.btnNewEmployee.TabIndex = 21;
            this.btnNewEmployee.Text = "New Employee ▶";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.Location = new System.Drawing.Point(937, 597);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(250, 50);
            this.btnNewCustomer.TabIndex = 20;
            this.btnNewCustomer.Text = "New Customer ▶";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // tbxZip
            // 
            this.tbxZip.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxZip.Location = new System.Drawing.Point(959, 257);
            this.tbxZip.MaxLength = 10;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.ShortcutsEnabled = false;
            this.tbxZip.Size = new System.Drawing.Size(174, 33);
            this.tbxZip.TabIndex = 12;
            this.tbxZip.TextChanged += new System.EventHandler(this.tbxZip_TextChanged);
            this.tbxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZip_KeyPress);
            this.tbxZip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxZip_KeyUp);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblZip.ForeColor = System.Drawing.Color.Crimson;
            this.lblZip.Location = new System.Drawing.Point(954, 228);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(223, 25);
            this.lblZip.TabIndex = 82;
            this.lblZip.Text = "ZIP Code (Required)";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Font = new System.Drawing.Font("Rockwell", 16F);
            this.tbxTitle.Location = new System.Drawing.Point(934, 110);
            this.tbxTitle.MaxLength = 15;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(185, 33);
            this.tbxTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(934, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 25);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.Text = "Title";
            // 
            // lblError1
            // 
            this.lblError1.BackColor = System.Drawing.Color.Transparent;
            this.lblError1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblError1.ForeColor = System.Drawing.Color.Crimson;
            this.lblError1.Location = new System.Drawing.Point(319, 506);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(714, 30);
            this.lblError1.TabIndex = 84;
            this.lblError1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteUser.Location = new System.Drawing.Point(411, 709);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(250, 50);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1199, 771);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.tbxZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
    }
}