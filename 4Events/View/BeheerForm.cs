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
using _4Events.RFID;
using System.Timers;

namespace _4Events.View
{
    public partial class BeheerForm : Form
    {
        BeheerViewModel viewModel = new BeheerViewModel();
        Beheer beheer = new Beheer(new BeheerContext());
        ReserveringLogic reserveer = new ReserveringLogic(new ReserveringContext());
        System.Timers.Timer timer;
        System.Timers.Timer timerRFID;
        RFID.RFID rf;


        public BeheerForm()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeRFIDTimer();

            viewModel.Account = beheer.GetAccountById(beheer.GetAccountCache());

            rf = new RFID.RFID();
            rf.Open();
            if (rf.IsAttached == false)
            {
                MessageBox.Show("Geen RFID gevonden.", "Melding");
            }

            RefreshForm();
        }

        private void RefreshForm()
        {
            viewModel.AccountList = beheer.GetAllAccounts();
            viewModel.EventList = beheer.GetAllEvents();
            viewModel.LocatieList = reserveer.GetAllLocaties();

            lvAccounts.Items.Clear();
            lvEvents.Items.Clear();
            cbLocatie.Items.Clear();

            foreach (var locatie in viewModel.LocatieList)
            {
                cbLocatie.Items.Add(locatie);
            }

            foreach (var account in viewModel.AccountList)
            {
                lvAccounts.Items.Add(new ListViewItem(new string[] { account.ID.ToString(), account.Naam, account.Email, account.Functie.ToString() }));
            }

            foreach (var item in viewModel.EventList)
            {
                lvEvents.Items.Add(new ListViewItem(new string[] { item.Naam, item.Datum.ToString(), item.MaxBezoekers.ToString() }));
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

            beheer.DeleteAccount(viewModel.SelectedAccount.ID);

            RefreshForm();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvAccounts.SelectedItems.Count != 0)
            {
                viewModel.SelectedAccount = viewModel.AccountList.Find(x => x.ID == Convert.ToInt32(lvAccounts.SelectedItems[0].Text));
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
            if (lvEvents.SelectedItems != null)
            {
                viewModel.SelectedEvent = viewModel.EventList.Find(x => x.Naam == lvEvents.SelectedItems[0].Text);

                tbEventNaam.Text = viewModel.SelectedEvent.Naam;
                tbEventBezoekers.Text = Convert.ToString(viewModel.SelectedEvent.MaxBezoekers);
                dtpEvent.Value = viewModel.SelectedEvent.Datum;
            }
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

            Account newAccount = beheer.GetAccountById(viewModel.SelectedAccount.ID);
            newAccount.Naam = tbNaam.Text;
            newAccount.Plaats = tbPlaats.Text;
            newAccount.Huisnummer = Convert.ToInt32(tbHuisnr.Text);
            newAccount.Postcode = tbPostcode.Text;
            newAccount.Email = tbEmail.Text;
            
            beheer.UpdateAccount(newAccount);
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

            beheer.InsertEvent(newEvent);
            RefreshForm();
        }

        private void RefreshOverzicht()
        {
            int RSelected = -1,
                ASelected = -1;
            if (lvReservering.Items.Count > 0)
                RSelected = lvReservering.SelectedIndices[0];
            if (lvAanwezig.Items.Count > 0)
                ASelected = lvAanwezig.SelectedIndices[0];
            lvAanwezig.Items.Clear();
            lvReservering.Items.Clear();
            if (viewModel.SelectedEvent != null)
            {
                viewModel.Aanwezigen = beheer.GetPresentAccountsByEventID(viewModel.SelectedEvent.ID);
                viewModel.ReserveringList = reserveer.GetAllReserveringen();
                
                foreach (var reservering in viewModel.ReserveringList)
                {
                    lvReservering.Items.Add(new ListViewItem(new string[] { reservering.MainAccountNaam, Convert.ToString(reservering.Betaald) }));
                }

                foreach (var account in viewModel.Aanwezigen)
                {
                    lvAanwezig.Items.Add(new ListViewItem(new string[] { account.Naam }));
                }
                if (ASelected != -1)
                    lvAanwezig.Items[ASelected].Selected = true;
                else
                    lvAanwezig.Items[0].Selected = true;
                if (RSelected != -1)
                    lvReservering.Items[RSelected].Selected = true;
                else
                    lvReservering.Items[0].Selected = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage3;
            RefreshOverzicht();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(TimerTick);
            timer.Interval = 5000;
        }

        private void InitializeRFIDTimer()
        {
            timerRFID = new System.Timers.Timer();
            timerRFID.Elapsed += new ElapsedEventHandler(RFIDTimerTick);
            timerRFID.Interval = 1000;
            timerRFID.Start();
        }

        private void RFIDTimerTick(object sender, ElapsedEventArgs e)
        {
            if(rf.CurrentRFIDTag != null)
            {
                InvokeRFID();
            }
        }

        private void InvokeRFID()
        {
            if (InvokeRequired)
            {
                try
                {
                    MethodInvoker method = new MethodInvoker(InvokeRFID);
                    Invoke(method);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            tbRFID.Text = rf.CurrentRFIDTag;
        }

        private void InvokeOverzicht()
        {
            if (InvokeRequired)
                try
                {
                    MethodInvoker method = new MethodInvoker(RefreshOverzicht);
                    Invoke(method);
                    return;
                }
                catch (Exception)
                {

                }
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            InvokeOverzicht();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enables RFID on the account page
            if(tabControl.SelectedTab == tabPage1)
            {
                if (!timerRFID.Enabled)
                {
                    timerRFID.Start();
                }
            }
            else if (timerRFID.Enabled)
                timerRFID.Stop();

            if (tabControl.SelectedTab == tabPage3)
            {
                if (!timer.Enabled)
                    timer.Start();
            }
            else if (timer.Enabled)
                timer.Stop();
        }

        private void BeheerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf.Close();
            Dispose();
        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            if(beheer.InsertRFID(viewModel.SelectedAccount.ID, "rfidnummer"/* tbRFID.Text */))
            {
                MessageBox.Show("RFID aan account gekoppeld.");
            }
            else
            {
                MessageBox.Show("Kan RFID niet aan account koppelen.\nCheck of de RFID tag in de database zit od het account is al aan deze tag gekoppelt.");
            }
        }
    }
}
