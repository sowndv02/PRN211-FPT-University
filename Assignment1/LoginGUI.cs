using Assignment1.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment1
{
    public partial class LoginGUI : Form
    {
        public event EventHandler<LoginEventArgs> LoginSuccessful;
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text.Trim();
            string pass = tbPassword.Text.Trim();
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill full input!");
            }
            else
            {
                Admin admin = GetAdmin();
                if (admin != null)
                {
                    if (admin.Password.Equals(pass) && admin.Username.Equals(user))
                    {
                        DialogResult = DialogResult.OK;
                        LoginSuccessful?.Invoke(this, new LoginEventArgs(user));
                        frmCarGUI frmCarGUI = new frmCarGUI(user);
                        frmCarGUI.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Admin GetAdmin()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminUsername = configuration["Admin:Username"];
            string adminPassword = configuration["Admin:Password"];
            return new Admin(adminUsername, adminPassword);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCarGUI frmCarGUI = new frmCarGUI(null);
            frmCarGUI.Show();
        }
    }

    public class LoginEventArgs : EventArgs
    {
        public string UserName { get; }

        public LoginEventArgs(string userName)
        {
            UserName = userName;
        }
    }
}
