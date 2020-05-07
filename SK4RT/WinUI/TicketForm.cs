using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace WinUI
{
    public partial class TicketForm : Form
    {
        private TicketManager ticketManager;
        public TicketForm()
        {
            InitializeComponent();
            ticketManager = new TicketManager();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            GetTickets();
            grdTickets.EnableHeadersVisualStyles = false;
            grdTickets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdTickets.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdTickets.Columns[0].HeaderText = "Ticket ID";
            grdTickets.Columns[1].HeaderText = "Customer ID";
            grdTickets.Columns[2].HeaderText = "Film ID";
            grdTickets.Columns[3].HeaderText = "Theater ID";
            grdTickets.Columns[4].HeaderText = "Chair ID";
            grdTickets.Columns[5].HeaderText = "Session ID";
            grdTickets.Columns[6].HeaderText = "Saloon ID";
            grdTickets.Columns[7].HeaderText = "Ticket Date";
            grdTickets.Columns[8].Visible = false;
            grdTickets.Columns[9].Visible = false;
            grdTickets.Columns[10].Visible = false;
            grdTickets.Columns[11].Visible = false;
            grdTickets.Columns[12].Visible = false;
            grdTickets.Columns[13].Visible = false;

        }

        private void grdTickets_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdTickets.ClearSelection();
        }

        private void GetTickets()
        {
            try
            {
                grdTickets.DataSource = ticketManager.DataGridViewTickets();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
