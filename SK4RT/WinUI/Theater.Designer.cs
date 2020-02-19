namespace WinUI
{
    partial class Theater
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
            this.labelTheaterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTheaterName
            // 
            this.labelTheaterName.AutoSize = true;
            this.labelTheaterName.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.labelTheaterName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTheaterName.Location = new System.Drawing.Point(413, 9);
            this.labelTheaterName.Name = "labelTheaterName";
            this.labelTheaterName.Size = new System.Drawing.Size(68, 25);
            this.labelTheaterName.TabIndex = 1;
            this.labelTheaterName.Text = "label";
            // 
            // Theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1047, 734);
            this.Controls.Add(this.labelTheaterName);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Theater";
            this.Text = "Theater";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Theater_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTheaterName;
    }
}