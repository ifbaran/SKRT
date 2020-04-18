using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DAL.Model;

namespace WinUI
{
    public partial class Film : Form
    {
        //SK4RT mainForm = new SK4RT();
        //BusinessLogicLayer.CustomerModule customerModule = new CustomerModule();
        //BusinessLogicLayer.Customer customer = new Customer();
        List<string> _selectedChairs;

        public Film()
        {
            InitializeComponent();
            //labelFilmAdi.Text = filmAdi;
        }

        private void Film_Load(object sender, EventArgs e)
        {
            _selectedChairs = new List<string>();
            //while (!cmbSession.Items.Contains(session.GetSessionTime()))
            //    cmbSession.Items.Add(session.GetSessionTime());


        }
        private string GetFilm()
        {
            //DataTable films = help.GetFilms();
            //string ComeFilm = films.Rows[0]["FilmName"].ToString();

            //return ComeFilm;
            return "";
        }
        private void Film_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        //bool _isSelectedButton = false;


        private void btnChair_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            var btnText = ((Button)sender).Text;
            btn.BackgroundImage = Properties.Resources.yellowChair;

            if (btn.BackgroundImage.ToString() == Properties.Resources.turqouisChair.ToString())
            {
                btn.BackgroundImage = Properties.Resources.yellowChair;
            }
            else if (btn.BackgroundImage.ToString() == Properties.Resources.yellowChair.ToString())
            {
                btn.BackgroundImage = Properties.Resources.turqouisChair;
            }

            

            #region Değiştir

            //if (_isSelectedButton == false)
            //{
            //    btn.Image = Image.FromFile(@"E:\DOCS\SK4RT\SK4RT\img\yellowChair.png");
            //    _selectedChairs.Add(btnText);

            //    //for (int i = 0; i < _selectedChairs.Count; i++)
            //    //{
            //    //    txtCustomerChair.Text = _selectedChairs[i];
            //    //}
            //    foreach (var item in _selectedChairs)
            //    {
            //        txtCustomerChair.Text = string.Empty;
            //        txtCustomerChair.Text += item;
            //    }
            //    //txtCustomerChair.Text= string.Empty;
            //    //txtCustomerChair.Text = _selectedChairs.ToList().ToString();

            //    _isSelectedButton = true;
            //}
            //else
            //{
            //    btn.Image = Image.FromFile(@"E:\DOCS\SK4RT\SK4RT\img\turqouisChair.png");
            //    _selectedChairs.Remove(btnText);

            //    if (_selectedChairs.Count > 0)
            //    {
            //        foreach (var item in _selectedChairs)
            //        {
            //            txtCustomerChair.Text += item;
            //        }
            //    }
            //    else
            //    {
            //        txtCustomerChair.Text = null;
            //    }
            //    _isSelectedButton = false;
            //}

            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            btnSave.BackColor = Color.FromArgb(8,5,30);
            btnSave.ForeColor = Color.Gainsboro;
            btnReservation.ForeColor = Color.Black;
            btnReservation.BackColor = Color.FromArgb(122, 210, 201);

        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(122, 210, 201);
            btnSave.ForeColor = Color.Black;
            btnReservation.ForeColor = Color.Gainsboro;
            btnReservation.BackColor = Color.FromArgb(8, 5, 30);
        }



        #endregion

    }
}
