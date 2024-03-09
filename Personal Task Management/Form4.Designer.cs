using System.Windows.Forms;

namespace Personal_Task_Management
{
    partial class CreateTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNameBox = new System.Windows.Forms.TextBox();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.SelectPriorityBox = new System.Windows.Forms.ComboBox();
            this.TaskDuePickerBox = new System.Windows.Forms.DateTimePicker();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.CreateTaskLabel = new System.Windows.Forms.Label();
            this.SelectPriorityLabel = new System.Windows.Forms.Label();
            this.SelectStatusLabel = new System.Windows.Forms.Label();
            this.SelectDueLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.TaskNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskNameBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameBox.ForeColor = System.Drawing.Color.White;
            this.TaskNameBox.Location = new System.Drawing.Point(123, 60);
            this.TaskNameBox.MaxLength = 50;
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(205, 24);
            this.TaskNameBox.TabIndex = 0;
            // 
            // PriorityBox
            // 
            this.PriorityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.PriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.PriorityBox.ForeColor = System.Drawing.Color.White;
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PriorityBox.Location = new System.Drawing.Point(123, 117);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(205, 31);
            this.PriorityBox.TabIndex = 1;
            // 
            // SelectPriorityBox
            // 
            this.SelectPriorityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.SelectPriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectPriorityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPriorityBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.SelectPriorityBox.ForeColor = System.Drawing.Color.White;
            this.SelectPriorityBox.FormattingEnabled = true;
            this.SelectPriorityBox.Items.AddRange(new object[] {
            "Incomplete",
            "In Progress",
            "Complete"});
            this.SelectPriorityBox.Location = new System.Drawing.Point(123, 172);
            this.SelectPriorityBox.Name = "SelectPriorityBox";
            this.SelectPriorityBox.Size = new System.Drawing.Size(205, 31);
            this.SelectPriorityBox.TabIndex = 2;
            // 
            // TaskDuePickerBox
            // 
            this.TaskDuePickerBox.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.TaskDuePickerBox.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.TaskDuePickerBox.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.TaskDuePickerBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.TaskDuePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TaskDuePickerBox.Location = new System.Drawing.Point(123, 226);
            this.TaskDuePickerBox.Name = "TaskDuePickerBox";
            this.TaskDuePickerBox.Size = new System.Drawing.Size(205, 31);
            this.TaskDuePickerBox.TabIndex = 3;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.AddTaskBtn.FlatAppearance.BorderSize = 0;
            this.AddTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskBtn.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.AddTaskBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaskBtn.Location = new System.Drawing.Point(174, 281);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(94, 34);
            this.AddTaskBtn.TabIndex = 4;
            this.AddTaskBtn.Text = "Add";
            this.AddTaskBtn.UseVisualStyleBackColor = false;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // CreateTaskLabel
            // 
            this.CreateTaskLabel.AutoSize = true;
            this.CreateTaskLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.CreateTaskLabel.ForeColor = System.Drawing.Color.White;
            this.CreateTaskLabel.Location = new System.Drawing.Point(12, 65);
            this.CreateTaskLabel.Name = "CreateTaskLabel";
            this.CreateTaskLabel.Size = new System.Drawing.Size(89, 19);
            this.CreateTaskLabel.TabIndex = 6;
            this.CreateTaskLabel.Text = "Create Task:";
            // 
            // SelectPriorityLabel
            // 
            this.SelectPriorityLabel.AutoSize = true;
            this.SelectPriorityLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.SelectPriorityLabel.ForeColor = System.Drawing.Color.White;
            this.SelectPriorityLabel.Location = new System.Drawing.Point(12, 121);
            this.SelectPriorityLabel.Name = "SelectPriorityLabel";
            this.SelectPriorityLabel.Size = new System.Drawing.Size(102, 19);
            this.SelectPriorityLabel.TabIndex = 7;
            this.SelectPriorityLabel.Text = "Select Priority:";
            // 
            // SelectStatusLabel
            // 
            this.SelectStatusLabel.AutoSize = true;
            this.SelectStatusLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.SelectStatusLabel.ForeColor = System.Drawing.Color.White;
            this.SelectStatusLabel.Location = new System.Drawing.Point(12, 176);
            this.SelectStatusLabel.Name = "SelectStatusLabel";
            this.SelectStatusLabel.Size = new System.Drawing.Size(96, 19);
            this.SelectStatusLabel.TabIndex = 8;
            this.SelectStatusLabel.Text = "Select Status:";
            // 
            // SelectDueLabel
            // 
            this.SelectDueLabel.AutoSize = true;
            this.SelectDueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SelectDueLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.SelectDueLabel.ForeColor = System.Drawing.Color.White;
            this.SelectDueLabel.Location = new System.Drawing.Point(19, 226);
            this.SelectDueLabel.Name = "SelectDueLabel";
            this.SelectDueLabel.Size = new System.Drawing.Size(82, 19);
            this.SelectDueLabel.TabIndex = 9;
            this.SelectDueLabel.Text = "Select Due:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::Personal_Task_Management.Properties.Resources.redDot18;
            this.CloseBtn.Location = new System.Drawing.Point(12, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(19, 19);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Image = global::Personal_Task_Management.Properties.Resources.yellowDot18;
            this.MinimizeBtn.Location = new System.Drawing.Point(37, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MinimizeBtn.TabIndex = 12;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Image = global::Personal_Task_Management.Properties.Resources.greenDot18;
            this.MaximizeBtn.Location = new System.Drawing.Point(62, 12);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MaximizeBtn.TabIndex = 11;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(383, 369);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.MaximizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SelectDueLabel);
            this.Controls.Add(this.SelectStatusLabel);
            this.Controls.Add(this.SelectPriorityLabel);
            this.Controls.Add(this.CreateTaskLabel);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.TaskDuePickerBox);
            this.Controls.Add(this.SelectPriorityBox);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.TaskNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTaskForm";
            this.Text = "Personal Task Management | Create Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskNameBox;
        private System.Windows.Forms.ComboBox PriorityBox;
        private System.Windows.Forms.ComboBox SelectPriorityBox;
        private System.Windows.Forms.DateTimePicker TaskDuePickerBox;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Label CreateTaskLabel;
        private System.Windows.Forms.Label SelectPriorityLabel;
        private System.Windows.Forms.Label SelectStatusLabel;
        private System.Windows.Forms.Label SelectDueLabel;
        private Button CloseBtn;
        private Button MinimizeBtn;
        private Button MaximizeBtn;
    }
}