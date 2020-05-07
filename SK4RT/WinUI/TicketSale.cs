using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class TicketSale : Form
    {
        public static int CustomerId;
        public static int FilmId;
        public static int TheaterId;
        public static int ChairId;
        public static int SessionId;
        public static int SaloonId;
        public static int WorkerId;
        private SK4RTContext context = new SK4RTContext();
        private TicketManager ticketManager;
        public TicketSale()
        {
            InitializeComponent();
        }
        public TicketSale(string chairName, string sessionName, string saloonName)
        {
            InitializeComponent();
            context = new SK4RTContext();
            ticketManager = new TicketManager();
            ChairId = context.Chairs.Where(x => x.ChairName == chairName).ToList()[0].ChairId;
            SessionId = context.Sessions.Where(x => x.SessionName == sessionName).ToList()[0].SessionId;
            SaloonId = context.Saloons.Where(x => x.SaloonName == saloonName).ToList()[0].SaloonId;
        }
        private void TicketSale_Load(object sender, EventArgs e)
        {
            txtChair.Text = ChairId.ToString();
            txtSession.Text = SessionId.ToString();
            txtSaloon.Text = SaloonId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
            txtCustomer.Text = CustomerId.ToString();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            FilmForm filmForm = new FilmForm();
            filmForm.ShowDialog();
            txtFilm.Text = FilmId.ToString();
        }

        private void btnTheater_Click(object sender, EventArgs e)
        {
            TheaterForm theaterForm = new TheaterForm();
            theaterForm.ShowDialog();
            txtTheater.Text = TheaterId.ToString();
        }

        private void btnSaleTicket_Click(object sender, EventArgs e)
        {
            if (txtTheater.Text == "")
            {
                txtTheater.Text = Convert.ToInt32(null).ToString();

                if (ticketManager.AddTicket(Convert.ToInt32(txtCustomer.Text), Convert.ToInt32(txtFilm.Text),
                    Convert.ToInt32(null), Convert.ToInt32(txtChair.Text), Convert.ToInt32(txtSession.Text),
                    Convert.ToInt32(txtSaloon.Text), dateTicketDate.Value))
                {
                    MessageBox.Show(" Film's Ticket addded.");
                }
                else
                {
                    MessageBox.Show("Film's ticket not add.");
                }
            }
            else if (txtFilm.Text == "")
            {
                txtFilm.Text = Convert.ToInt32(null).ToString();
                if (ticketManager.AddTicket(Convert.ToInt32(txtCustomer.Text), Convert.ToInt32(null),
                    Convert.ToInt32(txtTheater.Text), Convert.ToInt32(txtChair.Text), Convert.ToInt32(txtSession.Text),
                    Convert.ToInt32(txtSaloon.Text), dateTicketDate.Value))
                {
                    MessageBox.Show("Theater's Ticket addded.");
                }
                else
                {
                    MessageBox.Show("Theater's ticket not add.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
