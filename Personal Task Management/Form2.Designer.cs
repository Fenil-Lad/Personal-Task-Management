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
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmChangeBtn = new System.Windows.Forms.Button();
            this.LogBoxHeadingLabel = new System.Windows.Forms.Label();
            this.LogInTimeLabel = new System.Windows.Forms.Label();
            this.LogOutTimeLabel = new System.Windows.Forms.Label();
            this.LogInBox = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.NewPasswordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.AutoSize = true;
            this.UserNamePanel.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.UserNamePanel.ForeColor = System.Drawing.Color.White;
            this.UserNamePanel.Location = new System.Drawing.Point(24, 77);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Size = new System.Drawing.Size(66, 23);
            this.UserNamePanel.TabIndex = 0;
            this.UserNamePanel.Text = "prg455";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(21, 54);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(39, 19);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User";
            // 
            // OperationBtn
            // 
            this.OperationBtn.AutoSize = true;
            this.OperationBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationBtn.ForeColor = System.Drawing.Color.White;
            this.OperationBtn.Location = new System.Drawing.Point(21, 112);
            this.OperationBtn.Name = "OperationBtn";
            this.OperationBtn.Size = new System.Drawing.Size(81, 19);
            this.OperationBtn.TabIndex = 4;
            this.OperationBtn.Text = "Operations";
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.NewPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.NewPasswordBox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordBox.Location = new System.Drawing.Point(33, 59);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(160, 24);
            this.NewPasswordBox.TabIndex = 7;
            this.NewPasswordBox.TextChanged += new System.EventHandler(this.NewPasswordBox_TextChanged);
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.NewPasswordLabel.Location = new System.Drawing.Point(59, 16);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(112, 19);
            this.NewPasswordLabel.TabIndex = 10;
            this.NewPasswordLabel.Text = "Reset Password";
            // 
            // NewPasswordGroupBox
            // 
            this.NewPasswordGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.NewPasswordGroupBox.Controls.Add(this.ConfirmChangeBtn);
            this.NewPasswordGroupBox.Controls.Add(this.NewPasswordLabel);
            this.NewPasswordGroupBox.Controls.Add(this.NewPasswordBox);
            this.NewPasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPasswordGroupBox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordGroupBox.Location = new System.Drawing.Point(22, 134);
            this.NewPasswordGroupBox.Name = "NewPasswordGroupBox";
            this.NewPasswordGroupBox.Size = new System.Drawing.Size(234, 164);
            this.NewPasswordGroupBox.TabIndex = 13;
            this.NewPasswordGroupBox.TabStop = false;
            // 
            // ConfirmChangeBtn
            // 
            this.ConfirmChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.ConfirmChangeBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmChangeBtn.Location = new System.Drawing.Point(77, 111);
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
            this.LogBoxHeadingLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBoxHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.LogBoxHeadingLabel.Location = new System.Drawing.Point(377, 81);
            this.LogBoxHeadingLabel.Name = "LogBoxHeadingLabel";
            this.LogBoxHeadingLabel.Size = new System.Drawing.Size(84, 19);
            this.LogBoxHeadingLabel.TabIndex = 15;
            this.LogBoxHeadingLabel.Text = "Log Activity";
            // 
            // LogInTimeLabel
            // 
            this.LogInTimeLabel.AutoSize = true;
            this.LogInTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LogInTimeLabel.Location = new System.Drawing.Point(281, 112);
            this.LogInTimeLabel.Name = "LogInTimeLabel";
            this.LogInTimeLabel.Size = new System.Drawing.Size(80, 19);
            this.LogInTimeLabel.TabIndex = 16;
            this.LogInTimeLabel.Text = "Login Time";
            // 
            // LogOutTimeLabel
            // 
            this.LogOutTimeLabel.AutoSize = true;
            this.LogOutTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LogOutTimeLabel.Location = new System.Drawing.Point(456, 112);
            this.LogOutTimeLabel.Name = "LogOutTimeLabel";
            this.LogOutTimeLabel.Size = new System.Drawing.Size(89, 19);
            this.LogOutTimeLabel.TabIndex = 17;
            this.LogOutTimeLabel.Text = "Logout Time";
            // 
            // LogInBox
            // 
            this.LogInBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.LogInBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBox.ForeColor = System.Drawing.Color.White;
            this.LogInBox.FormattingEnabled = true;
            this.LogInBox.ItemHeight = 15;
            this.LogInBox.Location = new System.Drawing.Point(271, 142);
            this.LogInBox.Name = "LogInBox";
            this.LogInBox.Size = new System.Drawing.Size(328, 154);
            this.LogInBox.TabIndex = 18;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::Personal_Task_Management.Properties.Resources.redDot18;
            this.CloseBtn.Location = new System.Drawing.Point(16, 22);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(19, 19);
            this.CloseBtn.TabIndex = 19;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Image = global::Personal_Task_Management.Properties.Resources.yellowDot18;
            this.MinimizeBtn.Location = new System.Drawing.Point(41, 22);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MinimizeBtn.TabIndex = 20;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Image = global::Personal_Task_Management.Properties.Resources.greenDot18;
            this.MaximizeBtn.Location = new System.Drawing.Point(66, 22);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(19, 19);
            this.MaximizeBtn.TabIndex = 21;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.MaximizeBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LogInBox);
            this.Controls.Add(this.LogOutTimeLabel);
            this.Controls.Add(this.LogInTimeLabel);
            this.Controls.Add(this.LogBoxHeadingLabel);
            this.Controls.Add(this.NewPasswordGroupBox);
            this.Controls.Add(this.OperationBtn);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Task Management | Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseUp);
            this.NewPasswordGroupBox.ResumeLayout(false);
            this.NewPasswordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNamePanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label OperationBtn;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.GroupBox NewPasswordGroupBox;
        private System.Windows.Forms.Label LogBoxHeadingLabel;
        private System.Windows.Forms.Label LogInTimeLabel;
        private System.Windows.Forms.Label LogOutTimeLabel;
        private System.Windows.Forms.Button ConfirmChangeBtn;
        private System.Windows.Forms.ListBox LogInBox;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button MaximizeBtn;
    }
}