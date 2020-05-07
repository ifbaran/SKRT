using System;
using System.Drawing;
using System.Windows.Forms;
using BLL.Models;

namespace WinUI
{
    public partial class CustomerForm : Form
    {
        private BLL.Models.CustomerManager customerManager;
        public CustomerForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
            grdCustomer.EnableHeadersVisualStyles = false;
            grdCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdCustomer.Columns[0].HeaderText = "Customer ID";
            grdCustomer.Columns[1].HeaderText = "Customer Name";
            grdCustomer.Columns[2].HeaderText = "Customer Surname";
            grdCustomer.Columns[3].HeaderText = "Customer Email";
        }

        private void GetCustomers()
        {
            try
            {
                grdCustomer.DataSource = customerManager.DataGridViewCustomers();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
        private void grdCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdCustomer.ClearSelection();
        }

        private void grdCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketSale.CustomerId = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
            this.Close();
            TicketOperation.customerId = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
