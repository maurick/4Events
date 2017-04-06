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

namespace _4Events.View
{
    public partial class VerhuurForm : Form
    {
        VerhuurLogic verhuurLogic;
        VerhuurViewModel viewmodel;

        public VerhuurForm()
        {
            InitializeComponent();

            verhuurLogic = new VerhuurLogic(new VerhuurContext());
            viewmodel = new VerhuurViewModel();

            viewmodel.ExemplaarList = verhuurLogic.GetExemplaren(999);

            RefreshForm();
        }

        private void RefreshForm()
        {
            lbVoorraad.Items.Clear();

            foreach (var exemplaar in viewmodel.ExemplaarList)
            {
                lbVoorraad.Items.Add(exemplaar);
            }
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
