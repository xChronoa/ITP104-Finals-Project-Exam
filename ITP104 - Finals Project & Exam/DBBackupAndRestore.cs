using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP104___Finals_Project___Exam {
    public partial class DBBackupAndRestore : Form {
        // Pre-declared privated global variables to be used only in this form.
        // The usage of this global variable ensures that it will not be re-declared throughout the form, minimizing code length.
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlBackup backup;
        private static String databaseName = "finalsprojectandexam";
        private String con = "Server = localhost; " +
                             $"Database = {databaseName};" +
                             "user = root;" +
                             "password = ;";

        public DBBackupAndRestore() {
            InitializeComponent();
        }

        // Method for backup and restore functionality for the database.
        public void BackupRestore(String path, String toDo) {
            // Initialize the MySQL Connection, Command, and Backup.
            connection = new MySqlConnection(con);
            command = new MySqlCommand();
            backup = new MySqlBackup(command);

            // Try...Catch...Finally statements for error handling.
            // This handles exceptions that will prevent the program from terminating abruptly.
            try {
                // Set the MySQL Command's connection.
                command.Connection = connection;

                // Open a connection.
                connection.Open();

                // Check for the operation called by the user.
                // Proceed with if-block for backuping the database.
                // Proceed with else-block for restoring the database using a selected backup file.
                if (toDo.Equals("Backup")) {
                    backup.ExportToFile(path);
                } else {
                    backup.ImportFromFile(path);
                }

                // Show the successful operation to the user.
                MessageBox.Show("Database " + toDo + " successfully\n" + path);
            } catch (Exception e) {
                // Catch exception block for showing the user the error that has occured.
                MessageBox.Show(e.Message);
            } finally {
                // Finally block to always check if the connection state is open, if true then proceed to close it.
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        // Click Event Listener for the Button Backup
        private void btnBackupDB_Click(object sender, EventArgs e) {
            // String variables to store the file directory and path name.
            String fileDirectory, filePathName;

            // Folder Browser Dialog to browse for folder in which to put the database backup file.
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            // If user has determined a folder path. proceed with the if block. If not proceed with else.
            if (fbDialog.ShowDialog() == DialogResult.OK) {
                fileDirectory = fbDialog.SelectedPath;

                // Set the file name to "Database (databaseName) Backup Year-Month-Day Hour-Minute-Second"
                // This ensures a real-time and up to date naming convention for the database backup.
                filePathName =  System.IO.Path.Combine(fileDirectory, 
                                $"Database ({databaseName}) Backup " +
                                $"{DateTime.Now.Year.ToString()}-" +
                                $"{DateTime.Now.Month.ToString()}-" +
                                $"{DateTime.Now.Day.ToString()} " +
                                $"{DateTime.Now.Hour.ToString()}-" +
                                $"{DateTime.Now.Minute.ToString()}-" +
                                $"{DateTime.Now.Second.ToString()}" + ".bak");

                // Execute the BackupRestore method with the arguments filePathName and the operation to be done.
                BackupRestore(filePathName, "Backup");
            } else {
                // If the user cancelled the browsing of file then set the fileDirectory to empty.
                fileDirectory = String.Empty;
            }
        }

        // Click Event Listener for the Button Restore
        private void btnRestoreDB_Click(object sender, EventArgs e) {
            // Variable to store the file path of the selected backup file.
            String filePathName;

            // Open File Dialog to browse for the database backup files.
            OpenFileDialog ofDialog = new OpenFileDialog();

            // The open file dialog is filtered to only look for files with .bak extension.
            ofDialog.Filter = "All Files (*.bak)|*.bak";
            ofDialog.FilterIndex = 1;

            // Prevent the user from selecting multiple files, this is to ensure that the selected backup file is the only one to be restored.
            ofDialog.Multiselect = false;

            // Set the title of the open file dialog.
            ofDialog.Title = "Restore Database Backup";

            // If has determined the file to use on restoring the database and clicked ok, proceed with if block.
            if (ofDialog.ShowDialog() == DialogResult.OK) {
                // Store the file path of the selected backup file.
                filePathName = ofDialog.FileName;

                // Execute the BackupRestore method with the arguments filePathName and the operation to be done.
                BackupRestore(filePathName, "Restore");
            } else {
                // If the user cancelled the browsing of file then set the fileDirectory to empty.
                filePathName = String.Empty;
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
        private void DBBackupAndRestore_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}