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
            MessageBox.Show("Welkom, " + viewModel.Account.Naam);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Form = new LoginForm();
            Form.ShowDialog();
            this.Close();
        }
    }
}
