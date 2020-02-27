using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinUI
{
    public partial class SK4RT : Form
    {
        BusinessLogicLayer.FilmModule filmModule = new BusinessLogicLayer.FilmModule();
        BusinessLogicLayer.TheaterModule theaterModule = new BusinessLogicLayer.TheaterModule();

        public SK4RT()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void SK4RT_Load(object sender, EventArgs e)
        {
            btnFilm1.Text = string.Empty;
            btnFilm1.Text = filmModule.FilmName(0);
            btnFilm2.Text = string.Empty;
            btnFilm2.Text = filmModule.FilmName(1);
            btnFilm3.Text = string.Empty;
            btnFilm3.Text = filmModule.FilmName(2);
            btnFilm4.Text = string.Empty;
            btnFilm4.Text = filmModule.FilmName(3);
            btnFilm5.Text = string.Empty;
            btnFilm5.Text = filmModule.FilmName(4);
            btnThe1.Text = string.Empty;
            btnThe1.Text = theaterModule.GetTheaterName(0);
            btnThe2.Text = string.Empty;
            btnThe2.Text = theaterModule.GetTheaterName(1);
            btnThe3.Text = string.Empty;
            btnThe3.Text = theaterModule.GetTheaterName(2);
            btnThe4.Text = string.Empty;
            btnThe4.Text = theaterModule.GetTheaterName(3);
            btnThe5.Text = string.Empty;
            btnThe5.Text = theaterModule.GetTheaterName(4);

        }

        #region Form Hareket Ettirme Mouse Hareketleri
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
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X, MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }
        #endregion
     
        #region Panel Görünümleri
        private void customizeDesign()
        {
            panelFilms.Visible = false;
            panelTheaters.Visible = false;
            panelContact.Visible = false;
        }

        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
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

        #region Mouse Üzerine Geldiğinde ve Gittiğinde Renk Değişimi
        private void btnFilms_MouseMove(object sender, MouseEventArgs e)
        {
            btnFilms.BackColor = Color.FromArgb(30, 30, 55);
        }

        private void btnFilms_MouseLeave(object sender, EventArgs e)
        {
            btnFilms.BackColor = Color.FromArgb(8, 5, 30);
        }

        private void btnTheatres_MouseMove(object sender, MouseEventArgs e)
        {
            btnTheatres.BackColor = Color.FromArgb(30, 30, 55);
        }

        private void btnTheatres_MouseLeave(object sender, EventArgs e)
        {
            btnTheatres.BackColor = Color.FromArgb(8, 5, 30);
        }

        private void btnMusteriListe_MouseMove(object sender, MouseEventArgs e)
        {
            btnMusteriListe.BackColor = Color.FromArgb(30, 30, 55);
        }

        private void btnMusteriListe_MouseLeave(object sender, EventArgs e)
        {
            btnMusteriListe.BackColor = Color.FromArgb(8, 5, 30);
        }
        #endregion

        #region SubMenu Açılımları

        private void btnFilms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFilms);
        }

        private void btnTheatres_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTheaters);
        }
        private void btnContact_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContact);
        }

        #endregion

        #region Film Butonları
        
        private void btnFilm1_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Film film = new Film(btnFilm1.Text);
            film.TopLevel = false;
            panelContent.Controls.Add(film);
            film.Show();
            film.Dock = DockStyle.Fill;
            
            
            //...
            // operations
            //...
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
        }

        #endregion

        #region Tiyatro Butonları
        private void btnThe1_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Theater theater = new Theater(btnThe1.Text);
            theater.TopLevel = false;
            panelContent.Controls.Add(theater);
            theater.Show();
            theater.Dock = DockStyle.Fill;
            //...
            // operations
            //...
        }

        private void btnThe2_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Theater theater = new Theater(btnThe2.Text);
            theater.TopLevel = false;
            panelContent.Controls.Add(theater);
            theater.Show();
            theater.Dock = DockStyle.Fill;
            //...
            // operations
            //...
        }

        private void btnThe3_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Theater theater = new Theater(btnThe3.Text);
            theater.TopLevel = false;
            panelContent.Controls.Add(theater);
            theater.Show();
            theater.Dock = DockStyle.Fill;
            //...
            // operations
            //...
        }

        private void btnThe4_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Theater theater = new Theater(btnThe4.Text);
            theater.TopLevel = false;
            panelContent.Controls.Add(theater);
            theater.Show();
            theater.Dock = DockStyle.Fill;
            //...
            // operations
            //...
        }

        private void btnThe5_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Theater theater = new Theater(btnThe5.Text);
            theater.TopLevel = false;
            panelContent.Controls.Add(theater);
            theater.Show();
            theater.Dock = DockStyle.Fill;
            //...
            // operations
            //...
        }

        #endregion

        #region Mail Butonları
        private void btnSendMailCustomer_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            //hideSubMenu(panelTheaters);
            //hideSubMenu(panelFilms);
            //hideSubMenu(panelContact);
        }

        private void btnSendMailWorker_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            //hideSubMenu(panelTheaters);
            //hideSubMenu(panelFilms);
            //hideSubMenu(panelContact);
        }

        #endregion

        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CustomerForm customerForm = new CustomerForm();
            customerForm.TopLevel = false;
            panelContent.Controls.Add(customerForm);
            customerForm.Show();
            customerForm.Dock = DockStyle.Fill;
        }
    }
}
