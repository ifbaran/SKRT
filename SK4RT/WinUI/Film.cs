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
using BusinessLogicLayer;
using System.Collections;
using System.Data.SqlClient;

namespace WinUI
{
    public partial class Film : Form
    {
        SK4RT mainForm = new SK4RT();
        BusinessLogicLayer.CustomerModule customerModule = new CustomerModule();
        BusinessLogicLayer.Customer customer = new Customer();
        public Film(string filmAdi)
        {
            InitializeComponent();
            labelFilmAdi.Text = filmAdi;
        }

        private void Film_Load(object sender, EventArgs e)
        {
            //bll.GetOccupiedChairs();
        }

        private void Film_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        ArrayList chairs = new ArrayList();

        bool isSelectedButton = false;

        private void btnChair_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);

            if (isSelectedButton == false)
            {
                btn.Image = System.Drawing.Image.FromFile(@"C:\YEREL DİSK D\SK4RT\SK4RT\img\yellowChair.png");
                
                isSelectedButton = true;
            }
            else
            {
                btn.Image = System.Drawing.Image.FromFile(@"C:\YEREL DİSK D\SK4RT\SK4RT\img\turqouisChair.png");
                isSelectedButton = false;
            }
            var btnName = ((Button)sender).Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.ShowDialog();
        }
    }
}
