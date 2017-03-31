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
                    TreeNode tn = new TreeNode(item.ToString());
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
                    TreeNode tn = new TreeNode(item.ToString());
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
            if(openBestand.ShowDialog() == DialogResult.OK)
            {
                // Kan in media logic misschien?

                filename = openBestand.FileName;
                
                Image image = (Bitmap)((new ImageConverter()).ConvertFrom(File.ReadAllBytes(filename)));

                pbBestand.Image = image;
                viewModel.Bericht.Bestand = File.ReadAllBytes(filename);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // De byte array in bestand zou ook andere bestanden kunnen bevatten.
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Filter = "Bitmap Image|*.bmp";
            saveImageDialog.Title = "Download een plaatje";
            saveImageDialog.ShowDialog();

            if(saveImageDialog.FileName != "")
            {
                try
                {
                    using (FileStream fs = (FileStream)saveImageDialog.OpenFile())
                    {
                        pbBestand.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Filename or format is null");
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            tvBericht.Nodes.Clear();
            foreach (var item in media.SearchBerichten(tbZoek.Text))
            {

                TreeNode tn = new TreeNode(item.ToString());
                tn.Tag = item;

                tvBericht.Nodes.Add(tn);
            } 
        }
        private void tvBericht_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Bericht b = (Bericht)e.Node.Tag;

            viewModel.SelectedBericht = b;
            lblSelectBericht.Text = b.ID + "";

            if (viewModel.SelectedBericht != null
                && viewModel.SelectedBericht.Bestand != null)
            {
                pbBestand.Image = media.ConvertByteArrayToImage(viewModel.SelectedBericht.Bestand);
            }
            else
            {
                pbBestand.Image = Resources.geenImageMelding;
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if(media.LikeBericht(viewModel.SelectedBericht, viewModel.Account))
            {
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Kan bericht geen like geven.");
            }
        }

        private void btnRaporteer_Click(object sender, EventArgs e)
        {
            if (media.LikeBericht(viewModel.SelectedBericht, viewModel.Account))
            {
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Al gerapporteerd.");
            }
        }
    }
}
