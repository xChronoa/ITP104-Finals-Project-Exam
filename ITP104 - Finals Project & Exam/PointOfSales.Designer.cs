namespace ITP104___Finals_Project___Exam {
    partial class PointOfSales {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSales));
            this.msMenuBar = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAddToCart = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.nudTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblOrderForm = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dtmReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblReceiptId = new System.Windows.Forms.Label();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.lblCart = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPriec = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.lblOrderHistory = new System.Windows.Forms.Label();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.msMenuBar.SuspendLayout();
            this.panelAddToCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelReceipt.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuBar
            // 
            this.msMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.msMenuBar.Location = new System.Drawing.Point(0, 0);
            this.msMenuBar.Name = "msMenuBar";
            this.msMenuBar.Size = new System.Drawing.Size(1119, 24);
            this.msMenuBar.TabIndex = 0;
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
            // panelAddToCart
            // 
            this.panelAddToCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddToCart.Controls.Add(this.lblTotalAmount);
            this.panelAddToCart.Controls.Add(this.nudTotalAmount);
            this.panelAddToCart.Controls.Add(this.lblQuantity);
            this.panelAddToCart.Controls.Add(this.nudQuantity);
            this.panelAddToCart.Controls.Add(this.cboItemName);
            this.panelAddToCart.Controls.Add(this.lblItemName);
            this.panelAddToCart.Controls.Add(this.lblOrderForm);
            this.panelAddToCart.Controls.Add(this.btnAddToCart);
            this.panelAddToCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddToCart.Location = new System.Drawing.Point(0, 0);
            this.panelAddToCart.Name = "panelAddToCart";
            this.panelAddToCart.Size = new System.Drawing.Size(436, 299);
            this.panelAddToCart.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(57, 175);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(92, 17);
            this.lblTotalAmount.TabIndex = 31;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // nudTotalAmount
            // 
            this.nudTotalAmount.DecimalPlaces = 2;
            this.nudTotalAmount.Enabled = false;
            this.nudTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalAmount.Location = new System.Drawing.Point(57, 195);
            this.nudTotalAmount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudTotalAmount.Name = "nudTotalAmount";
            this.nudTotalAmount.ReadOnly = true;
            this.nudTotalAmount.Size = new System.Drawing.Size(320, 23);
            this.nudTotalAmount.TabIndex = 30;
            this.nudTotalAmount.ThousandsSeparator = true;
            this.nudTotalAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(57, 114);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(57, 134);
            this.nudQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(320, 23);
            this.nudQuantity.TabIndex = 28;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            this.nudQuantity.Leave += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // cboItemName
            // 
            this.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(57, 79);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(320, 24);
            this.cboItemName.TabIndex = 27;
            this.cboItemName.SelectionChangeCommitted += new System.EventHandler(this.cboItemName_SelectionChangeCommitted);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(57, 59);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 17);
            this.lblItemName.TabIndex = 25;
            this.lblItemName.Text = "Item Name";
            // 
            // lblOrderForm
            // 
            this.lblOrderForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderForm.Location = new System.Drawing.Point(0, 0);
            this.lblOrderForm.Name = "lblOrderForm";
            this.lblOrderForm.Size = new System.Drawing.Size(434, 50);
            this.lblOrderForm.TabIndex = 22;
            this.lblOrderForm.Text = "ORDER FORM";
            this.lblOrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.Location = new System.Drawing.Point(57, 234);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(320, 45);
            this.btnAddToCart.TabIndex = 20;
            this.btnAddToCart.Text = "ADD TO CART";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dtmReceiptDate
            // 
            this.dtmReceiptDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmReceiptDate.CustomFormat = "MMMM dd, yyyy";
            this.dtmReceiptDate.Enabled = false;
            this.dtmReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dtmReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmReceiptDate.Location = new System.Drawing.Point(267, 28);
            this.dtmReceiptDate.Name = "dtmReceiptDate";
            this.dtmReceiptDate.Size = new System.Drawing.Size(151, 21);
            this.dtmReceiptDate.TabIndex = 26;
            this.dtmReceiptDate.Value = new System.DateTime(2024, 1, 2, 17, 6, 43, 0);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(328, 8);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(90, 17);
            this.lblDeliveryDate.TabIndex = 24;
            this.lblDeliveryDate.Text = "Receipt Date";
            // 
            // lblReceiptId
            // 
            this.lblReceiptId.AutoSize = true;
            this.lblReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptId.Location = new System.Drawing.Point(10, 8);
            this.lblReceiptId.Name = "lblReceiptId";
            this.lblReceiptId.Size = new System.Drawing.Size(73, 17);
            this.lblReceiptId.TabIndex = 23;
            this.lblReceiptId.Text = "Receipt ID";
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Enabled = false;
            this.txtReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptId.Location = new System.Drawing.Point(10, 28);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.ReadOnly = true;
            this.txtReceiptId.Size = new System.Drawing.Size(120, 21);
            this.txtReceiptId.TabIndex = 21;
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.AcceptsTab = true;
            this.rtbReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReceipt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReceipt.Location = new System.Drawing.Point(5, 34);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.ReadOnly = true;
            this.rtbReceipt.Size = new System.Drawing.Size(671, 721);
            this.rtbReceipt.TabIndex = 3;
            this.rtbReceipt.Text = "";
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.dgvItemList);
            this.panelPayment.Controls.Add(this.lblCart);
            this.panelPayment.Controls.Add(this.panelBottom);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayment.Location = new System.Drawing.Point(0, 299);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Padding = new System.Windows.Forms.Padding(5);
            this.panelPayment.Size = new System.Drawing.Size(436, 463);
            this.panelPayment.TabIndex = 32;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(179)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.EnableHeadersVisualStyles = false;
            this.dgvItemList.Location = new System.Drawing.Point(5, 57);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItemList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(426, 194);
            this.dgvItemList.TabIndex = 28;
            this.dgvItemList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemList_CellFormatting);
            // 
            // lblCart
            // 
            this.lblCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(5, 5);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(426, 52);
            this.lblCart.TabIndex = 29;
            this.lblCart.Text = "CART";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelOrderDetails);
            this.panelBottom.Controls.Add(this.panelControls);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 251);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(426, 207);
            this.panelBottom.TabIndex = 27;
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.Controls.Add(this.lblChangeAmount);
            this.panelOrderDetails.Controls.Add(this.lblPayment);
            this.panelOrderDetails.Controls.Add(this.nudPayment);
            this.panelOrderDetails.Controls.Add(this.label2);
            this.panelOrderDetails.Controls.Add(this.nudTotalPrice);
            this.panelOrderDetails.Controls.Add(this.lblTotalPriec);
            this.panelOrderDetails.Controls.Add(this.lblDeliveryDate);
            this.panelOrderDetails.Controls.Add(this.dtmReceiptDate);
            this.panelOrderDetails.Controls.Add(this.lblReceiptId);
            this.panelOrderDetails.Controls.Add(this.txtReceiptId);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(426, 149);
            this.panelOrderDetails.TabIndex = 0;
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.Location = new System.Drawing.Point(267, 107);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(151, 23);
            this.lblChangeAmount.TabIndex = 32;
            this.lblChangeAmount.Text = "0.00";
            this.lblChangeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(355, 60);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(63, 17);
            this.lblPayment.TabIndex = 31;
            this.lblPayment.Text = "Payment";
            // 
            // nudPayment
            // 
            this.nudPayment.DecimalPlaces = 2;
            this.nudPayment.Location = new System.Drawing.Point(267, 80);
            this.nudPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudPayment.Size = new System.Drawing.Size(149, 20);
            this.nudPayment.TabIndex = 30;
            this.nudPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPayment.ThousandsSeparator = true;
            this.nudPayment.ValueChanged += new System.EventHandler(this.nudPayment_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Change: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTotalPrice
            // 
            this.nudTotalPrice.DecimalPlaces = 2;
            this.nudTotalPrice.Enabled = false;
            this.nudTotalPrice.Location = new System.Drawing.Point(10, 80);
            this.nudTotalPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTotalPrice.Name = "nudTotalPrice";
            this.nudTotalPrice.ReadOnly = true;
            this.nudTotalPrice.Size = new System.Drawing.Size(120, 20);
            this.nudTotalPrice.TabIndex = 28;
            this.nudTotalPrice.ThousandsSeparator = true;
            this.nudTotalPrice.ValueChanged += new System.EventHandler(this.nudTotalPrice_ValueChanged);
            // 
            // lblTotalPriec
            // 
            this.lblTotalPriec.AutoSize = true;
            this.lblTotalPriec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriec.Location = new System.Drawing.Point(7, 60);
            this.lblTotalPriec.Name = "lblTotalPriec";
            this.lblTotalPriec.Size = new System.Drawing.Size(76, 17);
            this.lblTotalPriec.TabIndex = 27;
            this.lblTotalPriec.Text = "Total Price";
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnRemoveItem);
            this.panelControls.Controls.Add(this.btnPay);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 149);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(5);
            this.panelControls.Size = new System.Drawing.Size(426, 58);
            this.panelControls.TabIndex = 1;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.btnRemoveItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveItem.Location = new System.Drawing.Point(296, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(125, 48);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "REMOVE ITEM";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(5, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 48);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panelReceipt
            // 
            this.panelReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceipt.Controls.Add(this.rtbReceipt);
            this.panelReceipt.Controls.Add(this.lblOrderHistory);
            this.panelReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReceipt.Location = new System.Drawing.Point(436, 24);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Padding = new System.Windows.Forms.Padding(5);
            this.panelReceipt.Size = new System.Drawing.Size(683, 762);
            this.panelReceipt.TabIndex = 33;
            // 
            // lblOrderHistory
            // 
            this.lblOrderHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHistory.Location = new System.Drawing.Point(5, 5);
            this.lblOrderHistory.Name = "lblOrderHistory";
            this.lblOrderHistory.Size = new System.Drawing.Size(671, 29);
            this.lblOrderHistory.TabIndex = 4;
            this.lblOrderHistory.Text = "ORDER HISTORY";
            this.lblOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.panelPayment);
            this.panelOperations.Controls.Add(this.panelAddToCart);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOperations.Location = new System.Drawing.Point(0, 24);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(436, 762);
            this.panelOperations.TabIndex = 34;
            // 
            // PointOfSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 786);
            this.Controls.Add(this.panelReceipt);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.msMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuBar;
            this.Name = "PointOfSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PointOfSales_FormClosing);
            this.Load += new System.EventHandler(this.PointOfSales_Load);
            this.SizeChanged += new System.EventHandler(this.PointOfSales_SizeChanged);
            this.msMenuBar.ResumeLayout(false);
            this.msMenuBar.PerformLayout();
            this.panelAddToCart.ResumeLayout(false);
            this.panelAddToCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panelPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelOrderDetails.ResumeLayout(false);
            this.panelOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelReceipt.ResumeLayout(false);
            this.panelOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuBar;
        private System.Windows.Forms.Panel panelAddToCart;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.DateTimePicker dtmReceiptDate;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblReceiptId;
        private System.Windows.Forms.Label lblOrderForm;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.NumericUpDown nudTotalAmount;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Label lblOrderHistory;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalPriec;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.NumericUpDown nudTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvItemList;
    }
}