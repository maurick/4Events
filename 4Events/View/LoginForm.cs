using _4Events.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4Events.Database;
using _4Events.Model;
using _4Events.View;

namespace _4Events
{
    public partial class LoginForm : Form
    {
        AccountRepository accountRepo = new AccountRepository(new AccountContext());

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbEmail.Text, tbWachtwoord.Text))
            {
                MessageBox.Show("Ingelogd");
                this.Hide();
                MainForm Form = new MainForm();
                Form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email of wachtwoord is verkeerd.");
            }
        }

        private bool Login(string email, string wachtwoord)
        {
            Account account = accountRepo.GetByEmail(email);
            if(wachtwoord == account.Password)
            {
                return true;
            }

            return false;
        }
    }
}
