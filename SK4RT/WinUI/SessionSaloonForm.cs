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
    public partial class SessionSaloonForm : Form
    {
        private SessionManager sessionManager;
        private SaloonManager saloonManager;
        public SessionSaloonForm()
        {
            InitializeComponent();
            saloonManager = new SaloonManager();
            sessionManager = new SessionManager();
            dateStart.Format = DateTimePickerFormat.Time;
            dateEnd.Format = DateTimePickerFormat.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            if (saloonManager.AddSaloon(txtSaloonName.Text))
            {
                MessageBox.Show("Saloon added.");
            }
            else
            {
                MessageBox.Show("Saloon not added.");
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (sessionManager.AddSession(txtSessionName.Text, dateStart.Value, dateEnd.Value))
            {
                MessageBox.Show("Session added.");
            }
            else
            {
                MessageBox.Show("Session not added.");
            }
        }
    }
}
