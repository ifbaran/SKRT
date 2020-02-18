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
            //hideSubMenu(panelFilms);
            hideSubMenu(panelTheaters);
            hideSubMenu(panelContact);
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
            //hideSubMenu(panelFilms);
            hideSubMenu(panelTheaters);
            hideSubMenu(panelContact);
        }

        private void btnFilm3_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            //hideSubMenu(panelFilms);
            hideSubMenu(panelTheaters);
            hideSubMenu(panelContact);
        }

        private void btnFilm4_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            //hideSubMenu(panelFilms);
            hideSubMenu(panelTheaters);
            hideSubMenu(panelContact);
        }

        private void btnFilm5_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            //hideSubMenu(panelFilms);
            hideSubMenu(panelTheaters);
            hideSubMenu(panelContact);
        }

        #endregion

        #region Tiyatro Butonları
        private void btnThe1_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }

        private void btnThe2_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }

        private void btnThe3_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }

        private void btnThe4_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }

        private void btnThe5_Click(object sender, EventArgs e)
        {
            //...
            // operations
            //...
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
            hideSubMenu(panelContact);
        }

        #endregion

        #region Mail Butonları
        private void btnSendMailCustomer_Click(object sender, EventArgs e)
        {
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }

        private void btnSendMailWorker_Click(object sender, EventArgs e)
        {
            hideSubMenu(panelTheaters);
            hideSubMenu(panelFilms);
            hideSubMenu(panelContact);
        }





        #endregion

    }
}
