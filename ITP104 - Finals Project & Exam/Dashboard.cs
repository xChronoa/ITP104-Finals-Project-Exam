using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class Dashboard : Form {
        public Dashboard() {
            InitializeComponent();
        }

        // Change the background color of lblTitle to that of the lblBackground.
        private void Dashboard_Load(object sender, EventArgs e) {
            lblTitle.Parent = lblBackground;
            lblTitle.BackColor = Color.Transparent;
        }

        // Logout functionality for the menu strip upon clicking.
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
            this.Dispose();
        }

        // Redirect the user to the maintenance window.
        private void btnMaintenance_Click(object sender, EventArgs e) {
            Maintenance maintenanceForm = new Maintenance(); 
            maintenanceForm.Show();
            this.Dispose();
        }

        // Redirect the user to the delivery window.
        private void btnDelivery_Click(object sender, EventArgs e) {
            Delivery deliveryForm = new Delivery();
            deliveryForm.Show();
            this.Dispose();
        }

        // Redirect the user to the inventory monitoring window.
        private void btnInventoryMonitoring_Click(object sender, EventArgs e) {
            InventoryMonitoring inventoryForm = new InventoryMonitoring();
            inventoryForm.Show();
            this.Dispose();
        }

        // Redirect the user to the point of sales window.
        private void btnPointOfSales_Click(object sender, EventArgs e) {
            PointOfSales pointOfSalesForm = new PointOfSales();
            pointOfSalesForm.Show();
            this.Dispose();
        }

        // Redirect the user to the sales monitoring window.
        private void btnSalesMonitoring_Click(object sender, EventArgs e) {
            SalesMonitoring salesForm = new SalesMonitoring();
            salesForm.Show();
            this.Dispose();
        }

        // Redirect the user to the database backup & restore window.
        private void btnDBBackupAndRestore_Click(object sender, EventArgs e) {
            DBBackupAndRestore backupAndRestoreForm = new DBBackupAndRestore();
            backupAndRestoreForm.Show();
            this.Dispose();
        }

        // Terminates the whole program upon clicking the window close button.
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}