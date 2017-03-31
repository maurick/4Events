using System;
using System.Drawing;
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
        Media media = new Media(new MediaContext());
        Beheer beheer = new Beheer(new BeheerContext());
        MediaViewModel viewModel = new MediaViewModel();

        public MediaForm()
        {
            InitializeComponent();
            viewModel.Account = beheer.GetAccountById((beheer.GetAccountCache()));

            RefreshForm();
        }

        private void RefreshForm()
        {
            viewModel.ListBerichten = media.GetBerichten(999);
            viewModel.Bericht = new Bericht();
            viewModel.Bericht.Bestand = null;

            tvBericht.Nodes.Clear();

            foreach (var item in viewModel.ListBerichten)
            {
                if(item.ReplyTo == 0)
                {
                    TreeNode tn = new TreeNode(item.Tekst);
                    tn.Tag = item;
                    tvBericht.Nodes.Add(tn);
                    PopulateTreeNode(item.ID, tn);
                }
            }

            rtbTekst.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tekst);
            tbTags.Text = ((viewModel.SelectedBericht == null) ? "" : viewModel.SelectedBericht.Tags);
        }

        private void PopulateTreeNode(int parentID, TreeNode parentNode)
        {
            foreach (var item in viewModel.ListBerichten)
            {
                if(item.ReplyTo == parentID)
                {
                    TreeNode tn = new TreeNode(item.Tekst);
                    tn.Tag = item;

                    parentNode.Nodes.Add(tn);
                    PopulateTreeNode(item.ID, tn);
                }
                
            }
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
                viewModel.Bericht.ReplyTo = viewModel.SelectedBericht.ID;
            }

            if (media.InsertBericht(viewModel.Bericht) != true)
            {
                MessageBox.Show("Error: Kan geen bericht in de database plaatsen.");
                return;
            }

            MessageBox.Show("Bericht succesvol gepost.");

            RefreshForm();
        }

        private void btnBestand_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBestand = new OpenFileDialog();
            string filename;

            if(viewModel.Bericht == null)
            {
                MessageBox.Show("Geen bericht.");
            }

            // Alle filelogic in logic ofzo
            if(openBestand.ShowDialog() == DialogResult.OK)
            {
                filename = openBestand.FileName;
                

                Image image = (Bitmap)((new ImageConverter()).ConvertFrom(File.ReadAllBytes(filename)));

                pbBestand.Image = image;
                viewModel.Bericht.Bestand = File.ReadAllBytes(filename);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // direct uit de byte array lezen van verschillende bestanden.
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            tvBericht.Nodes.Clear();
            foreach (var item in media.SearchBerichten(tbZoek.Text))
            {

                TreeNode tn = new TreeNode(item.Tekst);
                tn.Tag = item;

                tvBericht.Nodes.Add(tn);
            } 
        }

        private new void DoubleClick(object sender, MouseEventArgs e)
        {
            var listbox = (ListBox)sender;

            int index = listbox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show("laat reacties van dit bericht zien ofzo TODO toedeloe.");
            }

        }

        private void tvBericht_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Bericht b = (Bericht)e.Node.Tag;

            viewModel.SelectedBericht = b;

            if (viewModel.SelectedBericht != null && viewModel.SelectedBericht.Bestand != null)
            {
                //TODO zet buiten de form

                pbBestand.Image = (Bitmap)((new ImageConverter()).ConvertFrom(viewModel.SelectedBericht.Bestand));
            }
            else
            {
                pbBestand.Image = Resources.geenImageMelding;
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            // TODO database query die like relatie maakt.
        }

        private void btnRaporteer_Click(object sender, EventArgs e)
        {
            // TODO database query die report relatie maakt.
        }
    }
}
