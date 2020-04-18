using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        #region Form Hareket İşlemleri

        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X, MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }


        #endregion

        // Giriş İşlemleri
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (system.Login(txtUsername.Text, txtPassword.Text) != 0)
            //{
            //    SK4RT form = new SK4RT();
            //    form.Show();
            //    this.Hide();
            //}
            if (txtUsername.Text == "a" && txtPassword.Text=="a")
            {
                SK4RT form = new SK4RT();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
