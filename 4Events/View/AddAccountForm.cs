using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Events.View
{
    public partial class AddAccountForm : Form
    {
        public ListBox.ObjectCollection Accounts { get { return lbSelectedAccounts.Items; } }

        public AddAccountForm()
        {
            InitializeComponent();

            InitializeAccounts();
        }

        private void InitializeAccounts()
        {
            foreach (Model.Account account in new Logic.Beheer(new Database.BeheerContext()).GetAllAccounts())
                lbAccounts.Items.Add(account);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lbSelectedAccounts.SelectedItem != null)
            {
                lbAccounts.Items.Add(lbSelectedAccounts.SelectedItem);
                lbSelectedAccounts.Items.Remove(lbSelectedAccounts.SelectedItem);
                lbSelectedAccounts.Sorted = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedItem != null)
            {
                lbSelectedAccounts.Items.Add(lbAccounts.SelectedItem);
                lbAccounts.Items.Remove(lbAccounts.SelectedItem);
                lbAccounts.Sorted = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
