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
using System.Drawing.Drawing2D;

namespace Personal_Task_Management
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
            SetFormBorderRadius(this, 15);
        }

        private void SetFormBorderRadius(Form form, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle bounds = form.ClientRectangle;
            int diameter = borderRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            form.Region = new Region(path);
        }


        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskNameBox.Text) || string.IsNullOrWhiteSpace(PriorityBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(SelectPriorityBox.SelectedItem?.ToString()))
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
                int deleteVar = CountTasksFromFile()+1;

                string taskInfo = $"{taskName},{priority},{status},{dueDateTime.ToString("yyyy-MM-dd HH:mm:ss")},{deleteVar}";

                bool retunedVal = AppendTaskToFile(taskInfo);
                if (retunedVal)
                {
                    TaskNameBox.Clear();
                    PriorityBox.SelectedIndex = -1;
                    SelectPriorityBox.SelectedIndex = -1;
                    TaskDuePickerBox.Value = DateTime.Now;
                    TaskList taskList = new TaskList(taskName, priority, status, dueDateTime.ToString("MM/dd/yyyy"), deleteVar);
                    UserForm form = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                    if (form != null)
                    {
                        form.ShowAndClear();
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
        private int CountTasksFromFile()
        {
            string filePath = "..\\..\\Credentials\\tasks.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] taskLines = File.ReadAllLines(filePath);

                    return taskLines.Length;

                }
                else
                { 
                    return 0; 
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong. Contact your Admin.");
                return -1;
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The window is already at its maximum size.");
        }
    }
}
