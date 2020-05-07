using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace WinUI
{
    public partial class ChairForm : Form
    {
        private ChairManager chairManager;
        public ChairForm()
        {
            InitializeComponent();
            chairManager = new ChairManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChairForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chairManager.GetChairsDGW();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketOperation.chairId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
