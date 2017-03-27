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
using System.IO;

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
            viewModel.Account = beheerRepo.GetAccountById((beheerRepo.GetAccountCache()));

            RefreshForm();
        }

        private void RefreshForm()
        {
            viewModel.ListBerichten = mediaRepo.GetBerichten(20);
            viewModel.Bericht = new Bericht();
            viewModel.Bericht.Bestand = null;

            lbBerichten.Items.Clear();

            foreach (var bericht in viewModel.ListBerichten)
            {
                if(bericht.ReplyTo == 0)
                {
                    lbBerichten.Items.Add(bericht);
                }
            }



            rtbTekst.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tekst);
            tbTags.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tags);
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
            viewModel.Bericht = new Bericht
            {
                Tekst = rtbTekst.Text,
                Tags = tbTags.Text,
                Bestand = viewModel.Bericht.Bestand,
                AccountID = viewModel.Account.ID
            };

            if(viewModel.SelectedBericht != null)
            {
                viewModel.Bericht.ReplyTo = viewModel.SelectedBericht.AccountID;
            }

            if (mediaRepo.InsertBericht(viewModel.Bericht) != true)
            {
                MessageBox.Show("Error: Kan geen bericht in de database plaatsen.");
                return;
            }

            MessageBox.Show("Bericht succesvol gepost.");

            RefreshForm();
        }

        private void GetBericht(object sender, EventArgs e)
        {
            var s = (ListBox)sender;

            if(s.SelectedItem == null)
            {
                return;
            }

            viewModel.SelectedBericht = (Bericht)s.SelectedItem;

            //viewModel.SelectedBericht = new Bericht
            //{
            //    ID = selected.ID,
            //    Bestand = selected.Bestand,
            //    ReplyTo = selected.ReplyTo,
            //    Tags = selected.Tags,
            //    Tekst = selected.Tekst,
            //    AccountID = selected.AccountID
            //};

            if(s == lbBerichten)
            {
                lbReacties.Items.Clear();

                foreach (var bericht in viewModel.ListBerichten)
                {
                    if (bericht.ReplyTo == viewModel.SelectedBericht.ID)
                    {
                        lbReacties.Items.Add(bericht);
                    }
                }
            }

            if (viewModel.SelectedBericht != null && viewModel.SelectedBericht.Bestand != null)
            {
                pbBestand.Image = (Bitmap)((new ImageConverter()).ConvertFrom(viewModel.SelectedBericht.Bestand));
            }
            else
            {
                pbBestand.Image = null;
            }
        }

        private void btnBestand_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBestand = new OpenFileDialog();
            string filename;

            if(viewModel.Bericht == null)
            {
                MessageBox.Show("Geen bericht.");
            }

            if(openBestand.ShowDialog() == DialogResult.OK)
            {
                filename = openBestand.FileName;
                

                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(File.ReadAllBytes(filename)));

                pbBestand.Image = x;
                viewModel.Bericht.Bestand = File.ReadAllBytes(filename);
                //pbBestand.
            }
        }
    }
}
