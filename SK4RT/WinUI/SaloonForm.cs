using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace WinUI
{
    public partial class SaloonForm : Form
    {
        private SaloonManager saloonManager;
        public SaloonForm()
        {
            InitializeComponent();
            saloonManager = new SaloonManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaloonForm_Load(object sender, EventArgs e)
        {
            grdSaloon.DataSource = saloonManager.SaloonDGW();
        }

        private void grdSaloon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketOperation.saloonId = Convert.ToInt32(grdSaloon.SelectedRows[0].Cells[0].Value);
            this.Close();
        }

        private void grdSaloon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdSaloon.ClearSelection();
        }
    }
}
