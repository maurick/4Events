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
using _4Events.ViewModel;
using _4Events.Model;

namespace _4Events.View
{
    public partial class ReserveringsForm : Form
    {
        private Beheer beheer = new Beheer(new Database.BeheerContext());
        private BeheerViewModel viewModel = new BeheerViewModel();
        private ReserveringLogic reservering = new ReserveringLogic(new Database.ReserveringContext());

        public ReserveringsForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            viewModel.EventList = beheer.GetAllEvents();
            foreach (Event e in viewModel.EventList)
                cbEvent.Items.Add(e.Naam);
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wilt u nu betalen", "Betalen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                MessageBox.Show("Momenteel kan er niet betaald worden", "Oeps");
            else if (result == DialogResult.No)
                MaakReservering();
        }

        private void MaakReservering()
        {
            reservering.InsertReservering(reservering.NewReservering(viewModel.SelectedEvent, false));
            //Koppel aan accounts
        }

        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.SelectedEvent = viewModel.EventList.Find(x => x.Naam == cbEvent.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAccountForm aaf = new AddAccountForm();
            aaf.ShowDialog();
            if (aaf.DialogResult == DialogResult.OK)
            {
                lbAccounts.Items.AddRange(aaf.Accounts);
            }
        }
    }
}
