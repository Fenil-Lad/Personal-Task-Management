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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.FormClosing += UserForm_FormClosing;
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
            // Assuming TaskListPanel is a FlowLayoutPanel or Panel
            TaskListPanel.Controls.Add(task);
        }

    }
}
