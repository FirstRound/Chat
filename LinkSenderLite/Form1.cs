using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Chat
{
    public partial class Autorithation : Form
    {
        Admin admin;

        public Autorithation()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 1;
        }

        private bool signIn(String login, String password)
        {
            admin = new Admin(login, password);
            if (!admin.authorization())
            {
                MessageBox.Show("Wrong login or password!");
                return false;
            }
            return true;
        }
        
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpBtn.Hide();
            progressBar1.Visible = true;
            if(signIn(LoginBox.Text, PasswordBox.Text))
            {
                if (!Directory.Exists(Application.StartupPath + "/files/"))
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "/files/");
                MainWindow main = new MainWindow(admin);
                Hide();
                main.Show();

            }
            else 
            {
                progressBar1.Visible = false;
                SignUpBtn.Show();
                PasswordBox.Text = "";
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _signInBtn();
                e.Handled = true;
            }
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _signInBtn();
                e.Handled = true;
            }
        }

        private void _signInBtn()
        {
            SignUpBtn.Hide();
            progressBar1.Visible = true;
            if (signIn(LoginBox.Text, PasswordBox.Text))
            {
                if (!Directory.Exists(Application.StartupPath + "/files/"))
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "/files/");
                MainWindow main = new MainWindow(admin);
                Hide();
                main.Show();

            }
            else
            {
                progressBar1.Visible = false;
                SignUpBtn.Show();
                PasswordBox.Text = "";
            }
        }
    }
}
