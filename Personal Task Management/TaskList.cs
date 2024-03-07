using System;
using System.Windows.Forms;

namespace Personal_Task_Management
{
    public partial class TaskList : UserControl
    {
        public TaskList()
        {
            InitializeComponent();
        }

        public TaskList(string taskName, string priority, string status, string dueDate) : this()
        {
            TaskName = taskName;
            Priority = priority;
            Status = status;
            DueDate = dueDate;
        }

        public string TaskName
        {
            get { return TaskNameBox.Text; }
            set { TaskNameBox.Text = value; }
        }

        public string Priority
        {
            get { return PriorityBox.Text; }
            set { PriorityBox.Text = value; }
        }

        public string Status
        {
            get { return StatusBox.Text; }
            set { StatusBox.Text = value; }
        }

        public string DueDate
        {
            get { return DueBox.Text; }
            set { DueBox.Text = value; }
        }
    }
}
