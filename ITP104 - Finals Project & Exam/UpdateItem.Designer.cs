namespace ITP104___Finals_Project___Exam {
    partial class UpdateItem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItem));
            this.cboCategoryName = new System.Windows.Forms.ComboBox();
            this.nudBasePrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            lblItemsCategoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemsCategoryName
            // 
            lblItemsCategoryName.AutoSize = true;
            lblItemsCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblItemsCategoryName.Location = new System.Drawing.Point(5, 226);
            lblItemsCategoryName.Name = "lblItemsCategoryName";
            lblItemsCategoryName.Size = new System.Drawing.Size(119, 20);
            lblItemsCategoryName.TabIndex = 37;
            lblItemsCategoryName.Text = "Category Name";
            // 
            // cboCategoryName
            // 
            this.cboCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoryName.FormattingEnabled = true;
            this.cboCategoryName.Location = new System.Drawing.Point(8, 250);
            this.cboCategoryName.Name = "cboCategoryName";
            this.cboCategoryName.Size = new System.Drawing.Size(285, 33);
            this.cboCategoryName.TabIndex = 41;
            // 
            // nudBasePrice
            // 
            this.nudBasePrice.DecimalPlaces = 2;
            this.nudBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBasePrice.Location = new System.Drawing.Point(8, 315);
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
            this.nudBasePrice.Size = new System.Drawing.Size(285, 30);
            this.nudBasePrice.TabIndex = 40;
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
            this.btnUpdateItem.Location = new System.Drawing.Point(8, 355);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(285, 45);
            this.btnUpdateItem.TabIndex = 39;
            this.btnUpdateItem.Text = "UPDATE";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(5, 291);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(85, 20);
            this.lblBasePrice.TabIndex = 38;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(5, 161);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 36;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.Location = new System.Drawing.Point(5, 96);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(62, 20);
            this.lblItemId.TabIndex = 35;
            this.lblItemId.Text = "Item ID";
            // 
            // lblItems
            // 
            this.lblItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(0, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(304, 69);
            this.lblItems.TabIndex = 34;
            this.lblItems.Text = "UPDATE ITEM";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.Location = new System.Drawing.Point(8, 119);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(285, 30);
            this.txtItemId.TabIndex = 33;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(9, 184);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(284, 30);
            this.txtItemName.TabIndex = 32;
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 421);
            this.Controls.Add(this.cboCategoryName);
            this.Controls.Add(this.nudBasePrice);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(lblItemsCategoryName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance - Update Item";
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBasePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategoryName;
        private System.Windows.Forms.NumericUpDown nudBasePrice;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
    }
}