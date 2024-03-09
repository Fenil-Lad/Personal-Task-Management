namespace Personal_Task_Management
{
    partial class TaskList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNameBox = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityBox = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.Label();
            this.DueLabel = new System.Windows.Forms.Label();
            this.DueBox = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.AutoSize = true;
            this.TaskNameBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameBox.ForeColor = System.Drawing.Color.White;
            this.TaskNameBox.Location = new System.Drawing.Point(12, 20);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(65, 26);
            this.TaskNameBox.TabIndex = 0;
            this.TaskNameBox.Text = "Dance";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PriorityLabel.ForeColor = System.Drawing.Color.White;
            this.PriorityLabel.Location = new System.Drawing.Point(13, 67);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(59, 19);
            this.PriorityLabel.TabIndex = 1;
            this.PriorityLabel.Text = "Priority:";
            // 
            // PriorityBox
            // 
            this.PriorityBox.AutoSize = true;
            this.PriorityBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.PriorityBox.ForeColor = System.Drawing.Color.White;
            this.PriorityBox.Location = new System.Drawing.Point(77, 67);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(62, 19);
            this.PriorityBox.TabIndex = 2;
            this.PriorityBox.Text = "Medium";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(166, 67);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 19);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.StatusBox.ForeColor = System.Drawing.Color.White;
            this.StatusBox.Location = new System.Drawing.Point(216, 67);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(71, 19);
            this.StatusBox.TabIndex = 4;
            this.StatusBox.Text = "Complete";
            // 
            // DueLabel
            // 
            this.DueLabel.AutoSize = true;
            this.DueLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.DueLabel.ForeColor = System.Drawing.Color.White;
            this.DueLabel.Location = new System.Drawing.Point(320, 67);
            this.DueLabel.Name = "DueLabel";
            this.DueLabel.Size = new System.Drawing.Size(39, 19);
            this.DueLabel.TabIndex = 5;
            this.DueLabel.Text = "Due:";
            // 
            // DueBox
            // 
            this.DueBox.AutoSize = true;
            this.DueBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.DueBox.ForeColor = System.Drawing.Color.White;
            this.DueBox.Location = new System.Drawing.Point(365, 67);
            this.DueBox.Name = "DueBox";
            this.DueBox.Size = new System.Drawing.Size(143, 19);
            this.DueBox.TabIndex = 6;
            this.DueBox.Text = "2024-03-04 23:43:19";
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.UpdateLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateLabel.Location = new System.Drawing.Point(525, 67);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(56, 19);
            this.UpdateLabel.TabIndex = 7;
            this.UpdateLabel.Text = "Update";
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.DeleteLabel.ForeColor = System.Drawing.Color.White;
            this.DeleteLabel.Location = new System.Drawing.Point(586, 67);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(52, 19);
            this.DeleteLabel.TabIndex = 8;
            this.DeleteLabel.Text = "Delete";
            this.DeleteLabel.Click += new System.EventHandler(this.DeleteLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.panel1.Location = new System.Drawing.Point(642, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 103);
            this.panel1.TabIndex = 9;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.DueBox);
            this.Controls.Add(this.DueLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.TaskNameBox);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(658, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameBox;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label PriorityBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label DueLabel;
        private System.Windows.Forms.Label DueBox;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
