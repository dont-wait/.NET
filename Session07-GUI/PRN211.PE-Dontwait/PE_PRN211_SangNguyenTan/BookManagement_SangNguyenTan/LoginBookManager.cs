using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_SangNguyenTan
{
    public partial class LoginBookManager : Form
    {
        public LoginBookManager()
        {
            InitializeComponent();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
                txtEmail.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //chửi khi không nhập gì cả
            //validation
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPasssword.Text))
            {
                MessageBox.Show("Please input both Email and password", "Input please", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            UserAccountService service = new();
            UserAccount? acc = service.CheckLogin(txtEmail.Text, txtPasssword.Text);
            if (acc == null)
            {
                MessageBox.Show("Login failed. Check your email and password again!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //acc okie, khác null
            if(acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong privilage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                 
            else
            {
                BookManagerManUI bookManagerManUI = new();
                bookManagerManUI.Show();
                this.Hide();
            }
            
        }

        private void txtPasssword_Click(object sender, EventArgs e)
        {
            if (txtPasssword.Text != "")
                txtPasssword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
