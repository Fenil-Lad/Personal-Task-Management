using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Personal_Task_Management
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
            this.FormClosing += AdminForm_FormClosing;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = ShowConfirmBox("Are you sure you want to logout?");

            if (!result)
            {
                e.Cancel = true;
            }
            else
            {
                this.Hide();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ReadUserLogActivities();
        }

        private void ConfirmChangeBtn_Click(object sender, EventArgs e)
        {
            if(NewPasswordBox.Text == "")
            {
                MessageBox.Show("Please type the pin.");
            }
            else if(NewPasswordBox.Text.Length > 4 || NewPasswordBox.Text.Length < 4)
            {
                MessageBox.Show("The pin should be only of 4 digits.");
            }
            else
            {
                string filePath = "..\\..\\Credentials\\credentials.txt";
                string[] lines = File.ReadAllLines(filePath);
                string newPassword = NewPasswordBox.Text;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] credentials = lines[i].Split('\t');
                    string password = credentials[1];
                    lines[i] = lines[i].Replace(password, newPassword);
                    try
                    {
                         File.WriteAllLines(filePath, lines);
                         NewPasswordBox.Text = "";
                         LoginForm.UpdateLoginAttemptsToFile(0);
                         MessageBox.Show("Pin has been updated for the User: prg455.");
                    }
                    catch
                    {
                         Console.WriteLine("Internal Application Error");
                    }
                }
            }
        }
        private void ReadUserLogActivities()
        {
            string filePath = "..\\..\\Credentials\\logs.txt";
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    LogInBox.Items.Add(line);
                    LogInBox.Items.Add('\n');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading log activities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ShowConfirmBox("Are you sure you want to clear all the logs"))
            {
                string filePath = "..\\..\\Credentials\\logs.txt";
                try
                {
                    File.WriteAllText(filePath, string.Empty);
                    LogInBox.Items.Clear();
                    MessageBox.Show("Log file cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while clearing the log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static bool ShowConfirmBox(string confirmationText)
        {
            DialogResult result = MessageBox.Show(confirmationText, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void clearTasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ShowConfirmBox("Are you sure you want to clear all the tasks"))
            {
                MessageBox.Show("All Tasks cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {
            string currentText = NewPasswordBox.Text;

            if (currentText.Length > 0 && !char.IsDigit(currentText[currentText.Length - 1]))
            {
                NewPasswordBox.Text = currentText.Substring(0, currentText.Length - 1);
                NewPasswordBox.SelectionStart = NewPasswordBox.Text.Length;
                MessageBox.Show("Type only numbers. It's a pin.");
            }
        }
    }
}
