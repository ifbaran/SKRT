using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class CustomerOperations : Form
    {
        BLL.Models.CustomerManager customerManager;
        public CustomerOperations()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
        }


        private void CustomerOperations_Load(object sender, EventArgs e)
        {
            GetCustomers();
            cmbSelectCustomer.SelectedIndex = 0;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (cmbSelectCustomer.SelectedIndex != 0)
            {
                customerManager.DeleteCustomer(cmbSelectCustomer.SelectedItem.ToString());
                MessageBox.Show("Customer Deleted.");
            }
            GetCustomers();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (cmbSelectCustomer.SelectedIndex != 0)
            {
                customerManager.UpdateCustomer(cmbSelectCustomer.SelectedItem.ToString(),txtCustomerName.Text,txtCustomerLastname.Text,txtCustomerEmail.Text);
                MessageBox.Show("Customer Updated.");
            }
            GetCustomers();
        }

        private void GetCustomers()
        {
            foreach (var item in customerManager.BLLGetCustomers())
            {
                if (!cmbSelectCustomer.Items.Contains(item))
                {
                    cmbSelectCustomer.Items.Add(item);
                }
            }
        }

        private void cmbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectCustomer.SelectedIndex != 0)
            {
                List<Customers> customers =  customerManager.FillCustomers(cmbSelectCustomer.SelectedItem.ToString());

                txtCustomerName.Text = customers[0].CustomerName;
                txtCustomerLastname.Text = customers[0].CustomerLastName;
                txtCustomerEmail.Text = customers[0].CustomerEmail;
            }
            else
            {
                txtCustomerName.Text = string.Empty;
                txtCustomerLastname.Text = string.Empty;
                txtCustomerEmail.Text = string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }

}
