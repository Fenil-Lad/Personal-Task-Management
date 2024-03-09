namespace Personal_Task_Management
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RandomTaskBtn = new System.Windows.Forms.Button();
            this.ClearAllTaskBtn = new System.Windows.Forms.Button();
            this.CreateTaskBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TaskListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.ClearTaskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.RandomTaskBtn);
            this.panel1.Controls.Add(this.ClearAllTaskBtn);
            this.panel1.Controls.Add(this.CreateTaskBtn);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 404);
            this.panel1.TabIndex = 1;
            // 
            // RandomTaskBtn
            // 
            this.RandomTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.RandomTaskBtn.FlatAppearance.BorderSize = 0;
            this.RandomTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomTaskBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomTaskBtn.ForeColor = System.Drawing.Color.White;
            this.RandomTaskBtn.Location = new System.Drawing.Point(0, 217);
            this.RandomTaskBtn.Name = "RandomTaskBtn";
            this.RandomTaskBtn.Size = new System.Drawing.Size(139, 101);
            this.RandomTaskBtn.TabIndex = 2;
            this.RandomTaskBtn.Text = "Add Random Task";
            this.RandomTaskBtn.UseVisualStyleBackColor = false;
            // 
            // ClearAllTaskBtn
            // 
            this.ClearAllTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.ClearAllTaskBtn.FlatAppearance.BorderSize = 0;
            this.ClearAllTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllTaskBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllTaskBtn.ForeColor = System.Drawing.Color.White;
            this.ClearAllTaskBtn.Location = new System.Drawing.Point(0, 110);
            this.ClearAllTaskBtn.Name = "ClearAllTaskBtn";
            this.ClearAllTaskBtn.Size = new System.Drawing.Size(139, 101);
            this.ClearAllTaskBtn.TabIndex = 1;
            this.ClearAllTaskBtn.Text = "Clear all tasks";
            this.ClearAllTaskBtn.UseVisualStyleBackColor = false;
            this.ClearAllTaskBtn.Click += new System.EventHandler(this.ClearAllTaskBtn_Click);
            // 
            // CreateTaskBtn
            // 
            this.CreateTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.CreateTaskBtn.FlatAppearance.BorderSize = 0;
            this.CreateTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskBtn.ForeColor = System.Drawing.Color.White;
            this.CreateTaskBtn.Location = new System.Drawing.Point(0, 3);
            this.CreateTaskBtn.Name = "CreateTaskBtn";
            this.CreateTaskBtn.Size = new System.Drawing.Size(139, 101);
            this.CreateTaskBtn.TabIndex = 0;
            this.CreateTaskBtn.Text = "Add task";
            this.CreateTaskBtn.UseVisualStyleBackColor = false;
            this.CreateTaskBtn.Click += new System.EventHandler(this.CreateTaskBtn_Click);
            // 
            // TaskListPanel
            // 
            this.TaskListPanel.AutoScroll = true;
            this.TaskListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TaskListPanel.Location = new System.Drawing.Point(142, 44);
            this.TaskListPanel.Name = "TaskListPanel";
            this.TaskListPanel.Size = new System.Drawing.Size(681, 404);
            this.TaskListPanel.TabIndex = 2;
            this.TaskListPanel.Visible = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::Personal_Task_Management.Properties.Resources.redDot18;
            this.CloseBtn.Location = new System.Drawing.Point(12, 19);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(19, 19);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Image = global::Personal_Task_Management.Properties.Resources.yellowDot18;
            this.MinimizeBtn.Location = new System.Drawing.Point(37, 19);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MinimizeBtn.TabIndex = 7;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Image = global::Personal_Task_Management.Properties.Resources.greenDot18;
            this.MaximizeBtn.Location = new System.Drawing.Point(62, 19);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MaximizeBtn.TabIndex = 6;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // ClearTaskLabel
            // 
            this.ClearTaskLabel.AutoSize = true;
            this.ClearTaskLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTaskLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ClearTaskLabel.Location = new System.Drawing.Point(347, 214);
            this.ClearTaskLabel.Name = "ClearTaskLabel";
            this.ClearTaskLabel.Size = new System.Drawing.Size(279, 19);
            this.ClearTaskLabel.TabIndex = 0;
            this.ClearTaskLabel.Text = "Task List Empty. Awaiting Your Next Move";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.ClearTaskLabel);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.MaximizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TaskListPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Task Management | Home";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ClearAllTaskBtn;
        private System.Windows.Forms.Button CreateTaskBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel TaskListPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Label ClearTaskLabel;
        private System.Windows.Forms.Button RandomTaskBtn;
    }
}