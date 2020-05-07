namespace WinUI
{
    partial class WorkerOperations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnUpdateWorker = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.txtWorkerLastname = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtWorkerSalary = new System.Windows.Forms.TextBox();
            this.txtWorkerUsername = new System.Windows.Forms.TextBox();
            this.txtWorkerEmail = new System.Windows.Forms.TextBox();
            this.txtWorkerName = new System.Windows.Forms.TextBox();
            this.cmbWorkerSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(254, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Operations";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WinUI.Properties.Resources.closeButton;
            this.btnClose.Location = new System.Drawing.Point(638, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnDeleteWorker);
            this.panel2.Controls.Add(this.btnUpdateWorker);
            this.panel2.Controls.Add(this.btnAddWorker);
            this.panel2.Controls.Add(this.txtWorkerLastname);
            this.panel2.Controls.Add(this.txtUserPassword);
            this.panel2.Controls.Add(this.txtWorkerSalary);
            this.panel2.Controls.Add(this.txtWorkerUsername);
            this.panel2.Controls.Add(this.txtWorkerEmail);
            this.panel2.Controls.Add(this.txtWorkerName);
            this.panel2.Controls.Add(this.cmbWorkerSelect);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 463);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorker.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDeleteWorker.Location = new System.Drawing.Point(482, 353);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(140, 48);
            this.btnDeleteWorker.TabIndex = 3;
            this.btnDeleteWorker.Text = "Delete Worker";
            this.btnDeleteWorker.UseVisualStyleBackColor = false;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWorker.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnUpdateWorker.Location = new System.Drawing.Point(270, 353);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(140, 48);
            this.btnUpdateWorker.TabIndex = 3;
            this.btnUpdateWorker.Text = "Update Worker";
            this.btnUpdateWorker.UseVisualStyleBackColor = false;
            this.btnUpdateWorker.Click += new System.EventHandler(this.btnUpdateWorker_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAddWorker.Location = new System.Drawing.Point(48, 353);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(140, 48);
            this.btnAddWorker.TabIndex = 3;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // txtWorkerLastname
            // 
            this.txtWorkerLastname.Location = new System.Drawing.Point(242, 120);
            this.txtWorkerLastname.Name = "txtWorkerLastname";
            this.txtWorkerLastname.Size = new System.Drawing.Size(377, 20);
            this.txtWorkerLastname.TabIndex = 2;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(242, 244);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(377, 20);
            this.txtUserPassword.TabIndex = 2;
            // 
            // txtWorkerSalary
            // 
            this.txtWorkerSalary.Location = new System.Drawing.Point(242, 285);
            this.txtWorkerSalary.Name = "txtWorkerSalary";
            this.txtWorkerSalary.Size = new System.Drawing.Size(377, 20);
            this.txtWorkerSalary.TabIndex = 2;
            // 
            // txtWorkerUsername
            // 
            this.txtWorkerUsername.Location = new System.Drawing.Point(242, 201);
            this.txtWorkerUsername.Name = "txtWorkerUsername";
            this.txtWorkerUsername.Size = new System.Drawing.Size(377, 20);
            this.txtWorkerUsername.TabIndex = 2;
            // 
            // txtWorkerEmail
            // 
            this.txtWorkerEmail.Location = new System.Drawing.Point(242, 162);
            this.txtWorkerEmail.Name = "txtWorkerEmail";
            this.txtWorkerEmail.Size = new System.Drawing.Size(377, 20);
            this.txtWorkerEmail.TabIndex = 2;
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.Location = new System.Drawing.Point(242, 81);
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(377, 20);
            this.txtWorkerName.TabIndex = 2;
            // 
            // cmbWorkerSelect
            // 
            this.cmbWorkerSelect.FormattingEnabled = true;
            this.cmbWorkerSelect.Items.AddRange(new object[] {
            "--New Worker--"});
            this.cmbWorkerSelect.Location = new System.Drawing.Point(242, 43);
            this.cmbWorkerSelect.Name = "cmbWorkerSelect";
            this.cmbWorkerSelect.Size = new System.Drawing.Size(377, 21);
            this.cmbWorkerSelect.TabIndex = 1;
            this.cmbWorkerSelect.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerSelect_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(44, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Worker Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(44, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Worker E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(44, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Worker Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Worker Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(44, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Worker Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Worker Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Worker:";
            // 
            // WorkerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(680, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerOperations";
            this.Text = "WorkerOperations";
            this.Load += new System.EventHandler(this.WorkerOperations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox txtWorkerName;
        private System.Windows.Forms.ComboBox cmbWorkerSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnUpdateWorker;
        private System.Windows.Forms.TextBox txtWorkerLastname;
        private System.Windows.Forms.TextBox txtWorkerSalary;
        private System.Windows.Forms.TextBox txtWorkerUsername;
        private System.Windows.Forms.TextBox txtWorkerEmail;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label8;
    }
}