using System;
using System.Windows.Forms;
using System.Drawing;

namespace Personal_Task_Management
{
    public partial class TaskList : UserControl
    {

        private int DeleteVar;
        public TaskList()
        {
            InitializeComponent();
        }

        public TaskList(string taskName, string priority, string status, string dueDate, int deleteVar) : this()
        {
            TaskName = taskName;
            Priority = priority;
            Status = status;
            DueDate = dueDate;
            DeleteVar = deleteVar;
            PriorityColor(Priority); 
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

        public void PriorityColor(string priority)
        {
            if(priority == "High")
            {
                panel1.BackColor = Color.FromArgb(255, 255, 58, 58);
            }
            else if(priority == "Medium")
            {
                panel1.BackColor = Color.FromArgb(255, 227, 227, 58);
            }
            else if(priority == "Low")
            {
                panel1.BackColor = Color.FromArgb(255, 58, 227, 94);
            }
            else
            {
                panel1.BackColor = Color.FromArgb(255, 87, 33, 183);
            }
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
