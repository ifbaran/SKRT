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
            this.labelFilmAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilmAdi
            // 
            this.labelFilmAdi.AutoSize = true;
            this.labelFilmAdi.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.labelFilmAdi.Location = new System.Drawing.Point(404, 9);
            this.labelFilmAdi.Name = "labelFilmAdi";
            this.labelFilmAdi.Size = new System.Drawing.Size(68, 25);
            this.labelFilmAdi.TabIndex = 0;
            this.labelFilmAdi.Text = "label";
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1047, 734);
            this.Controls.Add(this.labelFilmAdi);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Film";
            this.Text = "Film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Film_FormClosed);
            this.Load += new System.EventHandler(this.Film_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilmAdi;
    }
}