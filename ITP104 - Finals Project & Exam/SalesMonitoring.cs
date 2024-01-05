using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class SalesMonitoring : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private MySqlDataAdapter dataAdapter;
        private String con = "Server = localhost; " +
                             "Database = finalsprojectandexam;" +
                             "user = root;" +
                             "password = ;";
        private String query = "";

        public SalesMonitoring() {
            InitializeComponent();
        }

        // Method for showing all the data in table sales to the data grid view.
        public void showTableSales() {
            executeQuery(() => {
                // Query to show the contents of table sales in a user friendly format ordered by the receipt date ascendingly.
                query = "SELECT a.receipt_Id AS 'Receipt ID', a.receipt_date AS 'Receipt Date', c.category_name AS 'Item Category',  b.item_name AS 'Item', a.quantity AS 'Quantity', FORMAT(a.total_amount, 2) AS 'Total Price' " +
                        "FROM tbl_sales AS a " +
                        "INNER JOIN tbl_items AS b " +
                        "ON a.item_Id = b.item_Id " +
                        "INNER JOIN tbl_itemcategory AS c " +
                        "ON c.category_Id = b.category_Id " +
                        "ORDER BY receipt_Id DESC, receipt_date DESC";

                command = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(command);

                // Initialize data set and fill it with the fetched data from the query.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Set the data source of dgvResults to the data set.
                dgvResults.DataSource = dataSet.Tables[0].DefaultView;
            });
        }


        #region Delegates and its respective Method
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


        // Method for fetching the first and latest date entry of the table sales.
        public void fetchDates() {
            // Variable for storing the date of the first and latest entry in table sales.
            String dateFrom = "", dateTo = "";

            // Query to select the date of the first entry in table sales.
            executeQuery(() => {
                query = "SELECT receipt_date FROM tbl_sales ORDER BY receipt_date ASC LIMIT 1";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                if(dataReader.Read()) {
                    dateFrom = dataReader["receipt_date"].ToString();
                }
            });

            // Query to select the date of the latest entry in table sales.
            executeQuery(() => {
                query = "SELECT receipt_date FROM tbl_sales ORDER BY receipt_date DESC LIMIT 1";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    dateTo = dataReader["receipt_date"].ToString();
                }
            });

            // Check if the variables dateFrom and dateTo are not empty.
            if(!(dateFrom == "" || dateTo == "")) {
                // Change the format of the fetched date into a more readable and user friendly format.
                DateTime formattedFrom = DateTime.Parse(dateFrom);
                dateFrom = formattedFrom.ToString("MMMM dd, yyyy");

                DateTime formattedTo = DateTime.Parse(dateTo);
                dateTo = formattedTo.ToString("MMMM dd, yyyy");

                // Set the value of the date time picker to the formatted date.
                dtmFrom.Text = dateFrom;
                dtmTo.Text = dateTo;
            }
        }

        // Click event for the button filter.
        private void btnFilter_Click(object sender, EventArgs e) {
            executeQuery(() => {
                // Get the value of both the date time picker for the filter.
                DateTime fromDate = dtmFrom.Value;
                DateTime toDate = dtmTo.Value;

                // Initialize MySQL Command and Data Adapter.
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter(command);

                command.Connection = connection;

                // Show the rows that are in between the fromDate and toDate by receipt_Date ascending order.
                command.CommandText = "SELECT a.receipt_Id AS 'Receipt ID', a.receipt_date AS 'Receipt Date', c.category_name AS 'Item Category',  b.item_name AS 'Item', a.quantity AS 'Quantity', FORMAT(a.total_amount, 2) AS 'Total Price' " +
                                      "FROM tbl_sales AS a " +
                                      "INNER JOIN tbl_items AS b " +
                                      "ON a.item_Id = b.item_Id " +
                                      "INNER JOIN tbl_itemcategory AS c " +
                                      "ON c.category_Id = b.category_Id " +
                                      "WHERE receipt_date BETWEEN @fromDate AND @toDate " +
                                      "ORDER BY receipt_Id DESC, receipt_date DESC";

                // Clear the parameters for each iteration.
                command.Parameters.Clear();

                // Use parameterized query to avoid SQL injection
                command.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@toDate", toDate.ToString("yyyy-MM-dd"));

                // Initialize data set and fill with the fetched data from the query.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Set the data source of dgvResults to the data set.
                dgvResults.DataSource = dataSet.Tables[0];
            });
        }

        // Upon window load execute the code in the block.
        private void SalesMonitoring_Load(object sender, EventArgs e) {
            // Show the first and latest date entry in table sales in the two available date time pickers.
            fetchDates();

            // Show the table sales by receipt date ascending order.
            showTableSales();

            // Disable sorting for all columns
            foreach (DataGridViewColumn column in dgvResults.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // Click event for the button reset.
        private void btnReset_Click(object sender, EventArgs e) {
            // Reset the from and to values to the first and latest date entry in table sales.
            fetchDates();

            // Show the table sales by receipt date ascending order.
            showTableSales();
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
        private void SalesMonitoring_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}