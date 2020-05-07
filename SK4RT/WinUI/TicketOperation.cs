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
    public partial class TicketOperation : Form
    {
        public static int customerId;
        public static int chairId;
        public static int filmId;
        public static int saloonId;
        public static int sessionId;
        public static int theaterId;
        private TicketManager ticketManager;
        public TicketOperation()
        {
            InitializeComponent();
            ticketManager = new TicketManager();
        }


        private void TicketOperation_Load(object sender, EventArgs e)
        {
            grdTicket.DataSource = ticketManager.DataGridViewTickets();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdTicket_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdTicket.ClearSelection();
        }

        private void grdTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow row = grdTicket.Rows[index];

                txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                txtChairId.Text = row.Cells["ChairId"].Value.ToString();
                txtFilmId.Text = Convert.ToInt32(row.Cells["FilmId"].Value).ToString();
                txtSaloonId.Text = row.Cells["SaloonId"].Value.ToString();
                txtSessionId.Text = row.Cells["SessionId"].Value.ToString();
                txtTheaterId.Text = Convert.ToInt32(row.Cells["TheaterId"].Value).ToString();
                dateTicketDate.Text = row.Cells["TicketDate"].Value.ToString();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
            txtCustomerId.Text = customerId.ToString();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            FilmForm filmForm = new FilmForm();
            filmForm.ShowDialog();
            txtFilmId.Text = filmId.ToString();
        }

        private void btnTheater_Click(object sender, EventArgs e)
        {
            TheaterForm theaterForm = new TheaterForm();
            theaterForm.ShowDialog();
            txtTheaterId.Text = theaterId.ToString();
        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            ChairForm chairForm = new ChairForm();
            chairForm.ShowDialog();
            txtChairId.Text = chairId.ToString();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionForm sessionFormForm = new SessionForm();
            sessionFormForm.ShowDialog();
            txtSessionId.Text = sessionId.ToString();
        }

        private void btnSaloon_Click(object sender, EventArgs e)
        {
            SaloonForm saloonForm = new SaloonForm();
            saloonForm.ShowDialog();
            txtSaloonId.Text = saloonId.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTheaterId.Text == "" || txtTheaterId.Text == "0")
            {
                txtTheaterId.Text = Convert.ToInt32(null).ToString();

                if (ticketManager.UpdateTicket(Convert.ToInt32(grdTicket.SelectedRows[0].Cells[0].Value),Convert.ToInt32(txtCustomerId.Text),Convert.ToInt32(txtFilmId.Text),Convert.ToInt32(null),Convert.ToInt32(txtChairId.Text),Convert.ToInt32(txtSessionId.Text),Convert.ToInt32(txtSaloonId.Text),dateTicketDate.Value))
                {
                    MessageBox.Show("Film's Ticket Updated.");
                }
                else
                {
                    MessageBox.Show("Film's Ticket Not Updated.");
                }
            }
            else if (txtFilmId.Text == "" || txtFilmId.Text == "0")
            {
                txtFilmId.Text = Convert.ToInt32(null).ToString();
                if (ticketManager.UpdateTicket(Convert.ToInt32(grdTicket.SelectedRows[0].Cells[0].Value), Convert.ToInt32(txtCustomerId.Text), Convert.ToInt32(null), Convert.ToInt32(txtTheaterId.Text), Convert.ToInt32(txtChairId.Text), Convert.ToInt32(txtSessionId.Text), Convert.ToInt32(txtSaloonId.Text), dateTicketDate.Value))
                {
                    MessageBox.Show("Theater's Ticket Updated.");
                }
                else
                {
                    MessageBox.Show("Theater's Ticket Not Updated.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
            grdTicket.DataSource = ticketManager.DataGridViewTickets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ticketManager.DeleteTicket(Convert.ToInt32(grdTicket.SelectedRows[0].Cells[0].Value)))
            {
                MessageBox.Show("Deleted.");
                grdTicket.DataSource = ticketManager.DataGridViewTickets();
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void Clear()
        {
            txtTheaterId.Text = string.Empty;
            txtFilmId.Text = string.Empty;
            txtSaloonId.Text = string.Empty;
            txtSessionId.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            txtChairId.Text = string.Empty;
            dateTicketDate.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
    }
}