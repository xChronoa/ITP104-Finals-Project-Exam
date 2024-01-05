using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class Delivery : Form {
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

        public Delivery() {
            InitializeComponent();

            // Fetch and set the value of the text field txtDeliveryId to the latest id of table delivery.
            txtDeliveryId.Text = fetchDeliveryId().ToString();
        }


        #region Delegate and its respective method
        /// <summary>
        /// The delegate in this program is used for recycling the try...catch...finally line of codes.
        /// So, that the overall length of the code would not be unnecessarily long.
        /// This is done to recycle the specified codes so that it will not be re-iterated over and over again throughout the code sheet.
        /// </summary>

        private delegate void QueryDelegate();
        private void executeQuery(QueryDelegate queryToExecute) {
            connection = new MySqlConnection(con);

            try {
                connection.Open();
                queryToExecute();
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }
        #endregion


        // Method for showing all the data in table delivery to the data grid view.
        public void showTableDelivery() {
            executeQuery(() => {
                // Columns shown are "Delivery ID", "Delivery Date", "Category", "Item Name", and "Quantity", respectively.
                query = $"SELECT a.delivery_Id AS 'Delivery ID', a.delivery_date AS 'Delivery Date', c.category_name AS 'Category', b.item_name AS 'Item Name', a.quantity AS 'Quantity'" +
                        $"FROM tbl_delivery AS a " +
                        $"INNER JOIN tbl_items AS b ON a.item_id = b.item_id " +
                        $"INNER JOIN tbl_itemcategory AS c ON c.category_Id = b.category_Id " +
                        $"ORDER BY delivery_Id DESC, item_name ASC"; 

                command = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(command);

                // Initialize data set and fill it with the fetched data from the query.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Set the data source of the data grid view dgvResults to the data set.
                dgvResults.DataSource = dataSet.Tables[0].DefaultView;
            });
        }

        // Method for fetching the latest id of the table delivery incremented by 1 to display the id that will be bound to the new entry.
        private int fetchDeliveryId() {
            int delivery_Id = 0;

            executeQuery(() => {
                // Query to select the latest existing delivery id in the table delivery.
                query = "SELECT delivery_Id FROM tbl_delivery ORDER BY delivery_Id DESC LIMIT 1";

                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                // Checks if the dataReader can fetch any row or data from the query
                // If true, set the value of delivery_Id to the fetched value incremented by 1.
                // If false, set the value of delivery_Id as 40001 as the starting value for the first entry in table delivery.
                if (dataReader.Read()) {
                    delivery_Id = int.Parse(dataReader["delivery_Id"].ToString()) + 1;
                } else {
                    delivery_Id = 40001;
                }

                dataReader.Close();
            });

            return delivery_Id;
        }

        // Method for fetching all the existing item id available in the table items.
        // The fetched item ids are then inserted into the combo box Item Id as elements.
        public void fetchItemName() {
            executeQuery(() => {
                query = "SELECT item_name FROM tbl_items";
                command = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(command);
                
                // Initialize data table then fill it with data from the query.
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                // Check if the query contains a row, if true, set the combo box cboItemName's data source to the data table.
                if (table.Rows.Count > 0) {
                    cboItemName.DataSource = new BindingSource(table, null);

                    cboItemName.DataSource = table;
                    cboItemName.DisplayMember = "item_name";
                    cboItemName.SelectedIndex = 0;
                }
            });
        }

        // Upon loading the window delivery execute the code inside the block.
        private void Delivery_Load(object sender, EventArgs e) {
            // Display the current date, item names, and table delivery's data into their respective areas
            dtmDeliveryDate.Text = DateTime.Now.ToString();
            fetchItemName();
            showTableDelivery();

            // DataTable to be used as a data source for the data grid view named dgvItemList.
            itemList = new DataTable("ItemList");
            itemList.Columns.Add("Item Name", typeof(string));
            itemList.Columns.Add("Quantity", typeof(int));

            // Set the data source of the data grid view named dgvItemList to the DataTable named itemList.
            dgvItemList.DataSource = itemList;

            // Disable sorting for all columns in data grid view results
            foreach (DataGridViewColumn column in dgvResults.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Disable sorting for all columns in data grid view item list
            foreach (DataGridViewColumn column in dgvItemList.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // Click event listener for the button add item to list
        // With the purpose of adding the item name and quantity of that item into the data grid view named dgvItemList.
        private void btnAddItemToList_Click(object sender, EventArgs e) {
            // Variables to store the item information.
            String item_name = cboItemName.Text.Trim();
            int quantity = int.Parse(nudQuantity.Value.ToString().Trim());

            // Validation to check if the user inputs are blank. If true return nothing. This is called a guard clause.
            if (string.IsNullOrWhiteSpace(item_name) || quantity == 0) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check whether the item name already exists in the data grid view named dgvItemList.
            // This is also used to get the row index of the selected item name.
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvItemList.Rows) {
                if (row.Cells["Item Name"].Value.ToString() == item_name) {
                    rowIndex = row.Index;
                }
            }

            // Check if the rowIndex is selecting a row.
            // If true then update the quantity of that row.
            // Else, then add a new row for the item entry.
            if (rowIndex != -1) {
                itemList.Rows[rowIndex]["Quantity"] = (int)itemList.Rows[rowIndex]["Quantity"] + quantity;
            } else {
                itemList.Rows.Add(item_name, quantity);
            }

            // Reset the text field nud quantity to 1 after addition of item.
            nudQuantity.Value = 1;
        }

        // Click event listener for the button remove item
        // With the purpose of allowing the user to remove the selected row in the data grid view named dgvItemList.
        private void btnRemoveItem_Click(object sender, EventArgs e) {
            // If, else-if, and else statements to validate the selected rows.
            
            // Check if there are multiple selected rows.
            if (dgvItemList.SelectedRows.Count > 0) {

                // Foreach to iterate through the selected rows and remove them from data grid view.
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
        }

        // Click Event Listener for the Button Deliver.
        // With the purpose of logging the delivery details into the table delivery, as well as insert item to / update the table inventory.
        private void btnDeliverItem_Click(object sender, EventArgs e) {
            // Variable to store the delivery id to be used in the insert of values to the table delivery.
            int delivery_Id = int.Parse(txtDeliveryId.Text.ToString());

            // Check if the data grid view named item list does not contain a row, if true return nothing.
            if(dgvItemList.Rows.Count < 1) {
                MessageBox.Show("Must add items to the list to be delivered!", "Invalid Delivery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Date Format to be used in the MySQL Table.
            String date = $"{dtmDeliveryDate.Value.Year.ToString()}-{dtmDeliveryDate.Value.Month.ToString()}-{dtmDeliveryDate.Value.Day.ToString()}";

            // Cycle through the rows of the data grid view named dgvItemList.
            // This ensures that the user can deliver multiple items on a single delivery.
            for(int i = 0; i < dgvItemList.Rows.Count; i++) {
                // Variable for storing the current row selected based on the index value of the for loop.
                DataGridViewRow row = dgvItemList.Rows[i];

                // Variable that stores the value of the specific column in the selected row based on the index value of the for loop.

                int item_Id = 0;
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());

                // Fetch the item id based on the item name.
                executeQuery(() => {
                    query = $"SELECT item_Id FROM tbl_items WHERE item_name = @itemName";

                    command = new MySqlCommand(query, connection);

                    // Parameterized value to prevent SQL injection.
                    command.Parameters.AddWithValue("@itemName", row.Cells["Item Name"].Value.ToString());

                    dataReader = command.ExecuteReader();

                    if (dataReader.Read()) {
                        item_Id = int.Parse(dataReader["item_Id"].ToString());
                    }
                    dataReader.Close();
                });

                // Log the delivery entry into the table delivery.
                executeQuery(() => {
                    query = $"INSERT INTO tbl_delivery " +
                            $"VALUES (@deliveryId, @date, @itemId, @quantity)";

                    command = new MySqlCommand(query, connection);

                    // Parameterized values to prevent SQL Injection.
                    command.Parameters.AddWithValue("@deliveryId", delivery_Id);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@itemId", item_Id);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();
                });

                // Check if the item exists in the table inventory.
                bool itemExist = false;
                executeQuery(() => {
                    query = $"SELECT item_Id FROM tbl_inventory WHERE item_Id = @itemId";

                    command = new MySqlCommand(query, connection);

                    // Parameterized value to prevent SQL injection.
                    command.Parameters.AddWithValue("@itemId", item_Id);

                    dataReader = command.ExecuteReader();

                    if (dataReader.Read()) {
                        itemExist = true;
                    }
                    dataReader.Close();
                });

                // If the item exists in the table inventory then just update the current quantity of the existing one.
                // Else, it will create a new row for the entry.
                if (itemExist) {
                    int currentQuantity = 0;

                    // Fetch the current quantity of the existing item in the table inventory.
                    executeQuery(() => {
                        query = $"SELECT quantity FROM tbl_inventory WHERE item_Id = @itemId";

                        command = new MySqlCommand(query, connection);

                        // Parameterized value to prevent SQL injection.
                        command.Parameters.AddWithValue("@itemId", item_Id);

                        dataReader = command.ExecuteReader();

                        if (dataReader.Read()) {
                            currentQuantity = int.Parse(dataReader["quantity"].ToString());
                        }

                        dataReader.Close();
                    });

                    // Update the quantity of the item in the table inventory.
                    // The current quantity will be incremented by the amount of quantity inputted by the user in the delivery form.
                    executeQuery(() => {
                        query = $"UPDATE tbl_inventory SET quantity = @newQuantity WHERE item_Id = @item_Id";

                        command = new MySqlCommand(query, connection);

                        command.Parameters.AddWithValue("@newQuantity", currentQuantity + quantity);
                        command.Parameters.AddWithValue("@item_Id", item_Id);

                        command.ExecuteNonQuery();
                    });
                } else {
                    // Create a new row for the item entry based on the item delivered.
                    executeQuery(() => {
                        query = $"INSERT INTO tbl_inventory (item_Id, quantity) VALUES (@itemId, @quantity)";

                        command = new MySqlCommand(query, connection);

                        // Parameterized value to prevent SQL injection.
                        command.Parameters.AddWithValue("@itemId", item_Id);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        command.ExecuteNonQuery();
                    });
                }

            };

            // Reset the data grid view item list
            itemList.Rows.Clear(); 
            dgvItemList.DataSource = null; 
            dgvItemList.DataSource = itemList;

            // Refresh the displayed delivery id and data grid view dgvResults to show the updated datas.
            txtDeliveryId.Text = fetchDeliveryId().ToString();
            showTableDelivery();
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
        private void Delivery_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}