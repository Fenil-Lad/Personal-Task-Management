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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.FormClosing += UserForm_FormClosing;
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

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = ShowConfirmBox("Are you sure you want to logout?");

            if (!result)
            {
                e.Cancel = true;
            }
            else
            {
                this.Hide();
                Program.SaveLogOutTime();
            }
        }

      

        static bool ShowConfirmBox(string confirmationText)
        {
            DialogResult result = MessageBox.Show(confirmationText, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void CreateTaskBtn_Click(object sender, EventArgs e)
        {
            CreateTaskForm form = new CreateTaskForm();
            form.ShowDialog();
        }

        public void AddTaskInPanel(TaskList task)
        {
            TaskListPanel.Controls.Add(task);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            
            LoadTasksFromFile();
        }

        private void LoadTasksFromFile()
        {
            string filePath = "..\\..\\Credentials\\tasks.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] taskLines = File.ReadAllLines(filePath);
                    if (taskLines.Length > 0)
                    {
                        ClearTaskLabel.Visible = false;
                        TaskListPanel.Visible = true;
                        foreach (string taskLine in taskLines)
                        {
                            string[] taskInfo = taskLine.Split(',');

                            if (taskInfo.Length == 5)
                            {
                                TaskList taskList = new TaskList(taskInfo[0], taskInfo[1], taskInfo[2], taskInfo[3], Convert.ToInt32(taskInfo[4]));
                                AddTaskInPanel(taskList);
                            }
                        }
                    }
                    else
                    {
                        TaskListPanel.Visible = false;
                        ClearTaskLabel.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void UserForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ClearAllTaskBtn_Click(object sender, EventArgs e)
        {
            string filePath = "..\\..\\Credentials\\tasks.txt";

            DialogResult result = MessageBox.Show("Are you sure you want to clear all tasks?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    File.WriteAllText(filePath, string.Empty);
                    TaskListPanel.Controls.Clear();
                    ClearAndShow();
                    MessageBox.Show("All tasks cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearAndShow()
        {
            TaskListPanel.Visible = false;
            ClearTaskLabel.Visible = true;
        }

        public void ShowAndClear()
        {
            ClearTaskLabel.Visible = false;
            TaskListPanel.Visible = true;
        }
    }
}
