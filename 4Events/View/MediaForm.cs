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
        Mpv mpv = new Mpv();

        public MediaForm()
        {
            InitializeComponent();
            cbZoek.SelectedIndex = 0;


            viewModel.Account = beheer.GetAccountById(beheer.GetAccountCache());
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
                Categorie = new Categorie
                {
                    Naam = tbCategorie.Text
                },
                Bestand = viewModel.Bericht.Bestand,
                AccountID = viewModel.Account.ID
            };

            if(viewModel.SelectedBericht != null)
            {
                viewModel.Bericht.ReplyTo = viewModel.SelectedBericht.ID;
                viewModel.Bericht.Categorie = viewModel.SelectedBericht.Categorie;
            }

            if (media.InsertBericht(viewModel.Bericht) != true)
            {
                MessageBox.Show("Kan geen bericht in de database plaatsen.");
                return;
            }

            MessageBox.Show("Bericht succesvol gepost.");
            RefreshForm();
        }

        private void btnBestand_Click(object sender, EventArgs e)
        {
            Image image = Resources.geenImageMelding;
            OpenFileDialog openBestand = new OpenFileDialog();
            openBestand.Filter = "Image (*.*)|*.*|Video (*.*)|*.*";
            string filename;

            if(viewModel.Bericht == null)
            {
                MessageBox.Show("Geen bericht.");
            }

            if(openBestand.ShowDialog() == DialogResult.OK)
            {
                // Kan in media logic misschien?
                filename = openBestand.FileName;

                switch (openBestand.FilterIndex)
                {
                    case 1:
                        image = (Bitmap)((new ImageConverter()).ConvertFrom(File.ReadAllBytes(filename)));
                        break;
                    case 2:
                        mpv.PlayVid(filename, pbBestand.Handle.ToInt64());
                        return;
                    default:
                        break;
                }

                pbBestand.Image = image;
                viewModel.Bericht.Bestand = new Bestand();
                viewModel.Bericht.Bestand.BestandArray = File.ReadAllBytes(filename);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // De byte array in bestand zou ook andere bestanden kunnen bevatten.
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveImageDialog.Title = "Download een plaatje";
            saveImageDialog.ShowDialog();

            if(saveImageDialog.FileName != "")
            {
                try
                {
                    using (FileStream fs = (FileStream)saveImageDialog.OpenFile())
                    {
                        switch (saveImageDialog.FilterIndex)
                        {
                            case 1:
                                pbBestand.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                pbBestand.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            case 3:
                                pbBestand.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }
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

            switch (cbZoek.SelectedIndex)
            {
                case (0):
                    foreach (var item in media.SearchBerichtenTekst(tbZoek.Text, 1000))
                    {
                        TreeNode tn = new TreeNode(item.ToString());
                        tn.Tag = item;
                        tvBericht.Nodes.Add(tn);
                    }
                    break;
                case (1):
                    foreach (var item in media.SearchBerichtenCategorie(tbZoek.Text, 1000))
                    {
                        TreeNode tn = new TreeNode(item.ToString());
                        tn.Tag = item;
                        tvBericht.Nodes.Add(tn);
                    }
                    break;
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
                pbBestand.Image = media.ConvertByteArrayToImage(media.GetBestandByBestandID(viewModel.SelectedBericht.Bestand.ID).BestandArray);
            }
            else
            {
                pbBestand.Image = Resources.geenImageMelding;
            }

            tbCategorie.Text = viewModel.SelectedBericht.Categorie.Naam;
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
            if (media.RaporteerBericht(viewModel.SelectedBericht, viewModel.Account))
            {
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Al gerapporteerd.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void tvBericht_MouseDown(object sender, MouseEventArgs e)
        {
            tvBericht.SelectedNode = null;
            viewModel.SelectedBericht = null;
            lblSelectBericht.Text = "N/A";
        }

        private void MediaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mpv.FormClose();
        }
    }
}
