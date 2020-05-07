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
    public partial class TheaterOperations : Form
    {
        private BLL.Models.TheaterManager theaterManager;
        public TheaterOperations()
        {
            InitializeComponent();
            theaterManager = new TheaterManager();
        }
        private void TheaterOperations_Load(object sender, EventArgs e)
        {
            GetTheaters();
            cmbTheaterSelect.SelectedIndex = 0;
        }

        private void btnAddTheater_Click(object sender, EventArgs e)
        {
            if (cmbTheaterSelect.SelectedIndex == 0)
            {
                theaterManager.AddTheater(txtTheaterName.Text,
                    txtTheaterAuthor.Text,
                    Convert.ToInt32(txtTheaterPeriod.Text));
                MessageBox.Show("Theater added.");
                GetTheaters();

            }
            else
            {
                MessageBox.Show("Please select --New Theater--");
            }
            GetTheaters();
            ClearTextBox();
        }

        private void btnUpdateTheater_Click(object sender, EventArgs e)
        {
            if (cmbTheaterSelect.SelectedIndex != 0)
            {
                theaterManager.UpdateTheater(cmbTheaterSelect.SelectedItem.ToString(),
                    txtTheaterName.Text,
                    txtTheaterAuthor.Text,
                    Convert.ToInt32(txtTheaterPeriod.Text));
                MessageBox.Show("Theater Updated.");
            }
            else
            {
                MessageBox.Show("Please select a theater.");
            }
            GetTheaters();
            ClearTextBox();
        }

        private void btnDeleteTheater_Click(object sender, EventArgs e)
        {
            if (cmbTheaterSelect.SelectedIndex != 0)
            {
                theaterManager.DeleteTheater(cmbTheaterSelect.SelectedItem.ToString());
                MessageBox.Show("Theater Deleted");

            }
            else
            {
                MessageBox.Show("Please select a theater");
            }
            GetTheaters();
            ClearTextBox();
        }

        private void cmbTheaterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheaterSelect.SelectedIndex != 0)
            {
                List<Theaters> theaters = theaterManager.FillTheaters(cmbTheaterSelect.SelectedItem.ToString());

                txtTheaterName.Text = theaters[0].TheaterName;
                txtTheaterAuthor.Text = theaters[0].TheaterAuthor;
                txtTheaterPeriod.Text = theaters[0].TheaterPeriod.ToString();
            }
            else
            {
                txtTheaterName.Text = string.Empty;
                txtTheaterAuthor.Text = string.Empty;
                txtTheaterPeriod.Text = string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClearTextBox()
        {
            txtTheaterAuthor.Text = string.Empty;
            txtTheaterName.Text = string.Empty;
            txtTheaterPeriod.Text = string.Empty;
            cmbTheaterSelect.SelectedIndex = 0;
        }
        private void GetTheaters()
        {
            foreach (var item in theaterManager.BLLGetTheaters())
            {
                if (!cmbTheaterSelect.Items.Contains(item))
                {
                    cmbTheaterSelect.Items.Add(item);
                }
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


    }
}
