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
    public partial class ToegangscontroleStatusFrom : Form
    {
        public bool Betalingsstatus { get { return Convert.ToBoolean(cbBetalingsstatus.SelectedText); } }
        public bool Ingechecked { get { return Convert.ToBoolean(cbIngechecked.SelectedText); } }

        public ToegangscontroleStatusFrom(bool betalingsstatus, bool ingechecked)
        {
            InitializeComponent();

            InitializeCombobox(betalingsstatus, cbBetalingsstatus);
            InitializeCombobox(ingechecked, cbIngechecked);
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
            this.DialogResult = DialogResult.OK;
        }
    }
}
