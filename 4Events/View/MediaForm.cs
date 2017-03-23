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
using _4Events.Properties;

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

            RefreshForm();
        }

        private void RefreshForm()
        {
            lbBerichten.Items.Clear();

            foreach (var bericht in viewModel.ListBerichten)
            {
                if(bericht.ReplyTo == null)
                {
                    lbBerichten.Items.Add(bericht);
                }
            }

            rtbTekst.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tekst);
            textBox1.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tags);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            //rtbTekst

            RefreshForm();
        }

        private void GetBericht(object sender, EventArgs e)
        {
            var s = (ListBox)sender;
            Bericht selected = (Bericht)s.SelectedItem;

            viewModel.SelectedBericht = new Bericht
            {
                ID = selected.ID,
                Bestand = selected.Bestand,
                ReplyTo = selected.ReplyTo,
                Tags = selected.Tags,
                Tekst = selected.Tekst
            };

            foreach (var bericht in viewModel.ListBerichten)
            {
                if (bericht.ID == viewModel.SelectedBericht.ReplyTo)
                {
                    
                }
            }

            RefreshForm();
        }
    }
}
