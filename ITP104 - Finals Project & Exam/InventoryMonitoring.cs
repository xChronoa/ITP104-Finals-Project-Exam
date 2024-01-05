using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class InventoryMonitoring : Form {
        public InventoryMonitoring() {
            InitializeComponent();

            // After initializing components show the data of table inventory.
            showTableInventory();
        }

        public void showTableInventory() {
            // Stores necessary information needed for MySQL Connection.
            String con = "Server = localhost; " +
                         "Database = finalsprojectandexam;" +
                         "user = root;" +
                         "password = ;";

            // Initialize the MySQL Connection.
            MySqlConnection connection = new MySqlConnection(con);

            try {
                // Open connection.
                connection.Open();

                // Query that will show the table data with columns as "Inventory ID", "Item Name", and "Quantity" ordered by least quantity to greatest.
                String query =  "SELECT a.inventory_id AS 'Inventory ID', c.category_name AS 'Item Category', b.item_name AS 'Item', a.quantity AS 'Quantity' " +
                                "FROM tbl_inventory AS a " +
                                "INNER JOIN tbl_items AS b " +
                                "ON a.item_Id = b.item_Id " +
                                "INNER JOIN tbl_itemcategory AS c " +
                                "ON c.category_Id = b.category_Id " +
                                "ORDER BY quantity ASC";

                // Bind the query and connection to a MySQL Command.
                MySqlCommand command = new MySqlCommand(query, connection);

                // Data Adapter to execute the query and fill a data set.
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                // Initialize data set and fill it with fetched data from the query.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Set the data source of the data grid view dgvResults to the data set.
                dgvResults.DataSource = dataSet.Tables[0].DefaultView;

                // Disable sorting for all columns
                foreach (DataGridViewColumn column in dgvResults.Columns) {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                // Finally block to always check if the connection state is open, if true then proceed to close it.
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }


        #region Menu Controls
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e) {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
            this.Dispose();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
            this.Dispose();
        }
        #endregion


        // Terminates the whole program upon clicking the window close button.
        private void InventoryMonitoring_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}