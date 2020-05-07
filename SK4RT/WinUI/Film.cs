using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class Film : Form
    {
        private ArrayList _selectedChairs;
        private SaloonManager saloonManager;
        private SessionManager sessionManager;
        private ChairManager chairManager;
        public Film(string gelenFilmAdi)
        {
            InitializeComponent();
            saloonManager = new SaloonManager();
            sessionManager = new SessionManager();
            chairManager = new ChairManager();
            labelFilmAdi.Text = gelenFilmAdi;
        }

        private void Film_Load(object sender, EventArgs e)
        {
            _selectedChairs = new ArrayList(); ;
            cmbSaloon.DataSource = saloonManager.GetSaloons();
            cmbSession.DataSource = sessionManager.GetSessions();

            //if (chairManager.GetChairStatus())
            //{
            //    _selectedChairs.Add(chairManager.GetChairId());
            //    if (_selectedChairs.Contains(chairManager.GetChairName(chairManager.GetChairId())))
            //    {
            //        buttonA1.Image = Image.FromFile(@"E:\DOCS\NESNE-TABANLI-PROGRAMLAMA\SK4RT\SK4RT\img\redChair.png");
            //    }
            //}

        }
        private void Film_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            var btnText = ((Button)sender).Text;

            if (!_selectedChairs.Contains(btnText))
            {
                btn.Image = Image.FromFile(@"E:\DOCS\NESNE-TABANLI-PROGRAMLAMA\SK4RT\SK4RT\img\yellowChair.png");
                if (!_selectedChairs.Contains(btnText))
                {
                    _selectedChairs.Add(btnText);
                }
                GetChairsOnForm();

            }
            else
            {
                btn.Image = Image.FromFile(@"E:\DOCS\NESNE-TABANLI-PROGRAMLAMA\SK4RT\SK4RT\img\turqouisChair.png");
                _selectedChairs.Remove(btnText);

                if (_selectedChairs.Count > 0)
                {
                    GetChairsOnForm();
                }
                else
                {
                    txtCustomerChair.Text = null;
                }
            }
        }

        private void GetChairsOnForm()
        {
            string chair = "";
            for (int i = 0; i < _selectedChairs.Count; i++)
            {
                chair += _selectedChairs[i].ToString()+ ",";
            }

            if (_selectedChairs.Count >= 1)
            {
                chair = chair.Remove(chair.Length -1 , 1);
            }

            txtCustomerChair.Text = chair;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers
            {
                CustomerName = txtCustomerName.Text,
                CustomerLastName = txtCustomerLastname.Text,
                CustomerEmail = txtCustomerEmail.Text
            };

            SaveCustomer saveCustomer = new SaveCustomer(customers);
            saveCustomer.ShowDialog();
        }

        #region Mouse Üzerine Geldiğinde Renk Değişimi
        //122; 210; 201

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSaveCustomer.BackColor = Color.FromArgb(8, 5, 30);
            btnSaveCustomer.ForeColor = Color.Gainsboro;
            btnAddTicket.ForeColor = Color.Black;
            btnAddTicket.BackColor = Color.FromArgb(122, 210, 201);

        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSaveCustomer.BackColor = Color.FromArgb(122, 210, 201);
            btnSaveCustomer.ForeColor = Color.Black;
            btnAddTicket.ForeColor = Color.Gainsboro;
            btnAddTicket.BackColor = Color.FromArgb(8, 5, 30);
        }




        #endregion

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            TicketSale ticketSale = new TicketSale(txtCustomerChair.Text,cmbSession.Text,cmbSaloon.Text);
            ticketSale.ShowDialog();
        }

    }
}
