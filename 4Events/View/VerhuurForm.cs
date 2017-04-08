using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4Events.Logic;
using _4Events.Database;
using _4Events.ViewModel;
using _4Events.Model;
using _4Events.RFID;

namespace _4Events.View
{
    public partial class VerhuurForm : Form
    {
        VerhuurLogic verhuurLogic;
        Beheer beheer;
        VerhuurViewModel viewmodel;
        RFID.RFID rf;

        public VerhuurForm()
        {
            InitializeComponent();

            verhuurLogic = new VerhuurLogic(new VerhuurContext());
            beheer = new Beheer(new BeheerContext());
            viewmodel = new VerhuurViewModel();

            rf = new RFID.RFID();
            rf.Open();
            if (rf.IsAttached == false)
            {
                MessageBox.Show("Geen RFID reader gevonden.\nDit form werkt niet zonder RFID!");
            }

            viewmodel.ExemplaarList = verhuurLogic.GetExemplaren(999);
            

            RefreshForm();
        }

        private void RefreshForm()
        {
            lbAccount.Items.Clear();
            lbVoorraad.Items.Clear();

            foreach (var exemplaar in viewmodel.ExemplaarList)
            {
                lbVoorraad.Items.Add(exemplaar);
            }

            // Account moet eerst worden opgehaald met RFID
            if (viewmodel.Account != null)
            {
                /* TODO
                foreach (var verhuur in accountverhuur)
                {

                }
                */
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnTeruggave_Click(object sender, EventArgs e)
        {
            if (lbAccount.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een verhuurd item uit de accout list box.");
                return;
            }
            if (rf.CurrentRFIDTag == null)
            {
                MessageBox.Show("Geen RFID tag gevonden.\nHou de tag boven de scanner.");
                return;
            }
            viewmodel.Account = beheer.GetAccountByRFID(rf.CurrentRFIDTag);

            // ?? staat niet in de requirement
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            if (lbVoorraad.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een item uit de voorraad list box.");
                return;
            }
            if (rf.CurrentRFIDTag == null)
            {
                MessageBox.Show("Geen RFID tag gevonden.\nHou de tag boven de scanner.");
                return;
            }
            viewmodel.Account = beheer.GetAccountByRFID(rf.CurrentRFIDTag);
            verhuurLogic.InsertVerhuur(new Verhuur()
            {
                Account = viewmodel.Account,
                DatumBegin = DateTime.Today,
                DatumEind = DateTime.Today,
                Exemplaar = (Exemplaar)lbVoorraad.SelectedItem
            });
            MessageBox.Show("Item verhuurd");
            RefreshForm();
        }

        private void VerhuurForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf.Close();
            Dispose();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            if (rf.CurrentRFIDTag == null)
            {
                MessageBox.Show("Geen RFID tag gevonden.\nHou de tag boven de scanner.");
                return;
            }

            MessageBox.Show("nee");
            //GetListVerhuurAccount(Account)

            // foreach exemplaar in verhuur lbAccount.add(exemplaar)
        }
    }
}
