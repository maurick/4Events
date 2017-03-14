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
using _4Events.ViewModel;

namespace _4Events
{
    public partial class LoginForm : Form
    {
        AccountRepository accountRepo = new AccountRepository(new AccountContext());
        LoginViewModel viewModel = new LoginViewModel();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm Form = new MainForm();

            foreach (Control textbox in this.Controls)
            {
                if (textbox is TextBox && string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld.");
                    return;
                }
            }

            if (Login(tbEmail.Text, tbWachtwoord.Text))
            {
                MessageBox.Show("Ingelogd");

                accountRepo.CreateAccountCache(viewModel.Account);

                this.Hide();
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
            wachtwoord = EncryptPassword(wachtwoord);

            viewModel.Account = accountRepo.GetByEmail(email);
            if(viewModel.Account != null && wachtwoord == viewModel.Account.Password)
            {
                return true;
            }

            return false;
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }


        // Waar moet dit
        private string EncryptPassword(string inputString)
        {
            byte[] data = Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
