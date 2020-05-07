namespace WinUI
{
    partial class TicketOperation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.txtTheaterId = new System.Windows.Forms.TextBox();
            this.txtChairId = new System.Windows.Forms.TextBox();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.txtSaloonId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdTicket = new System.Windows.Forms.DataGridView();
            this.dateTicketDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnChair = new System.Windows.Forms.Button();
            this.btnTheater = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnSaloon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.btnNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WinUI.Properties.Resources.closeButton;
            this.btnClose.Location = new System.Drawing.Point(939, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnNew.Controls.Add(this.btnTheater);
            this.btnNew.Controls.Add(this.btnChair);
            this.btnNew.Controls.Add(this.btnFilm);
            this.btnNew.Controls.Add(this.btnSaloon);
            this.btnNew.Controls.Add(this.btnSession);
            this.btnNew.Controls.Add(this.btnCustomer);
            this.btnNew.Controls.Add(this.dateTicketDate);
            this.btnNew.Controls.Add(this.grdTicket);
            this.btnNew.Controls.Add(this.button3);
            this.btnNew.Controls.Add(this.btnDelete);
            this.btnNew.Controls.Add(this.btnUpdate);
            this.btnNew.Controls.Add(this.txtChairId);
            this.btnNew.Controls.Add(this.txtTheaterId);
            this.btnNew.Controls.Add(this.txtFilmId);
            this.btnNew.Controls.Add(this.txtSaloonId);
            this.btnNew.Controls.Add(this.txtSessionId);
            this.btnNew.Controls.Add(this.txtCustomerId);
            this.btnNew.Controls.Add(this.label7);
            this.btnNew.Controls.Add(this.label4);
            this.btnNew.Controls.Add(this.label6);
            this.btnNew.Controls.Add(this.label3);
            this.btnNew.Controls.Add(this.label5);
            this.btnNew.Controls.Add(this.label2);
            this.btnNew.Controls.Add(this.label1);
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(0, 46);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(971, 609);
            this.btnNew.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(59, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ChairID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Theater ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(426, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ticket Operation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(461, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Session ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(461, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saloon ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(461, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ticket Date:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(201, 29);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(203, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtFilmId
            // 
            this.txtFilmId.Location = new System.Drawing.Point(201, 83);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(203, 20);
            this.txtFilmId.TabIndex = 1;
            // 
            // txtTheaterId
            // 
            this.txtTheaterId.Location = new System.Drawing.Point(201, 135);
            this.txtTheaterId.Name = "txtTheaterId";
            this.txtTheaterId.Size = new System.Drawing.Size(203, 20);
            this.txtTheaterId.TabIndex = 1;
            // 
            // txtChairId
            // 
            this.txtChairId.Location = new System.Drawing.Point(201, 186);
            this.txtChairId.Name = "txtChairId";
            this.txtChairId.Size = new System.Drawing.Size(203, 20);
            this.txtChairId.TabIndex = 1;
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(580, 59);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(203, 20);
            this.txtSessionId.TabIndex = 1;
            // 
            // txtSaloonId
            // 
            this.txtSaloonId.Location = new System.Drawing.Point(580, 106);
            this.txtSaloonId.Name = "txtSaloonId";
            this.txtSaloonId.Size = new System.Drawing.Size(203, 20);
            this.txtSaloonId.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(844, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDelete.Location = new System.Drawing.Point(844, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button3.Location = new System.Drawing.Point(844, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grdTicket
            // 
            this.grdTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTicket.Location = new System.Drawing.Point(0, 247);
            this.grdTicket.Name = "grdTicket";
            this.grdTicket.ReadOnly = true;
            this.grdTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTicket.Size = new System.Drawing.Size(971, 362);
            this.grdTicket.TabIndex = 3;
            this.grdTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTicket_CellClick);
            this.grdTicket.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdTicket_DataBindingComplete);
            // 
            // dateTicketDate
            // 
            this.dateTicketDate.Location = new System.Drawing.Point(580, 152);
            this.dateTicketDate.Name = "dateTicketDate";
            this.dateTicketDate.Size = new System.Drawing.Size(203, 20);
            this.dateTicketDate.TabIndex = 4;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(419, 30);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(31, 19);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "...";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(419, 83);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(31, 20);
            this.btnFilm.TabIndex = 5;
            this.btnFilm.Text = "...";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnChair
            // 
            this.btnChair.Location = new System.Drawing.Point(419, 184);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(31, 22);
            this.btnChair.TabIndex = 5;
            this.btnChair.Text = "...";
            this.btnChair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChair.UseVisualStyleBackColor = true;
            this.btnChair.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // btnTheater
            // 
            this.btnTheater.Location = new System.Drawing.Point(419, 135);
            this.btnTheater.Name = "btnTheater";
            this.btnTheater.Size = new System.Drawing.Size(31, 22);
            this.btnTheater.TabIndex = 5;
            this.btnTheater.Text = "...";
            this.btnTheater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTheater.UseVisualStyleBackColor = true;
            this.btnTheater.Click += new System.EventHandler(this.btnTheater_Click);
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(798, 59);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(31, 19);
            this.btnSession.TabIndex = 5;
            this.btnSession.Text = "...";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnSaloon
            // 
            this.btnSaloon.Location = new System.Drawing.Point(798, 106);
            this.btnSaloon.Name = "btnSaloon";
            this.btnSaloon.Size = new System.Drawing.Size(31, 19);
            this.btnSaloon.TabIndex = 5;
            this.btnSaloon.Text = "...";
            this.btnSaloon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaloon.UseVisualStyleBackColor = true;
            this.btnSaloon.Click += new System.EventHandler(this.btnSaloon_Click);
            // 
            // TicketOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 655);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketOperation";
            this.Text = "TicketOperation";
            this.Load += new System.EventHandler(this.TicketOperation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnNew.ResumeLayout(false);
            this.btnNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdTicket;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtChairId;
        private System.Windows.Forms.TextBox txtTheaterId;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.TextBox txtSaloonId;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTicketDate;
        private System.Windows.Forms.Button btnTheater;
        private System.Windows.Forms.Button btnChair;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnSaloon;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnCustomer;
    }
}