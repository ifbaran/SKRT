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
    public partial class TheaterForm : Form
    {
        private BLL.Models.TheaterManager theaterManager;
        public TheaterForm()
        {
            InitializeComponent();
            theaterManager = new TheaterManager();
        }

        private void TheaterForm_Load(object sender, EventArgs e)
        {
            GetTheaters();
            grdTheaters.EnableHeadersVisualStyles = false;
            grdTheaters.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdTheaters.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdTheaters.Columns[0].HeaderText = "Theater ID";
            grdTheaters.Columns[1].HeaderText = "Theater Name";
            grdTheaters.Columns[2].HeaderText = "Theater Author";
            grdTheaters.Columns[3].HeaderText = "Theater Period";
        }

        private void GetTheaters()
        {
            try
            {
                grdTheaters.DataSource = theaterManager.DataGridViewTheaters();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //CloseButton
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grdTheaters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdTheaters.ClearSelection();
        }

        private void grdTheaters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketSale.TheaterId = Convert.ToInt32(grdTheaters.SelectedRows[0].Cells[0].Value);
            this.Close();
            TicketOperation.theaterId = Convert.ToInt32(grdTheaters.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
