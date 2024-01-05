using MySqlConnector;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class Maintenance : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private MySqlDataAdapter dataAdapter;
        private static String dbName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {dbName};" +
                             "user = root;" +
                             "password = ;";
        private String query = "";

        public Maintenance() {
            InitializeComponent();

            // Set the value of the text fields for table ids.
            txtUserId.Text = fetchTableId("tbl_users").ToString();
            txtCategoryId.Text = fetchTableId("tbl_itemcategory").ToString();
            txtSupplierId.Text = fetchTableId("tbl_suppliers").ToString();
            txtItemId.Text = fetchTableId("tbl_items").ToString();

            // Set the maximum length of characters possible for the text field contact number.
            txtContactNo.MaxLength = 11;
            
            // Fetch and set the elements of the combo box named cboCategoryName.
            fetchItemCategories();

            // Set the numeric up and down named nudBasePrice to the max value possible.
            nudBasePrice.Maximum = decimal.MaxValue;
        }

        // Getter for the data grid view named dgvResults.
        // To allow external classes/objects to gain access to the data shown in the data grid view.
        // Used in the forms UpdateUser, UpdateCategory, UpdateSupplier, and UpdateItem.
        public DataGridView getdgvResults() {
            return dgvResults;
        }

        #region Delegate and its respective method.
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


        #region Fetch the latest ID of each respective table.

        // To fetch the given table's auto increment value.
        private int fetchTableId(String tableName) {
            int tableId = 0;

           executeQuery(() => {
               query = "SELECT AUTO_INCREMENT " +
                       "FROM information_schema.TABLES " +
                      $"WHERE TABLE_SCHEMA = @dbName AND TABLE_NAME = @tableName;";

               command = new MySqlCommand(query, connection);

               // Usage of Parameterized Values to prevent SQL Injection.
               command.Parameters.AddWithValue("@dbName", dbName);
               command.Parameters.AddWithValue("@tableName", tableName);

               dataReader = command.ExecuteReader();
               dataReader.Read();

               tableId = int.Parse(dataReader["AUTO_INCREMENT"].ToString());
               dataReader.Close();
            });

            return tableId;
        }

        //  Method for fetching the existing item categories and setting the cboCategoryName's value to the fetched data.
        private void fetchItemCategories() {
            executeQuery(() => {
                // Fetch the category name from table item category.
                query = "SELECT category_name FROM tbl_itemcategory";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                // Initialize data table then fill the table data to the fetched data.
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                // Check if the table contains any data. If it does then set the data source to the fetched data.
                if (table.Rows.Count > 0) {
                    cboCategoryName.DataSource = new BindingSource(table, null);

                    cboCategoryName.DataSource = table;
                    cboCategoryName.DisplayMember = "category_name";
                }
            });
        }
        #endregion


        #region (SHOW) selected Table Data.
        // Method to show table data based on the argument.
        public void showTableData(String tableName) {
            switch(tableName) {
                case "User":
                    query = "SELECT user_Id AS 'User ID', username AS 'Username', password AS 'Password' " +
                            "FROM tbl_users " +
                            "ORDER BY user_Id DESC";
                    break;
                case "Category":
                    query = "SELECT category_Id AS 'Category ID', category_name AS 'Category Name' " +
                            "FROM tbl_itemcategory " +
                            "ORDER BY category_Id DESC";
                    break;
                case "Supplier":
                    query = "SELECT supplier_Id AS 'Supplier ID', supplier_name AS 'Supplier Name', address AS 'Address', contactNo AS 'Contact Number' " +
                            "FROM tbl_suppliers " +
                            "ORDER BY supplier_Id DESC";
                    break;
                case "Items":
                    query = "SELECT a.item_Id AS 'Item ID', b.category_name AS 'Item Category', a.item_name AS 'Item Name', FORMAT(base_price, 2) AS 'Base Price' " +
                            "FROM tbl_items AS a " +
                            "INNER JOIN tbl_itemcategory AS b " +
                            "ON a.category_Id = b.category_Id " +
                            "ORDER BY item_Id DESC";
                    break;
            }

            executeQuery(() => {
                command = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(command);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Set the data grid view dgvResults data source to the data set which contains the fetched table data.
                dgvResults.DataSource = dataSet.Tables[0].DefaultView;

                // Disable sorting for all columns
                foreach (DataGridViewColumn column in dgvResults.Columns) {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            });
        }

        // Event Listener for the Tab Control which executes whenever the user selects a tab.
        // With the purpose of showing the table data based on the tab that was selected.
        private void tcOperations_Selected(object sender, TabControlEventArgs e) {
            switch (e.TabPageIndex) {
                case 0:
                    showTableData("User");
                    break;
                case 1:
                    showTableData("Category");
                    break;
                case 2:
                    showTableData("Supplier");
                    break;
                case 3:
                    showTableData("Items");
                    break;
            }
        }
        #endregion


        #region (INSERT) Data into the respective table.
        // Click event for the button add under user tab.
        private void btnAddUsers_Click(object sender, EventArgs e) {
            // Variable for storing the text field's values of the user tab.
            String username = txtUsername.Text.Trim(),
                   password = txtPassword.Text.Trim();

            // Validation for checking if the text fields in the user tab is empty. If true return nothing.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking if the username and password contains spaces, if true return nothing.
            if (username.Contains(" ")) {
                MessageBox.Show("Username cannot contain spaces. \nPlease choose a username without spaces.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Contains(" ")) {
                MessageBox.Show("Password cannot contain spaces. \nPlease choose a password without spaces.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking whether the entered username already exists in the database.
            bool userExist = false;
            executeQuery(() => {
                query = $"SELECT username FROM tbl_users WHERE username = @username";
                
                command = new MySqlCommand(query, connection);
                // Parameterized Value to prevent SQL injection.
                command.Parameters.AddWithValue("@username", username);

                dataReader = command.ExecuteReader();

                // If dataReader returns true then it sets the boolean userExist to true
                // This indicates that the user already exists in the database.
                if (dataReader.Read()) {
                    userExist = true;
                } 
                dataReader.Close();
            });

            // If boolean userExist is true then display a message box. Then return nothing.
            if (userExist) {
                MessageBox.Show("User already exists!", "Failed Inserting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }

            // If userExist is false then it inserts the entered information into the database.
            executeQuery(() => {
                query = $"INSERT INTO tbl_users (username, password) VALUES (@username, @password)";
                
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery();

                // Reset the text fields of the user tab.
                txtUserId.Text = fetchTableId("tbl_users").ToString();
                txtUsername.Text = "";
                txtPassword.Text = "";

                // Update the data grid view after the insertion.
                showTableData("User");
            });
        }

        // Click event for the button add under item category tab.
        private void btnAddItemCategory_Click(object sender, EventArgs e) {
            // Variable to store the value of the input field under item category tab.
            String category_name = txtCategoryName.Text.Trim();

            // Validation for checking whether the input field under item category tab is empty or not. If empty, return nothing.
            if (string.IsNullOrWhiteSpace(category_name)) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking if the category name already exists in the database.
            bool categoryExists = false;
            executeQuery(() => {
                query = $"SELECT category_name FROM tbl_itemcategory WHERE category_name = @categoryName";
                
                command = new MySqlCommand(query, connection);

                // Paramaterized Value to prevent SQL Injection.
                command.Parameters.AddWithValue("@categoryName", category_name);

                dataReader = command.ExecuteReader();

                // If the dataReader returns true, set the boolean categoryExists to true.
                // Indicating that the category name already exists in the database.
                if (dataReader.Read()) {
                    categoryExists = true;
                }
                dataReader.Close();
            });

            // If boolean categoryExists is true then return nothing.
            if (categoryExists) {
                MessageBox.Show("Category already exists!", "Failed Inserting Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                return;
            }

            // If boolean categoryExists is false then insert the category name into the database.
            executeQuery(() => {
                query = $"INSERT INTO tbl_itemcategory (category_name) VALUES (@categoryName)";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@categoryName", category_name);

                command.ExecuteNonQuery();

                // Reset the text fields of the item category tab.
                txtCategoryId.Text = fetchTableId("tbl_itemcategory").ToString();
                txtCategoryName.Text = "";
                fetchItemCategories();

                // Update the data grid view after the insertion.
                showTableData("Category");
            });
        }

        // Click event for the button add under supplier tab.
        private void btnAddSupplier_Click(object sender, EventArgs e) {
            // Variable for storing the values of the input fields under supplier tab.
            String supplier_name = txtSupplierName.Text.Trim(),
                   address = txtAddress.Text.Trim(),
                   contactNo = txtContactNo.Text.Trim();

            // Validation for checking whether the input fields are empty. If true, return nothing.
            if (string.IsNullOrWhiteSpace(supplier_name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(contactNo)) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Regular Expression Pattern to determine valid phone number length (7-15).
            string phoneNumberPattern = @"^\d{7,11}$";

            // Check if the entered phone number matches the RegEx pattern
            if (!Regex.IsMatch(txtContactNo.Text, phoneNumberPattern)) {
                // Display an error prompt indicating the invalid phone number format.
                MessageBox.Show("Please enter a valid numeric phone number with a length between 7 and 11 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation for checking if the category name inputted already exists in the database.
            bool supplierExists = false;
            executeQuery(() => {
                query = $"SELECT supplier_name FROM tbl_suppliers WHERE supplier_name = @supplierName";

                command = new MySqlCommand(query, connection);

                // Parameterized value to prevent SQL Injection.
                command.Parameters.AddWithValue("@supplierName", supplier_name);

                dataReader = command.ExecuteReader();

                // If dataReader returns true then it sets the boolean supplierExists to true
                // This indicates that the user already exists in the database.
                if (dataReader.Read()) {
                    supplierExists = true;
                }
                dataReader.Close();
            });

            // Check if the boolean supplierExists is true, if not then return nothing. 
            if(supplierExists) {
                MessageBox.Show("Supplier already exists!", "Failed Inserting Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Text = "";
                txtAddress.Text = "";
                txtContactNo.Text = "";
                return;
            }

            // If boolean supplierExists is true then continue to insert the information to the selected table.
            executeQuery(() => {
                query = $"INSERT INTO tbl_suppliers (supplier_name, address, contactNo) " +
                        $"VALUES (@supplierName, @address, @contactNo)";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@supplierName", supplier_name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contactNo", contactNo);

                command.ExecuteNonQuery();

                // Reset the text fields of the supplier tab.
                txtSupplierId.Text = fetchTableId("tbl_suppliers").ToString();
                txtSupplierName.Text = "";
                txtAddress.Text = "";
                txtContactNo.Text = "";

                // Update the data grid view after the insertion.
                showTableData("Supplier");
            });
        }

        // Click event for the button add under items tab.
        private void btnAddItem_Click(object sender, EventArgs e) {
            // Variables for storing the values of the input fields under item tab.
            String item_name = txtItemName.Text.Trim();
            int category_Id = cboCategoryName.SelectedIndex;
            double base_price = double.Parse(nudBasePrice.Value.ToString());

            // Validation for checking if the input fields under item tab is empty. If true, return nothing.
            if (string.IsNullOrWhiteSpace(item_name) || category_Id == -1 || base_price < 1) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetches category Id based on the category name inputted.
            // This is crucial in the insert query for table items since it only has a column named category_Id.
            executeQuery(() => {
                query = $"SELECT category_Id FROM tbl_itemcategory WHERE category_name = @categoryName";

                command = new MySqlCommand(query, connection);

                // Parameterized Value to prevent SQL Injection.
                command.Parameters.AddWithValue("@categoryName", cboCategoryName.Text.Trim());

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    category_Id = int.Parse(dataReader["category_Id"].ToString());
                }
            });

            // Validation for checking if the item name already exists in the database.
            bool itemExists = false;
            executeQuery(() => {
                query = $"SELECT item_name FROM tbl_items WHERE item_name = @itemName";

                command = new MySqlCommand(query, connection);

                // Parameterized Value to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemName", item_name);

                dataReader = command.ExecuteReader();

                // If dataReader is true then set the boolean itemExists to true.
                // This indicates that the item already exists in the database.
                if (dataReader.Read()) {
                    itemExists = true;
                }
                dataReader.Close();
            });

            // If boolean itemExists is true, show a message box and return nothing.
            if (itemExists) {
                MessageBox.Show("Item already exists!", "Failed Inserting Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Text = "";
                nudBasePrice.Value = 1;
                return;
            }

            // If boolean itemExists is false then continue the insertion.
            executeQuery(() => {
                query = $"INSERT INTO tbl_items (item_name, category_Id, base_price) " +
                        $"VALUES (@itemName, @categoryId, @basePrice)";

                command = new MySqlCommand(query, connection);

                // Parameterized Value to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemName", item_name);
                command.Parameters.AddWithValue("@categoryId", category_Id);
                command.Parameters.AddWithValue("@basePrice", base_price);

                command.ExecuteNonQuery();

                // Reset the text fields of the items tab.
                txtItemId.Text = fetchTableId("tbl_items").ToString();
                txtItemName.Text = "";
                nudBasePrice.Value = 1;

                // Update the data grid view after insertion.
                showTableData("Items");
            });
        }
        #endregion  


        #region (UPDATE) the information of the selected row in the data grid view into the database.
        // Click event for the button update under users tab.
        private void btnUpdateUsers_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if(!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select user to be updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Initialize the UpdateUser with the necessary information of the selected user.
            UpdateUser dialogUser = new UpdateUser
                    (this, 
                    int.Parse(selectedRow.Cells["User ID"].Value.ToString()), 
                    selectedRow.Cells["Username"].Value.ToString(), 
                    selectedRow.Cells["Password"].Value.ToString());

            // Show the UpdateUser Form as a dialog.
            dialogUser.ShowDialog();
        }

        // Click event for the button update under item category tab.
        private void btnUpdateItemCategory_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if (!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select category to be updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Initialize the UpdateCategory with the necessary information of the selected category.
            UpdateCategory dialogCategory = new UpdateCategory
                        (this, 
                        int.Parse(selectedRow.Cells["Category ID"].Value.ToString()),
                        selectedRow.Cells["Category Name"].Value.ToString());

            // Show the UpdateCategory form as a dialog.
            dialogCategory.ShowDialog();
        }

        // Click event for the button update under supplier tab.
        private void btnUpdateSupplier_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if (!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select supplier to be updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Initialize the UpdateSupplier with the necessary information of the selected supplier.
            UpdateSupplier dialogSupplier = new UpdateSupplier
                            (this,
                            int.Parse(selectedRow.Cells["Supplier ID"].Value.ToString()),
                            selectedRow.Cells["Supplier Name"].Value.ToString(),
                            selectedRow.Cells["Address"].Value.ToString(),
                            selectedRow.Cells["Contact Number"].Value.ToString());

            // Show the UpdateSupplier form as a dialog.
            dialogSupplier.ShowDialog();
        }

        // Click event for the button update under supplier tab.
        private void btnUpdateItem_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if (!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select supplier to be updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Initialize the UpdateItem with the necessary information of the selected item.
            UpdateItem dialogItem = new UpdateItem
                        (this,
                        int.Parse(selectedRow.Cells["Item ID"].Value.ToString()),
                        selectedRow.Cells["Item Category"].Value.ToString(),
                        selectedRow.Cells["Item Name"].Value.ToString(),
                        double.Parse(selectedRow.Cells["Base Price"].Value.ToString()));

            // Show the UpdateItem form as a dialog.
            dialogItem.ShowDialog();
        }
        #endregion


        #region (DELETE) selected row from the database.
        // Click event for the button delete under user tab.
        private void btnDeleteUser_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if (!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select user to be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Show a dialog asking the user for confirmation in deleting selected user.
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // If user clicks button ok proceed to delete selected user.
            if (confirmDelete == DialogResult.OK) {

                // Check if the id of the selected user is 1, if true show a prompt indicating that the admin user cannot be deleted and return.
                if (int.Parse(selectedRow.Cells["User ID"].Value.ToString()) == 1) {
                    MessageBox.Show("Cannot delete administrator account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Proceed to delete the selected user from the table.
                executeQuery(() => {
                    query = "DELETE FROM tbl_users WHERE user_Id = @user_Id";
                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@user_Id", int.Parse(selectedRow.Cells["User ID"].Value.ToString()));
                    command.ExecuteNonQuery();

                    showTableData("User");
                });
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e) {
            // Check if the user has selected a row. If not show a prompt and return nothing.
            if (!(dgvResults.CurrentRow != null && dgvResults.CurrentRow.Index >= 0)) {
                MessageBox.Show("Select supplier to be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize a data grid view row that contains the selected row.
            DataGridViewRow selectedRow = dgvResults.Rows[dgvResults.CurrentRow.Index];

            // Show a dialog asking the user for confirmation in deleting selected supplier.
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // If user clicks button ok proceed to delete selected user.
            if (confirmDelete == DialogResult.OK) {

                // Query to delete the selected supplier from the table.
                executeQuery(() => {
                    query = "DELETE FROM tbl_suppliers WHERE supplier_Id = @supplier_Id";
                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@supplier_Id", int.Parse(selectedRow.Cells["Supplier ID"].Value.ToString()));
                    command.ExecuteNonQuery();

                    showTableData("Supplier");
                });
            }
        }
        #endregion


        #region (EVENT LISTENERS)
        // Key Press event listener for the text field contact number element.
        // With the purpose of preventing letter inputs into the field, only numerics are allowed.
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        // Text Changed event listener for the text field contact number element.
        // With the purpose of preventing the user in inputting letters/words through the use of CTRL + V (Copy & Paste).
        private void txtContactNo_TextChanged(object sender, EventArgs e) {
            txtContactNo.Text = Regex.Replace(txtContactNo.Text, "[^0-9]", "");
        }

        // Change the font size of the data grid view upon maximizing or minimizing the window.
        private void Maintenance_SizeChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                dgvResults.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 14f, System.Drawing.FontStyle.Bold);
                dgvResults.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12f);
            } else {
                dgvResults.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10f, System.Drawing.FontStyle.Bold);
                dgvResults.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 8.25f);
            }
        }


        // After the maintenance window has loaded execute the command inside the block.
        private void Maintenance_Load(object sender, EventArgs e) {
            showTableData("User");
        }
        #endregion


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
        private void Maintenance_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}