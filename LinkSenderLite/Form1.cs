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
using ComponentFactory.Krypton.Toolkit;

namespace Chat
{
    public partial class Autorithation : KryptonForm
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

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            SignInBtn.Hide();
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
                SignInBtn.Show();
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
            SignInBtn.Hide();
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
                SignInBtn.Show();
                PasswordBox.Text = "";
            }
        }

        
    }
}
