using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinUI
{
    public partial class Film : Form
    {
        SK4RT mainForm = new SK4RT();
        public Film(string filmAdi)
        {
            InitializeComponent();
            labelFilmAdi.Text = filmAdi;
        }

        private void Film_Load(object sender, EventArgs e)
        {

        }

        private void Film_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
