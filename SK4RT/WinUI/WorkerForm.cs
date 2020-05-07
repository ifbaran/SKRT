using System;
using System.Drawing;
using System.Windows.Forms;
using BLL.Models;

namespace WinUI
{
    public partial class WorkerForm : Form
    {
        private BLL.Models.WorkerManager workerManager;
        public WorkerForm()
        {
            InitializeComponent();
            workerManager = new WorkerManager();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            GetWorkers();
            grdWorker.EnableHeadersVisualStyles = false;
            grdWorker.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdWorker.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdWorker.Columns[0].HeaderText = "Worker ID";
            grdWorker.Columns[1].HeaderText = "Worker Name";
            grdWorker.Columns[2].HeaderText = "Worker Surname";
            grdWorker.Columns[3].HeaderText = "Worker Email";
            grdWorker.Columns[4].HeaderText = "Worker Username";
            grdWorker.Columns[5].HeaderText = "Worker Password";
            grdWorker.Columns[6].HeaderText = "Worker Salary";
            grdWorker.Columns[7].Visible = false;
        }

        private void GetWorkers()
        {
            try
            {
                grdWorker.DataSource = workerManager.DataGridViewWorkers();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void grdWorker_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdWorker.ClearSelection();
        }
    }
}
