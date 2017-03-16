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
using _4Events.Logic;
using _4Events.Database;
using _4Events.Model;

namespace _4Events.View
{
    public partial class AccountBeheerForm : Form
    {
        AccountBeheerViewModel viewModel = new AccountBeheerViewModel();
        BeheerRepository accountRepo = new BeheerRepository(new BeheerContext());

        public AccountBeheerForm()
        {
            InitializeComponent();

            viewModel.Account = accountRepo.GetAccountById(accountRepo.GetAccountCache());
            
            RefreshForm();
        }

        private void RefreshForm()
        {
            viewModel.AccountList = accountRepo.GetAllAccounts();

            lbAccounts.Items.Clear();

            foreach (var account in viewModel.AccountList)
            {
                lbAccounts.Items.Add(account);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Weet je zeker dat je " + viewModel.SelectedAccount.Naam + " wil verwijderen?", "Waarschuwing",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            accountRepo.DeleteAccount(viewModel.SelectedAccount.ID);

            RefreshForm();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAccounts.SelectedItem != null)
                viewModel.SelectedAccount = (Account)lbAccounts.SelectedItem;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            AccountBeheerWijzigForm Form = new AccountBeheerWijzigForm();
            Form.GetAccountInformation(viewModel.SelectedAccount);
            Form.ShowDialog();
            RefreshForm();
        }
    }
}
