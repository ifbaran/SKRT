using System;
using System.Drawing;
using System.Windows.Forms;
using BLL.Enums;
using BLL.Models;

namespace WinUI
{
    public partial class SK4RT : Form
    {
        BLL.Enums.LoginType loginType;
        private FilmManager filmManager;
        public SK4RT()
        {
            InitializeComponent();
            customizeDesign();
        }

        public SK4RT(LoginType loginType, string name)
        {
            InitializeComponent();
            customizeDesign();
            this.loginType = loginType;
            lblEmployeeName.Text = name;
            filmManager = new FilmManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void SK4RT_Load(object sender, EventArgs e)
        {
            if (loginType == LoginType.Admin)
            {
                btnWorkerOperations.Visible = true;
                label1.Text = "You have logged in ";
            }
            else if (loginType == LoginType.Worker)
            {
                btnWorkerOperations.Visible = false;
                label1.Text = "Welcome Back: ";
            }
            btnFilm1.Text = filmManager.GetOneFilm()[0];
            btnFilm2.Text = filmManager.GetOneFilm()[1];
            btnFilm3.Text = filmManager.GetOneFilm()[2];
            btnFilm4.Text = filmManager.GetOneFilm()[3];
            btnFilm5.Text = filmManager.GetOneFilm()[4];
        }

        #region Form Move

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X,
                    MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }

        #endregion

        #region Show of Panels

        private void customizeDesign()
        {
            panelFilms.Visible = false;
            panelShow.Visible = false;
        }

        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible)
                subMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        #region Color Change when MouseMove or MouseLeave

        private void btnFilms_MouseMove(object sender, MouseEventArgs e)
        {
            btnFilms.BackColor = Color.FromArgb(30, 30, 55);
        }

        private void btnFilms_MouseLeave(object sender, EventArgs e)
        {
            btnFilms.BackColor = Color.FromArgb(8, 5, 30);
        }

        private void btnMusteriListe_MouseMove(object sender, MouseEventArgs e)
        {
            btnShow.BackColor = Color.FromArgb(30, 30, 55);
        }

        private void btnMusteriListe_MouseLeave(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.FromArgb(8, 5, 30);
        }

        #endregion

        #region Open of SubMenu

        private void btnFilms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFilms);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm();
            emailForm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showSubMenu(panelShow);
        }

        #endregion

        #region Film's Buttons

        private void btnFilm1_Click(object sender, EventArgs e)
        {
            Film film = new Film(btnFilm1.Text);
            panelContent.Controls.Clear();
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            hideSubMenu(panelFilms);
        }

        private void btnFilm2_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Film film = new Film(btnFilm2.Text);
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            //...
            // operations
            //...
            hideSubMenu(panelFilms);
        }

        private void btnFilm3_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Film film = new Film(btnFilm3.Text);
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            //...
            // operations
            //...
            hideSubMenu(panelFilms);
        }

        private void btnFilm4_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Film film = new Film(btnFilm4.Text);
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            //...
            // operations
            //...
            hideSubMenu(panelFilms);
        }

        private void btnFilm5_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Film film = new Film(btnFilm5.Text);
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            //...
            // operations
            //...
            hideSubMenu(panelFilms);
        }

        #endregion

        #region Customer, Worker, Film, Theater Shows

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            panelContent.Controls.Clear();
            customerForm.TopLevel = false;
            panelContent.Controls.Add(customerForm);
            customerForm.Show();
            customerForm.Dock = DockStyle.Fill;
            hideSubMenu(panelShow);
        }

        private void btnShowWorker_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
            panelContent.Controls.Clear();
            workerForm.TopLevel = false;
            panelContent.Controls.Add(workerForm);
            workerForm.Show();
            workerForm.Dock = DockStyle.Fill;
            hideSubMenu(panelShow);
        }

        private void btnShowFilm_Click(object sender, EventArgs e)
        {
            FilmForm filmForm = new FilmForm();
            panelContent.Controls.Clear();
            filmForm.TopLevel = false;
            panelContent.Controls.Add(filmForm);
            filmForm.Show();
            filmForm.Dock = DockStyle.Fill;
            hideSubMenu(panelShow);
        }

        private void btnShowTheaters_Click(object sender, EventArgs e)
        {
            TheaterForm theaterForm = new TheaterForm();
            panelContent.Controls.Clear();
            theaterForm.TopLevel = false;
            panelContent.Controls.Add(theaterForm);
            theaterForm.Show();
            theaterForm.Dock = DockStyle.Fill;
            hideSubMenu(panelShow);
        }

        private void btnShowTicket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            panelContent.Controls.Clear();
            ticketForm.TopLevel = false;
            panelContent.Controls.Add(ticketForm);
            ticketForm.Show();
            ticketForm.Dock = DockStyle.Fill;
            hideSubMenu(panelShow);
        }

        #endregion

        #region Customer, Worker, Film Operations

        private void btnWorkerOperations_Click(object sender, EventArgs e)
        {
            WorkerOperations workerOperations = new WorkerOperations();
            workerOperations.ShowDialog();
        }

        private void btnCustomerOperations_Click(object sender, EventArgs e)
        {
            CustomerOperations customerOperations = new CustomerOperations();
            customerOperations.ShowDialog();
        }

        private void btnFilmOperations_Click(object sender, EventArgs e)
        {
            FilmOperations filmOperations = new FilmOperations();
            filmOperations.ShowDialog();
        }

        private void btnTheaterOperations_Click(object sender, EventArgs e)
        {
            TheaterOperations theaterOperations = new TheaterOperations();
            theaterOperations.ShowDialog();
        }

        private void btnSessionSaloon_Click(object sender, EventArgs e)
        {
            SessionSaloonForm sessionSaloonForm = new SessionSaloonForm();
            sessionSaloonForm.ShowDialog();
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            TicketOperation ticketOperation = new TicketOperation();
            ticketOperation.ShowDialog();
        }

        #endregion


    }
}