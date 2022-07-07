using SchoolManagmentStudio_DavitKldiashvili;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DavitKldiashvili
{
    public partial class LoginForm : Dashboard
    {
        private object txtusername;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            if (txtusername == "Enter Username")
            {
                txtusername = "";
                txtusername = Color.Black;
            }
        }

        private void txtusername_leave(object sender, EventArgs e)
        {

            if (txtusername == "Enter Password")
            {
                txtusername = "";
                txtusername = Color.Silver;
            }
        }
        private void txtpassword_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Enter Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}