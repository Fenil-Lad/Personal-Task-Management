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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateTaskLabel = new System.Windows.Forms.Label();
            this.SelectPriorityLabel = new System.Windows.Forms.Label();
            this.SelectStatusLabel = new System.Windows.Forms.Label();
            this.SelectDueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameBox.Location = new System.Drawing.Point(123, 65);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(205, 26);
            this.TaskNameBox.TabIndex = 0;
            // 
            // PriorityBox
            // 
            this.PriorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PriorityBox.Location = new System.Drawing.Point(123, 117);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(205, 28);
            this.PriorityBox.TabIndex = 1;
            // 
            // SelectPriorityBox
            // 
            this.SelectPriorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPriorityBox.FormattingEnabled = true;
            this.SelectPriorityBox.Items.AddRange(new object[] {
            "Incomplete",
            "Inprogress",
            "Complete"});
            this.SelectPriorityBox.Location = new System.Drawing.Point(123, 172);
            this.SelectPriorityBox.Name = "SelectPriorityBox";
            this.SelectPriorityBox.Size = new System.Drawing.Size(205, 28);
            this.SelectPriorityBox.TabIndex = 2;
            // 
            // TaskDuePickerBox
            // 
            this.TaskDuePickerBox.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.TaskDuePickerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDuePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TaskDuePickerBox.Location = new System.Drawing.Point(123, 226);
            this.TaskDuePickerBox.Name = "TaskDuePickerBox";
            this.TaskDuePickerBox.Size = new System.Drawing.Size(205, 26);
            this.TaskDuePickerBox.TabIndex = 3;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.AddTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaskBtn.Location = new System.Drawing.Point(174, 281);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(94, 34);
            this.AddTaskBtn.TabIndex = 4;
            this.AddTaskBtn.Text = "Add";
            this.AddTaskBtn.UseVisualStyleBackColor = false;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateTaskLabel
            // 
            this.CreateTaskLabel.AutoSize = true;
            this.CreateTaskLabel.Location = new System.Drawing.Point(49, 73);
            this.CreateTaskLabel.Name = "CreateTaskLabel";
            this.CreateTaskLabel.Size = new System.Drawing.Size(68, 13);
            this.CreateTaskLabel.TabIndex = 6;
            this.CreateTaskLabel.Text = "Create Task:";
            // 
            // SelectPriorityLabel
            // 
            this.SelectPriorityLabel.AutoSize = true;
            this.SelectPriorityLabel.Location = new System.Drawing.Point(49, 125);
            this.SelectPriorityLabel.Name = "SelectPriorityLabel";
            this.SelectPriorityLabel.Size = new System.Drawing.Size(74, 13);
            this.SelectPriorityLabel.TabIndex = 7;
            this.SelectPriorityLabel.Text = "Select Priority:";
            // 
            // SelectStatusLabel
            // 
            this.SelectStatusLabel.AutoSize = true;
            this.SelectStatusLabel.Location = new System.Drawing.Point(49, 180);
            this.SelectStatusLabel.Name = "SelectStatusLabel";
            this.SelectStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.SelectStatusLabel.TabIndex = 8;
            this.SelectStatusLabel.Text = "Select Status:";
            // 
            // SelectDueLabel
            // 
            this.SelectDueLabel.AutoSize = true;
            this.SelectDueLabel.Location = new System.Drawing.Point(49, 236);
            this.SelectDueLabel.Name = "SelectDueLabel";
            this.SelectDueLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectDueLabel.TabIndex = 9;
            this.SelectDueLabel.Text = "Select Due:";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 369);
            this.Controls.Add(this.SelectDueLabel);
            this.Controls.Add(this.SelectStatusLabel);
            this.Controls.Add(this.SelectPriorityLabel);
            this.Controls.Add(this.CreateTaskLabel);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.TaskDuePickerBox);
            this.Controls.Add(this.SelectPriorityBox);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.TaskNameBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label CreateTaskLabel;
        private System.Windows.Forms.Label SelectPriorityLabel;
        private System.Windows.Forms.Label SelectStatusLabel;
        private System.Windows.Forms.Label SelectDueLabel;
    }
}