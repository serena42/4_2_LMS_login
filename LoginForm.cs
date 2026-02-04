using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4_2_LMS_login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "teacher" && txtPassword.Text == "admin")
            {
                var s = new StudentCRUD();
                s.Show();
            }
            else
            {
                MessageBox.Show("Try again!");
            }
        }
    }
}

