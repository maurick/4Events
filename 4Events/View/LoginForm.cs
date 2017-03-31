using _4Events.Logic;
using System;
using System.Text;
using System.Windows.Forms;
using _4Events.Database;
using _4Events.View;
using _4Events.ViewModel;
using System.Configuration;
using System.Security.Principal;

namespace _4Events
{
    public partial class LoginForm : Form
    {
        Beheer beheer = new Beheer();
        LoginViewModel viewModel = new LoginViewModel();

        public LoginForm()
        {
            InitializeComponent();

            // Laat zien of debug aan staat met een label.
            if (Properties.Settings.Default.Debug)
                lblDebug.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((viewModel.Account = beheer.Login(tbEmail.Text, tbWachtwoord.Text)) != null)
            {
                beheer.CreateAccountCache(viewModel.Account);

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

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
