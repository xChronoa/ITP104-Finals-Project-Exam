using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class UpdateCategory : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private static String dbName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {dbName};" +
                             "user = root;" +
                             "password = ;";
        private String query = "";
        private Maintenance maintenanceForm;
        private int categoryId;
        private String categoryName;

        // Establishes an association relationship between UpdateCategory and Maintenance
        public UpdateCategory(Maintenance maintenanceForm, int category_Id, String category_name) {
            InitializeComponent();

            // Set values of the selected variables.
            // The information stored is to be used for updating the selected category.
            this.maintenanceForm = maintenanceForm;
            this.categoryId = category_Id;
            this.categoryName = category_name;
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


        // Click event for the button update.
        private void btnUpdateItemCategory_Click(object sender, EventArgs e) {
            // Validation for the user inputs to not allow the user to input blanks.
            if (string.IsNullOrWhiteSpace(txtCategoryId.Text.Trim()) || string.IsNullOrWhiteSpace(txtCategoryName.Text.Trim())) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking if the category name inputted already exists in the database.
            bool categoryExists = false;
            executeQuery(() => {
                query = $"SELECT category_name FROM tbl_itemcategory WHERE category_name = @categoryName";
                
                command = new MySqlCommand(query, connection);

                // Parameterized value to prevent SQL injection.
                command.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());

                dataReader = command.ExecuteReader();

                // If dataReader returns true then it sets the boolean categoryExists to true
                // This indicates that the user already exists in the database.
                if (dataReader.Read()) {
                    categoryExists = true;
                }
                dataReader.Close();
            });

            // If boolean categoryExists is true then display a message box. Then return nothing.
            if (categoryExists) {
                MessageBox.Show("Category already exists!", "Failed to Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If categoryExists is false proceed to update the selected category.
            executeQuery(() => {
                query = $"UPDATE tbl_itemcategory " +
                        $"SET category_name = @newCategory " +
                        $"WHERE category_Id = @category_Id";

                command = new MySqlCommand(query, connection);

                // Parameterized variables to prevent SQL Injection.
                command.Parameters.AddWithValue("@newCategory", txtCategoryName.Text.Trim());
                command.Parameters.AddWithValue("@category_Id", txtCategoryId.Text.Trim());
                command.ExecuteNonQuery();

                // Store the data grid view of the Maintenance class named dgvResults into a local variable.
                DataGridView dgvResults = this.maintenanceForm.getdgvResults();

                // Get the current selected row before refreshing the table data.
                int selectedIndex = dgvResults.SelectedRows[0].Index;

                // Refresh the data grid view after the update query.
                this.maintenanceForm.showTableData("Category");

                // Set the selected row of the newly refreshed data grid view to the stored selected row.
                // This allows the program to indicate the row that was updated by the user.
                dgvResults.CurrentCell = dgvResults.Rows[selectedIndex].Cells[0];
                dgvResults.Rows[selectedIndex].Selected = true;
                dgvResults.FirstDisplayedScrollingRowIndex = selectedIndex;

                // Dipose the update category dialog.
                this.Dispose();
            });
        }

        // Upon loading the window execute the code inside the block.
        private void UpdateCategory_Load(object sender, EventArgs e) {
            txtCategoryId.Text = this.categoryId.ToString();
            txtCategoryName.Text = this.categoryName.ToString();
        }
    }
}