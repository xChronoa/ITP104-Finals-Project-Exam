using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }


        #region Button Login - Click Event
        private void btnLogin_Click(object sender, EventArgs e) {
            String username = txtUsername.Text.Trim(),
                   password = txtPassword.Text.Trim();

            // Input Validation to prevent user from entering blank fields.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Please fill out the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variable to store the details needed for MySQL Connection.
            String con = "Server = localhost; " +
                         "Database = finalsprojectandexam;" +
                         "user = root;" +
                         "password = ;";

            // Initialize the MySQL Connection.
            MySqlConnection connection = new MySqlConnection(con);

            // Query to check if the user exists in the database. Utilizing parameters to prevent SQL Injection.
            String query = $"SELECT username FROM tbl_users WHERE username = @Username";

            // Bind the query and connection to the MySQLCommand.
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);

            // Variable boolean userExists is used for determining whether the user already exists in the database.
            bool userExists = false;

            // Try...Catch...Finally statements for error handling.
            // This handles exceptions that will prevent the program from terminating abruptly.
            try {
                // Open Connection
                connection.Open();

                // DataReader to be used to read the fetched query.
                MySqlDataReader dataReader = command.ExecuteReader();

                // To check if the user exists or not in the database.
                if(dataReader.Read()) {

                    // Check user inputted username and compare it with username from the database to check for its capitalization.
                    // Validate username case sensitivitiy.
                    if (!String.Equals(username, dataReader["username"].ToString(), StringComparison.Ordinal)) {
                        MessageBox.Show("Invalid username or password. \nPlease check your capitalization.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        return;
                    }

                    // Close the dataReader after successfully determining user existance.
                    // This is to prepare for the checking of user's password.
                    dataReader.Close();

                    // Query for checking the user's password in the database.
                    query = $"SELECT password FROM tbl_users WHERE password = @Password AND username = @Username";

                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    dataReader = command.ExecuteReader();

                    // If-else statements for checking if the user's inputted password exists in the database.
                    if(dataReader.Read()) {
                        // Check user inputted password and compare it with password from the database to check for its capitalization.
                        // Validate password case sensitivitiy.
                        if (!String.Equals(password, dataReader["password"].ToString(), StringComparison.Ordinal)) {
                            MessageBox.Show("Invalid username or password. \nPlease check your capitalization.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            return;
                        }

                        userExists = true;
                    } else {
                        MessageBox.Show("Incorrect Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        return;
                    }
                } else {
                    MessageBox.Show("Couldn't find your account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    return;
                }
                dataReader.Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } finally {
                // Finally block to always check if the connection state is open, if true then proceed to close it.
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }

            // Usage of if statement to ensure that the user would not be redirected to the dashboard unless the user's information exists.
            // If true, then redirect the user to the dashboard window.
            if(userExists) {
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
        }
        #endregion


        // Terminates the whole program upon clicking the window close button.
        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}