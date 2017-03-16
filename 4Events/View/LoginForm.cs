using _4Events.Logic;
using System;
using System.Text;
using System.Windows.Forms;
using _4Events.Database;
using _4Events.View;
using _4Events.ViewModel;
using System.Configuration;

namespace _4Events
{
    public partial class LoginForm : Form
    {
        BeheerRepository beheerRepo = new BeheerRepository(new BeheerContext());
        LoginViewModel viewModel = new LoginViewModel();

        public LoginForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Debug)
                lblDebug.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                beheerRepo.CreateAccountCache(viewModel.Account);

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
            wachtwoord = EncryptPassword(wachtwoord);

            viewModel.Account = beheerRepo.GetAccountByEmail(email);
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
