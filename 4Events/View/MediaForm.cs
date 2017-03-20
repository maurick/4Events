using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4Events.Database;
using _4Events.Logic;
using _4Events.Model;
using _4Events.ViewModel;

namespace _4Events.View
{
    public partial class MediaForm : Form
    {
        MediaRepository mediaRepo = new MediaRepository(new MediaContext());
        BeheerRepository beheerRepo = new BeheerRepository(new BeheerContext());
        MediaViewModel viewModel = new MediaViewModel();

        public MediaForm()
        {
            InitializeComponent();

            viewModel.ListBerichten = mediaRepo.GetBerichten(5);
            viewModel.Account = beheerRepo.GetAccountById((beheerRepo.GetAccountCache()));
        }

        private void RefreshForm()
        {
            foreach (var bericht in viewModel.ListBerichten)
            {
                lbBerichten.Items.Add(bericht);
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
