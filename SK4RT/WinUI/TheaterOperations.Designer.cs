namespace WinUI
{
    partial class TheaterOperations
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTheaterSelect = new System.Windows.Forms.ComboBox();
            this.txtTheaterAuthor = new System.Windows.Forms.TextBox();
            this.txtTheaterPeriod = new System.Windows.Forms.TextBox();
            this.txtTheaterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTheater = new System.Windows.Forms.Button();
            this.btnUpdateTheater = new System.Windows.Forms.Button();
            this.btnAddTheater = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(332, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theater Operations";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WinUI.Properties.Resources.closeButton;
            this.btnClose.Location = new System.Drawing.Point(800, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.cmbTheaterSelect);
            this.panel2.Controls.Add(this.txtTheaterAuthor);
            this.panel2.Controls.Add(this.txtTheaterPeriod);
            this.panel2.Controls.Add(this.txtTheaterName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDeleteTheater);
            this.panel2.Controls.Add(this.btnUpdateTheater);
            this.panel2.Controls.Add(this.btnAddTheater);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 358);
            this.panel2.TabIndex = 1;
            // 
            // cmbTheaterSelect
            // 
            this.cmbTheaterSelect.FormattingEnabled = true;
            this.cmbTheaterSelect.Items.AddRange(new object[] {
            "--New Theater--"});
            this.cmbTheaterSelect.Location = new System.Drawing.Point(241, 42);
            this.cmbTheaterSelect.Name = "cmbTheaterSelect";
            this.cmbTheaterSelect.Size = new System.Drawing.Size(542, 24);
            this.cmbTheaterSelect.TabIndex = 3;
            this.cmbTheaterSelect.SelectedIndexChanged += new System.EventHandler(this.cmbTheaterSelect_SelectedIndexChanged);
            // 
            // txtTheaterAuthor
            // 
            this.txtTheaterAuthor.Location = new System.Drawing.Point(241, 148);
            this.txtTheaterAuthor.Name = "txtTheaterAuthor";
            this.txtTheaterAuthor.Size = new System.Drawing.Size(542, 21);
            this.txtTheaterAuthor.TabIndex = 2;
            // 
            // txtTheaterPeriod
            // 
            this.txtTheaterPeriod.Location = new System.Drawing.Point(241, 198);
            this.txtTheaterPeriod.Name = "txtTheaterPeriod";
            this.txtTheaterPeriod.Size = new System.Drawing.Size(542, 21);
            this.txtTheaterPeriod.TabIndex = 2;
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.Location = new System.Drawing.Point(241, 96);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.Size = new System.Drawing.Size(542, 21);
            this.txtTheaterName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(70, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Theater Period: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(70, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Theater Author: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(70, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Theater Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Theater:";
            // 
            // btnDeleteTheater
            // 
            this.btnDeleteTheater.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDeleteTheater.Location = new System.Drawing.Point(640, 260);
            this.btnDeleteTheater.Name = "btnDeleteTheater";
            this.btnDeleteTheater.Size = new System.Drawing.Size(143, 51);
            this.btnDeleteTheater.TabIndex = 0;
            this.btnDeleteTheater.Text = "Delete Theater";
            this.btnDeleteTheater.UseVisualStyleBackColor = true;
            this.btnDeleteTheater.Click += new System.EventHandler(this.btnDeleteTheater_Click);
            // 
            // btnUpdateTheater
            // 
            this.btnUpdateTheater.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnUpdateTheater.Location = new System.Drawing.Point(343, 260);
            this.btnUpdateTheater.Name = "btnUpdateTheater";
            this.btnUpdateTheater.Size = new System.Drawing.Size(143, 51);
            this.btnUpdateTheater.TabIndex = 0;
            this.btnUpdateTheater.Text = "Update Theater";
            this.btnUpdateTheater.UseVisualStyleBackColor = true;
            this.btnUpdateTheater.Click += new System.EventHandler(this.btnUpdateTheater_Click);
            // 
            // btnAddTheater
            // 
            this.btnAddTheater.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAddTheater.Location = new System.Drawing.Point(74, 260);
            this.btnAddTheater.Name = "btnAddTheater";
            this.btnAddTheater.Size = new System.Drawing.Size(143, 51);
            this.btnAddTheater.TabIndex = 0;
            this.btnAddTheater.Text = "Add Theater";
            this.btnAddTheater.UseVisualStyleBackColor = true;
            this.btnAddTheater.Click += new System.EventHandler(this.btnAddTheater_Click);
            // 
            // TheaterOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TheaterOperations";
            this.Text = "TheaterOperations";
            this.Load += new System.EventHandler(this.TheaterOperations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddTheater;
        private System.Windows.Forms.ComboBox cmbTheaterSelect;
        private System.Windows.Forms.TextBox txtTheaterAuthor;
        private System.Windows.Forms.TextBox txtTheaterPeriod;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteTheater;
        private System.Windows.Forms.Button btnUpdateTheater;
    }
}