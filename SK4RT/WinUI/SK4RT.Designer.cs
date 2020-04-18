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
            this.panelContact = new System.Windows.Forms.Panel();
            this.btnSendMailWorker = new System.Windows.Forms.Button();
            this.btnSendMailCustomer = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowWorker = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panelTheaters = new System.Windows.Forms.Panel();
            this.btnThe5 = new System.Windows.Forms.Button();
            this.btnThe4 = new System.Windows.Forms.Button();
            this.btnThe3 = new System.Windows.Forms.Button();
            this.btnThe2 = new System.Windows.Forms.Button();
            this.btnThe1 = new System.Windows.Forms.Button();
            this.btnTheatres = new System.Windows.Forms.Button();
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.btn_FilmOperations = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContact.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTheaters.SuspendLayout();
            this.panelFilms.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
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
            this.panelMenu.Controls.Add(this.panelContact);
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.panelShow);
            this.panelMenu.Controls.Add(this.btnShow);
            this.panelMenu.Controls.Add(this.panelTheaters);
            this.panelMenu.Controls.Add(this.btnTheatres);
            this.panelMenu.Controls.Add(this.panelFilms);
            this.panelMenu.Controls.Add(this.btnFilms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 834);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.btnSendMailWorker);
            this.panelContact.Controls.Add(this.btnSendMailCustomer);
            this.panelContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContact.Location = new System.Drawing.Point(0, 721);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(253, 68);
            this.panelContact.TabIndex = 7;
            // 
            // btnSendMailWorker
            // 
            this.btnSendMailWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSendMailWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSendMailWorker.FlatAppearance.BorderSize = 0;
            this.btnSendMailWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMailWorker.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSendMailWorker.ForeColor = System.Drawing.Color.LightGray;
            this.btnSendMailWorker.Location = new System.Drawing.Point(0, 34);
            this.btnSendMailWorker.Name = "btnSendMailWorker";
            this.btnSendMailWorker.Size = new System.Drawing.Size(253, 34);
            this.btnSendMailWorker.TabIndex = 9;
            this.btnSendMailWorker.Text = "Worker";
            this.btnSendMailWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMailWorker.UseVisualStyleBackColor = false;
            this.btnSendMailWorker.Click += new System.EventHandler(this.btnSendMailWorker_Click);
            // 
            // btnSendMailCustomer
            // 
            this.btnSendMailCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSendMailCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSendMailCustomer.FlatAppearance.BorderSize = 0;
            this.btnSendMailCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMailCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSendMailCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.btnSendMailCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnSendMailCustomer.Name = "btnSendMailCustomer";
            this.btnSendMailCustomer.Size = new System.Drawing.Size(253, 34);
            this.btnSendMailCustomer.TabIndex = 8;
            this.btnSendMailCustomer.Text = "Customer";
            this.btnSendMailCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMailCustomer.UseVisualStyleBackColor = false;
            this.btnSendMailCustomer.Click += new System.EventHandler(this.btnSendMailCustomer_Click);
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContact.Location = new System.Drawing.Point(0, 668);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(253, 53);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Send E-Mail";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.panel1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShow.Location = new System.Drawing.Point(0, 600);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(253, 68);
            this.panelShow.TabIndex = 12;
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
            this.btnShow.Location = new System.Drawing.Point(0, 547);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(253, 53);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnList_Click);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnMusteriListe_MouseLeave);
            this.btnShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMusteriListe_MouseMove);
            // 
            // panelTheaters
            // 
            this.panelTheaters.Controls.Add(this.btnThe5);
            this.panelTheaters.Controls.Add(this.btnThe4);
            this.panelTheaters.Controls.Add(this.btnThe3);
            this.panelTheaters.Controls.Add(this.btnThe2);
            this.panelTheaters.Controls.Add(this.btnThe1);
            this.panelTheaters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheaters.Location = new System.Drawing.Point(0, 376);
            this.panelTheaters.Name = "panelTheaters";
            this.panelTheaters.Size = new System.Drawing.Size(253, 171);
            this.panelTheaters.TabIndex = 4;
            // 
            // btnThe5
            // 
            this.btnThe5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThe5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThe5.FlatAppearance.BorderSize = 0;
            this.btnThe5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnThe5.ForeColor = System.Drawing.Color.LightGray;
            this.btnThe5.Location = new System.Drawing.Point(0, 136);
            this.btnThe5.Name = "btnThe5";
            this.btnThe5.Size = new System.Drawing.Size(253, 34);
            this.btnThe5.TabIndex = 11;
            this.btnThe5.Text = "Theater 5";
            this.btnThe5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe5.UseVisualStyleBackColor = false;
            this.btnThe5.Click += new System.EventHandler(this.btnThe5_Click);
            // 
            // btnThe4
            // 
            this.btnThe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThe4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThe4.FlatAppearance.BorderSize = 0;
            this.btnThe4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnThe4.ForeColor = System.Drawing.Color.LightGray;
            this.btnThe4.Location = new System.Drawing.Point(0, 102);
            this.btnThe4.Name = "btnThe4";
            this.btnThe4.Size = new System.Drawing.Size(253, 34);
            this.btnThe4.TabIndex = 10;
            this.btnThe4.Text = "Theater 4";
            this.btnThe4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe4.UseVisualStyleBackColor = false;
            this.btnThe4.Click += new System.EventHandler(this.btnThe4_Click);
            // 
            // btnThe3
            // 
            this.btnThe3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThe3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThe3.FlatAppearance.BorderSize = 0;
            this.btnThe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnThe3.ForeColor = System.Drawing.Color.LightGray;
            this.btnThe3.Location = new System.Drawing.Point(0, 68);
            this.btnThe3.Name = "btnThe3";
            this.btnThe3.Size = new System.Drawing.Size(253, 34);
            this.btnThe3.TabIndex = 9;
            this.btnThe3.Text = "Theater 3";
            this.btnThe3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe3.UseVisualStyleBackColor = false;
            this.btnThe3.Click += new System.EventHandler(this.btnThe3_Click);
            // 
            // btnThe2
            // 
            this.btnThe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThe2.FlatAppearance.BorderSize = 0;
            this.btnThe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnThe2.ForeColor = System.Drawing.Color.LightGray;
            this.btnThe2.Location = new System.Drawing.Point(0, 34);
            this.btnThe2.Name = "btnThe2";
            this.btnThe2.Size = new System.Drawing.Size(253, 34);
            this.btnThe2.TabIndex = 8;
            this.btnThe2.Text = "Theater 2";
            this.btnThe2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe2.UseVisualStyleBackColor = false;
            this.btnThe2.Click += new System.EventHandler(this.btnThe2_Click);
            // 
            // btnThe1
            // 
            this.btnThe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThe1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThe1.FlatAppearance.BorderSize = 0;
            this.btnThe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnThe1.ForeColor = System.Drawing.Color.LightGray;
            this.btnThe1.Location = new System.Drawing.Point(0, 0);
            this.btnThe1.Name = "btnThe1";
            this.btnThe1.Size = new System.Drawing.Size(253, 34);
            this.btnThe1.TabIndex = 7;
            this.btnThe1.Text = "Theater 1";
            this.btnThe1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe1.UseVisualStyleBackColor = false;
            this.btnThe1.Click += new System.EventHandler(this.btnThe1_Click);
            // 
            // btnTheatres
            // 
            this.btnTheatres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheatres.FlatAppearance.BorderSize = 0;
            this.btnTheatres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheatres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnTheatres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTheatres.Location = new System.Drawing.Point(0, 323);
            this.btnTheatres.Name = "btnTheatres";
            this.btnTheatres.Size = new System.Drawing.Size(253, 53);
            this.btnTheatres.TabIndex = 3;
            this.btnTheatres.Text = "Theaters";
            this.btnTheatres.UseVisualStyleBackColor = true;
            this.btnTheatres.Click += new System.EventHandler(this.btnTheatres_Click);
            this.btnTheatres.MouseLeave += new System.EventHandler(this.btnTheatres_MouseLeave);
            this.btnTheatres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTheatres_MouseMove);
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
            this.panelFooter.Controls.Add(this.button2);
            this.panelFooter.Controls.Add(this.button1);
            this.panelFooter.Controls.Add(this.btn_FilmOperations);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(253, 780);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1381, 100);
            this.panelFooter.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(253, 46);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1381, 734);
            this.panelContent.TabIndex = 4;
            // 
            // btn_FilmOperations
            // 
            this.btn_FilmOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_FilmOperations.FlatAppearance.BorderSize = 0;
            this.btn_FilmOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilmOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_FilmOperations.ForeColor = System.Drawing.Color.Black;
            this.btn_FilmOperations.Location = new System.Drawing.Point(50, 25);
            this.btn_FilmOperations.Name = "btn_FilmOperations";
            this.btn_FilmOperations.Size = new System.Drawing.Size(150, 50);
            this.btn_FilmOperations.TabIndex = 12;
            this.btn_FilmOperations.Text = "Film Operations";
            this.btn_FilmOperations.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(219, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Film Operations";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(390, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Film Operations";
            this.button2.UseVisualStyleBackColor = false;
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
            this.panelContact.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTheaters.ResumeLayout(false);
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
        private Button btnTheatres;
        private PictureBox picLogo;
        private Panel panelTheaters;
        private Button btnThe5;
        private Button btnThe4;
        private Button btnThe3;
        private Button btnThe2;
        private Button btnThe1;
        private Button btnContact;
        private Panel panelContact;
        private Button btnSendMailWorker;
        private Button btnSendMailCustomer;
        public Button btnFilm1;
        private Panel panelShow;
        private Panel panel1;
        private Button btnShowWorker;
        private Button btnShowCustomer;
        private Button btnShow;
        private Button button2;
        private Button button1;
        private Button btn_FilmOperations;
        private Panel panelContent;
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, ClientRectangle, System.Drawing.Color as color ,ButtonBorderStyle.Solid);
        //}

    }
}

