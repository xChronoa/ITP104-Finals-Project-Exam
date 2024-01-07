namespace ITP104___Finals_Project___Exam {
    partial class Maintenance {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label lblItemsCategoryName;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.tcOperations = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.tpItemCategory = new System.Windows.Forms.TabPage();
            this.btnDeleteItemCategory = new System.Windows.Forms.Button();
            this.btnUpdateItemCategory = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddItemCategory = new System.Windows.Forms.Button();
            this.tpSupplier = new System.Windows.Forms.TabPage();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.cboCategoryName = new System.Windows.Forms.ComboBox();
            this.nudBasePrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.msMenuBar = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResultGrid = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            lblItemsCategoryName = new System.Windows.Forms.Label();
            this.tcOperations.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.tpItemCategory.SuspendLayout();
            this.tpSupplier.SuspendLayout();
            this.tpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.msMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemsCategoryName
            // 
            lblItemsCategoryName.AutoSize = true;
            lblItemsCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblItemsCategoryName.Location = new System.Drawing.Point(5, 202);
            lblItemsCategoryName.Name = "lblItemsCategoryName";
            lblItemsCategoryName.Size = new System.Drawing.Size(119, 20);
            lblItemsCategoryName.TabIndex = 26;
            lblItemsCategoryName.Text = "Category Name";
            // 
            // tcOperations
            // 
            this.tcOperations.Controls.Add(this.tpUsers);
            this.tcOperations.Controls.Add(this.tpItemCategory);
            this.tcOperations.Controls.Add(this.tpSupplier);
            this.tcOperations.Controls.Add(this.tpItems);
            this.tcOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.tcOperations.Location = new System.Drawing.Point(575, 24);
            this.tcOperations.Name = "tcOperations";
            this.tcOperations.SelectedIndex = 0;
            this.tcOperations.Size = new System.Drawing.Size(309, 687);
            this.tcOperations.TabIndex = 1;
            this.tcOperations.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcOperations_Selected);
            // 
            // tpUsers
            // 
            this.tpUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpUsers.Controls.Add(this.btnDeleteUser);
            this.tpUsers.Controls.Add(this.btnUpdateUsers);
            this.tpUsers.Controls.Add(this.lblPassword);
            this.tpUsers.Controls.Add(this.lblUsername);
            this.tpUsers.Controls.Add(this.lblUserId);
            this.tpUsers.Controls.Add(this.lblUsers);
            this.tpUsers.Controls.Add(this.txtUserId);
            this.tpUsers.Controls.Add(this.txtPassword);
            this.tpUsers.Controls.Add(this.txtUsername);
            this.tpUsers.Controls.Add(this.btnAddUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Size = new System.Drawing.Size(301, 661);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Location = new System.Drawing.Point(8, 437);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(285, 45);
            this.btnDeleteUser.TabIndex = 33;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateUsers.Location = new System.Drawing.Point(8, 383);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(286, 45);
            this.btnUpdateUsers.TabIndex = 8;
            this.btnUpdateUsers.Text = "UPDATE";
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(5, 202);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(5, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(5, 70);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(64, 20);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User ID";
            // 
            // lblUsers
            // 
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(0, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(299, 69);
            this.lblUsers.TabIndex = 4;
            this.lblUsers.Text = "USERS";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(6, 93);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(287, 30);
            this.txtUserId.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(9, 226);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(286, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(6, 158);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(287, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUsers.Location = new System.Drawing.Point(8, 328);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(286, 45);
            this.btnAddUsers.TabIndex = 0;
            this.btnAddUsers.Text = "ADD";
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // tpItemCategory
            // 
            this.tpItemCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpItemCategory.Controls.Add(this.btnDeleteItemCategory);
            this.tpItemCategory.Controls.Add(this.btnUpdateItemCategory);
            this.tpItemCategory.Controls.Add(this.lblCategoryName);
            this.tpItemCategory.Controls.Add(this.lblCategoryId);
            this.tpItemCategory.Controls.Add(this.lblItemCategory);
            this.tpItemCategory.Controls.Add(this.txtCategoryId);
            this.tpItemCategory.Controls.Add(this.txtCategoryName);
            this.tpItemCategory.Controls.Add(this.btnAddItemCategory);
            this.tpItemCategory.Location = new System.Drawing.Point(4, 22);
            this.tpItemCategory.Name = "tpItemCategory";
            this.tpItemCategory.Size = new System.Drawing.Size(301, 661);
            this.tpItemCategory.TabIndex = 1;
            this.tpItemCategory.Text = "Item Category";
            this.tpItemCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItemCategory
            // 
            this.btnDeleteItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnDeleteItemCategory.Enabled = false;
            this.btnDeleteItemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItemCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItemCategory.Location = new System.Drawing.Point(8, 437);
            this.btnDeleteItemCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteItemCategory.Name = "btnDeleteItemCategory";
            this.btnDeleteItemCategory.Size = new System.Drawing.Size(285, 45);
            this.btnDeleteItemCategory.TabIndex = 33;
            this.btnDeleteItemCategory.Text = "DELETE";
            this.btnDeleteItemCategory.UseVisualStyleBackColor = false;
            this.btnDeleteItemCategory.Visible = false;
            // 
            // btnUpdateItemCategory
            // 
            this.btnUpdateItemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnUpdateItemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItemCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateItemCategory.Location = new System.Drawing.Point(8, 383);
            this.btnUpdateItemCategory.Name = "btnUpdateItemCategory";
            this.btnUpdateItemCategory.Size = new System.Drawing.Size(285, 45);
            this.btnUpdateItemCategory.TabIndex = 15;
            this.btnUpdateItemCategory.Text = "UPDATE";
            this.btnUpdateItemCategory.UseVisualStyleBackColor = false;
            this.btnUpdateItemCategory.Click += new System.EventHandler(this.btnUpdateItemCategory_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(5, 135);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(119, 20);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(5, 70);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(94, 20);
            this.lblCategoryId.TabIndex = 13;
            this.lblCategoryId.Text = "Category ID";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.Location = new System.Drawing.Point(0, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(299, 69);
            this.lblItemCategory.TabIndex = 12;
            this.lblItemCategory.Text = "ITEM CATEGORY";
            this.lblItemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(6, 93);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(286, 30);
            this.txtCategoryId.TabIndex = 11;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(6, 158);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(286, 30);
            this.txtCategoryName.TabIndex = 9;
            // 
            // btnAddItemCategory
            // 
            this.btnAddItemCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddItemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItemCategory.Location = new System.Drawing.Point(8, 328);
            this.btnAddItemCategory.Name = "btnAddItemCategory";
            this.btnAddItemCategory.Size = new System.Drawing.Size(285, 45);
            this.btnAddItemCategory.TabIndex = 8;
            this.btnAddItemCategory.Text = "ADD";
            this.btnAddItemCategory.UseVisualStyleBackColor = false;
            this.btnAddItemCategory.Click += new System.EventHandler(this.btnAddItemCategory_Click);
            // 
            // tpSupplier
            // 
            this.tpSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpSupplier.Controls.Add(this.btnDeleteSupplier);
            this.tpSupplier.Controls.Add(this.btnUpdateSupplier);
            this.tpSupplier.Controls.Add(this.lblContactNo);
            this.tpSupplier.Controls.Add(this.txtContactNo);
            this.tpSupplier.Controls.Add(this.lblAddress);
            this.tpSupplier.Controls.Add(this.lblSupplierName);
            this.tpSupplier.Controls.Add(this.lblSupplierId);
            this.tpSupplier.Controls.Add(this.lblSupplier);
            this.tpSupplier.Controls.Add(this.txtSupplierId);
            this.tpSupplier.Controls.Add(this.txtAddress);
            this.tpSupplier.Controls.Add(this.txtSupplierName);
            this.tpSupplier.Controls.Add(this.btnAddSupplier);
            this.tpSupplier.Location = new System.Drawing.Point(4, 22);
            this.tpSupplier.Name = "tpSupplier";
            this.tpSupplier.Size = new System.Drawing.Size(301, 661);
            this.tpSupplier.TabIndex = 2;
            this.tpSupplier.Text = "Supplier";
            this.tpSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(8, 437);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(285, 45);
            this.btnDeleteSupplier.TabIndex = 33;
            this.btnDeleteSupplier.Text = "DELETE";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(8, 383);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(285, 45);
            this.btnUpdateSupplier.TabIndex = 18;
            this.btnUpdateSupplier.Text = "UPDATE";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(4, 266);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(125, 20);
            this.lblContactNo.TabIndex = 17;
            this.lblContactNo.Text = "Contact Number";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(6, 289);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(286, 30);
            this.txtContactNo.TabIndex = 16;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(5, 135);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(113, 20);
            this.lblSupplierName.TabIndex = 14;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierId.Location = new System.Drawing.Point(5, 70);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(88, 20);
            this.lblSupplierId.TabIndex = 13;
            this.lblSupplierId.Text = "Supplier ID";
            // 
            // lblSupplier
            // 
            this.lblSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(0, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(299, 69);
            this.lblSupplier.TabIndex = 12;
            this.lblSupplier.Text = "SUPPLIER";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.Location = new System.Drawing.Point(6, 93);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.ReadOnly = true;
            this.txtSupplierId.Size = new System.Drawing.Size(286, 30);
            this.txtSupplierId.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(7, 225);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 30);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(6, 158);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(286, 30);
            this.txtSupplierName.TabIndex = 9;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSupplier.Location = new System.Drawing.Point(8, 328);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(285, 45);
            this.btnAddSupplier.TabIndex = 8;
            this.btnAddSupplier.Text = "ADD";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // tpItems
            // 
            this.tpItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpItems.Controls.Add(this.btnDeleteItem);
            this.tpItems.Controls.Add(this.cboCategoryName);
            this.tpItems.Controls.Add(this.nudBasePrice);
            this.tpItems.Controls.Add(this.btnUpdateItem);
            this.tpItems.Controls.Add(this.lblBasePrice);
            this.tpItems.Controls.Add(lblItemsCategoryName);
            this.tpItems.Controls.Add(this.lblItemName);
            this.tpItems.Controls.Add(this.lblItemId);
            this.tpItems.Controls.Add(this.lblItems);
            this.tpItems.Controls.Add(this.txtItemId);
            this.tpItems.Controls.Add(this.txtItemName);
            this.tpItems.Controls.Add(this.btnAddItem);
            this.tpItems.Location = new System.Drawing.Point(4, 22);
            this.tpItems.Name = "tpItems";
            this.tpItems.Size = new System.Drawing.Size(301, 661);
            this.tpItems.TabIndex = 3;
            this.tpItems.Text = "Items";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItem.Location = new System.Drawing.Point(8, 437);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(285, 45);
            this.btnDeleteItem.TabIndex = 32;
            this.btnDeleteItem.Text = "DELETE";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Visible = false;
            // 
            // cboCategoryName
            // 
            this.cboCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoryName.FormattingEnabled = true;
            this.cboCategoryName.Location = new System.Drawing.Point(9, 226);
            this.cboCategoryName.Name = "cboCategoryName";
            this.cboCategoryName.Size = new System.Drawing.Size(283, 33);
            this.cboCategoryName.TabIndex = 31;
            // 
            // nudBasePrice
            // 
            this.nudBasePrice.DecimalPlaces = 2;
            this.nudBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBasePrice.Location = new System.Drawing.Point(9, 290);
            this.nudBasePrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBasePrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBasePrice.Name = "nudBasePrice";
            this.nudBasePrice.Size = new System.Drawing.Size(283, 30);
            this.nudBasePrice.TabIndex = 30;
            this.nudBasePrice.ThousandsSeparator = true;
            this.nudBasePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateItem.Location = new System.Drawing.Point(8, 383);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(285, 45);
            this.btnUpdateItem.TabIndex = 29;
            this.btnUpdateItem.Text = "UPDATE";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(5, 266);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(85, 20);
            this.lblBasePrice.TabIndex = 28;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(5, 135);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 25;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.Location = new System.Drawing.Point(5, 70);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(62, 20);
            this.lblItemId.TabIndex = 24;
            this.lblItemId.Text = "Item ID";
            // 
            // lblItems
            // 
            this.lblItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(0, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(299, 69);
            this.lblItems.TabIndex = 23;
            this.lblItems.Text = "ITEMS";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.Location = new System.Drawing.Point(6, 93);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(286, 30);
            this.txtItemId.TabIndex = 22;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(6, 158);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(286, 30);
            this.txtItemName.TabIndex = 20;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(8, 328);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(285, 45);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "ADD";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(0, 59);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.Size = new System.Drawing.Size(575, 652);
            this.dgvResults.TabIndex = 2;
            // 
            // msMenuBar
            // 
            this.msMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.msMenuBar.Location = new System.Drawing.Point(0, 0);
            this.msMenuBar.Name = "msMenuBar";
            this.msMenuBar.Size = new System.Drawing.Size(884, 24);
            this.msMenuBar.TabIndex = 3;
            this.msMenuBar.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Image = global::ITP104___Finals_Project___Exam.Properties.Resources.DASHBOARD;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::ITP104___Finals_Project___Exam.Properties.Resources.LOGOUT;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblResultGrid
            // 
            this.lblResultGrid.AllowDrop = true;
            this.lblResultGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResultGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultGrid.Location = new System.Drawing.Point(0, 24);
            this.lblResultGrid.Name = "lblResultGrid";
            this.lblResultGrid.Size = new System.Drawing.Size(575, 35);
            this.lblResultGrid.TabIndex = 4;
            this.lblResultGrid.Text = "RESULT GRID";
            this.lblResultGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelResults
            // 
            this.panelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(884, 711);
            this.panelResults.TabIndex = 5;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblResultGrid);
            this.Controls.Add(this.tcOperations);
            this.Controls.Add(this.msMenuBar);
            this.Controls.Add(this.panelResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuBar;
            this.Name = "Maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maintenance_FormClosing);
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.SizeChanged += new System.EventHandler(this.Maintenance_SizeChanged);
            this.tcOperations.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            this.tpItemCategory.ResumeLayout(false);
            this.tpItemCategory.PerformLayout();
            this.tpSupplier.ResumeLayout(false);
            this.tpSupplier.PerformLayout();
            this.tpItems.ResumeLayout(false);
            this.tpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.msMenuBar.ResumeLayout(false);
            this.msMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcOperations;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpItemCategory;
        private System.Windows.Forms.TabPage tpSupplier;
        private System.Windows.Forms.TabPage tpItems;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddItemCategory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Button btnUpdateItemCategory;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.ComboBox cboCategoryName;
        private System.Windows.Forms.NumericUpDown nudBasePrice;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenuBar;
        private System.Windows.Forms.Label lblResultGrid;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteItemCategory;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}