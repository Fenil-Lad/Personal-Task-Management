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

namespace Personal_Task_Management
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
        }


        private void AddTaskBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TaskNameBox.Text) ||  string.IsNullOrWhiteSpace(PriorityBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(SelectPriorityBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please fill out all the required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string taskName = TaskNameBox.Text;
                string priority = PriorityBox.SelectedItem.ToString();
                string status = SelectPriorityBox.SelectedItem.ToString();
                DateTime dueDateTime = TaskDuePickerBox.Value;

                string taskInfo = $"{taskName},{priority},{status},{dueDateTime.ToString("yyyy-MM-dd HH:mm:ss")}";

                bool retunedVal = AppendTaskToFile(taskInfo);
                if (retunedVal)
                {
                    TaskNameBox.Clear();
                    PriorityBox.SelectedIndex = -1;
                    SelectPriorityBox.SelectedIndex = -1;
                    TaskDuePickerBox.Value = DateTime.Now;
                    TaskList taskList = new TaskList(taskName, priority, status, dueDateTime.ToString("MM/dd/yyyy"));
                    MessageBox.Show("Task was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UserForm form = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                    if (form != null)
                    {
                        form.AddTaskInPanel(taskList);
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error adding task. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool AppendTaskToFile(string taskInfo)
        {
            string filePath = "..\\..\\Credentials\\tasks.txt";

            try
            {
                string existingContent = File.ReadAllText(filePath);

                string updatedContent = existingContent + taskInfo + Environment.NewLine;

                File.WriteAllText(filePath, updatedContent);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
