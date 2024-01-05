using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class PointOfSales : Form {
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
        private DataTable itemList;

        public PointOfSales() {
            InitializeComponent();

            // After components are initialized, set the value of the specified text fields.
            txtReceiptId.Text = fetchReceiptId().ToString();
            dtmReceiptDate.Text = DateTime.Now.ToString();
            fetchItemNames();

            // Set the numeric up and down fields max value to the max possible number.
            nudTotalAmount.Maximum = decimal.MaxValue;
            nudTotalPrice.Maximum = decimal.MaxValue;
            nudPayment.Maximum = decimal.MaxValue;
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


        #region Fetch Receipt ID and Item Names
        // Method for fetching the value of receipt_Id of the table sales.
        private int fetchReceiptId() {
            int receipt_Id = 0;

            executeQuery(() => {
                // Query to select the latest existing receipt_Id on the table sales.
                query = "SELECT receipt_Id FROM tbl_sales ORDER BY receipt_Id DESC LIMIT 1";

                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                // Check if the query returns any row using dataReader.
                // If true, set the value of receipt_Id incremented by 1.
                // If false, set the value of receipt_Id to 60001 as the starting entry value for the table sales.
                if (dataReader.Read()) {
                    receipt_Id = int.Parse(dataReader["receipt_Id"].ToString()) + 1;
                } else {
                    receipt_Id = 60001;
                }
                dataReader.Close();
            });

            return receipt_Id;
        }

        // Method for fetching the item from the table inventory.
        private void fetchItemNames() {
            executeQuery(() => {
                // Query that will fetch item name based on the item id present on table inventory by using inner join with table items.
                query = "SELECT b.item_name FROM tbl_inventory AS a " +
                        "INNER JOIN tbl_items AS b " +
                        "ON a.item_Id = b.item_Id";

                // Initialize MySQL Command and Data Adapter.
                command = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(command);

                // Initialize data table and set its data with fetched data from the query using data adapter.
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                // Check if fetched data contains a row, if true set the data source of combo box cboItemName to the data table.
                if (table.Rows.Count > 0) {
                    cboItemName.DataSource = new BindingSource(table, null);
                    cboItemName.DataSource = table;
                    cboItemName.DisplayMember = "item_name";
                }
            });
        }
        #endregion


        #region Click event listeners for the buttons btnAddToCart, btnRemoveItem, and btnPay.
        // Click event for the button add to cart.
        private void btnAddToCart_Click(object sender, EventArgs e) {
            // Variables to store the item information.
            int item_Id = 0;
            String item_name = cboItemName.Text.Trim();
            int quantity = int.Parse(nudQuantity.Value.ToString().Trim());
            double total_amount = double.Parse(nudTotalAmount.Value.ToString().Trim());

            // Validation to check if the user inputs are blank or invalid for the operation. If true return nothing. This is called a guard clause.
            if (string.IsNullOrWhiteSpace(item_name)) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudQuantity.Maximum == 0 && (quantity == 0 || total_amount == 0)) {
                MessageBox.Show("Out of stocks for selected item!", "Insufficient Stocks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Value = nudQuantity.Maximum > 0 ? 1 : 0;
                return;
            }

            if(quantity == 0 || total_amount == 0) {
                MessageBox.Show("Item quantity cannot be 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Value = 1;
                return;
            }

            int currentQuantity = 0;

            // Fetch the item id based on the item name.
            executeQuery(() => {
                query = $"SELECT item_Id FROM tbl_items WHERE item_name = @itemName";

                command = new MySqlCommand(query, connection);

                // Usage of parameters to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemName", item_name);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    item_Id = int.Parse(dataReader["item_Id"].ToString());
                }
            });

            // Query to take the current quantity of the selected item in the table inventory.
            executeQuery(() => {
                query = $"SELECT quantity FROM tbl_inventory WHERE item_Id = @item_Id";

                command = new MySqlCommand(query, connection);

                // Usage of parameters to prevent SQL Injection.
                command.Parameters.AddWithValue("@item_Id", item_Id);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    currentQuantity = int.Parse(dataReader["quantity"].ToString());
                }

                dataReader.Close();
            });

            // Check whether the item name already exists in the data grid view named dgvItemList.
            // This is also used to get the row index of the selected item id.
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvItemList.Rows) {
                if (row.Cells["Item Name"].Value.ToString() == item_name.ToString()) {
                    rowIndex = row.Index;
                }
            }

            // Check if the rowIndex is selecting a row.
            // If true then update the quantity of that row.
            // Else, then add a new row for the item entry.
            if (rowIndex != -1) {
                itemList.Rows[rowIndex]["Quantity"] = (int)itemList.Rows[rowIndex]["Quantity"]  + quantity;
                itemList.Rows[rowIndex]["Total Amount"] = (double)itemList.Rows[rowIndex]["Total Amount"] + total_amount;
            } else {
                itemList.Rows.Add(item_name, quantity, total_amount);
            }

            // Update the maximum quantity of the numeric up and down nudQuantity.
            UpdateMaxQuantity();

            // Reset the value of the numeric up and down nudQuantity to 1 after addition of item.
            nudQuantity.Value = (nudQuantity.Maximum > 0 ? 1 : 0);
           
            // Update the value of the numeric up and down nudTotalPrice.
            UpdateTotalPrice();
        }

        // Click event for the button remove item.
        private void btnRemoveItem_Click(object sender, EventArgs e) {
            // If, else-if, and else statements to validate the selected rows.

            // Check if there are multiple selected rows.
            if (dgvItemList.SelectedRows.Count > 0) {

                // foreach to iterate through the selected rows and remove them from data grid view.
                foreach (DataGridViewRow selectedRow in dgvItemList.SelectedRows) {
                    itemList.Rows.RemoveAt(selectedRow.Index);
                }

            // If no multiple rows are selected, check for a single selected row and remove that row.
            } else if (dgvItemList.CurrentRow != null && dgvItemList.CurrentRow.Selected) {
                itemList.Rows.RemoveAt(dgvItemList.CurrentRow.Index);

            // If there are no selected rows, show a prompt.
            } else {
                MessageBox.Show("Select the item to be removed from the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Update the numeric up and down nudQuantity and nudTotalPrice.
            UpdateMaxQuantity();
            UpdateTotalPrice();
        }

        // Click event for the button pay.
        private void btnPay_Click(object sender, EventArgs e) {
            // Check if the data grid view named item list does not contain a row, if true return nothing.
            if (dgvItemList.Rows.Count < 1) {
                MessageBox.Show("Must add items to the list to be bought!", "Invalid Delivery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the value of the change is not less than 0, if true return nothing.
            if (double.Parse(lblChangeAmount.Text) < 0) {
                MessageBox.Show("Insufficient Payment!", "Invalid Amount of Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Store the values of the text fields into the variables.
            int receiptId = int.Parse(txtReceiptId.Text);
            String receipt_date = dtmReceiptDate.Text.Trim();

            // The date to be used when inserting to the MySQL Table.
            String date = $"{dtmReceiptDate.Value.Year.ToString()}-{dtmReceiptDate.Value.Month.ToString()}-{dtmReceiptDate.Value.Day.ToString()}";

            // Format and append the output to the RichTextBox
            rtbReceipt.AppendText($"================================================================================\n" +
                                  $"\t\tORDER - RECEIPT #{receiptId} \t - \t DATE: {DateTime.Now.ToString("MMMM dd, yyyy")}\n\n" +
                                  "ORDER DETAILS: \n" +
                                  "Item Name".PadRight(40) + " Qty".PadLeft(20) + "Amount".PadLeft(20) +
                                  "\n----------------------------------------------------    -------      -----------\r\n");

            // Cycle through the rows of the data grid view named dgvItemList.
            // This ensures that the user can deliver multiple items on a single delivery.
            for (int i = 0; i < dgvItemList.Rows.Count; i++) {
                // Variable for storing the current row selected based on the index value of the for loop.
                DataGridViewRow row = dgvItemList.Rows[i];

                int item_Id = 0;

                // Store the current row's quantity and total amount to these specified variables.
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                double total_amount = double.Parse(row.Cells["Total Amount"].Value.ToString());

                // Fetch the item id based on the item name.
                executeQuery(() => {
                    query = $"SELECT item_Id FROM tbl_items WHERE item_name = @itemName";

                    command = new MySqlCommand(query, connection);

                    // Usage of parameters to prevent SQL Injection.
                    command.Parameters.AddWithValue("@itemName", row.Cells["Item Name"].Value.ToString());

                    dataReader = command.ExecuteReader();

                    if (dataReader.Read()) {
                        item_Id = int.Parse(dataReader["item_Id"].ToString());
                    }
                });

                // Variables used for determining the item's total price based on the quantity and its base price.
                int currentQuantity = 0;
                double base_price = 0;
                double item_TotalPrice = 0;

                // Query to take the current quantity of the selected item in the table inventory.
                executeQuery(() => {
                    query = $"SELECT quantity FROM tbl_inventory WHERE item_Id = @item_Id";

                    command = new MySqlCommand(query, connection);

                    // Usage of parameters to prevent SQL Injection.
                    command.Parameters.AddWithValue("@item_Id", item_Id);

                    dataReader = command.ExecuteReader();

                    if (dataReader.Read()) {
                        currentQuantity = int.Parse(dataReader["quantity"].ToString());
                    }

                    dataReader.Close();
                });

                // Query to take the base price of the selected item in the table items.
                executeQuery(() => {
                    query = $"SELECT base_price FROM tbl_items WHERE item_Id = @item_Id";

                    command = new MySqlCommand(query, connection);

                    // Usage of parameters to prevent SQL Injection.
                    command.Parameters.AddWithValue("@item_Id", item_Id);

                    dataReader = command.ExecuteReader();

                    if (dataReader.Read()) {
                        base_price = double.Parse(dataReader["base_price"].ToString());
                    }

                    dataReader.Close();
                });

                // Get the item's total price by multiplying item's quantity and it's base price.
                item_TotalPrice = quantity * base_price;

                // Update the quantity in the table inventory. (Deduct user inputted quantity to inventory item quantity.)
                // Query to update the quantity of the selected item.
                executeQuery(() => {
                    query = $"UPDATE tbl_inventory SET quantity = @newQuantity WHERE item_Id = @item_Id";

                    command = new MySqlCommand(query, connection);

                    // Usage of parameters to prevent SQL Injection.
                    command.Parameters.AddWithValue("@newQuantity", currentQuantity - quantity);
                    command.Parameters.AddWithValue("@item_Id", item_Id);

                    command.ExecuteNonQuery();
                });

                // Query to log the item order into the table sales.
                executeQuery(() => {
                    query = $"INSERT INTO tbl_sales " +
                            $"VALUES (@receiptId, @date, @item_Id, @quantity, @item_TotalPrice)";

                    command = new MySqlCommand(query, connection);

                    // Usage of parameters to prevent SQL Injection.
                    command.Parameters.AddWithValue("@receiptId", receiptId);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@item_Id", item_Id);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@item_TotalPrice", item_TotalPrice);

                    command.ExecuteNonQuery();
                });
                
                rtbReceipt.AppendText($"\n{row.Cells["Item Name"].Value.ToString().PadRight(40)}"+ $"{quantity.ToString().PadLeft(20)}" + $"{total_amount.ToString("N2").PadLeft(20)}");
            }
            rtbReceipt.AppendText("\n----------------------------------------------------                 -----------\r\n");
            rtbReceipt.AppendText($"\n{"Total Price:".PadRight(60)}{nudTotalPrice.Value.ToString("N2").PadLeft(20)}" +
                                  $"\n{"Payment:".PadRight(60)}{nudPayment.Value.ToString("N2").PadLeft(20)}" +
                                  $"\n{"Change:".PadRight(60)}{lblChangeAmount.Text.PadLeft(20)}" +
                                  $"================================================================================\n\n\n");

            // Reset the data grid view item list
            itemList.Rows.Clear();
            dgvItemList.DataSource = null;
            dgvItemList.DataSource = itemList;

            // Update the id visible on the text field txtReceiptId after the insertion.
            txtReceiptId.Text = fetchReceiptId().ToString();

            // Reset the values for the specified elements to the default.
            nudTotalPrice.Value = 0;
            nudPayment.Value = 0;
        }
        #endregion

        
        #region Event Listeners for the numeric up and down and data grid view elements.
        // CellFormating Event Handler for checking if it contains a numeric value that will display it into 2 decimal places.
        private void dgvItemList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                // Select the cell with numeric value.
                DataGridViewCell cell = dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell contains a numeric value
                if (cell.Value is decimal || cell.Value is double) {

                    // Format the numeric value to display up to 2 decimal places
                    e.Value = string.Format("{0:N2}", cell.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        // Event listeners used for updating the total amount value of the numeric up and down nudTotalAmount.
        private void nudQuantity_ValueChanged(object sender, EventArgs e) {
            getOrderTotalAmount();
        }

        private void cboItemName_SelectionChangeCommitted(object sender, EventArgs e) {
            getOrderTotalAmount();
            UpdateMaxQuantity();
        }

        // Event Listener for the numeric up and down nudPayment and nudTotalPrice that will execute the code in the block when their value is changed.
        private void nudPayment_ValueChanged(object sender, EventArgs e) {
            lblChangeAmount.Text = (nudPayment.Value - nudTotalPrice.Value).ToString("N2");
        }

        private void nudTotalPrice_ValueChanged(object sender, EventArgs e) {
            lblChangeAmount.Text = (nudPayment.Value - nudTotalPrice.Value).ToString("N2");
        }

        private void getOrderTotalAmount() {
            int item_Id = cboItemName.SelectedIndex;

            // Check if the user has selected an element from the combo box. If true, return.
            if (item_Id == -1) {
                return;
            }

            // Query to select the item id from table items based on the item name.
            executeQuery(() => {
                query = $"SELECT item_Id FROM tbl_items WHERE item_name = @itemName";

                command = new MySqlCommand(query, connection);

                // Usage of parameters to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemName", cboItemName.Text);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    item_Id = int.Parse(dataReader["item_Id"].ToString());
                }
            });

            // Stores the value of the numeric up and down nudQuantity.
            int quantity = int.Parse(nudQuantity.Value.ToString());

            // Initialize variable to be used in storing item's base price and it's total amount based on the quantity.
            double base_price = 1;
            double totalAmount = 1;

            // Query to take the base price of the selected item in the table items.
            executeQuery(() => {
                query = $"SELECT base_price FROM tbl_items WHERE item_Id = @item_Id";

                command = new MySqlCommand(query, connection);

                // Usage of parameters to prevent SQL Injection.
                command.Parameters.AddWithValue("@item_Id", item_Id);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    base_price = double.Parse(dataReader["base_price"].ToString());
                }

                dataReader.Close();
            });

            // Calculate the total amount of the quantity.
            totalAmount = quantity * base_price;

            // Set the value of the numeric up and down nudTotalAmount to the total amount.
            nudTotalAmount.Value = decimal.Parse(totalAmount.ToString());
        }
        #endregion


        // Upon loading the form execute the code inside the block.
        private void PointOfSales_Load(object sender, EventArgs e) {
            getOrderTotalAmount();

            // DataTable to be used as a data source for the data grid view named dgvItemList.
            itemList = new DataTable("ItemList");
            itemList.Columns.Add("Item Name", typeof(string));
            itemList.Columns.Add("Quantity", typeof(int));
            itemList.Columns.Add("Total Amount", typeof(double));

            // Set the data source of the data grid view named dgvItemList to the DataTable named itemList.
            dgvItemList.DataSource = itemList;
            
            // Set the values of the combo box cboItemName and the max quantity of the numeric up and down nudQuantity.
            fetchItemNames();
            UpdateMaxQuantity();

            // Disable sorting for all columns
            foreach (DataGridViewColumn column in dgvItemList.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        // Method for changing the maximum value for the numeric up and down elements based on the selected item's total quantity.
        private void UpdateMaxQuantity() {
            // Initialize variables to store fetched values of item id and quantity from table inventory.
            int item_Id = 0;
            int quantity = 0;
            String itemName = cboItemName.Text;

            // Fetch the item id based on the item name.
            executeQuery(() => {
                query = $"SELECT item_Id FROM tbl_items WHERE item_name = @itemName";

                command = new MySqlCommand(query, connection);

                // Usage of parameters to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemName", itemName);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    item_Id = int.Parse(dataReader["item_Id"].ToString());
                }
            });

            // Fetch the quantity of the selected item.
            executeQuery(() => {
                query = $"SELECT quantity FROM tbl_inventory WHERE item_Id = @itemId";

                command = new MySqlCommand(query, connection);

                // Usage of parameter to prevent SQL Injection.
                command.Parameters.AddWithValue("@itemId", item_Id);

                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    quantity = int.Parse(dataReader["quantity"].ToString());
                }
            });

            // Check if the data grid view dgvItemList contains a row.
            if (dgvItemList.RowCount > 0) {
                // Set the maximum value of the numeric up and down nudQuantity to the current quantity of the selected item.
                // This is to set the maximum value in the scenario that it does not pass the foreach's if statement.
                nudQuantity.Maximum = quantity;

                // foreach to iterate through the existing rows in the data grid view dgvItemList.
                foreach (DataGridViewRow row in dgvItemList.Rows) {

                    // Check if the dgvItemList contains the selected item, then set the maximum value of nudQuantity
                    // Based on current quantity of the item in the table inventory minus the quantity in the data grid view dgvItemList.
                    if (itemName == row.Cells["Item Name"].Value.ToString()) {
                        nudQuantity.Maximum = quantity - int.Parse(row.Cells["Quantity"].Value.ToString());
                    }
                }
                // If the dgvItemList does not contain a row proceed to set the maximum value of nudQuantity to the quantity of the selected item.
            } else {
                nudQuantity.Maximum = quantity;
            }

            // Ternary operator to accomodate the scenarios in which the maximum value of nudQuantity is less than 1.
            nudQuantity.Value = nudQuantity.Maximum > 0 ? 1 : 0;
        }

        // Method to update the value of numeric up down element named nudTotalPrice.
        private void UpdateTotalPrice() {
            double total_price = 0;

            // Cycle through the rows of the data grid view named dgvItemList.
            for (int i = 0; i < dgvItemList.Rows.Count; i++) {
                // Variable for storing the current row selected based on the index value of the for loop.
                DataGridViewRow row = dgvItemList.Rows[i];

                // Increment value of  total_price based on the current row's total amount.
                total_price += double.Parse(row.Cells["Total Amount"].Value.ToString());
            }

            // Set the value of numeric up and down nudTotalPrice to the total_price.
            nudTotalPrice.Value = (decimal)total_price;
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


        // Event listener for the checking if the form window size is changing.
        private void PointOfSales_SizeChanged(object sender, EventArgs e) {
            // If the window state is set to maximized then set the font size of the rich text box to 15.
            // If it was reverted back then set it to the default size which is 10.
            if (WindowState == FormWindowState.Maximized) {
                rtbReceipt.Font = new Font(rtbReceipt.Font.FontFamily, 15);
            } else {
                rtbReceipt.Font = new Font(rtbReceipt.Font.FontFamily, 10);
            }
        }

        // Terminates the whole program upon clicking the window close button.
        private void PointOfSales_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}