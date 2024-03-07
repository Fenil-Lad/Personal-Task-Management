﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.LinkLabel;
using System.Runtime.CompilerServices;

namespace Personal_Task_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void ShowMainForm()
        {
           this.Show();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserBox.Text == "" && PasswordBox.Text == "")
            {
                MessageBox.Show("Please fill the login information.");
            }
            else if (UserBox.Text == "")
            {
                MessageBox.Show("Please fill the username.");
            }
            else if(PasswordBox.Text == "")
            {
                MessageBox.Show("Please fill the pin.");
            }
            else
            {
                ValidateUser();
            }
        }

        private int ReadLoginAttemptsFromFile()
        {
            string filePath = "..\\..\\Credentials\\attempt.txt";
            try
            {
                string fileContent = File.ReadAllText(filePath);

                if (int.TryParse(fileContent, out int loginAttempts))
                {
                    return loginAttempts;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("Internal Application Error.");
                return -1;
            }
        }

        public static void UpdateLoginAttemptsToFile(int newLoginAttempts)
        {
            string filePath = "..\\..\\Credentials\\attempt.txt";
            try
            {
                File.WriteAllText(filePath, newLoginAttempts.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating file: {ex.Message}");
            }
        }
        private string ReadAdminLoginFromFile(string para)
        {
            string filePath = "..\\..\\Credentials\\admin.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] credentials = line.Split('\t');
                        if (credentials.Length >= 2)
                        {
                            string username = credentials[0].Trim();
                            string password = credentials[1].Trim();

                            if (para == "username")
                            {
                                return username;
                            }
                            else if (para == "password")
                            {
                                return password;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
            return "";
        }

        private void ValidateUser()
        {
            string filePath = "..\\..\\Credentials\\credentials.txt";
            int maxLoginAttempts = 3;

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Internal Application Error.");
                    return;
                }

                int loginAttempts = ReadLoginAttemptsFromFile();

                if (loginAttempts > maxLoginAttempts)
                {
                    if (UserBox.Text == ReadAdminLoginFromFile("username") && PasswordBox.Text == ReadAdminLoginFromFile("password"))
                    {
                        UserBox.Text = "";
                        PasswordBox.Text = "";
                        this.Hide();
                        AdminForm form2 = new AdminForm();
                        form2.ShowDialog();
                        this.Show();
                        return;
                    }
                    else
                    {
                        UserBox.Text = "";
                        PasswordBox.Text = "";
                        MessageBox.Show("User account is locked.");
                        return;
                    }
                }
                else
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] credentials = line.Split('\t');
                        string username = credentials[0];
                        string password = credentials[1];
                        if (UserBox.Text == ReadAdminLoginFromFile("username"))
                        {
                            if (UserBox.Text == ReadAdminLoginFromFile("username") && PasswordBox.Text == ReadAdminLoginFromFile("password"))
                            {
                                UserBox.Text = "";
                                PasswordBox.Text = "";

                                this.Hide();
                                AdminForm form2 = new AdminForm();
                                form2.ShowDialog();
                                this.Show();

                                return;
                            }
                            else
                            {
                                UserBox.Text = "";
                                PasswordBox.Text = "";

                                MessageBox.Show("Incorrect username or pin");
                                return;
                            }
                        }
                        else
                        {
                            if (UserBox.Text == username && PasswordBox.Text == password)
                            {
                                UserBox.Text = "";
                                PasswordBox.Text = "";

                                this.Hide();
                                Program.SaveLoginTime();
                                UserForm form3 = new UserForm();
                                form3.ShowDialog();
                                this.Show();
                                return;
                            }

                            else
                            {
                                loginAttempts++;
                                UpdateLoginAttemptsToFile(loginAttempts);
                                UserBox.Text = "";
                                PasswordBox.Text = "";
                                MessageBox.Show("Incorrect username or pin");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. \n" + ex.Message);
            }
        }

        private void ResetPasswordLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign in with the admin account to reset your pin");
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            string currentText = PasswordBox.Text;

            if (currentText.Length > 0 && !char.IsDigit(currentText[currentText.Length - 1]))
            {
                PasswordBox.Text = currentText.Substring(0, currentText.Length - 1);
                PasswordBox.SelectionStart = PasswordBox.Text.Length;
                MessageBox.Show("Type only numbers. It's a pin.");
            }
        }
    }
}
