using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class UpdateUser : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private Maintenance maintenanceForm;
        private int userId;
        private String username, password;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private static String dbName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {dbName};" +
                             "user = root;" +
                             "password = ;";
        private String query = "";

        // Establishes an association relationship between UpdateUser and Maintenance
        public UpdateUser(Maintenance maintenanceForm, int userId, String username, String password) {
            InitializeComponent();

            // Set the values for these select variables.
            // The information stored shall be used for updating the selected user.
            this.maintenanceForm = maintenanceForm;
            this.userId = userId;
            this.username = username;
            this.password = password;
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


        // Execute the code inside the block after form loads.
        private void UpdateUser_Load(object sender, EventArgs e) {
            txtUserId.Text = this.userId.ToString();
            txtUsername.Text = this.username;
            txtPassword.Text = this.password;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(txtUserId.Text.Trim()) || string.IsNullOrWhiteSpace(txtUsername.Text.Trim()) || string.IsNullOrWhiteSpace(txtPassword.Text.Trim())) {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking if the username and password contains spaces, if true return nothing.
            if (txtUsername.Text.Trim().Contains(" ")) {
                MessageBox.Show("Username cannot contain spaces. \nPlease choose a username without spaces.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtPassword.Text.Trim().Contains(" ")) {
                MessageBox.Show("Password cannot contain spaces. \nPlease choose a password without spaces.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for checking if the username inputted already exists in the database.
            bool userExist = false;
            executeQuery(() => {
                query = $"SELECT username FROM tbl_users WHERE username = @Username";

                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                dataReader = command.ExecuteReader();

                // If dataReader returns true then it sets the boolean userExist to true
                // This indicates that the user already exists in the database.
                if (dataReader.Read()) {
                    userExist = true;
                }
                dataReader.Close();
            });

            DataGridView dgvResults = this.maintenanceForm.getdgvResults();

            // If the following condition is true, it will proceed to displaying an error message and return.
            if (userExist && !String.Equals(txtUsername.Text.Trim(), this.username, StringComparison.Ordinal)) {
                MessageBox.Show("Sorry, the username is already in use. \nPlease choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {
                // If the prior condition is false then it proceeds to update the user's details.
                executeQuery(() => {
                    query = $"UPDATE tbl_users " +
                            $"SET username = @newUsername, " +
                            $"    password = @newPassword " +
                            $"WHERE user_Id = @user_Id";

                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@newUsername", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@newPassword", txtPassword.Text.Trim());
                    command.Parameters.AddWithValue("@user_Id", txtUserId.Text.Trim());
                    command.ExecuteNonQuery();

                    // Get the current selected row before refreshing the table data.
                    int selectedIndex = dgvResults.SelectedRows[0].Index;

                    // Refresh the data grid view after the update query.
                    this.maintenanceForm.showTableData("User");

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