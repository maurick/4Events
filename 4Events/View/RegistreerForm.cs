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
using _4Events.Model;
using _4Events.Logic;
using _4Events.Database;

namespace _4Events.View
{
    public partial class RegistreerForm : Form
    {
        RegistreerViewModel viewModel = new RegistreerViewModel();
        AccountRepository accountRepo = new AccountRepository(new AccountContext());

        public RegistreerForm()
        {
            InitializeComponent();
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            foreach (Control textbox in this.Controls)
            {
                if(textbox is TextBox && string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld.");
                    return;
                }
            }

            if (tbWachtwoord.Text != tbHerhaal.Text)
            {
                MessageBox.Show("Wachtwoord is niet hetzelfde.");
                return;
            }

            Account newAccount = new Account()
            {
                Naam = tbNaam.Text,
                Email = tbEmail.Text,
                Huisnummer = Convert.ToInt32(tbHuisnr.Text),
                ID = 0,
                HuisnummerToevoeging = "0",
                Password = tbWachtwoord.Text,
                Plaats = tbPlaats.Text,
                Postcode = tbPostcode.Text,
                Straat = tbStraat.Text
            };

            if (Properties.Settings.Default.Debug)
                newAccount.Functie = Enums.Functie.Beheerder;
            else
                newAccount.Functie = Enums.Functie.Bezoeker;


            if (accountRepo.Insert(newAccount) != null)
            {
                MessageBox.Show("GEREGISTREERD");
                Terug();
            }
            else
            {
                MessageBox.Show("FAILURE");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Terug();
        }

        private void Terug()
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
