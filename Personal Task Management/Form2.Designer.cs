namespace Personal_Task_Management
{
    partial class AdminForm
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
            this.UserNamePanel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.OperationBtn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractLogsInExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmChangeBtn = new System.Windows.Forms.Button();
            this.LogBoxHeadingLabel = new System.Windows.Forms.Label();
            this.LogInTimeLabel = new System.Windows.Forms.Label();
            this.LogOutTimeLabel = new System.Windows.Forms.Label();
            this.LogInBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.NewPasswordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.AutoSize = true;
            this.UserNamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamePanel.Location = new System.Drawing.Point(18, 65);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Size = new System.Drawing.Size(68, 24);
            this.UserNamePanel.TabIndex = 0;
            this.UserNamePanel.Text = "prg455";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(21, 46);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(33, 15);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User";
            // 
            // OperationBtn
            // 
            this.OperationBtn.AutoSize = true;
            this.OperationBtn.Location = new System.Drawing.Point(21, 106);
            this.OperationBtn.Name = "OperationBtn";
            this.OperationBtn.Size = new System.Drawing.Size(58, 13);
            this.OperationBtn.TabIndex = 4;
            this.OperationBtn.Text = "Operations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.clearTasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem,
            this.extractLogsInExcelToolStripMenuItem});
            this.logsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // extractLogsInExcelToolStripMenuItem
            // 
            this.extractLogsInExcelToolStripMenuItem.Name = "extractLogsInExcelToolStripMenuItem";
            this.extractLogsInExcelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.extractLogsInExcelToolStripMenuItem.Text = "Extract Logs in Excel";
            // 
            // clearTasksToolStripMenuItem
            // 
            this.clearTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTasksToolStripMenuItem1});
            this.clearTasksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clearTasksToolStripMenuItem.Name = "clearTasksToolStripMenuItem";
            this.clearTasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearTasksToolStripMenuItem.Text = "Tasks";
            // 
            // clearTasksToolStripMenuItem1
            // 
            this.clearTasksToolStripMenuItem1.Name = "clearTasksToolStripMenuItem1";
            this.clearTasksToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.clearTasksToolStripMenuItem1.Text = "Clear All Tasks";
            this.clearTasksToolStripMenuItem1.Click += new System.EventHandler(this.clearTasksToolStripMenuItem1_Click);
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(6, 38);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(160, 20);
            this.NewPasswordBox.TabIndex = 7;
            this.NewPasswordBox.TextChanged += new System.EventHandler(this.NewPasswordBox_TextChanged);
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(6, 16);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(106, 16);
            this.NewPasswordLabel.TabIndex = 10;
            this.NewPasswordLabel.Text = "Reset Password";
            // 
            // NewPasswordGroupBox
            // 
            this.NewPasswordGroupBox.Controls.Add(this.ConfirmChangeBtn);
            this.NewPasswordGroupBox.Controls.Add(this.NewPasswordLabel);
            this.NewPasswordGroupBox.Controls.Add(this.NewPasswordBox);
            this.NewPasswordGroupBox.Location = new System.Drawing.Point(22, 122);
            this.NewPasswordGroupBox.Name = "NewPasswordGroupBox";
            this.NewPasswordGroupBox.Size = new System.Drawing.Size(173, 105);
            this.NewPasswordGroupBox.TabIndex = 13;
            this.NewPasswordGroupBox.TabStop = false;
            // 
            // ConfirmChangeBtn
            // 
            this.ConfirmChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.ConfirmChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmChangeBtn.Location = new System.Drawing.Point(46, 64);
            this.ConfirmChangeBtn.Name = "ConfirmChangeBtn";
            this.ConfirmChangeBtn.Size = new System.Drawing.Size(75, 31);
            this.ConfirmChangeBtn.TabIndex = 11;
            this.ConfirmChangeBtn.Text = "Confirm";
            this.ConfirmChangeBtn.UseVisualStyleBackColor = false;
            this.ConfirmChangeBtn.Click += new System.EventHandler(this.ConfirmChangeBtn_Click);
            // 
            // LogBoxHeadingLabel
            // 
            this.LogBoxHeadingLabel.AutoSize = true;
            this.LogBoxHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBoxHeadingLabel.Location = new System.Drawing.Point(353, 46);
            this.LogBoxHeadingLabel.Name = "LogBoxHeadingLabel";
            this.LogBoxHeadingLabel.Size = new System.Drawing.Size(62, 13);
            this.LogBoxHeadingLabel.TabIndex = 15;
            this.LogBoxHeadingLabel.Text = "Log Activity";
            // 
            // LogInTimeLabel
            // 
            this.LogInTimeLabel.AutoSize = true;
            this.LogInTimeLabel.Location = new System.Drawing.Point(281, 76);
            this.LogInTimeLabel.Name = "LogInTimeLabel";
            this.LogInTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.LogInTimeLabel.TabIndex = 16;
            this.LogInTimeLabel.Text = "Login Time";
            // 
            // LogOutTimeLabel
            // 
            this.LogOutTimeLabel.AutoSize = true;
            this.LogOutTimeLabel.Location = new System.Drawing.Point(427, 76);
            this.LogOutTimeLabel.Name = "LogOutTimeLabel";
            this.LogOutTimeLabel.Size = new System.Drawing.Size(66, 13);
            this.LogOutTimeLabel.TabIndex = 17;
            this.LogOutTimeLabel.Text = "Logout Time";
            // 
            // LogInBox
            // 
            this.LogInBox.FormattingEnabled = true;
            this.LogInBox.Location = new System.Drawing.Point(271, 106);
            this.LogInBox.Name = "LogInBox";
            this.LogInBox.Size = new System.Drawing.Size(282, 160);
            this.LogInBox.TabIndex = 18;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 280);
            this.Controls.Add(this.LogInBox);
            this.Controls.Add(this.LogOutTimeLabel);
            this.Controls.Add(this.LogInTimeLabel);
            this.Controls.Add(this.LogBoxHeadingLabel);
            this.Controls.Add(this.NewPasswordGroupBox);
            this.Controls.Add(this.OperationBtn);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNamePanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Task Management | Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NewPasswordGroupBox.ResumeLayout(false);
            this.NewPasswordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNamePanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label OperationBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.GroupBox NewPasswordGroupBox;
        private System.Windows.Forms.Label LogBoxHeadingLabel;
        private System.Windows.Forms.Label LogInTimeLabel;
        private System.Windows.Forms.Label LogOutTimeLabel;
        private System.Windows.Forms.Button ConfirmChangeBtn;
        private System.Windows.Forms.ListBox LogInBox;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractLogsInExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTasksToolStripMenuItem1;
    }
}