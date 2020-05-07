namespace WinUI
{
    partial class TicketSale
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTicketDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnTheater = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSaleTicket = new System.Windows.Forms.Button();
            this.txtChair = new System.Windows.Forms.TextBox();
            this.txtSaloon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtTheater = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 47);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WinUI.Properties.Resources.closeButton;
            this.button1.Location = new System.Drawing.Point(363, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 47);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.dateTicketDate);
            this.panel2.Controls.Add(this.btnFilm);
            this.panel2.Controls.Add(this.btnTheater);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnSaleTicket);
            this.panel2.Controls.Add(this.txtChair);
            this.panel2.Controls.Add(this.txtSaloon);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFilm);
            this.panel2.Controls.Add(this.txtTheater);
            this.panel2.Controls.Add(this.txtSession);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCustomer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 347);
            this.panel2.TabIndex = 5;
            // 
            // dateTicketDate
            // 
            this.dateTicketDate.Location = new System.Drawing.Point(159, 217);
            this.dateTicketDate.Name = "dateTicketDate";
            this.dateTicketDate.Size = new System.Drawing.Size(217, 20);
            this.dateTicketDate.TabIndex = 25;
            // 
            // btnFilm
            // 
            this.btnFilm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm.Location = new System.Drawing.Point(338, 57);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(38, 24);
            this.btnFilm.TabIndex = 22;
            this.btnFilm.Text = "...";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnTheater
            // 
            this.btnTheater.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTheater.Location = new System.Drawing.Point(338, 83);
            this.btnTheater.Name = "btnTheater";
            this.btnTheater.Size = new System.Drawing.Size(38, 23);
            this.btnTheater.TabIndex = 20;
            this.btnTheater.Text = "...";
            this.btnTheater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTheater.UseVisualStyleBackColor = true;
            this.btnTheater.Click += new System.EventHandler(this.btnTheater_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCustomer.Location = new System.Drawing.Point(338, 31);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(38, 24);
            this.btnCustomer.TabIndex = 18;
            this.btnCustomer.Text = "...";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSaleTicket
            // 
            this.btnSaleTicket.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSaleTicket.Location = new System.Drawing.Point(55, 267);
            this.btnSaleTicket.Name = "btnSaleTicket";
            this.btnSaleTicket.Size = new System.Drawing.Size(321, 40);
            this.btnSaleTicket.TabIndex = 17;
            this.btnSaleTicket.Text = "Sale Ticket";
            this.btnSaleTicket.UseVisualStyleBackColor = true;
            this.btnSaleTicket.Click += new System.EventHandler(this.btnSaleTicket_Click);
            // 
            // txtChair
            // 
            this.txtChair.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtChair.Location = new System.Drawing.Point(159, 109);
            this.txtChair.Name = "txtChair";
            this.txtChair.Size = new System.Drawing.Size(159, 24);
            this.txtChair.TabIndex = 15;
            // 
            // txtSaloon
            // 
            this.txtSaloon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSaloon.Location = new System.Drawing.Point(159, 161);
            this.txtSaloon.Name = "txtSaloon";
            this.txtSaloon.Size = new System.Drawing.Size(159, 24);
            this.txtSaloon.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(51, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(52, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chair:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(52, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saloon:";
            // 
            // txtFilm
            // 
            this.txtFilm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtFilm.Location = new System.Drawing.Point(159, 57);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(159, 24);
            this.txtFilm.TabIndex = 12;
            // 
            // txtTheater
            // 
            this.txtTheater.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTheater.Location = new System.Drawing.Point(159, 83);
            this.txtTheater.Name = "txtTheater";
            this.txtTheater.Size = new System.Drawing.Size(159, 24);
            this.txtTheater.TabIndex = 11;
            // 
            // txtSession
            // 
            this.txtSession.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSession.Location = new System.Drawing.Point(159, 135);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(159, 24);
            this.txtSession.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(52, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Theater:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(52, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Session:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCustomer.Location = new System.Drawing.Point(159, 31);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(159, 24);
            this.txtCustomer.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer:";
            // 
            // TicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketSale";
            this.Text = "TicketSale";
            this.Load += new System.EventHandler(this.TicketSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnTheater;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSaleTicket;
        private System.Windows.Forms.TextBox txtChair;
        private System.Windows.Forms.TextBox txtSaloon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtTheater;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTicketDate;
        private System.Windows.Forms.Label label8;
    }
}