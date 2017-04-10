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
using System.Timers;

namespace _4Events.View
{
    public partial class ToegangscontroleStatusFrom : Form
    {
        public bool Betalingsstatus { get { return Convert.ToBoolean(cbBetalingsstatus.SelectedItem); } }
        public bool Ingechecked { get { return Convert.ToBoolean(cbIngechecked.SelectedItem); } }

        private Beheer beheer;
        private BeheerViewModel viewModel;

        System.Timers.Timer timerRFID;
        RFID.RFID rf;

        public ToegangscontroleStatusFrom(bool betalingsstatus, bool ingechecked, Beheer beheer, BeheerViewModel viewModel)
        {
            InitializeComponent();

            InitializeCombobox(betalingsstatus, cbBetalingsstatus);
            InitializeCombobox(ingechecked, cbIngechecked);
            this.beheer = beheer;
            this.viewModel = viewModel;

            rf = new RFID.RFID();
            rf.Open();
            if (rf.IsAttached == false)
            {
                MessageBox.Show("Geen RFID reader gevonden.", "Melding");
            }

            InitializeRFIDTimer();
        }

        private void InitializeCombobox(bool status, ComboBox box)
        {
            if (status)
            {
                box.SelectedIndex = 0;
                return;
            }
            box.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(cbIngechecked.SelectedItem) && !Convert.ToBoolean(cbBetalingsstatus.SelectedItem))
                MessageBox.Show("Kan niet inchecken, nog niet betaald", "Oeps");
            else if (!beheer.InsertRFID(viewModel.SelectedAccount.ID, tbRFID.Text))
                MessageBox.Show("Kan RFID niet aan account koppelen.\nCheck of de RFID tag in de database zit od het account is al aan deze tag gekoppelt.", "Error");
            else
                this.DialogResult = DialogResult.OK;
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
            if (rf.CurrentRFIDTag != null)
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

        private void ToegangscontroleStatusFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf.Close();
            this.Dispose();
        }
    }
}
