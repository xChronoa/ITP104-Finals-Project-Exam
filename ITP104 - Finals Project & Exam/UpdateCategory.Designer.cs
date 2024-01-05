namespace ITP104___Finals_Project___Exam {
    partial class UpdateCategory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategory));
            this.btnUpdateItemCategory = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateItemCategory
            // 
            this.btnUpdateItemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnUpdateItemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItemCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateItemCategory.Location = new System.Drawing.Point(8, 355);
            this.btnUpdateItemCategory.Name = "btnUpdateItemCategory";
            this.btnUpdateItemCategory.Size = new System.Drawing.Size(285, 45);
            this.btnUpdateItemCategory.TabIndex = 21;
            this.btnUpdateItemCategory.Text = "UPDATE";
            this.btnUpdateItemCategory.UseVisualStyleBackColor = false;
            this.btnUpdateItemCategory.Click += new System.EventHandler(this.btnUpdateItemCategory_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(5, 161);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(119, 20);
            this.lblCategoryName.TabIndex = 20;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(5, 96);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(94, 20);
            this.lblCategoryId.TabIndex = 19;
            this.lblCategoryId.Text = "Category ID";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.Location = new System.Drawing.Point(0, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(304, 69);
            this.lblItemCategory.TabIndex = 18;
            this.lblItemCategory.Text = "UPDATE ITEM CATEGORY";
            this.lblItemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(8, 119);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(285, 30);
            this.txtCategoryId.TabIndex = 17;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(8, 184);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(285, 30);
            this.txtCategoryName.TabIndex = 16;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 421);
            this.Controls.Add(this.btnUpdateItemCategory);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCategory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance - Update Item Category";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateItemCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtCategoryName;
    }
}