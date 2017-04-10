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

namespace _4Events.View
{
    public partial class ReserveringsForm : Form
    {
        ReserveringLogic reservering = new ReserveringLogic(new ReserveringContext());
        public ReserveringsForm()
        {
            InitializeComponent();

        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            reservering.Reserveer(Convert.ToInt32(cbKampeerplaatsen.Text), Convert.ToInt32(nudAantalpersonen.Value), dtpBegindatum.Value, dtpEinddatum.Value);
        }
    }
}
