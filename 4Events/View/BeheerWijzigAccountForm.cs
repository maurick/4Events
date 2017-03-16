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
using _4Events.Logic;
using _4Events.ViewModel;
using _4Events.Model;

namespace _4Events.View
{
    public partial class BeheerWijzigAccountForm : Form
    {
        BeheerWijzigAccountViewModel viewModel = new BeheerWijzigAccountViewModel();
        BeheerRepository beheerRepo = new BeheerRepository(new BeheerContext());

        public BeheerWijzigAccountForm()
        {
            InitializeComponent();
        }

        public void GetAccountInformation(Account account)
        {
            viewModel.Account = account;
            RefreshForm();
        }

        private void RefreshForm()
        {
            if (viewModel.Account == null)
            {
                MessageBox.Show("Kan form niet vullen.");
                return;
            }

            tbNaam.Text = viewModel.Account.Naam;
            tbPlaats.Text = viewModel.Account.Plaats;
            tbPostcode.Text = viewModel.Account.Postcode;
            tbStraat.Text = viewModel.Account.Straat;
            tbEmail.Text = viewModel.Account.Email;
            tbHuisnr.Text = viewModel.Account.Huisnummer.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Weet je zeker dat je " + viewModel.Account.Naam + " wil wijzigen?", "Waarschuwing",
                MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            viewModel.Account.Naam = tbNaam.Text;
            viewModel.Account.Plaats = tbPlaats.Text;
            viewModel.Account.Postcode = tbPostcode.Text;
            viewModel.Account.Straat = tbStraat.Text;
            viewModel.Account.Email = tbEmail.Text;
            viewModel.Account.Huisnummer = Convert.ToInt32(tbHuisnr.Text);
            beheerRepo.UpdateAccount(viewModel.Account);
            this.Close();
        }
    }
}
