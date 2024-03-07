using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Personal_Task_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
        public static void SaveLogOutTime()
        {
            DateTime loginTime = DateTime.Now;

            string timeString = loginTime.ToString("yyyy-MM-dd HH:mm:ss");

            string filePath = "..\\..\\Credentials\\logs.txt";
            try
            {
                File.AppendAllText(filePath, $"{timeString}\n");

                Console.WriteLine($"Login time has been saved to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving login time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveLoginTime()
        {
            DateTime loginTime = DateTime.Now;
            string filePath = "..\\..\\Credentials\\logs.txt";

            string timeString = loginTime.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                File.AppendAllText(filePath, $"{timeString}\t");

                Console.WriteLine($"Login time has been saved to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving login time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
