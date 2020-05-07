using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class WorkerOperations : Form
    {
        private BLL.Models.WorkerManager bllWorkerManager;
        public WorkerOperations()
        {
            InitializeComponent();
            bllWorkerManager = new WorkerManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void WorkerOperations_Load(object sender, EventArgs e)
        {
            GetWorkers();
            cmbWorkerSelect.SelectedIndex = 0;
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if (cmbWorkerSelect.SelectedIndex == 0)
            {
                bllWorkerManager.AddWorker(
                    txtWorkerName.Text,
                    txtWorkerLastname.Text,
                    txtWorkerEmail.Text,
                    txtWorkerUsername.Text,
                    txtUserPassword.Text,
                    Convert.ToDecimal(txtWorkerSalary.Text));

                MessageBox.Show("Worker added.");
            }
            else
            {
                MessageBox.Show("Please select --New Worker-- ");
            }
            GetWorkers();
        }

        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            if (cmbWorkerSelect.SelectedIndex != 0)
            {
                bllWorkerManager.UpdateWorker(
                    cmbWorkerSelect.SelectedItem.ToString(),
                    txtWorkerName.Text,
                    txtWorkerLastname.Text,
                    txtWorkerEmail.Text,
                    txtWorkerUsername.Text,
                    txtUserPassword.Text,
                    Convert.ToDecimal(txtWorkerSalary.Text)
                    );
                MessageBox.Show("Worker Updated.");
            }
            else
            {
                MessageBox.Show("Please select any worker.");
            }
            GetWorkers();
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (cmbWorkerSelect.SelectedIndex != 0)
            {
                bllWorkerManager.DeleteWorker(cmbWorkerSelect.SelectedItem.ToString());
                MessageBox.Show("Worker Deleted.");
            }
        }


        private void GetWorkers()
        {
            foreach (var item in bllWorkerManager.BLLGetWorkers())
            {
                if (!cmbWorkerSelect.Items.Contains(item))
                {
                    cmbWorkerSelect.Items.Add(item); 
                }
            }
        }


        private void cmbWorkerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWorkerSelect.SelectedIndex != 0)
            {
                List<Workers> workers = bllWorkerManager.FillWorkers(cmbWorkerSelect.SelectedItem.ToString());

                txtWorkerName.Text = workers[0].WorkerName;
                txtWorkerLastname.Text = workers[0].WorkerLastName;
                txtWorkerEmail.Text = workers[0].WorkerEmail;
                txtWorkerUsername.Text = workers[0].WorkerUsername;
                txtUserPassword.Text = workers[0].WorkerPassword;
                txtWorkerSalary.Text = workers[0].WorkerSalary.ToString();
            }
            else
            {
                txtWorkerName.Text = string.Empty;
                txtWorkerLastname.Text = string.Empty;
                txtWorkerEmail.Text = string.Empty;
                txtWorkerUsername.Text = string.Empty;
                txtUserPassword.Text = string.Empty;
                txtWorkerSalary.Text = string.Empty;
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
