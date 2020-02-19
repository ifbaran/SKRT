using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Theater : Form
    {
        public Theater(string theaterName)
        {
            InitializeComponent();
            labelTheaterName.Text = theaterName;
        }

        private void Theater_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
