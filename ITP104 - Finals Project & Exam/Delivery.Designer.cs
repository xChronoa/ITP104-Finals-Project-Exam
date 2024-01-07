namespace ITP104___Finals_Project___Exam {
    partial class Delivery {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.panelDelivery = new System.Windows.Forms.Panel();
            this.msMenuBar = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelDeliverItem = new System.Windows.Forms.Panel();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelDeliveryDetails = new System.Windows.Forms.Panel();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.lblDeliveryId = new System.Windows.Forms.Label();
            this.dtmDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.panelDeliverControls = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnDeliverItem = new System.Windows.Forms.Button();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.btnAddItemToList = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblDeliveryForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.panelDelivery.SuspendLayout();
            this.msMenuBar.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelDeliverItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelDeliveryDetails.SuspendLayout();
            this.panelDeliverControls.SuspendLayout();
            this.panelAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvResults.Location = new System.Drawing.Point(0, 31);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.Size = new System.Drawing.Size(631, 754);
            this.dgvResults.TabIndex = 0;
            // 
            // lblResults
            // 
            this.lblResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(0, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(631, 31);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "DELIVERY LOG";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDelivery
            // 
            this.panelDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDelivery.Controls.Add(this.dgvResults);
            this.panelDelivery.Controls.Add(this.lblResults);
            this.panelDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelivery.Location = new System.Drawing.Point(0, 24);
            this.panelDelivery.Name = "panelDelivery";
            this.panelDelivery.Size = new System.Drawing.Size(633, 787);
            this.panelDelivery.TabIndex = 2;
            // 
            // msMenuBar
            // 
            this.msMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.msMenuBar.Location = new System.Drawing.Point(0, 0);
            this.msMenuBar.Name = "msMenuBar";
            this.msMenuBar.Size = new System.Drawing.Size(984, 24);
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
            // panelControl
            // 
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.panelDeliverItem);
            this.panelControl.Controls.Add(this.panelAddItem);
            this.panelControl.Controls.Add(this.lblDeliveryForm);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(633, 24);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(351, 787);
            this.panelControl.TabIndex = 4;
            // 
            // panelDeliverItem
            // 
            this.panelDeliverItem.Controls.Add(this.dgvItemList);
            this.panelDeliverItem.Controls.Add(this.panelBottom);
            this.panelDeliverItem.Controls.Add(this.lblListOfItems);
            this.panelDeliverItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliverItem.Location = new System.Drawing.Point(0, 255);
            this.panelDeliverItem.Name = "panelDeliverItem";
            this.panelDeliverItem.Padding = new System.Windows.Forms.Padding(5);
            this.panelDeliverItem.Size = new System.Drawing.Size(349, 530);
            this.panelDeliverItem.TabIndex = 22;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(179)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.EnableHeadersVisualStyles = false;
            this.dgvItemList.Location = new System.Drawing.Point(5, 39);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.ShowEditingIcon = false;
            this.dgvItemList.Size = new System.Drawing.Size(339, 386);
            this.dgvItemList.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelDeliveryDetails);
            this.panelBottom.Controls.Add(this.panelDeliverControls);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(339, 100);
            this.panelBottom.TabIndex = 18;
            // 
            // panelDeliveryDetails
            // 
            this.panelDeliveryDetails.Controls.Add(this.lblDeliveryDate);
            this.panelDeliveryDetails.Controls.Add(this.txtDeliveryId);
            this.panelDeliveryDetails.Controls.Add(this.lblDeliveryId);
            this.panelDeliveryDetails.Controls.Add(this.dtmDeliveryDate);
            this.panelDeliveryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliveryDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveryDetails.Name = "panelDeliveryDetails";
            this.panelDeliveryDetails.Size = new System.Drawing.Size(339, 55);
            this.panelDeliveryDetails.TabIndex = 17;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(261, 6);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 14;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Enabled = false;
            this.txtDeliveryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryId.Location = new System.Drawing.Point(5, 22);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.ReadOnly = true;
            this.txtDeliveryId.Size = new System.Drawing.Size(86, 23);
            this.txtDeliveryId.TabIndex = 11;
            // 
            // lblDeliveryId
            // 
            this.lblDeliveryId.AutoSize = true;
            this.lblDeliveryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryId.Location = new System.Drawing.Point(4, 6);
            this.lblDeliveryId.Name = "lblDeliveryId";
            this.lblDeliveryId.Size = new System.Drawing.Size(59, 13);
            this.lblDeliveryId.TabIndex = 13;
            this.lblDeliveryId.Text = "Delivery ID";
            // 
            // dtmDeliveryDate
            // 
            this.dtmDeliveryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDeliveryDate.CustomFormat = "MMMM dd, yyyy";
            this.dtmDeliveryDate.Enabled = false;
            this.dtmDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dtmDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDeliveryDate.Location = new System.Drawing.Point(163, 22);
            this.dtmDeliveryDate.Name = "dtmDeliveryDate";
            this.dtmDeliveryDate.Size = new System.Drawing.Size(171, 23);
            this.dtmDeliveryDate.TabIndex = 16;
            this.dtmDeliveryDate.Value = new System.DateTime(2024, 1, 2, 17, 7, 18, 0);
            // 
            // panelDeliverControls
            // 
            this.panelDeliverControls.Controls.Add(this.btnRemoveItem);
            this.panelDeliverControls.Controls.Add(this.btnDeliverItem);
            this.panelDeliverControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeliverControls.Location = new System.Drawing.Point(0, 55);
            this.panelDeliverControls.Name = "panelDeliverControls";
            this.panelDeliverControls.Padding = new System.Windows.Forms.Padding(5);
            this.panelDeliverControls.Size = new System.Drawing.Size(339, 45);
            this.panelDeliverControls.TabIndex = 9;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnRemoveItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveItem.Location = new System.Drawing.Point(219, 5);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(115, 35);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "REMOVE";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnDeliverItem
            // 
            this.btnDeliverItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnDeliverItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeliverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliverItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeliverItem.Location = new System.Drawing.Point(5, 5);
            this.btnDeliverItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeliverItem.Name = "btnDeliverItem";
            this.btnDeliverItem.Size = new System.Drawing.Size(115, 35);
            this.btnDeliverItem.TabIndex = 8;
            this.btnDeliverItem.Text = "DELIVER ITEMS";
            this.btnDeliverItem.UseVisualStyleBackColor = false;
            this.btnDeliverItem.Click += new System.EventHandler(this.btnDeliverItem_Click);
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfItems.Location = new System.Drawing.Point(5, 5);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(339, 34);
            this.lblListOfItems.TabIndex = 17;
            this.lblListOfItems.Text = "List of Items";
            this.lblListOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddItem
            // 
            this.panelAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddItem.Controls.Add(this.btnAddItemToList);
            this.panelAddItem.Controls.Add(this.lblItemName);
            this.panelAddItem.Controls.Add(this.cboItemName);
            this.panelAddItem.Controls.Add(this.lblQuantity);
            this.panelAddItem.Controls.Add(this.nudQuantity);
            this.panelAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddItem.Location = new System.Drawing.Point(0, 50);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(349, 205);
            this.panelAddItem.TabIndex = 21;
            // 
            // btnAddItemToList
            // 
            this.btnAddItemToList.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddItemToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemToList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItemToList.Location = new System.Drawing.Point(14, 139);
            this.btnAddItemToList.Name = "btnAddItemToList";
            this.btnAddItemToList.Size = new System.Drawing.Size(320, 45);
            this.btnAddItemToList.TabIndex = 20;
            this.btnAddItemToList.Text = "ADD ITEM TO LIST";
            this.btnAddItemToList.UseVisualStyleBackColor = false;
            this.btnAddItemToList.Click += new System.EventHandler(this.btnAddItemToList_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(11, 13);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 15;
            this.lblItemName.Text = "Item Name";
            // 
            // cboItemName
            // 
            this.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(15, 37);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(317, 32);
            this.cboItemName.TabIndex = 17;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(11, 77);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(15, 101);
            this.nudQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(317, 30);
            this.nudQuantity.TabIndex = 18;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDeliveryForm
            // 
            this.lblDeliveryForm.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeliveryForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeliveryForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryForm.Location = new System.Drawing.Point(0, 0);
            this.lblDeliveryForm.Name = "lblDeliveryForm";
            this.lblDeliveryForm.Size = new System.Drawing.Size(349, 50);
            this.lblDeliveryForm.TabIndex = 12;
            this.lblDeliveryForm.Text = "DELIVERY FORM";
            this.lblDeliveryForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 811);
            this.Controls.Add(this.panelDelivery);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.msMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuBar;
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delivery_FormClosing);
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.panelDelivery.ResumeLayout(false);
            this.msMenuBar.ResumeLayout(false);
            this.msMenuBar.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelDeliverItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelDeliveryDetails.ResumeLayout(false);
            this.panelDeliveryDetails.PerformLayout();
            this.panelDeliverControls.ResumeLayout(false);
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel panelDelivery;
        private System.Windows.Forms.MenuStrip msMenuBar;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryId;
        private System.Windows.Forms.Label lblDeliveryForm;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnDeliverItem;
        private System.Windows.Forms.DateTimePicker dtmDeliveryDate;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddItemToList;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Panel panelDeliverItem;
        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblListOfItems;
        private System.Windows.Forms.Panel panelDeliveryDetails;
        private System.Windows.Forms.Panel panelDeliverControls;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}