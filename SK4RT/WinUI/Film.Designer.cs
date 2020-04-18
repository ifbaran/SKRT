using System.Drawing;
using System.Drawing.Drawing2D;
namespace WinUI
{
    partial class Film
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film));
            this.labelFilmAdi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sK4RTDataSet = new WinUI.SK4RTDataSet();
            this.sessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.sessionTableAdapter = new WinUI.SK4RTDataSetTableAdapters.SessionTableAdapter();
            this.btnReservation = new System.Windows.Forms.Button();
            this.sessionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sK4RTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpCustomerData = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerChair = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button85 = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.button87 = new System.Windows.Forms.Button();
            this.button88 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.button90 = new System.Windows.Forms.Button();
            this.button91 = new System.Windows.Forms.Button();
            this.button92 = new System.Windows.Forms.Button();
            this.button93 = new System.Windows.Forms.Button();
            this.button94 = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.button96 = new System.Windows.Forms.Button();
            this.button73 = new System.Windows.Forms.Button();
            this.button74 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button76 = new System.Windows.Forms.Button();
            this.button77 = new System.Windows.Forms.Button();
            this.button78 = new System.Windows.Forms.Button();
            this.button79 = new System.Windows.Forms.Button();
            this.button80 = new System.Windows.Forms.Button();
            this.button81 = new System.Windows.Forms.Button();
            this.button82 = new System.Windows.Forms.Button();
            this.button83 = new System.Windows.Forms.Button();
            this.button84 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.button65 = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button68 = new System.Windows.Forms.Button();
            this.button69 = new System.Windows.Forms.Button();
            this.button70 = new System.Windows.Forms.Button();
            this.button71 = new System.Windows.Forms.Button();
            this.button72 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.buttonA12 = new System.Windows.Forms.Button();
            this.buttonA11 = new System.Windows.Forms.Button();
            this.buttonA10 = new System.Windows.Forms.Button();
            this.buttonA9 = new System.Windows.Forms.Button();
            this.buttonA8 = new System.Windows.Forms.Button();
            this.buttonA7 = new System.Windows.Forms.Button();
            this.buttonA6 = new System.Windows.Forms.Button();
            this.buttonA5 = new System.Windows.Forms.Button();
            this.buttonA4 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sK4RTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sK4RTDataSetBindingSource)).BeginInit();
            this.grpCustomerData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilmAdi
            // 
            this.labelFilmAdi.AutoSize = true;
            this.labelFilmAdi.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.labelFilmAdi.Location = new System.Drawing.Point(432, 78);
            this.labelFilmAdi.Name = "labelFilmAdi";
            this.labelFilmAdi.Size = new System.Drawing.Size(88, 37);
            this.labelFilmAdi.TabIndex = 0;
            this.labelFilmAdi.Text = "label";
            this.labelFilmAdi.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(211, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 46);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "C   U   R    T    A    I    N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(187, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Full Chairs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(469, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Empty Chairs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(813, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 103;
            this.label4.Text = "Double Chairs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(1139, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Your Choise";
            // 
            // cmbSession
            // 
            this.cmbSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.cmbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSession.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(1093, 91);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(244, 24);
            this.cmbSession.TabIndex = 105;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.sK4RTDataSet;
            // 
            // sK4RTDataSet
            // 
            this.sK4RTDataSet.DataSetName = "SK4RTDataSet";
            this.sK4RTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource1
            // 
            this.sessionBindingSource1.DataMember = "Session";
            this.sessionBindingSource1.DataSource = this.sK4RTDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label6.Location = new System.Drawing.Point(975, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "Session: ";
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnReservation.Location = new System.Drawing.Point(0, 0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(182, 75);
            this.btnReservation.TabIndex = 6;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            // 
            // sessionBindingSource2
            // 
            this.sessionBindingSource2.DataMember = "Session";
            this.sessionBindingSource2.DataSource = this.sK4RTDataSet;
            // 
            // sK4RTDataSetBindingSource
            // 
            this.sK4RTDataSetBindingSource.DataSource = this.sK4RTDataSet;
            this.sK4RTDataSetBindingSource.Position = 0;
            // 
            // grpCustomerData
            // 
            this.grpCustomerData.Controls.Add(this.panel2);
            this.grpCustomerData.Controls.Add(this.txtCustomerChair);
            this.grpCustomerData.Controls.Add(this.label10);
            this.grpCustomerData.Controls.Add(this.txtCustomerLastname);
            this.grpCustomerData.Controls.Add(this.txtCustomerEmail);
            this.grpCustomerData.Controls.Add(this.label8);
            this.grpCustomerData.Controls.Add(this.label9);
            this.grpCustomerData.Controls.Add(this.txtCustomerName);
            this.grpCustomerData.Controls.Add(this.label7);
            this.grpCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCustomerData.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.grpCustomerData.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCustomerData.Location = new System.Drawing.Point(976, 143);
            this.grpCustomerData.Name = "grpCustomerData";
            this.grpCustomerData.Size = new System.Drawing.Size(370, 490);
            this.grpCustomerData.TabIndex = 107;
            this.grpCustomerData.TabStop = false;
            this.grpCustomerData.Text = "Customer Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnReservation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 75);
            this.panel2.TabIndex = 105;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(210)))), ((int)(((byte)(201)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(182, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 75);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Reservation && Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseMove);
            // 
            // txtCustomerChair
            // 
            this.txtCustomerChair.Location = new System.Drawing.Point(107, 337);
            this.txtCustomerChair.Name = "txtCustomerChair";
            this.txtCustomerChair.Size = new System.Drawing.Size(231, 24);
            this.txtCustomerChair.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chair:";
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(107, 151);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(231, 24);
            this.txtCustomerLastname.TabIndex = 2;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(107, 244);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(231, 24);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Surname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "E-Mail";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(107, 63);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(231, 24);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1083, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 101;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(757, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // button85
            // 
            this.button85.BackColor = System.Drawing.Color.Transparent;
            this.button85.FlatAppearance.BorderSize = 0;
            this.button85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button85.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button85.ForeColor = System.Drawing.Color.Black;
            this.button85.Image = ((System.Drawing.Image)(resources.GetObject("button85.Image")));
            this.button85.Location = new System.Drawing.Point(862, 143);
            this.button85.Name = "button85";
            this.button85.Size = new System.Drawing.Size(51, 44);
            this.button85.TabIndex = 97;
            this.button85.Text = "H12";
            this.button85.UseVisualStyleBackColor = false;
            this.button85.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button86
            // 
            this.button86.BackColor = System.Drawing.Color.Transparent;
            this.button86.FlatAppearance.BorderSize = 0;
            this.button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button86.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button86.ForeColor = System.Drawing.Color.Black;
            this.button86.Image = ((System.Drawing.Image)(resources.GetObject("button86.Image")));
            this.button86.Location = new System.Drawing.Point(792, 143);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(51, 44);
            this.button86.TabIndex = 96;
            this.button86.Text = "H11";
            this.button86.UseVisualStyleBackColor = false;
            this.button86.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button87
            // 
            this.button87.BackColor = System.Drawing.Color.Transparent;
            this.button87.FlatAppearance.BorderSize = 0;
            this.button87.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button87.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button87.ForeColor = System.Drawing.Color.Black;
            this.button87.Image = ((System.Drawing.Image)(resources.GetObject("button87.Image")));
            this.button87.Location = new System.Drawing.Point(722, 143);
            this.button87.Name = "button87";
            this.button87.Size = new System.Drawing.Size(51, 44);
            this.button87.TabIndex = 95;
            this.button87.Text = "H10";
            this.button87.UseVisualStyleBackColor = false;
            this.button87.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button88
            // 
            this.button88.BackColor = System.Drawing.Color.Transparent;
            this.button88.FlatAppearance.BorderSize = 0;
            this.button88.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button88.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button88.ForeColor = System.Drawing.Color.Black;
            this.button88.Image = ((System.Drawing.Image)(resources.GetObject("button88.Image")));
            this.button88.Location = new System.Drawing.Point(650, 143);
            this.button88.Name = "button88";
            this.button88.Size = new System.Drawing.Size(51, 44);
            this.button88.TabIndex = 94;
            this.button88.Text = "H9";
            this.button88.UseVisualStyleBackColor = false;
            this.button88.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button89
            // 
            this.button89.BackColor = System.Drawing.Color.Transparent;
            this.button89.FlatAppearance.BorderSize = 0;
            this.button89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button89.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button89.ForeColor = System.Drawing.Color.Black;
            this.button89.Image = ((System.Drawing.Image)(resources.GetObject("button89.Image")));
            this.button89.Location = new System.Drawing.Point(580, 143);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(51, 44);
            this.button89.TabIndex = 93;
            this.button89.Text = "H8";
            this.button89.UseVisualStyleBackColor = false;
            this.button89.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button90
            // 
            this.button90.BackColor = System.Drawing.Color.Transparent;
            this.button90.FlatAppearance.BorderSize = 0;
            this.button90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button90.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button90.ForeColor = System.Drawing.Color.Black;
            this.button90.Image = ((System.Drawing.Image)(resources.GetObject("button90.Image")));
            this.button90.Location = new System.Drawing.Point(510, 143);
            this.button90.Name = "button90";
            this.button90.Size = new System.Drawing.Size(51, 44);
            this.button90.TabIndex = 92;
            this.button90.Text = "H7";
            this.button90.UseVisualStyleBackColor = false;
            this.button90.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button91
            // 
            this.button91.BackColor = System.Drawing.Color.Transparent;
            this.button91.FlatAppearance.BorderSize = 0;
            this.button91.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button91.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button91.ForeColor = System.Drawing.Color.Black;
            this.button91.Image = ((System.Drawing.Image)(resources.GetObject("button91.Image")));
            this.button91.Location = new System.Drawing.Point(439, 143);
            this.button91.Name = "button91";
            this.button91.Size = new System.Drawing.Size(51, 44);
            this.button91.TabIndex = 91;
            this.button91.Text = "H6";
            this.button91.UseVisualStyleBackColor = false;
            this.button91.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button92
            // 
            this.button92.BackColor = System.Drawing.Color.Transparent;
            this.button92.FlatAppearance.BorderSize = 0;
            this.button92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button92.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button92.ForeColor = System.Drawing.Color.Black;
            this.button92.Image = ((System.Drawing.Image)(resources.GetObject("button92.Image")));
            this.button92.Location = new System.Drawing.Point(369, 143);
            this.button92.Name = "button92";
            this.button92.Size = new System.Drawing.Size(51, 44);
            this.button92.TabIndex = 90;
            this.button92.Text = "H5";
            this.button92.UseVisualStyleBackColor = false;
            this.button92.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button93
            // 
            this.button93.BackColor = System.Drawing.Color.Transparent;
            this.button93.FlatAppearance.BorderSize = 0;
            this.button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button93.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button93.ForeColor = System.Drawing.Color.Black;
            this.button93.Image = ((System.Drawing.Image)(resources.GetObject("button93.Image")));
            this.button93.Location = new System.Drawing.Point(299, 143);
            this.button93.Name = "button93";
            this.button93.Size = new System.Drawing.Size(51, 44);
            this.button93.TabIndex = 89;
            this.button93.Text = "H4";
            this.button93.UseVisualStyleBackColor = false;
            this.button93.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button94
            // 
            this.button94.BackColor = System.Drawing.Color.Transparent;
            this.button94.FlatAppearance.BorderSize = 0;
            this.button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button94.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button94.ForeColor = System.Drawing.Color.Black;
            this.button94.Image = ((System.Drawing.Image)(resources.GetObject("button94.Image")));
            this.button94.Location = new System.Drawing.Point(227, 143);
            this.button94.Name = "button94";
            this.button94.Size = new System.Drawing.Size(51, 44);
            this.button94.TabIndex = 88;
            this.button94.Text = "H3";
            this.button94.UseVisualStyleBackColor = false;
            this.button94.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button95
            // 
            this.button95.BackColor = System.Drawing.Color.Transparent;
            this.button95.FlatAppearance.BorderSize = 0;
            this.button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button95.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button95.ForeColor = System.Drawing.Color.Black;
            this.button95.Image = ((System.Drawing.Image)(resources.GetObject("button95.Image")));
            this.button95.Location = new System.Drawing.Point(157, 143);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(51, 44);
            this.button95.TabIndex = 87;
            this.button95.Text = "H2";
            this.button95.UseVisualStyleBackColor = false;
            this.button95.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button96
            // 
            this.button96.BackColor = System.Drawing.Color.Transparent;
            this.button96.FlatAppearance.BorderSize = 0;
            this.button96.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button96.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button96.ForeColor = System.Drawing.Color.Black;
            this.button96.Image = ((System.Drawing.Image)(resources.GetObject("button96.Image")));
            this.button96.Location = new System.Drawing.Point(87, 143);
            this.button96.Name = "button96";
            this.button96.Size = new System.Drawing.Size(51, 44);
            this.button96.TabIndex = 86;
            this.button96.Text = "H1";
            this.button96.UseVisualStyleBackColor = false;
            this.button96.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button73
            // 
            this.button73.BackColor = System.Drawing.Color.Transparent;
            this.button73.FlatAppearance.BorderSize = 0;
            this.button73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button73.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button73.ForeColor = System.Drawing.Color.Black;
            this.button73.Image = ((System.Drawing.Image)(resources.GetObject("button73.Image")));
            this.button73.Location = new System.Drawing.Point(905, 206);
            this.button73.Name = "button73";
            this.button73.Size = new System.Drawing.Size(51, 44);
            this.button73.TabIndex = 85;
            this.button73.Text = "G12";
            this.button73.UseVisualStyleBackColor = false;
            this.button73.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button74
            // 
            this.button74.BackColor = System.Drawing.Color.Transparent;
            this.button74.FlatAppearance.BorderSize = 0;
            this.button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button74.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button74.ForeColor = System.Drawing.Color.Black;
            this.button74.Image = ((System.Drawing.Image)(resources.GetObject("button74.Image")));
            this.button74.Location = new System.Drawing.Point(835, 206);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(51, 44);
            this.button74.TabIndex = 84;
            this.button74.Text = "G11";
            this.button74.UseVisualStyleBackColor = false;
            this.button74.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button75
            // 
            this.button75.BackColor = System.Drawing.Color.Transparent;
            this.button75.FlatAppearance.BorderSize = 0;
            this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button75.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button75.ForeColor = System.Drawing.Color.Black;
            this.button75.Image = ((System.Drawing.Image)(resources.GetObject("button75.Image")));
            this.button75.Location = new System.Drawing.Point(765, 206);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(51, 44);
            this.button75.TabIndex = 83;
            this.button75.Text = "G10";
            this.button75.UseVisualStyleBackColor = false;
            this.button75.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button76
            // 
            this.button76.BackColor = System.Drawing.Color.Transparent;
            this.button76.FlatAppearance.BorderSize = 0;
            this.button76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button76.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button76.ForeColor = System.Drawing.Color.Black;
            this.button76.Image = ((System.Drawing.Image)(resources.GetObject("button76.Image")));
            this.button76.Location = new System.Drawing.Point(693, 206);
            this.button76.Name = "button76";
            this.button76.Size = new System.Drawing.Size(51, 44);
            this.button76.TabIndex = 82;
            this.button76.Text = "G9";
            this.button76.UseVisualStyleBackColor = false;
            this.button76.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button77
            // 
            this.button77.BackColor = System.Drawing.Color.Transparent;
            this.button77.FlatAppearance.BorderSize = 0;
            this.button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button77.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button77.ForeColor = System.Drawing.Color.Black;
            this.button77.Image = ((System.Drawing.Image)(resources.GetObject("button77.Image")));
            this.button77.Location = new System.Drawing.Point(623, 206);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(51, 44);
            this.button77.TabIndex = 81;
            this.button77.Text = "G8";
            this.button77.UseVisualStyleBackColor = false;
            this.button77.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button78
            // 
            this.button78.BackColor = System.Drawing.Color.Transparent;
            this.button78.FlatAppearance.BorderSize = 0;
            this.button78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button78.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button78.ForeColor = System.Drawing.Color.Black;
            this.button78.Image = ((System.Drawing.Image)(resources.GetObject("button78.Image")));
            this.button78.Location = new System.Drawing.Point(553, 206);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(51, 44);
            this.button78.TabIndex = 80;
            this.button78.Text = "G7";
            this.button78.UseVisualStyleBackColor = false;
            this.button78.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button79
            // 
            this.button79.BackColor = System.Drawing.Color.Transparent;
            this.button79.FlatAppearance.BorderSize = 0;
            this.button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button79.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button79.ForeColor = System.Drawing.Color.Black;
            this.button79.Image = ((System.Drawing.Image)(resources.GetObject("button79.Image")));
            this.button79.Location = new System.Drawing.Point(482, 206);
            this.button79.Name = "button79";
            this.button79.Size = new System.Drawing.Size(51, 44);
            this.button79.TabIndex = 79;
            this.button79.Text = "G6";
            this.button79.UseVisualStyleBackColor = false;
            this.button79.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button80
            // 
            this.button80.BackColor = System.Drawing.Color.Transparent;
            this.button80.FlatAppearance.BorderSize = 0;
            this.button80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button80.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button80.ForeColor = System.Drawing.Color.Black;
            this.button80.Image = ((System.Drawing.Image)(resources.GetObject("button80.Image")));
            this.button80.Location = new System.Drawing.Point(412, 206);
            this.button80.Name = "button80";
            this.button80.Size = new System.Drawing.Size(51, 44);
            this.button80.TabIndex = 78;
            this.button80.Text = "G5";
            this.button80.UseVisualStyleBackColor = false;
            this.button80.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button81
            // 
            this.button81.BackColor = System.Drawing.Color.Transparent;
            this.button81.FlatAppearance.BorderSize = 0;
            this.button81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button81.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button81.ForeColor = System.Drawing.Color.Black;
            this.button81.Image = ((System.Drawing.Image)(resources.GetObject("button81.Image")));
            this.button81.Location = new System.Drawing.Point(342, 206);
            this.button81.Name = "button81";
            this.button81.Size = new System.Drawing.Size(51, 44);
            this.button81.TabIndex = 77;
            this.button81.Text = "G4";
            this.button81.UseVisualStyleBackColor = false;
            this.button81.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button82
            // 
            this.button82.BackColor = System.Drawing.Color.Transparent;
            this.button82.FlatAppearance.BorderSize = 0;
            this.button82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button82.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button82.ForeColor = System.Drawing.Color.Black;
            this.button82.Image = ((System.Drawing.Image)(resources.GetObject("button82.Image")));
            this.button82.Location = new System.Drawing.Point(270, 206);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(51, 44);
            this.button82.TabIndex = 76;
            this.button82.Text = "G3";
            this.button82.UseVisualStyleBackColor = false;
            this.button82.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button83
            // 
            this.button83.BackColor = System.Drawing.Color.Transparent;
            this.button83.FlatAppearance.BorderSize = 0;
            this.button83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button83.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button83.ForeColor = System.Drawing.Color.Black;
            this.button83.Image = ((System.Drawing.Image)(resources.GetObject("button83.Image")));
            this.button83.Location = new System.Drawing.Point(200, 206);
            this.button83.Name = "button83";
            this.button83.Size = new System.Drawing.Size(51, 44);
            this.button83.TabIndex = 75;
            this.button83.Text = "G2";
            this.button83.UseVisualStyleBackColor = false;
            this.button83.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button84
            // 
            this.button84.BackColor = System.Drawing.Color.Transparent;
            this.button84.FlatAppearance.BorderSize = 0;
            this.button84.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button84.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button84.ForeColor = System.Drawing.Color.Black;
            this.button84.Image = ((System.Drawing.Image)(resources.GetObject("button84.Image")));
            this.button84.Location = new System.Drawing.Point(130, 206);
            this.button84.Name = "button84";
            this.button84.Size = new System.Drawing.Size(51, 44);
            this.button84.TabIndex = 74;
            this.button84.Text = "G1";
            this.button84.UseVisualStyleBackColor = false;
            this.button84.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button61
            // 
            this.button61.BackColor = System.Drawing.Color.Transparent;
            this.button61.FlatAppearance.BorderSize = 0;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button61.ForeColor = System.Drawing.Color.Black;
            this.button61.Image = ((System.Drawing.Image)(resources.GetObject("button61.Image")));
            this.button61.Location = new System.Drawing.Point(862, 269);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(51, 44);
            this.button61.TabIndex = 73;
            this.button61.Text = "F12";
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button62
            // 
            this.button62.BackColor = System.Drawing.Color.Transparent;
            this.button62.FlatAppearance.BorderSize = 0;
            this.button62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button62.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button62.ForeColor = System.Drawing.Color.Black;
            this.button62.Image = ((System.Drawing.Image)(resources.GetObject("button62.Image")));
            this.button62.Location = new System.Drawing.Point(792, 269);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(51, 44);
            this.button62.TabIndex = 72;
            this.button62.Text = "F11";
            this.button62.UseVisualStyleBackColor = false;
            this.button62.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button63
            // 
            this.button63.BackColor = System.Drawing.Color.Transparent;
            this.button63.FlatAppearance.BorderSize = 0;
            this.button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button63.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button63.ForeColor = System.Drawing.Color.Black;
            this.button63.Image = ((System.Drawing.Image)(resources.GetObject("button63.Image")));
            this.button63.Location = new System.Drawing.Point(722, 269);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(51, 44);
            this.button63.TabIndex = 71;
            this.button63.Text = "F10";
            this.button63.UseVisualStyleBackColor = false;
            this.button63.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button64
            // 
            this.button64.BackColor = System.Drawing.Color.Transparent;
            this.button64.FlatAppearance.BorderSize = 0;
            this.button64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button64.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button64.ForeColor = System.Drawing.Color.Black;
            this.button64.Image = ((System.Drawing.Image)(resources.GetObject("button64.Image")));
            this.button64.Location = new System.Drawing.Point(650, 269);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(51, 44);
            this.button64.TabIndex = 70;
            this.button64.Text = "F9";
            this.button64.UseVisualStyleBackColor = false;
            this.button64.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button65
            // 
            this.button65.BackColor = System.Drawing.Color.Transparent;
            this.button65.FlatAppearance.BorderSize = 0;
            this.button65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button65.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button65.ForeColor = System.Drawing.Color.Black;
            this.button65.Image = ((System.Drawing.Image)(resources.GetObject("button65.Image")));
            this.button65.Location = new System.Drawing.Point(580, 269);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(51, 44);
            this.button65.TabIndex = 69;
            this.button65.Text = "F8";
            this.button65.UseVisualStyleBackColor = false;
            this.button65.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button66
            // 
            this.button66.BackColor = System.Drawing.Color.Transparent;
            this.button66.FlatAppearance.BorderSize = 0;
            this.button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button66.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button66.ForeColor = System.Drawing.Color.Black;
            this.button66.Image = ((System.Drawing.Image)(resources.GetObject("button66.Image")));
            this.button66.Location = new System.Drawing.Point(510, 269);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(51, 44);
            this.button66.TabIndex = 68;
            this.button66.Text = "F7";
            this.button66.UseVisualStyleBackColor = false;
            this.button66.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button67
            // 
            this.button67.BackColor = System.Drawing.Color.Transparent;
            this.button67.FlatAppearance.BorderSize = 0;
            this.button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button67.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button67.ForeColor = System.Drawing.Color.Black;
            this.button67.Image = ((System.Drawing.Image)(resources.GetObject("button67.Image")));
            this.button67.Location = new System.Drawing.Point(439, 269);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(51, 44);
            this.button67.TabIndex = 67;
            this.button67.Text = "F6";
            this.button67.UseVisualStyleBackColor = false;
            this.button67.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button68
            // 
            this.button68.BackColor = System.Drawing.Color.Transparent;
            this.button68.FlatAppearance.BorderSize = 0;
            this.button68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button68.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button68.ForeColor = System.Drawing.Color.Black;
            this.button68.Image = ((System.Drawing.Image)(resources.GetObject("button68.Image")));
            this.button68.Location = new System.Drawing.Point(369, 269);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(51, 44);
            this.button68.TabIndex = 66;
            this.button68.Text = "F5";
            this.button68.UseVisualStyleBackColor = false;
            this.button68.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button69
            // 
            this.button69.BackColor = System.Drawing.Color.Transparent;
            this.button69.FlatAppearance.BorderSize = 0;
            this.button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button69.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button69.ForeColor = System.Drawing.Color.Black;
            this.button69.Image = ((System.Drawing.Image)(resources.GetObject("button69.Image")));
            this.button69.Location = new System.Drawing.Point(299, 269);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(51, 44);
            this.button69.TabIndex = 65;
            this.button69.Text = "F4";
            this.button69.UseVisualStyleBackColor = false;
            this.button69.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button70
            // 
            this.button70.BackColor = System.Drawing.Color.Transparent;
            this.button70.FlatAppearance.BorderSize = 0;
            this.button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button70.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button70.ForeColor = System.Drawing.Color.Black;
            this.button70.Image = ((System.Drawing.Image)(resources.GetObject("button70.Image")));
            this.button70.Location = new System.Drawing.Point(227, 269);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(51, 44);
            this.button70.TabIndex = 64;
            this.button70.Text = "F3";
            this.button70.UseVisualStyleBackColor = false;
            this.button70.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button71
            // 
            this.button71.BackColor = System.Drawing.Color.Transparent;
            this.button71.FlatAppearance.BorderSize = 0;
            this.button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button71.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button71.ForeColor = System.Drawing.Color.Black;
            this.button71.Image = ((System.Drawing.Image)(resources.GetObject("button71.Image")));
            this.button71.Location = new System.Drawing.Point(157, 269);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(51, 44);
            this.button71.TabIndex = 63;
            this.button71.Text = "F2";
            this.button71.UseVisualStyleBackColor = false;
            this.button71.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button72
            // 
            this.button72.BackColor = System.Drawing.Color.Transparent;
            this.button72.FlatAppearance.BorderSize = 0;
            this.button72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button72.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button72.ForeColor = System.Drawing.Color.Black;
            this.button72.Image = ((System.Drawing.Image)(resources.GetObject("button72.Image")));
            this.button72.Location = new System.Drawing.Point(87, 273);
            this.button72.Name = "button72";
            this.button72.Size = new System.Drawing.Size(51, 44);
            this.button72.TabIndex = 62;
            this.button72.Text = "F1";
            this.button72.UseVisualStyleBackColor = false;
            this.button72.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.Transparent;
            this.button49.FlatAppearance.BorderSize = 0;
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button49.ForeColor = System.Drawing.Color.Black;
            this.button49.Image = ((System.Drawing.Image)(resources.GetObject("button49.Image")));
            this.button49.Location = new System.Drawing.Point(905, 332);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(51, 44);
            this.button49.TabIndex = 61;
            this.button49.Text = "E12";
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.Transparent;
            this.button50.FlatAppearance.BorderSize = 0;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button50.ForeColor = System.Drawing.Color.Black;
            this.button50.Image = ((System.Drawing.Image)(resources.GetObject("button50.Image")));
            this.button50.Location = new System.Drawing.Point(835, 332);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(51, 44);
            this.button50.TabIndex = 60;
            this.button50.Text = "E11";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.Transparent;
            this.button51.FlatAppearance.BorderSize = 0;
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button51.ForeColor = System.Drawing.Color.Black;
            this.button51.Image = ((System.Drawing.Image)(resources.GetObject("button51.Image")));
            this.button51.Location = new System.Drawing.Point(765, 332);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(51, 44);
            this.button51.TabIndex = 59;
            this.button51.Text = "E10";
            this.button51.UseVisualStyleBackColor = false;
            this.button51.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.Color.Transparent;
            this.button52.FlatAppearance.BorderSize = 0;
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button52.ForeColor = System.Drawing.Color.Black;
            this.button52.Image = ((System.Drawing.Image)(resources.GetObject("button52.Image")));
            this.button52.Location = new System.Drawing.Point(693, 332);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(51, 44);
            this.button52.TabIndex = 58;
            this.button52.Text = "E9";
            this.button52.UseVisualStyleBackColor = false;
            this.button52.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button53
            // 
            this.button53.BackColor = System.Drawing.Color.Transparent;
            this.button53.FlatAppearance.BorderSize = 0;
            this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button53.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button53.ForeColor = System.Drawing.Color.Black;
            this.button53.Image = ((System.Drawing.Image)(resources.GetObject("button53.Image")));
            this.button53.Location = new System.Drawing.Point(623, 332);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(51, 44);
            this.button53.TabIndex = 57;
            this.button53.Text = "E8";
            this.button53.UseVisualStyleBackColor = false;
            this.button53.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button54
            // 
            this.button54.BackColor = System.Drawing.Color.Transparent;
            this.button54.FlatAppearance.BorderSize = 0;
            this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button54.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button54.ForeColor = System.Drawing.Color.Black;
            this.button54.Image = ((System.Drawing.Image)(resources.GetObject("button54.Image")));
            this.button54.Location = new System.Drawing.Point(553, 332);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(51, 44);
            this.button54.TabIndex = 56;
            this.button54.Text = "E7";
            this.button54.UseVisualStyleBackColor = false;
            this.button54.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button55
            // 
            this.button55.BackColor = System.Drawing.Color.Transparent;
            this.button55.FlatAppearance.BorderSize = 0;
            this.button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button55.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button55.ForeColor = System.Drawing.Color.Black;
            this.button55.Image = ((System.Drawing.Image)(resources.GetObject("button55.Image")));
            this.button55.Location = new System.Drawing.Point(482, 332);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(51, 44);
            this.button55.TabIndex = 55;
            this.button55.Text = "E6";
            this.button55.UseVisualStyleBackColor = false;
            this.button55.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button56
            // 
            this.button56.BackColor = System.Drawing.Color.Transparent;
            this.button56.FlatAppearance.BorderSize = 0;
            this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button56.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button56.ForeColor = System.Drawing.Color.Black;
            this.button56.Image = ((System.Drawing.Image)(resources.GetObject("button56.Image")));
            this.button56.Location = new System.Drawing.Point(412, 332);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(51, 44);
            this.button56.TabIndex = 54;
            this.button56.Text = "E5";
            this.button56.UseVisualStyleBackColor = false;
            this.button56.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button57
            // 
            this.button57.BackColor = System.Drawing.Color.Transparent;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button57.ForeColor = System.Drawing.Color.Black;
            this.button57.Image = ((System.Drawing.Image)(resources.GetObject("button57.Image")));
            this.button57.Location = new System.Drawing.Point(342, 332);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(51, 44);
            this.button57.TabIndex = 53;
            this.button57.Text = "E4";
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button58
            // 
            this.button58.BackColor = System.Drawing.Color.Transparent;
            this.button58.FlatAppearance.BorderSize = 0;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button58.ForeColor = System.Drawing.Color.Black;
            this.button58.Image = ((System.Drawing.Image)(resources.GetObject("button58.Image")));
            this.button58.Location = new System.Drawing.Point(270, 332);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(51, 44);
            this.button58.TabIndex = 52;
            this.button58.Text = "E3";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button59
            // 
            this.button59.BackColor = System.Drawing.Color.Transparent;
            this.button59.FlatAppearance.BorderSize = 0;
            this.button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button59.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button59.ForeColor = System.Drawing.Color.Black;
            this.button59.Image = ((System.Drawing.Image)(resources.GetObject("button59.Image")));
            this.button59.Location = new System.Drawing.Point(200, 332);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(51, 44);
            this.button59.TabIndex = 51;
            this.button59.Text = "E2";
            this.button59.UseVisualStyleBackColor = false;
            this.button59.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button60
            // 
            this.button60.BackColor = System.Drawing.Color.Transparent;
            this.button60.FlatAppearance.BorderSize = 0;
            this.button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button60.ForeColor = System.Drawing.Color.Black;
            this.button60.Image = ((System.Drawing.Image)(resources.GetObject("button60.Image")));
            this.button60.Location = new System.Drawing.Point(130, 332);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(51, 44);
            this.button60.TabIndex = 50;
            this.button60.Text = "E1";
            this.button60.UseVisualStyleBackColor = false;
            this.button60.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Transparent;
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button37.ForeColor = System.Drawing.Color.Black;
            this.button37.Image = ((System.Drawing.Image)(resources.GetObject("button37.Image")));
            this.button37.Location = new System.Drawing.Point(862, 395);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(51, 44);
            this.button37.TabIndex = 49;
            this.button37.Text = "D12";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Transparent;
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button38.ForeColor = System.Drawing.Color.Black;
            this.button38.Image = ((System.Drawing.Image)(resources.GetObject("button38.Image")));
            this.button38.Location = new System.Drawing.Point(792, 395);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(51, 44);
            this.button38.TabIndex = 48;
            this.button38.Text = "D11";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.Transparent;
            this.button39.FlatAppearance.BorderSize = 0;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button39.ForeColor = System.Drawing.Color.Black;
            this.button39.Image = ((System.Drawing.Image)(resources.GetObject("button39.Image")));
            this.button39.Location = new System.Drawing.Point(722, 395);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(51, 44);
            this.button39.TabIndex = 47;
            this.button39.Text = "D10";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Transparent;
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button40.ForeColor = System.Drawing.Color.Black;
            this.button40.Image = ((System.Drawing.Image)(resources.GetObject("button40.Image")));
            this.button40.Location = new System.Drawing.Point(650, 395);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(51, 44);
            this.button40.TabIndex = 46;
            this.button40.Text = "D9";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Transparent;
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button41.ForeColor = System.Drawing.Color.Black;
            this.button41.Image = ((System.Drawing.Image)(resources.GetObject("button41.Image")));
            this.button41.Location = new System.Drawing.Point(580, 395);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(51, 44);
            this.button41.TabIndex = 45;
            this.button41.Text = "D8";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.Transparent;
            this.button42.FlatAppearance.BorderSize = 0;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button42.ForeColor = System.Drawing.Color.Black;
            this.button42.Image = ((System.Drawing.Image)(resources.GetObject("button42.Image")));
            this.button42.Location = new System.Drawing.Point(510, 395);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(51, 44);
            this.button42.TabIndex = 44;
            this.button42.Text = "D7";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.Transparent;
            this.button43.FlatAppearance.BorderSize = 0;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button43.ForeColor = System.Drawing.Color.Black;
            this.button43.Image = ((System.Drawing.Image)(resources.GetObject("button43.Image")));
            this.button43.Location = new System.Drawing.Point(439, 395);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(51, 44);
            this.button43.TabIndex = 43;
            this.button43.Text = "D6";
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Transparent;
            this.button44.FlatAppearance.BorderSize = 0;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button44.ForeColor = System.Drawing.Color.Black;
            this.button44.Image = ((System.Drawing.Image)(resources.GetObject("button44.Image")));
            this.button44.Location = new System.Drawing.Point(369, 395);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(51, 44);
            this.button44.TabIndex = 42;
            this.button44.Text = "D5";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.Transparent;
            this.button45.FlatAppearance.BorderSize = 0;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button45.ForeColor = System.Drawing.Color.Black;
            this.button45.Image = ((System.Drawing.Image)(resources.GetObject("button45.Image")));
            this.button45.Location = new System.Drawing.Point(299, 395);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(51, 44);
            this.button45.TabIndex = 41;
            this.button45.Text = "D4";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.Transparent;
            this.button46.FlatAppearance.BorderSize = 0;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button46.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button46.ForeColor = System.Drawing.Color.Black;
            this.button46.Image = ((System.Drawing.Image)(resources.GetObject("button46.Image")));
            this.button46.Location = new System.Drawing.Point(227, 395);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(51, 44);
            this.button46.TabIndex = 40;
            this.button46.Text = "D3";
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.Transparent;
            this.button47.FlatAppearance.BorderSize = 0;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button47.ForeColor = System.Drawing.Color.Black;
            this.button47.Image = ((System.Drawing.Image)(resources.GetObject("button47.Image")));
            this.button47.Location = new System.Drawing.Point(157, 395);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(51, 44);
            this.button47.TabIndex = 39;
            this.button47.Text = "D2";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.Transparent;
            this.button48.FlatAppearance.BorderSize = 0;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button48.ForeColor = System.Drawing.Color.Black;
            this.button48.Image = ((System.Drawing.Image)(resources.GetObject("button48.Image")));
            this.button48.Location = new System.Drawing.Point(87, 399);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(51, 44);
            this.button48.TabIndex = 38;
            this.button48.Text = "D1";
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Image = ((System.Drawing.Image)(resources.GetObject("button25.Image")));
            this.button25.Location = new System.Drawing.Point(905, 458);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(51, 44);
            this.button25.TabIndex = 37;
            this.button25.Text = "C12";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Image = ((System.Drawing.Image)(resources.GetObject("button26.Image")));
            this.button26.Location = new System.Drawing.Point(835, 458);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(51, 44);
            this.button26.TabIndex = 36;
            this.button26.Text = "C11";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button27.ForeColor = System.Drawing.Color.Black;
            this.button27.Image = ((System.Drawing.Image)(resources.GetObject("button27.Image")));
            this.button27.Location = new System.Drawing.Point(765, 458);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(51, 44);
            this.button27.TabIndex = 35;
            this.button27.Text = "C10";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button28.ForeColor = System.Drawing.Color.Black;
            this.button28.Image = ((System.Drawing.Image)(resources.GetObject("button28.Image")));
            this.button28.Location = new System.Drawing.Point(693, 458);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(51, 44);
            this.button28.TabIndex = 34;
            this.button28.Text = "C9";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button29.ForeColor = System.Drawing.Color.Black;
            this.button29.Image = ((System.Drawing.Image)(resources.GetObject("button29.Image")));
            this.button29.Location = new System.Drawing.Point(623, 458);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(51, 44);
            this.button29.TabIndex = 33;
            this.button29.Text = "C8";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Transparent;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button30.ForeColor = System.Drawing.Color.Black;
            this.button30.Image = ((System.Drawing.Image)(resources.GetObject("button30.Image")));
            this.button30.Location = new System.Drawing.Point(553, 458);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(51, 44);
            this.button30.TabIndex = 32;
            this.button30.Text = "C7";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Transparent;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button31.ForeColor = System.Drawing.Color.Black;
            this.button31.Image = ((System.Drawing.Image)(resources.GetObject("button31.Image")));
            this.button31.Location = new System.Drawing.Point(482, 458);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(51, 44);
            this.button31.TabIndex = 31;
            this.button31.Text = "C6";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Transparent;
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button32.ForeColor = System.Drawing.Color.Black;
            this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
            this.button32.Location = new System.Drawing.Point(412, 458);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(51, 44);
            this.button32.TabIndex = 30;
            this.button32.Text = "C5";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Transparent;
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button33.ForeColor = System.Drawing.Color.Black;
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.Location = new System.Drawing.Point(342, 458);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(51, 44);
            this.button33.TabIndex = 29;
            this.button33.Text = "C4";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Transparent;
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button34.ForeColor = System.Drawing.Color.Black;
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.Location = new System.Drawing.Point(270, 458);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(51, 44);
            this.button34.TabIndex = 28;
            this.button34.Text = "C3";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Transparent;
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button35.ForeColor = System.Drawing.Color.Black;
            this.button35.Image = ((System.Drawing.Image)(resources.GetObject("button35.Image")));
            this.button35.Location = new System.Drawing.Point(200, 458);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(51, 44);
            this.button35.TabIndex = 27;
            this.button35.Text = "C2";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Transparent;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button36.ForeColor = System.Drawing.Color.Black;
            this.button36.Image = ((System.Drawing.Image)(resources.GetObject("button36.Image")));
            this.button36.Location = new System.Drawing.Point(130, 458);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(51, 44);
            this.button36.TabIndex = 26;
            this.button36.Text = "C1";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(862, 521);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 44);
            this.button13.TabIndex = 25;
            this.button13.Text = "B12";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(792, 521);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 44);
            this.button14.TabIndex = 24;
            this.button14.Text = "B11";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(722, 521);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 44);
            this.button15.TabIndex = 23;
            this.button15.Text = "B10";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(650, 521);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 44);
            this.button16.TabIndex = 22;
            this.button16.Text = "B9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(580, 521);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 44);
            this.button17.TabIndex = 21;
            this.button17.Text = "B8";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(510, 521);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 44);
            this.button18.TabIndex = 20;
            this.button18.Text = "B7";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(439, 521);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(51, 44);
            this.button19.TabIndex = 19;
            this.button19.Text = "B6";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(369, 521);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(51, 44);
            this.button20.TabIndex = 18;
            this.button20.Text = "B5";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(299, 521);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(51, 44);
            this.button21.TabIndex = 17;
            this.button21.Text = "B4";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Image = ((System.Drawing.Image)(resources.GetObject("button22.Image")));
            this.button22.Location = new System.Drawing.Point(227, 521);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(51, 44);
            this.button22.TabIndex = 16;
            this.button22.Text = "B3";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button23.ForeColor = System.Drawing.Color.Black;
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(157, 521);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(51, 44);
            this.button23.TabIndex = 15;
            this.button23.Text = "B2";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button24.ForeColor = System.Drawing.Color.Black;
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.Location = new System.Drawing.Point(87, 521);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(51, 44);
            this.button24.TabIndex = 14;
            this.button24.Text = "B1";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA12
            // 
            this.buttonA12.BackColor = System.Drawing.Color.Transparent;
            this.buttonA12.FlatAppearance.BorderSize = 0;
            this.buttonA12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA12.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA12.ForeColor = System.Drawing.Color.Black;
            this.buttonA12.Image = global::WinUI.Properties.Resources.turqouisChair;
            this.buttonA12.Location = new System.Drawing.Point(905, 584);
            this.buttonA12.Name = "buttonA12";
            this.buttonA12.Size = new System.Drawing.Size(51, 44);
            this.buttonA12.TabIndex = 13;
            this.buttonA12.Text = "A12";
            this.buttonA12.UseVisualStyleBackColor = false;
            this.buttonA12.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA11
            // 
            this.buttonA11.BackColor = System.Drawing.Color.Transparent;
            this.buttonA11.FlatAppearance.BorderSize = 0;
            this.buttonA11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA11.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA11.ForeColor = System.Drawing.Color.Black;
            this.buttonA11.Image = global::WinUI.Properties.Resources.turqouisChair;
            this.buttonA11.Location = new System.Drawing.Point(832, 579);
            this.buttonA11.Name = "buttonA11";
            this.buttonA11.Size = new System.Drawing.Size(54, 54);
            this.buttonA11.TabIndex = 12;
            this.buttonA11.Text = "A11";
            this.buttonA11.UseVisualStyleBackColor = false;
            this.buttonA11.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA10
            // 
            this.buttonA10.BackColor = System.Drawing.Color.Transparent;
            this.buttonA10.FlatAppearance.BorderSize = 0;
            this.buttonA10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA10.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA10.ForeColor = System.Drawing.Color.Black;
            this.buttonA10.Image = ((System.Drawing.Image)(resources.GetObject("buttonA10.Image")));
            this.buttonA10.Location = new System.Drawing.Point(765, 584);
            this.buttonA10.Name = "buttonA10";
            this.buttonA10.Size = new System.Drawing.Size(51, 44);
            this.buttonA10.TabIndex = 11;
            this.buttonA10.Text = "A10";
            this.buttonA10.UseVisualStyleBackColor = false;
            this.buttonA10.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA9
            // 
            this.buttonA9.BackColor = System.Drawing.Color.Transparent;
            this.buttonA9.FlatAppearance.BorderSize = 0;
            this.buttonA9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA9.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA9.ForeColor = System.Drawing.Color.Black;
            this.buttonA9.Image = ((System.Drawing.Image)(resources.GetObject("buttonA9.Image")));
            this.buttonA9.Location = new System.Drawing.Point(693, 584);
            this.buttonA9.Name = "buttonA9";
            this.buttonA9.Size = new System.Drawing.Size(51, 44);
            this.buttonA9.TabIndex = 10;
            this.buttonA9.Text = "A9";
            this.buttonA9.UseVisualStyleBackColor = false;
            this.buttonA9.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA8
            // 
            this.buttonA8.BackColor = System.Drawing.Color.Transparent;
            this.buttonA8.FlatAppearance.BorderSize = 0;
            this.buttonA8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA8.ForeColor = System.Drawing.Color.Black;
            this.buttonA8.Image = ((System.Drawing.Image)(resources.GetObject("buttonA8.Image")));
            this.buttonA8.Location = new System.Drawing.Point(623, 584);
            this.buttonA8.Name = "buttonA8";
            this.buttonA8.Size = new System.Drawing.Size(51, 44);
            this.buttonA8.TabIndex = 9;
            this.buttonA8.Text = "A8";
            this.buttonA8.UseVisualStyleBackColor = false;
            this.buttonA8.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA7
            // 
            this.buttonA7.BackColor = System.Drawing.Color.Transparent;
            this.buttonA7.FlatAppearance.BorderSize = 0;
            this.buttonA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA7.ForeColor = System.Drawing.Color.Black;
            this.buttonA7.Image = ((System.Drawing.Image)(resources.GetObject("buttonA7.Image")));
            this.buttonA7.Location = new System.Drawing.Point(553, 584);
            this.buttonA7.Name = "buttonA7";
            this.buttonA7.Size = new System.Drawing.Size(51, 44);
            this.buttonA7.TabIndex = 8;
            this.buttonA7.Text = "A7";
            this.buttonA7.UseVisualStyleBackColor = false;
            this.buttonA7.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA6
            // 
            this.buttonA6.BackColor = System.Drawing.Color.Transparent;
            this.buttonA6.FlatAppearance.BorderSize = 0;
            this.buttonA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA6.ForeColor = System.Drawing.Color.Black;
            this.buttonA6.Image = ((System.Drawing.Image)(resources.GetObject("buttonA6.Image")));
            this.buttonA6.Location = new System.Drawing.Point(482, 584);
            this.buttonA6.Name = "buttonA6";
            this.buttonA6.Size = new System.Drawing.Size(51, 44);
            this.buttonA6.TabIndex = 7;
            this.buttonA6.Text = "A6";
            this.buttonA6.UseVisualStyleBackColor = false;
            this.buttonA6.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA5
            // 
            this.buttonA5.BackColor = System.Drawing.Color.Transparent;
            this.buttonA5.FlatAppearance.BorderSize = 0;
            this.buttonA5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA5.ForeColor = System.Drawing.Color.Black;
            this.buttonA5.Image = ((System.Drawing.Image)(resources.GetObject("buttonA5.Image")));
            this.buttonA5.Location = new System.Drawing.Point(412, 584);
            this.buttonA5.Name = "buttonA5";
            this.buttonA5.Size = new System.Drawing.Size(51, 44);
            this.buttonA5.TabIndex = 6;
            this.buttonA5.Text = "A5";
            this.buttonA5.UseVisualStyleBackColor = false;
            this.buttonA5.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA4
            // 
            this.buttonA4.BackColor = System.Drawing.Color.Transparent;
            this.buttonA4.FlatAppearance.BorderSize = 0;
            this.buttonA4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA4.ForeColor = System.Drawing.Color.Black;
            this.buttonA4.Image = ((System.Drawing.Image)(resources.GetObject("buttonA4.Image")));
            this.buttonA4.Location = new System.Drawing.Point(342, 584);
            this.buttonA4.Name = "buttonA4";
            this.buttonA4.Size = new System.Drawing.Size(51, 44);
            this.buttonA4.TabIndex = 5;
            this.buttonA4.Text = "A4";
            this.buttonA4.UseVisualStyleBackColor = false;
            this.buttonA4.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.BackColor = System.Drawing.Color.Transparent;
            this.buttonA3.FlatAppearance.BorderSize = 0;
            this.buttonA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA3.ForeColor = System.Drawing.Color.Black;
            this.buttonA3.Image = ((System.Drawing.Image)(resources.GetObject("buttonA3.Image")));
            this.buttonA3.Location = new System.Drawing.Point(270, 584);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(51, 44);
            this.buttonA3.TabIndex = 3;
            this.buttonA3.Text = "A3";
            this.buttonA3.UseVisualStyleBackColor = false;
            this.buttonA3.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA2
            // 
            this.buttonA2.BackColor = System.Drawing.Color.Transparent;
            this.buttonA2.FlatAppearance.BorderSize = 0;
            this.buttonA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA2.ForeColor = System.Drawing.Color.Black;
            this.buttonA2.Image = ((System.Drawing.Image)(resources.GetObject("buttonA2.Image")));
            this.buttonA2.Location = new System.Drawing.Point(200, 584);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(51, 44);
            this.buttonA2.TabIndex = 1;
            this.buttonA2.Text = "A2";
            this.buttonA2.UseVisualStyleBackColor = false;
            this.buttonA2.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.BackColor = System.Drawing.Color.Transparent;
            this.buttonA1.BackgroundImage = global::WinUI.Properties.Resources.turqouisChair;
            this.buttonA1.FlatAppearance.BorderSize = 0;
            this.buttonA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.buttonA1.ForeColor = System.Drawing.Color.Black;
            this.buttonA1.Location = new System.Drawing.Point(130, 584);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(48, 48);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.Text = "A1";
            this.buttonA1.UseVisualStyleBackColor = false;
            this.buttonA1.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1357, 734);
            this.Controls.Add(this.grpCustomerData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button85);
            this.Controls.Add(this.button86);
            this.Controls.Add(this.button87);
            this.Controls.Add(this.button88);
            this.Controls.Add(this.button89);
            this.Controls.Add(this.button90);
            this.Controls.Add(this.button91);
            this.Controls.Add(this.button92);
            this.Controls.Add(this.button93);
            this.Controls.Add(this.button94);
            this.Controls.Add(this.button95);
            this.Controls.Add(this.button96);
            this.Controls.Add(this.button73);
            this.Controls.Add(this.button74);
            this.Controls.Add(this.button75);
            this.Controls.Add(this.button76);
            this.Controls.Add(this.button77);
            this.Controls.Add(this.button78);
            this.Controls.Add(this.button79);
            this.Controls.Add(this.button80);
            this.Controls.Add(this.button81);
            this.Controls.Add(this.button82);
            this.Controls.Add(this.button83);
            this.Controls.Add(this.button84);
            this.Controls.Add(this.button61);
            this.Controls.Add(this.button62);
            this.Controls.Add(this.button63);
            this.Controls.Add(this.button64);
            this.Controls.Add(this.button65);
            this.Controls.Add(this.button66);
            this.Controls.Add(this.button67);
            this.Controls.Add(this.button68);
            this.Controls.Add(this.button69);
            this.Controls.Add(this.button70);
            this.Controls.Add(this.button71);
            this.Controls.Add(this.button72);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.button57);
            this.Controls.Add(this.button58);
            this.Controls.Add(this.button59);
            this.Controls.Add(this.button60);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.buttonA12);
            this.Controls.Add(this.buttonA11);
            this.Controls.Add(this.buttonA10);
            this.Controls.Add(this.buttonA9);
            this.Controls.Add(this.buttonA8);
            this.Controls.Add(this.buttonA7);
            this.Controls.Add(this.buttonA6);
            this.Controls.Add(this.buttonA5);
            this.Controls.Add(this.buttonA4);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.labelFilmAdi);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Film";
            this.Text = "1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Film_FormClosed);
            this.Load += new System.EventHandler(this.Film_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sK4RTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sK4RTDataSetBindingSource)).EndInit();
            this.grpCustomerData.ResumeLayout(false);
            this.grpCustomerData.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilmAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonA6;
        private System.Windows.Forms.Button buttonA5;
        private System.Windows.Forms.Button buttonA4;
        private System.Windows.Forms.Button buttonA12;
        private System.Windows.Forms.Button buttonA11;
        private System.Windows.Forms.Button buttonA10;
        private System.Windows.Forms.Button buttonA9;
        private System.Windows.Forms.Button buttonA8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.Button button58;
        private System.Windows.Forms.Button button59;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button61;
        private System.Windows.Forms.Button button62;
        private System.Windows.Forms.Button button63;
        private System.Windows.Forms.Button button64;
        private System.Windows.Forms.Button button65;
        private System.Windows.Forms.Button button66;
        private System.Windows.Forms.Button button67;
        private System.Windows.Forms.Button button68;
        private System.Windows.Forms.Button button69;
        private System.Windows.Forms.Button button70;
        private System.Windows.Forms.Button button71;
        private System.Windows.Forms.Button button72;
        private System.Windows.Forms.Button button73;
        private System.Windows.Forms.Button button74;
        private System.Windows.Forms.Button button75;
        private System.Windows.Forms.Button button76;
        private System.Windows.Forms.Button button77;
        private System.Windows.Forms.Button button78;
        private System.Windows.Forms.Button button79;
        private System.Windows.Forms.Button button80;
        private System.Windows.Forms.Button button81;
        private System.Windows.Forms.Button button82;
        private System.Windows.Forms.Button button83;
        private System.Windows.Forms.Button button84;
        private System.Windows.Forms.Button button85;
        private System.Windows.Forms.Button button86;
        private System.Windows.Forms.Button button87;
        private System.Windows.Forms.Button button88;
        private System.Windows.Forms.Button button89;
        private System.Windows.Forms.Button button90;
        private System.Windows.Forms.Button button91;
        private System.Windows.Forms.Button button92;
        private System.Windows.Forms.Button button93;
        private System.Windows.Forms.Button button94;
        private System.Windows.Forms.Button button95;
        private System.Windows.Forms.Button button96;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonA7;
        public System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label6;
        private SK4RTDataSet sK4RTDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private SK4RTDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.BindingSource sessionBindingSource1;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.BindingSource sessionBindingSource2;
        private System.Windows.Forms.BindingSource sK4RTDataSetBindingSource;
        private System.Windows.Forms.GroupBox grpCustomerData;
        private System.Windows.Forms.TextBox txtCustomerChair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
    }
}