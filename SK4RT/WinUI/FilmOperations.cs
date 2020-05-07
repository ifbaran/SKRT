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
using DAL.Models;

namespace WinUI
{
    public partial class FilmOperations : Form
    {
        private BLL.Models.FilmManager filmManager;
        public FilmOperations()
        {
            InitializeComponent();
            filmManager = new FilmManager();
        }

        private void FilmOperations_Load(object sender, EventArgs e)
        {
            GetFilms();
            cmbFilmSelect.SelectedIndex = 0;
        }

        private void btnFilmAdd_Click(object sender, EventArgs e)
        {
            if (cmbFilmSelect.SelectedIndex == 0)
            {
                filmManager.AddFilm(txtFilmName.Text,txtFilmAuthor.Text,Convert.ToInt32(txtFilmPeriod.Text));
                MessageBox.Show("Film added.");
                GetFilms();
            }
            else
            {
                MessageBox.Show("Please select --New Film--");
            }
            
        }

        private void btnFilmUpdate_Click(object sender, EventArgs e)
        {
            if (cmbFilmSelect.SelectedIndex != 0)
            {
                filmManager.UpdateFilm(cmbFilmSelect.SelectedItem.ToString(),txtFilmName.Text,txtFilmAuthor.Text,Convert.ToInt32(txtFilmPeriod.Text));
                MessageBox.Show("Film Updated.");
            }
            else
            {
                MessageBox.Show("Please select a film.");
            }
                GetFilms();
        }

        private void btnFilmDelete_Click(object sender, EventArgs e)
        {
            if (cmbFilmSelect.SelectedIndex!=0)
            {
                filmManager.DeleteFilm(cmbFilmSelect.SelectedItem.ToString());
                MessageBox.Show("Film Deleted.");
            }
            else
            {
                MessageBox.Show("Please select a film.");
            }
            GetFilms();
        }

        private void GetFilms()
        {
            foreach (var item in filmManager.BLLGetFilms())
            {
                if (!cmbFilmSelect.Items.Contains(item))
                {
                    cmbFilmSelect.Items.Add(item);
                }
            }
        }

        private void cmbFilmSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilmSelect.SelectedIndex != 0)
            {
                List<Films> films = filmManager.FillFilms(cmbFilmSelect.SelectedItem.ToString());

                txtFilmName.Text = films[0].FilmName;
                txtFilmAuthor.Text = films[0].FilmAuthor;
                txtFilmPeriod.Text = films[0].FilmPeriod.ToString();
            }
            else
            {
                txtFilmName.Text = string.Empty;
                txtFilmAuthor.Text = string.Empty;
                txtFilmPeriod.Text = string.Empty;
            }
        }

        #region Form Motion
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X, MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
