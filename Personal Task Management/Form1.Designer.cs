namespace Personal_Task_Management
{
    partial class LoginForm
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
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.ResetPasswordLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LeftBox = new System.Windows.Forms.GroupBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.LoginBox.SuspendLayout();
            this.LeftBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.ResetPasswordLabel);
            this.LoginBox.Controls.Add(this.LoginBtn);
            this.LoginBox.Controls.Add(this.PasswordLabel);
            this.LoginBox.Controls.Add(this.UserLabel);
            this.LoginBox.Controls.Add(this.PasswordBox);
            this.LoginBox.Controls.Add(this.UserBox);
            this.LoginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.LoginBox.Location = new System.Drawing.Point(472, 1);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(330, 452);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            // 
            // ResetPasswordLabel
            // 
            this.ResetPasswordLabel.AutoSize = true;
            this.ResetPasswordLabel.Location = new System.Drawing.Point(138, 346);
            this.ResetPasswordLabel.Name = "ResetPasswordLabel";
            this.ResetPasswordLabel.Size = new System.Drawing.Size(65, 16);
            this.ResetPasswordLabel.TabIndex = 3;
            this.ResetPasswordLabel.Text = "Reset Pin";
            this.ResetPasswordLabel.Click += new System.EventHandler(this.ResetPasswordLabel_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(128, 288);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 35);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(55, 211);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(26, 16);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Pin";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(55, 146);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 16);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Username";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(58, 227);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(221, 29);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.White;
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.Location = new System.Drawing.Point(58, 164);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(221, 29);
            this.UserBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(38, 147);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(381, 39);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Personal Task Management";
            // 
            // LeftBox
            // 
            this.LeftBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.LeftBox.Controls.Add(this.DescriptionLabel);
            this.LeftBox.Controls.Add(this.TitleLabel);
            this.LeftBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LeftBox.Location = new System.Drawing.Point(0, 1);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(473, 452);
            this.LeftBox.TabIndex = 2;
            this.LeftBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(26, 186);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(413, 15);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Effectively managing personal tasks for productivity and organized success.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeftBox);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Task Management | Login";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.LeftBox.ResumeLayout(false);
            this.LeftBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox LeftBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ResetPasswordLabel;
    }
}

