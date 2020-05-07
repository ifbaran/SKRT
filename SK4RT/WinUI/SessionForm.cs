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
    public partial class SessionForm : Form
    {
        private SessionManager sessionManager;
        public SessionForm()
        {
            InitializeComponent();
            sessionManager = new SessionManager();
        }

        private void grdSession_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketOperation.sessionId = Convert.ToInt32(grdSession.SelectedRows[0].Cells[0].Value);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdSession_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdSession.ClearSelection();
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            grdSession.DataSource = sessionManager.SessionsDGW();
        }
    }
}
