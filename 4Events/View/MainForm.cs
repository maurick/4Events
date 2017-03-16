using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4Events.ViewModel;
using _4Events.Database;
using _4Events.Logic;
using System.Configuration;

namespace _4Events.View
{
    public partial class MainForm : Form
    {
        MainViewModel viewModel = new MainViewModel();
        AccountRepository accountRepo = new AccountRepository(new AccountContext());

        public MainForm()
        {
            InitializeComponent();
            // Globale authenticatie
            // TODO:
            // Beter Implementeren. Met expiration date
            viewModel.Account = accountRepo.GetById(accountRepo.GetAccountCache());
            lblWelkom.Text = "Welkom, " + viewModel.Account.Naam;
            lblFunctie.Text = "Uw huidige functie is: " + viewModel.Account.Functie.ToString();

            AccessControl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Form = new LoginForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnAccountBeheer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountBeheerForm Form = new AccountBeheerForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnEventBeheer_Click(object sender, EventArgs e)
        {

        }

        private void AccessControl()
        {
            switch (viewModel.Account.Functie)
            {
                // Alle controls als default disabled.
                // Hier worden ze op enabled gezet.

                case (Enums.Functie.Beheerder):
                    /* Buttons */
                    btnAccountBeheer.Enabled = true;
                    break;
                case (Enums.Functie.Medewerker):
                    /* Buttons */
                    btnAccountBeheer.Enabled = true;
                    break;
                case (Enums.Functie.Bezoeker):
                    break;
                default:
                    break;
            }
        }
    }
}
