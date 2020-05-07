using System.Windows.Forms;

namespace WinUI
{
    partial class SK4RT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SK4RT));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.btnShowTicket = new System.Windows.Forms.Button();
            this.btnShowTheaters = new System.Windows.Forms.Button();
            this.btnShowFilm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowWorker = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panelFilms = new System.Windows.Forms.Panel();
            this.btnFilm5 = new System.Windows.Forms.Button();
            this.btnFilm4 = new System.Windows.Forms.Button();
            this.btnFilm3 = new System.Windows.Forms.Button();
            this.btnFilm2 = new System.Windows.Forms.Button();
            this.btnFilm1 = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnTicketOperations = new System.Windows.Forms.Button();
            this.btnWorkerOperations = new System.Windows.Forms.Button();
            this.btnCustomerOperations = new System.Windows.Forms.Button();
            this.btnFilmOperations = new System.Windows.Forms.Button();
            this.btnTheaterOperations = new System.Windows.Forms.Button();
            this.btnSessionSaloon = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFilms.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.lblEmployeeName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1634, 46);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1602, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(795, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(229, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Software Kiosque 4 Art";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.panelShow);
            this.panelMenu.Controls.Add(this.btnShow);
            this.panelMenu.Controls.Add(this.panelFilms);
            this.panelMenu.Controls.Add(this.btnFilms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 834);
            this.panelMenu.TabIndex = 0;
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContact.Location = new System.Drawing.Point(0, 546);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(253, 53);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Send E-Mail";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.btnShowTicket);
            this.panelShow.Controls.Add(this.btnShowTheaters);
            this.panelShow.Controls.Add(this.btnShowFilm);
            this.panelShow.Controls.Add(this.panel1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShow.Location = new System.Drawing.Point(0, 376);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(253, 170);
            this.panelShow.TabIndex = 12;
            // 
            // btnShowTicket
            // 
            this.btnShowTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShowTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowTicket.FlatAppearance.BorderSize = 0;
            this.btnShowTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTicket.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnShowTicket.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowTicket.Location = new System.Drawing.Point(0, 136);
            this.btnShowTicket.Name = "btnShowTicket";
            this.btnShowTicket.Size = new System.Drawing.Size(253, 34);
            this.btnShowTicket.TabIndex = 0;
            this.btnShowTicket.Text = "Ticket";
            this.btnShowTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTicket.UseVisualStyleBackColor = false;
            this.btnShowTicket.Click += new System.EventHandler(this.btnShowTicket_Click);
            // 
            // btnShowTheaters
            // 
            this.btnShowTheaters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShowTheaters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowTheaters.FlatAppearance.BorderSize = 0;
            this.btnShowTheaters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTheaters.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnShowTheaters.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowTheaters.Location = new System.Drawing.Point(0, 102);
            this.btnShowTheaters.Name = "btnShowTheaters";
            this.btnShowTheaters.Size = new System.Drawing.Size(253, 34);
            this.btnShowTheaters.TabIndex = 0;
            this.btnShowTheaters.Text = "Theater";
            this.btnShowTheaters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTheaters.UseVisualStyleBackColor = false;
            this.btnShowTheaters.Click += new System.EventHandler(this.btnShowTheaters_Click);
            // 
            // btnShowFilm
            // 
            this.btnShowFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShowFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFilm.FlatAppearance.BorderSize = 0;
            this.btnShowFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFilm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnShowFilm.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowFilm.Location = new System.Drawing.Point(0, 68);
            this.btnShowFilm.Name = "btnShowFilm";
            this.btnShowFilm.Size = new System.Drawing.Size(253, 34);
            this.btnShowFilm.TabIndex = 9;
            this.btnShowFilm.Text = "Film";
            this.btnShowFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFilm.UseVisualStyleBackColor = false;
            this.btnShowFilm.Click += new System.EventHandler(this.btnShowFilm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowWorker);
            this.panel1.Controls.Add(this.btnShowCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 68);
            this.panel1.TabIndex = 8;
            // 
            // btnShowWorker
            // 
            this.btnShowWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShowWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowWorker.FlatAppearance.BorderSize = 0;
            this.btnShowWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWorker.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnShowWorker.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowWorker.Location = new System.Drawing.Point(0, 34);
            this.btnShowWorker.Name = "btnShowWorker";
            this.btnShowWorker.Size = new System.Drawing.Size(253, 34);
            this.btnShowWorker.TabIndex = 9;
            this.btnShowWorker.Text = "Worker";
            this.btnShowWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowWorker.UseVisualStyleBackColor = false;
            this.btnShowWorker.Click += new System.EventHandler(this.btnShowWorker_Click);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShowCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCustomer.FlatAppearance.BorderSize = 0;
            this.btnShowCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnShowCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(253, 34);
            this.btnShowCustomer.TabIndex = 8;
            this.btnShowCustomer.Text = "Customer";
            this.btnShowCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCustomer.UseVisualStyleBackColor = false;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShow.Location = new System.Drawing.Point(0, 323);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(253, 53);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnMusteriListe_MouseLeave);
            this.btnShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMusteriListe_MouseMove);
            // 
            // panelFilms
            // 
            this.panelFilms.Controls.Add(this.btnFilm5);
            this.panelFilms.Controls.Add(this.btnFilm4);
            this.panelFilms.Controls.Add(this.btnFilm3);
            this.panelFilms.Controls.Add(this.btnFilm2);
            this.panelFilms.Controls.Add(this.btnFilm1);
            this.panelFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilms.Location = new System.Drawing.Point(0, 153);
            this.panelFilms.Name = "panelFilms";
            this.panelFilms.Size = new System.Drawing.Size(253, 170);
            this.panelFilms.TabIndex = 2;
            // 
            // btnFilm5
            // 
            this.btnFilm5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFilm5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm5.FlatAppearance.BorderSize = 0;
            this.btnFilm5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm5.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilm5.Location = new System.Drawing.Point(0, 136);
            this.btnFilm5.Name = "btnFilm5";
            this.btnFilm5.Size = new System.Drawing.Size(253, 34);
            this.btnFilm5.TabIndex = 6;
            this.btnFilm5.Text = "Film 5";
            this.btnFilm5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm5.UseVisualStyleBackColor = false;
            this.btnFilm5.Click += new System.EventHandler(this.btnFilm5_Click);
            // 
            // btnFilm4
            // 
            this.btnFilm4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFilm4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm4.FlatAppearance.BorderSize = 0;
            this.btnFilm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm4.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilm4.Location = new System.Drawing.Point(0, 102);
            this.btnFilm4.Name = "btnFilm4";
            this.btnFilm4.Size = new System.Drawing.Size(253, 34);
            this.btnFilm4.TabIndex = 5;
            this.btnFilm4.Text = "Film 4";
            this.btnFilm4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm4.UseVisualStyleBackColor = false;
            this.btnFilm4.Click += new System.EventHandler(this.btnFilm4_Click);
            // 
            // btnFilm3
            // 
            this.btnFilm3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFilm3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm3.FlatAppearance.BorderSize = 0;
            this.btnFilm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm3.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilm3.Location = new System.Drawing.Point(0, 68);
            this.btnFilm3.Name = "btnFilm3";
            this.btnFilm3.Size = new System.Drawing.Size(253, 34);
            this.btnFilm3.TabIndex = 4;
            this.btnFilm3.Text = "Film 3";
            this.btnFilm3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm3.UseVisualStyleBackColor = false;
            this.btnFilm3.Click += new System.EventHandler(this.btnFilm3_Click);
            // 
            // btnFilm2
            // 
            this.btnFilm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFilm2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm2.FlatAppearance.BorderSize = 0;
            this.btnFilm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm2.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilm2.Location = new System.Drawing.Point(0, 34);
            this.btnFilm2.Name = "btnFilm2";
            this.btnFilm2.Size = new System.Drawing.Size(253, 34);
            this.btnFilm2.TabIndex = 3;
            this.btnFilm2.Text = "Film 2";
            this.btnFilm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm2.UseVisualStyleBackColor = false;
            this.btnFilm2.Click += new System.EventHandler(this.btnFilm2_Click);
            // 
            // btnFilm1
            // 
            this.btnFilm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFilm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm1.FlatAppearance.BorderSize = 0;
            this.btnFilm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilm1.ForeColor = System.Drawing.Color.LightGray;
            this.btnFilm1.Location = new System.Drawing.Point(0, 0);
            this.btnFilm1.Name = "btnFilm1";
            this.btnFilm1.Size = new System.Drawing.Size(253, 34);
            this.btnFilm1.TabIndex = 2;
            this.btnFilm1.Text = "Film 1";
            this.btnFilm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm1.UseVisualStyleBackColor = false;
            this.btnFilm1.Click += new System.EventHandler(this.btnFilm1_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.btnFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFilms.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilms.Location = new System.Drawing.Point(0, 100);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(253, 53);
            this.btnFilms.TabIndex = 1;
            this.btnFilms.Text = "Films";
            this.btnFilms.UseVisualStyleBackColor = false;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            this.btnFilms.MouseLeave += new System.EventHandler(this.btnFilms_MouseLeave);
            this.btnFilms.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFilms_MouseMove);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(253, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.panelFooter.Controls.Add(this.btnTicketOperations);
            this.panelFooter.Controls.Add(this.btnWorkerOperations);
            this.panelFooter.Controls.Add(this.btnCustomerOperations);
            this.panelFooter.Controls.Add(this.btnFilmOperations);
            this.panelFooter.Controls.Add(this.btnTheaterOperations);
            this.panelFooter.Controls.Add(this.btnSessionSaloon);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(253, 780);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1381, 100);
            this.panelFooter.TabIndex = 2;
            // 
            // btnTicketOperations
            // 
            this.btnTicketOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTicketOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTicketOperations.ForeColor = System.Drawing.Color.Black;
            this.btnTicketOperations.Location = new System.Drawing.Point(720, 25);
            this.btnTicketOperations.Name = "btnTicketOperations";
            this.btnTicketOperations.Size = new System.Drawing.Size(150, 50);
            this.btnTicketOperations.TabIndex = 13;
            this.btnTicketOperations.Text = "Ticket Operations";
            this.btnTicketOperations.UseVisualStyleBackColor = false;
            this.btnTicketOperations.Click += new System.EventHandler(this.btnTicketOperations_Click);
            // 
            // btnWorkerOperations
            // 
            this.btnWorkerOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWorkerOperations.FlatAppearance.BorderSize = 0;
            this.btnWorkerOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnWorkerOperations.ForeColor = System.Drawing.Color.Black;
            this.btnWorkerOperations.Location = new System.Drawing.Point(1166, 25);
            this.btnWorkerOperations.Name = "btnWorkerOperations";
            this.btnWorkerOperations.Size = new System.Drawing.Size(150, 50);
            this.btnWorkerOperations.TabIndex = 12;
            this.btnWorkerOperations.Text = "Worker Operations";
            this.btnWorkerOperations.UseVisualStyleBackColor = false;
            this.btnWorkerOperations.Click += new System.EventHandler(this.btnWorkerOperations_Click);
            // 
            // btnCustomerOperations
            // 
            this.btnCustomerOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCustomerOperations.FlatAppearance.BorderSize = 0;
            this.btnCustomerOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCustomerOperations.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerOperations.Location = new System.Drawing.Point(489, 25);
            this.btnCustomerOperations.Name = "btnCustomerOperations";
            this.btnCustomerOperations.Size = new System.Drawing.Size(150, 50);
            this.btnCustomerOperations.TabIndex = 12;
            this.btnCustomerOperations.Text = "Customer Operations";
            this.btnCustomerOperations.UseVisualStyleBackColor = false;
            this.btnCustomerOperations.Click += new System.EventHandler(this.btnCustomerOperations_Click);
            // 
            // btnFilmOperations
            // 
            this.btnFilmOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFilmOperations.FlatAppearance.BorderSize = 0;
            this.btnFilmOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFilmOperations.ForeColor = System.Drawing.Color.Black;
            this.btnFilmOperations.Location = new System.Drawing.Point(270, 25);
            this.btnFilmOperations.Name = "btnFilmOperations";
            this.btnFilmOperations.Size = new System.Drawing.Size(150, 50);
            this.btnFilmOperations.TabIndex = 12;
            this.btnFilmOperations.Text = "Film Operations";
            this.btnFilmOperations.UseVisualStyleBackColor = false;
            this.btnFilmOperations.Click += new System.EventHandler(this.btnFilmOperations_Click);
            // 
            // btnTheaterOperations
            // 
            this.btnTheaterOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTheaterOperations.FlatAppearance.BorderSize = 0;
            this.btnTheaterOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheaterOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTheaterOperations.ForeColor = System.Drawing.Color.Black;
            this.btnTheaterOperations.Location = new System.Drawing.Point(952, 25);
            this.btnTheaterOperations.Name = "btnTheaterOperations";
            this.btnTheaterOperations.Size = new System.Drawing.Size(150, 50);
            this.btnTheaterOperations.TabIndex = 12;
            this.btnTheaterOperations.Text = "Theater Operations";
            this.btnTheaterOperations.UseVisualStyleBackColor = false;
            this.btnTheaterOperations.Click += new System.EventHandler(this.btnTheaterOperations_Click);
            // 
            // btnSessionSaloon
            // 
            this.btnSessionSaloon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSessionSaloon.FlatAppearance.BorderSize = 0;
            this.btnSessionSaloon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionSaloon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSessionSaloon.ForeColor = System.Drawing.Color.Black;
            this.btnSessionSaloon.Location = new System.Drawing.Point(50, 25);
            this.btnSessionSaloon.Name = "btnSessionSaloon";
            this.btnSessionSaloon.Size = new System.Drawing.Size(150, 50);
            this.btnSessionSaloon.TabIndex = 12;
            this.btnSessionSaloon.Text = "Session && Saloon Operations";
            this.btnSessionSaloon.UseVisualStyleBackColor = false;
            this.btnSessionSaloon.Click += new System.EventHandler(this.btnSessionSaloon_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(253, 46);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1381, 734);
            this.panelContent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 6;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmployeeName.Location = new System.Drawing.Point(215, 15);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 21);
            this.lblEmployeeName.TabIndex = 6;
            // 
            // SK4RT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1634, 880);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "SK4RT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Kiosque for Art";
            this.Load += new System.EventHandler(this.SK4RT_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelFilms.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SK4RT_ChangeUICues(object sender, System.Windows.Forms.UICuesEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblHeader;
        private Button btnClose;
        private Panel panelLogo;
        private Button btnFilms;
        private Panel panelFilms;
        private Button btnFilm5;
        private Button btnFilm4;
        private Button btnFilm3;
        private Button btnFilm2;
        private Panel panelFooter;
        private PictureBox picLogo;
        private Button btnContact;
        public Button btnFilm1;
        private Panel panelShow;
        private Panel panel1;
        private Button btnShowWorker;
        private Button btnShowCustomer;
        private Button btnShow;
        private Button btnCustomerOperations;
        private Button btnFilmOperations;
        private Button btnSessionSaloon;
        private Panel panelContent;
        private Button btnWorkerOperations;
        private Button btnShowFilm;
        private Button btnTheaterOperations;
        private Button btnShowTheaters;
        private Button btnShowTicket;
        private Button btnTicketOperations;
        private Label lblEmployeeName;
        private Label label1;
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, ClientRectangle, System.Drawing.Color as color ,ButtonBorderStyle.Solid);
        //}

    }
}

