using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class UpdateItem : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private Maintenance maintenanceForm;
        private int itemId;
        private String itemName, categoryName;
        private double base_price;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private static String dbName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {dbName};" +
                             "user = root;" +
                             "password = ;";
        private String query = "";

        // Establishes association relationship between UpdateItem and Maintenance.
        public UpdateItem(Maintenance maintenanceForm, int itemId, String categoryName, String itemName, double base_price) {
            InitializeComponent();

            // Set the values for these select variables.
            // The information stored shall be used for updating the selected item.
            this.maintenanceForm = maintenanceForm;
            this.itemId = itemId;
            this.categoryName = categoryName;
            this.itemName = itemName;
            this.base_price = base_price;
        }


        #region Delegate and its respective method
        /// <summary>
        /// The delegate in this program is used for recycling the try...catch...finally line of codes.
        /// So, that the overall length of the code would not be unnecessarily long.
        /// This is done to recycle the specified codes so that it will not be re-iterated over and over again throughout the code sheet.
        /// </summary>

        private delegate void QueryDelegate();
        private void executeQuery(QueryDelegate queryToExecute) {
            // Initialize MySQL Connection.
            connection = new MySqlConnection(con);

            // Try...Catch...Finally statements for error handling.
            // This handles exceptions that will prevent the program from terminating abruptly.
            try {
                // Open a connection.
                connection.Open();

                // Execute the code given to the delegate.
                queryToExecute();
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                // Finally block to always check if the connection state is open, if true then proceed to close it.
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }
        #endregion


        // Method for fetching the item categories.
        private void fetchItemCategories() {
            // Query for fetching the category name from the table item category.
            executeQuery(() => {
                query = "SELECT category_name FROM tbl_itemcategory";

                // Initialize the MySQL Command and Data Adapter.
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                // Initialize data table and fill it with fetched data from the query.
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                // Check if the table contains any rows. If true then proceed to set the data source of the combo box cboCategoryName to the data table.
                if (table.Rows.Count > 0) {
                    cboCategoryName.DataSource = new BindingSource(table, null);
                    cboCategoryName.DataSource = table;
                    cboCategoryName.DisplayMember = "category_name";
                }
            });
        }

        // Upon loading the window execute the code inside the block.
        private void UpdateItem_Load(object sender, EventArgs e) {
            // Set the text fields values to the values of the variables taken from the maintenance form.
            txtItemId.Text = this.itemId.ToString();
            txtItemName.Text = this.itemName;

            // Set the selected item category to the selected category from the maintenance form.
            fetchItemCategories();
            cboCategoryName.SelectedIndex = cboCategoryName.FindString(this.categoryName);

            // Set the maximum value of the nudBasePrice to prevent limiting the user's inputs.
            nudBasePrice.Maximum = decimal.MaxValue;

            // Set the value of the nudBasePrice to the value taken from the maintenance form.
            nudBasePrice.Value = (decimal)this.base_price;
        }

        // Click event for the button update.
        private void btnUpdateItem_Click(object sender, EventArgs e) {
            // Variables for storing the values of the input fields under item tab.
            String item_name = txtItemName.Text.Trim();
            int category_Id = cboCategoryName.SelectedIndex;
            double base_price = double.Parse(nudBasePrice.Value.ToString());

            // Validation for checking if the input fields under item tab is empty. If true, return nothing.
            if (string.IsNullOrWhiteSpace(item_name) || category_Id == -1 || base_price == 0) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetches category Id based on the category name inputted.
            // This is crucial in the insert query for table items since it only has a column named category_Id.
            executeQuery(() => {
                query = $"SELECT category_Id FROM tbl_itemcategory WHERE category_name = @CategoryName";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@CategoryName", cboCategoryName.Text.Trim());
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    category_Id = int.Parse(dataReader["category_Id"].ToString());
                }
            });

            // Validation for checking if the item name already exists in the database.
            bool itemExists = false;
            executeQuery(() => {
                query = $"SELECT item_name FROM tbl_items WHERE item_name = @ItemName";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@ItemName", item_name);
                dataReader = command.ExecuteReader();

                // If dataReader is true then set the boolean itemExists to true.
                // This indicates that the item already exists in the database.
                if (dataReader.Read()) {
                    itemExists = true;
                }
                dataReader.Close();
            });

            // If the following condition is true, it will proceed to displaying an error message and return.
            if (itemExists && !String.Equals(item_name, this.itemName, StringComparison.Ordinal)) {
                MessageBox.Show("Sorry, the item name is already in use. \nPlease choose a different name.", "Item Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {
                // If itemExists is false proceed to update the selected item.
                executeQuery(() => {
                    query = $"UPDATE tbl_items " +
                            $"SET item_name = @newItemName, " +
                            $"    category_Id = @newCategory, " +
                            $"    base_price = @newBasePrice " +
                            $"WHERE item_Id = @item_Id";

                    command = new MySqlCommand(query, connection);

                    // Parameterized variables to prevent SQL Injection.
                    command.Parameters.AddWithValue("@item_Id", txtItemId.Text.Trim());
                    command.Parameters.AddWithValue("@newItemName", item_name);
                    command.Parameters.AddWithValue("@newCategory", category_Id);
                    command.Parameters.AddWithValue("@newBasePrice", base_price);
                    command.ExecuteNonQuery();

                    // Store the data grid view of the Maintenance class named dgvResults into a local variable.
                    DataGridView dgvResults = this.maintenanceForm.getdgvResults();

                    // Get the current selected row before refreshing the table data.
                    int selectedIndex = dgvResults.SelectedRows[0].Index;

                    // Refresh the data grid view after the update query.
                    this.maintenanceForm.showTableData("Items");

                    // Set the selected row of the newly refreshed data grid view to the stored selected row.
                    // This allows the program to indicate the row that was updated by the user.
                    dgvResults.CurrentCell = dgvResults.Rows[selectedIndex].Cells[0];
                    dgvResults.Rows[selectedIndex].Selected = true;
                    dgvResults.FirstDisplayedScrollingRowIndex = selectedIndex;

                    // Dipose the update category dialog.
                    this.Dispose();
                });
            }
        }
    }
}