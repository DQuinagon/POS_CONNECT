using Bunifu.Framework.UI;
using POS_CONNECT.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_CONNECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.text == "Username")
            {
                username.text = string.Empty;
            }
            
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.text ==  string.Empty)
            {
                username.text = "Username";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.text == "Password")
            {
                password.text = string.Empty;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if(password.text == string.Empty)
            {
                password.text = "Password";
            }
        }

        private void password_OnTextChange(object sender, EventArgs e)
        {
            if (password.text == "" || password.text == "Password")
            {

            }
            else
            {
                password._TextBox.PasswordChar = '*';
            }
            password.ForeColor = Color.FromArgb(177, 177, 177);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username.text == "user1" && password.text == "Password1")
            {
                menu mainmenu = new menu();
                mainmenu.Show();
                this.Hide();
            }else if(username.text == "Username" || username.text == "")
            {
                errtime.Start();
                errmessage.Text = "Error: Username cannot be empty";
                username.ForeColor = Color.IndianRed;
                errlog.Visible = true;
               
            }
            else if (password.text == "Password" || password.text == "")
            {
                errtime.Start();
                errmessage.Text = "Error: Password cannot be empty";
                password.ForeColor = Color.IndianRed;
                errlog.Visible = true;
            }
            else
            {
                errtime.Start();
                errmessage.Text = "Error: Invalid email or Password";
                errlog.Visible = true;
            }
        }

        private void errtime_Tick(object sender, EventArgs e)
        {
            errlog.Visible = false;
            errtime.Stop();
        }

        private void username_OnTextChange(object sender, EventArgs e)
        {
            username.ForeColor = Color.FromArgb(177, 177, 177);
        }
    }
}
