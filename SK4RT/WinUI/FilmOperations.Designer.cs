namespace WinUI
{
    partial class FilmOperations
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
            this.cmbFilmSelect = new System.Windows.Forms.ComboBox();
            this.txtFilmPeriod = new System.Windows.Forms.TextBox();
            this.txtFilmAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilmDelete = new System.Windows.Forms.Button();
            this.btnFilmUpdate = new System.Windows.Forms.Button();
            this.btnFilmAdd = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 57);
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
            this.label1.Location = new System.Drawing.Point(296, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Operation";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WinUI.Properties.Resources.closeButton;
            this.btnClose.Location = new System.Drawing.Point(726, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.cmbFilmSelect);
            this.panel2.Controls.Add(this.txtFilmPeriod);
            this.panel2.Controls.Add(this.txtFilmAuthor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFilmName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnFilmDelete);
            this.panel2.Controls.Add(this.btnFilmUpdate);
            this.panel2.Controls.Add(this.btnFilmAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 413);
            this.panel2.TabIndex = 1;
            // 
            // cmbFilmSelect
            // 
            this.cmbFilmSelect.FormattingEnabled = true;
            this.cmbFilmSelect.Items.AddRange(new object[] {
            "--New Film--"});
            this.cmbFilmSelect.Location = new System.Drawing.Point(222, 44);
            this.cmbFilmSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilmSelect.Name = "cmbFilmSelect";
            this.cmbFilmSelect.Size = new System.Drawing.Size(479, 24);
            this.cmbFilmSelect.TabIndex = 3;
            this.cmbFilmSelect.SelectedIndexChanged += new System.EventHandler(this.cmbFilmSelect_SelectedIndexChanged);
            // 
            // txtFilmPeriod
            // 
            this.txtFilmPeriod.Location = new System.Drawing.Point(222, 231);
            this.txtFilmPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilmPeriod.Name = "txtFilmPeriod";
            this.txtFilmPeriod.Size = new System.Drawing.Size(479, 21);
            this.txtFilmPeriod.TabIndex = 2;
            // 
            // txtFilmAuthor
            // 
            this.txtFilmAuthor.Location = new System.Drawing.Point(222, 171);
            this.txtFilmAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilmAuthor.Name = "txtFilmAuthor";
            this.txtFilmAuthor.Size = new System.Drawing.Size(479, 21);
            this.txtFilmAuthor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(77, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Film Period:";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(222, 106);
            this.txtFilmName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(479, 21);
            this.txtFilmName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(77, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Film Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(77, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Film Author:";
            // 
            // btnFilmDelete
            // 
            this.btnFilmDelete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnFilmDelete.Location = new System.Drawing.Point(555, 305);
            this.btnFilmDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilmDelete.Name = "btnFilmDelete";
            this.btnFilmDelete.Size = new System.Drawing.Size(146, 53);
            this.btnFilmDelete.TabIndex = 1;
            this.btnFilmDelete.Text = "Film Delete";
            this.btnFilmDelete.UseVisualStyleBackColor = true;
            this.btnFilmDelete.Click += new System.EventHandler(this.btnFilmDelete_Click);
            // 
            // btnFilmUpdate
            // 
            this.btnFilmUpdate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnFilmUpdate.Location = new System.Drawing.Point(311, 305);
            this.btnFilmUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilmUpdate.Name = "btnFilmUpdate";
            this.btnFilmUpdate.Size = new System.Drawing.Size(146, 53);
            this.btnFilmUpdate.TabIndex = 1;
            this.btnFilmUpdate.Text = "Film Update";
            this.btnFilmUpdate.UseVisualStyleBackColor = true;
            this.btnFilmUpdate.Click += new System.EventHandler(this.btnFilmUpdate_Click);
            // 
            // btnFilmAdd
            // 
            this.btnFilmAdd.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnFilmAdd.Location = new System.Drawing.Point(82, 305);
            this.btnFilmAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilmAdd.Name = "btnFilmAdd";
            this.btnFilmAdd.Size = new System.Drawing.Size(146, 53);
            this.btnFilmAdd.TabIndex = 1;
            this.btnFilmAdd.Text = "Film Add";
            this.btnFilmAdd.UseVisualStyleBackColor = true;
            this.btnFilmAdd.Click += new System.EventHandler(this.btnFilmAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(77, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Film:";
            // 
            // FilmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FilmOperations";
            this.Text = "FilmOperations";
            this.Load += new System.EventHandler(this.FilmOperations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFilmSelect;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmPeriod;
        private System.Windows.Forms.TextBox txtFilmAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilmAdd;
        private System.Windows.Forms.Button btnFilmDelete;
        private System.Windows.Forms.Button btnFilmUpdate;
    }
}