using System;
using System.Windows.Forms;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class SaveCustomer : Form
    {
        private Customers _customers;
        private BLL.Models.CustomerManager customerManager;
        public SaveCustomer(Customers customer)
        {
            InitializeComponent();
            _customers = customer;
            customerManager = new CustomerManager();
        }

        #region Form Hareketi

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X, MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }


        #endregion

        private void SaveCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = _customers.CustomerName;
            txtCustomerSurname.Text = _customers.CustomerLastName;
            txtCustomerEmail.Text = _customers.CustomerEmail;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            
            try
            {
                customerManager.AddCustomer(txtName.Text,txtCustomerSurname.Text,txtCustomerEmail.Text);
                MessageBox.Show("Kayıt Başarıyla Alınmıştır.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }
    }
}
