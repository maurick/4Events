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
using System.Security;

namespace _4Events.View
{
    public partial class MainForm : Form
    {
        MainViewModel viewModel = new MainViewModel();
        Beheer beheer = new Beheer(new BeheerContext());

        public MainForm()
        {
            InitializeComponent();
            // Globale authenticatie
            // TODO:
            // Beter Implementeren. Met expiration date?
            viewModel.Account = beheer.GetAccountById(beheer.GetAccountCache());
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
            BeheerForm Form = new BeheerForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            this.Hide();
            MediaForm form = new MediaForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReserveringsForm form = new ReserveringsForm();
            form.ShowDialog();
            this.Close();
        }

        private void AccessControl()
        {
            switch (viewModel.Account.Functie)
            {
                // Alle controls als default disabled.
                // Hier worden ze op enabled gezet.

                case (Enums.Functie.Beheerder):
                    btnAccountBeheer.Enabled = true;
                    break;
                case (Enums.Functie.Medewerker):
                    btnAccountBeheer.Enabled = true;
                    break;
                case (Enums.Functie.Bezoeker):
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToegangscontroleFrom form = new ToegangscontroleFrom();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerhuurForm form = new VerhuurForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
