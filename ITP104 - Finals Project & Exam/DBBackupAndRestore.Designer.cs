namespace ITP104___Finals_Project___Exam {
    partial class DBBackupAndRestore {
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
            System.Windows.Forms.Button btnBackupDB;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBBackupAndRestore));
            this.btnRestoreDB = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.msMenuBar = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnBackupDB = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.msMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackupDB
            // 
            btnBackupDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            btnBackupDB.Dock = System.Windows.Forms.DockStyle.Top;
            btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBackupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBackupDB.ForeColor = System.Drawing.Color.White;
            btnBackupDB.Location = new System.Drawing.Point(0, 24);
            btnBackupDB.Name = "btnBackupDB";
            btnBackupDB.Size = new System.Drawing.Size(434, 130);
            btnBackupDB.TabIndex = 0;
            btnBackupDB.Text = "BACKUP DATABASE";
            btnBackupDB.UseVisualStyleBackColor = false;
            btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnRestoreDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRestoreDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDB.ForeColor = System.Drawing.Color.White;
            this.btnRestoreDB.Location = new System.Drawing.Point(0, 156);
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.Size = new System.Drawing.Size(434, 130);
            this.btnRestoreDB.TabIndex = 1;
            this.btnRestoreDB.Text = "RESTORE DATABASE";
            this.btnRestoreDB.UseVisualStyleBackColor = false;
            this.btnRestoreDB.Click += new System.EventHandler(this.btnRestoreDB_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(btnBackupDB);
            this.panelContent.Controls.Add(this.msMenuBar);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(434, 286);
            this.panelContent.TabIndex = 2;
            // 
            // msMenuBar
            // 
            this.msMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.msMenuBar.Location = new System.Drawing.Point(0, 0);
            this.msMenuBar.Name = "msMenuBar";
            this.msMenuBar.Size = new System.Drawing.Size(434, 24);
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
            // DBBackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 286);
            this.Controls.Add(this.btnRestoreDB);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuBar;
            this.MaximizeBox = false;
            this.Name = "DBBackupAndRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup & Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBBackupAndRestore_FormClosing);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.msMenuBar.ResumeLayout(false);
            this.msMenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestoreDB;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.MenuStrip msMenuBar;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}