using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class EmailForm : Form
    {
        private CustomerManager customerManager;
        private WorkerManager workerManager;
        private SendMailManager sendMailManager;
        public EmailForm()
        {
            InitializeComponent();
            CustomerWorkerNotChoose();
            customerManager = new CustomerManager();
            workerManager = new WorkerManager();
            sendMailManager = new SendMailManager();
        }

        private void CustomerWorkerNotChoose()
        {
            if (!radCustomer.Checked || !radWorker.Checked)
            {
                    lblChoise.Text = "Please fill step-1.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radContact_Click(object sender, EventArgs e)
        {
            using (SK4RTContext context = new SK4RTContext())
            {
                if (radCustomer.Checked)
                {
                    lblChoise.Text = "Customer: ";
                    List<Customers> customers = context.Customers.ToList();
                    cmbContact.DataSource = customerManager.BLLGetCustomers();
                    
                }
                else
                {
                    lblChoise.Text = "Worker: ";
                    List<Workers> workers= context.Workers.ToList();
                    cmbContact.DataSource = workerManager.BLLGetWorkers();
                }
            }
        }
        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SK4RTContext context = new SK4RTContext())
            {
                if (radCustomer.Checked)
                {
                    txtEmail.Text =
                        context.Customers.Where(x =>
                                (x.CustomerName + " " + x.CustomerLastName) == cmbContact.SelectedItem.ToString())
                            .ToList()[0]
                            .CustomerEmail;
                }
                else
                {
                    txtEmail.Text =
                        context.Workers.Where(x =>
                                (x.WorkerName + " " + x.WorkerLastName) == cmbContact.SelectedItem.ToString())
                            .ToList()[0]
                            .WorkerEmail;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMailManager.SendMail(txtEmail.Text,txtSubject.Text,txtMessage.Text);
        }
    }
}
