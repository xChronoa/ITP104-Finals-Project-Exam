using MySqlConnector;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class UpdateSupplier : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private Maintenance maintenanceForm;
        private int supplierId;
        private String supplierName, address, contactNo;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private static String dbName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {dbName};" +
                             "user = root;" +
                             "password = ;";
        private String query = "";

        // Establishes an association relationship between UpdateSupplier and Maintenance
        public UpdateSupplier(Maintenance maintenanceForm, int supplierId, String supplierName, String address, String contactNo) {
            InitializeComponent();

            txtContactNo.MaxLength = 11;

            // Set the values for these select variables.
            // The information stored shall be used for updating the selected supplier.
            this.maintenanceForm = maintenanceForm;
            this.supplierId = supplierId;
            this.supplierName = supplierName;
            this.address = address;
            this.contactNo = contactNo;
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


        // Upon loading the window form execute the code inside the block.
        // The purpose of the code inside the block is to set the input field's values to the values transferred from maintenance form.
        private void UpdateSupplier_Load(object sender, EventArgs e) {
            txtSupplierId.Text = this.supplierId.ToString();
            txtSupplierName.Text = this.supplierName;
            txtAddress.Text = this.address;
            txtContactNo.Text = this.contactNo;
        }

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

        // Click event for the button update.
        private void btnUpdateSupplier_Click(object sender, EventArgs e) {
            // Validation for checking if the user's inputs is blank or not. If true, display a prompt and return nothing.
            if (string.IsNullOrWhiteSpace(txtSupplierId.Text.Trim()) || 
                string.IsNullOrWhiteSpace(txtSupplierName.Text.Trim()) || 
                string.IsNullOrWhiteSpace(txtAddress.Text.Trim()) ||      
                string.IsNullOrWhiteSpace(txtContactNo.Text.Trim())) {
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
                query = $"SELECT supplier_name FROM tbl_suppliers WHERE supplier_name = @SupplierName";

                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text.Trim());

                dataReader = command.ExecuteReader();

                // If dataReader returns true then it sets the boolean supplierExists to true
                // This indicates that the user already exists in the database.
                if (dataReader.Read()) {
                    supplierExists = true;
                }
                dataReader.Close();
            });

            // Declare a variable dgvResult and initialize it with the dgvResults from the maintenance form.
            DataGridView dgvResults = this.maintenanceForm.getdgvResults();

            // If the following condition is true, it will proceed to displaying an error message and return.
            if (supplierExists && !String.Equals(txtSupplierName.Text.Trim(), this.supplierName, StringComparison.Ordinal)) {
                MessageBox.Show("Sorry, the name is already in use. \nPlease choose a different name.", "Supplier Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {
                // If the prior condition is false then it proceeds to update the supplier details.
                executeQuery(() => {
                    query = $"UPDATE tbl_suppliers " +
                            $"SET supplier_name = @newSupplierName," +
                            $"    address = @newAddress," +
                            $"    contactNo = @newContactNumber " +
                            $"WHERE supplier_Id = @supplier_Id";

                    command = new MySqlCommand(query, connection);

                    // Parameterized Variables to prevent SQL Injection.
                    command.Parameters.AddWithValue("@supplier_Id", txtSupplierId.Text.Trim());
                    command.Parameters.AddWithValue("@newSupplierName", txtSupplierName.Text.Trim());
                    command.Parameters.AddWithValue("@newAddress", txtAddress.Text.Trim());
                    command.Parameters.AddWithValue("@newContactNumber", txtContactNo.Text.Trim());
                    command.ExecuteNonQuery();

                    // Get the current selected row before refreshing the table data.
                    int selectedIndex = dgvResults.SelectedRows[0].Index;

                    // Refresh the data grid view after the update query.
                    this.maintenanceForm.showTableData("Supplier");

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