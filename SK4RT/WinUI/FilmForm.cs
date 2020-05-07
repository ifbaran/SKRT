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
    public partial class FilmForm : Form
    {
        private BLL.Models.FilmManager filmManager;
        public FilmForm()
        {
            InitializeComponent();
            filmManager = new FilmManager();
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
            grdFilms.EnableHeadersVisualStyles = false;
            grdFilms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdFilms.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdFilms.Columns[0].HeaderText = "Film ID";
            grdFilms.Columns[1].HeaderText = "Film Name";
            grdFilms.Columns[2].HeaderText = "Film Author";
            grdFilms.Columns[3].HeaderText = "Film Period";
        }

        private void GetCustomers()
        {
            try
            {
                grdFilms.DataSource = filmManager.DataGridViewFilms();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void grdFilms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdFilms.ClearSelection();
        }

        private void grdFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketSale.FilmId = Convert.ToInt32(grdFilms.SelectedRows[0].Cells[0].Value);
            this.Close();
            TicketOperation.filmId = Convert.ToInt32(grdFilms.SelectedRows[0].Cells[0].Value);
            this.Close();

        }
    }
}
