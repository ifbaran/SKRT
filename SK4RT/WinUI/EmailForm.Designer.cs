namespace WinUI
{
    partial class EmailForm
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
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChoise = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radWorker = new System.Windows.Forms.RadioButton();
            this.radCustomer = new System.Windows.Forms.RadioButton();
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
            this.panel1.Size = new System.Drawing.Size(710, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.4F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(294, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send E-Mail";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WinUI.Properties.Resources.closeButton;
            this.btnClose.Location = new System.Drawing.Point(680, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.cmbContact);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSubject);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblChoise);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radWorker);
            this.panel2.Controls.Add(this.radCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 533);
            this.panel2.TabIndex = 1;
            // 
            // cmbContact
            // 
            this.cmbContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.cmbContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbContact.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(229, 76);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(393, 25);
            this.cmbContact.TabIndex = 4;
            this.cmbContact.SelectedIndexChanged += new System.EventHandler(this.cmbContact_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(229, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSubject.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSubject.Location = new System.Drawing.Point(229, 174);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(393, 24);
            this.txtSubject.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMessage.Location = new System.Drawing.Point(229, 228);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(393, 219);
            this.txtMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSend.Location = new System.Drawing.Point(229, 462);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(393, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(51, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Message:";
            // 
            // lblChoise
            // 
            this.lblChoise.AutoSize = true;
            this.lblChoise.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblChoise.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChoise.Location = new System.Drawing.Point(51, 77);
            this.lblChoise.Name = "lblChoise";
            this.lblChoise.Size = new System.Drawing.Size(44, 19);
            this.lblChoise.TabIndex = 1;
            this.lblChoise.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(51, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(51, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Select(Customer/ Worker):";
            // 
            // radWorker
            // 
            this.radWorker.AutoSize = true;
            this.radWorker.FlatAppearance.BorderSize = 0;
            this.radWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radWorker.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.radWorker.ForeColor = System.Drawing.Color.Gainsboro;
            this.radWorker.Location = new System.Drawing.Point(548, 20);
            this.radWorker.Name = "radWorker";
            this.radWorker.Size = new System.Drawing.Size(74, 23);
            this.radWorker.TabIndex = 0;
            this.radWorker.TabStop = true;
            this.radWorker.Text = "Worker";
            this.radWorker.UseVisualStyleBackColor = true;
            this.radWorker.Click += new System.EventHandler(this.radContact_Click);
            // 
            // radCustomer
            // 
            this.radCustomer.AutoSize = true;
            this.radCustomer.FlatAppearance.BorderSize = 0;
            this.radCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.radCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.radCustomer.Location = new System.Drawing.Point(374, 20);
            this.radCustomer.Name = "radCustomer";
            this.radCustomer.Size = new System.Drawing.Size(91, 23);
            this.radCustomer.TabIndex = 0;
            this.radCustomer.TabStop = true;
            this.radCustomer.Text = "Customer";
            this.radCustomer.UseVisualStyleBackColor = true;
            this.radCustomer.Click += new System.EventHandler(this.radContact_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblChoise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radWorker;
        private System.Windows.Forms.RadioButton radCustomer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
    }
}