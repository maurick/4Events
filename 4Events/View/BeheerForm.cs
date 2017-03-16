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
    public partial class BeheerForm : Form
    {
        BeheerViewModel viewModel = new BeheerViewModel();
        BeheerRepository beheerRepo = new BeheerRepository(new BeheerContext());
        ReserveringRepository reserveerRepo = new ReserveringRepository(new ReserveringContext());

        public BeheerForm()
        {
            InitializeComponent();

            viewModel.Account = beheerRepo.GetAccountById(beheerRepo.GetAccountCache());
            
            RefreshForm();
        }

        private void RefreshForm()
        {
            viewModel.AccountList = beheerRepo.GetAllAccounts();
            viewModel.EventList = beheerRepo.GetAllEvents();
            viewModel.LocatieList = reserveerRepo.GetAllLocaties();

            lbAccounts.Items.Clear();
            lbEvents.Items.Clear();
            cbLocatie.Items.Clear();

            foreach (var locatie in viewModel.LocatieList)
            {
                cbLocatie.Items.Add(locatie);
            }

            foreach (var account in viewModel.AccountList)
            {
                lbAccounts.Items.Add(account);
            }

            foreach (var item in viewModel.EventList)
            {
                lbEvents.Items.Add(item);
            }

            cbLocatie.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(viewModel.SelectedAccount == null)
            {
                MessageBox.Show("Geen account geselecteerd.");
                return;
            }

            if (MessageBox.Show(
                "Weet je zeker dat je " + viewModel.SelectedAccount.Naam + " wil verwijderen?", "Waarschuwing",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            beheerRepo.DeleteAccount(viewModel.SelectedAccount.ID);

            RefreshForm();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAccounts.SelectedItem != null)
            {
                viewModel.SelectedAccount = (Account)lbAccounts.SelectedItem;
            }

            tbNaam.Text = viewModel.SelectedAccount.Naam;
            tbPlaats.Text = viewModel.SelectedAccount.Plaats;
            tbPostcode.Text = viewModel.SelectedAccount.Postcode;
            tbStraat.Text = viewModel.SelectedAccount.Straat;
            tbEmail.Text = viewModel.SelectedAccount.Email;
            tbHuisnr.Text = viewModel.SelectedAccount.Huisnummer.ToString();
        }

        private void SelectedEventChanged(object sender, EventArgs e)
        {
            if (lbEvents.SelectedItem != null)
                viewModel.SelectedEvent = (Event)lbEvents.SelectedItem;

            tbEventNaam.Text = viewModel.SelectedEvent.Naam;
            tbEventBezoekers.Text = Convert.ToString(viewModel.SelectedEvent.MaxBezoekers);
            dtpEvent.Value = viewModel.SelectedEvent.Datum;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (viewModel.SelectedAccount == null)
            {
                MessageBox.Show("Geen account geselecteerd.");
                return;
            }

            if (MessageBox.Show(
                    "Weet je zeker dat je " + viewModel.SelectedAccount.Naam + " wil wijzigen?", "Waarschuwing",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Account newAccount = beheerRepo.GetAccountById(viewModel.SelectedAccount.ID);
            newAccount.Naam = tbNaam.Text;
            newAccount.Plaats = tbPlaats.Text;
            newAccount.Huisnummer = Convert.ToInt32(tbHuisnr.Text);
            newAccount.Postcode = tbPostcode.Text;
            newAccount.Email = tbEmail.Text;
            
            beheerRepo.UpdateAccount(newAccount);
            RefreshForm();
        }

        private void btnNieuwEvent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Weet je zeker dat je " + tbEventNaam.Text + " wil aanmaken?", "Waarschuwing",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            Locatie selectedLocatie;
            if ((selectedLocatie = (Locatie)cbLocatie.SelectedItem) == null)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld.");
                return;
            }

            foreach (Control textbox in tabControl.SelectedTab.Controls)
            {
                if (textbox is TextBox && string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld.");
                    return;
                }
            }

            Event newEvent = new Event()
            {
                Naam = tbEventNaam.Text,
                Datum = dtpEvent.Value,
                LocatieID = selectedLocatie.ID,
                MaxBezoekers = Convert.ToInt32(tbEventBezoekers.Text)
            };

            beheerRepo.InsertEvent(newEvent);
            RefreshForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
