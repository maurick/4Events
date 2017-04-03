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
    public partial class ToegangscontroleFrom : Form
    {
        private enum FormState
        {
            Event,
            Reservering
        }

        private FormState formState = FormState.Event;
        private BeheerViewModel viewModel = new BeheerViewModel();
        private Beheer beheer = new Beheer(new BeheerContext());
        private ReserveringLogic reserveer = new ReserveringLogic(new ReserveringContext());

        public ToegangscontroleFrom()
        {
            InitializeComponent();
            InitializeEventColumns();
        }

        private void InitializeEventColumns()
        {
            listView.Columns.Clear();
            listView.Columns.AddRange(new ColumnHeader[] { new ColumnHeader("Naam"), new ColumnHeader("Datum"), new ColumnHeader("Max Bezoekers") });
            listView.Columns[0].Text = "Naam";
            listView.Columns[0].Width = 120;
            listView.Columns[1].Text = "Datum";
            listView.Columns[1].Width = 80;
            listView.Columns[2].Text = "Max Bez.";
            listView.Columns[2].Width = 60;

            RefreshEvents();
        }

        private void RefreshEvents()
        {
            viewModel.EventList = beheer.GetAllEvents();

            listView.Items.Clear();

            foreach (var item in viewModel.EventList)
            {
                listView.Items.Add(new ListViewItem(new string[] { item.Naam, item.Datum.ToString(), item.MaxBezoekers.ToString() }));
            }
        }

        private void InitializeReserveringColumns()
        {
            listView.Columns.Clear();
            listView.Columns.AddRange(new ColumnHeader[] { new ColumnHeader("ID"), new ColumnHeader("Naam"), new ColumnHeader("Betalingsstatus"), new ColumnHeader("Ingechecked") });
            listView.Columns[0].Text = "ID";
            listView.Columns[0].Width = 40;
            listView.Columns[1].Text = "Naam";
            listView.Columns[1].Width = 100;
            listView.Columns[2].Text = "Betalingsstatus";
            listView.Columns[2].Width = 90;
            listView.Columns[3].Text = "Ingechecked";
            listView.Columns[3].Width = 80;

            RefreshReserveringen();
        }

        private void RefreshReserveringen()
        {
            viewModel.ReserveringList = reserveer.GetReserveringenByEvent(viewModel.SelectedEvent.ID);

            listView.Items.Clear();

            foreach (Reservering reservering in viewModel.ReserveringList)
            {
                listView.Items.Add(new ListViewItem(new string[] { reservering.ID.ToString(), reservering.MainAccountNaam, reservering.Betaald.ToString(), reservering.Ingechecked.ToString() }));
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (formState == FormState.Event)
            {
                viewModel.SelectedEvent = viewModel.EventList.Find(x => x.Naam == listView.SelectedItems[0].Text);
                formState = FormState.Reservering;
                InitializeReserveringColumns();
            }
            else if (formState == FormState.Reservering)
            {
                viewModel.SelectedReservering = viewModel.ReserveringList.Find(x => x.ID == Convert.ToInt32(listView.SelectedItems[0].Text));
                ToegangscontroleStatusFrom statusForm = new ToegangscontroleStatusFrom(viewModel.SelectedReservering.Betaald, viewModel.SelectedReservering.Ingechecked);
                statusForm.ShowDialog();
                if (statusForm.DialogResult == DialogResult.OK)
                {
                    viewModel.SelectedReservering.Update(statusForm.Betalingsstatus, statusForm.Ingechecked);
                    reserveer.UpdateReservering(viewModel.SelectedReservering);
                    statusForm.Close();
                    statusForm.Dispose();
                }
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            if (formState == FormState.Event)
            {
                this.Hide();
                MainForm form = new MainForm();
                form.ShowDialog();
                this.Close();
            }
            else if (formState == FormState.Reservering)
            {
                InitializeEventColumns();
                formState = FormState.Event;
            }
        }
    }
}
