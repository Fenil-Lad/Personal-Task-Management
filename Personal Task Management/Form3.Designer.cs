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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearAllTaskBtn = new System.Windows.Forms.Button();
            this.CreateTaskBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TaskListPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(183)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.ClearAllTaskBtn);
            this.panel1.Controls.Add(this.CreateTaskBtn);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 421);
            this.panel1.TabIndex = 1;
            // 
            // ClearAllTaskBtn
            // 
            this.ClearAllTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.ClearAllTaskBtn.FlatAppearance.BorderSize = 0;
            this.ClearAllTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllTaskBtn.ForeColor = System.Drawing.Color.White;
            this.ClearAllTaskBtn.Location = new System.Drawing.Point(0, 110);
            this.ClearAllTaskBtn.Name = "ClearAllTaskBtn";
            this.ClearAllTaskBtn.Size = new System.Drawing.Size(139, 101);
            this.ClearAllTaskBtn.TabIndex = 1;
            this.ClearAllTaskBtn.Text = "Clear all tasks";
            this.ClearAllTaskBtn.UseVisualStyleBackColor = false;
            // 
            // CreateTaskBtn
            // 
            this.CreateTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.CreateTaskBtn.FlatAppearance.BorderSize = 0;
            this.CreateTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskBtn.ForeColor = System.Drawing.Color.White;
            this.CreateTaskBtn.Location = new System.Drawing.Point(0, 3);
            this.CreateTaskBtn.Name = "CreateTaskBtn";
            this.CreateTaskBtn.Size = new System.Drawing.Size(139, 101);
            this.CreateTaskBtn.TabIndex = 0;
            this.CreateTaskBtn.Text = "Create tasks";
            this.CreateTaskBtn.UseVisualStyleBackColor = false;
            this.CreateTaskBtn.Click += new System.EventHandler(this.CreateTaskBtn_Click);
            // 
            // TaskListPanel
            // 
            this.TaskListPanel.AutoScroll = true;
            this.TaskListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TaskListPanel.Location = new System.Drawing.Point(142, 27);
            this.TaskListPanel.Name = "TaskListPanel";
            this.TaskListPanel.Size = new System.Drawing.Size(681, 421);
            this.TaskListPanel.TabIndex = 2;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.TaskListPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Task Management | Home";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ClearAllTaskBtn;
        private System.Windows.Forms.Button CreateTaskBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel TaskListPanel;
    }
}