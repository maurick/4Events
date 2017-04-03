namespace _4Events.View
{
    partial class MediaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.gbBestand = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pbBestand = new System.Windows.Forms.PictureBox();
            this.gbBerichten = new System.Windows.Forms.GroupBox();
            this.btnRaporteer = new System.Windows.Forms.Button();
            this.lblSelectBericht = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnBestand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZoek = new System.Windows.Forms.Button();
            this.tbZoek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvBericht = new System.Windows.Forms.TreeView();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbZoek = new System.Windows.Forms.ComboBox();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.gbBestand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBestand)).BeginInit();
            this.gbBerichten.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(622, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(256, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbBestand
            // 
            this.gbBestand.Controls.Add(this.btnDownload);
            this.gbBestand.Controls.Add(this.pbBestand);
            this.gbBestand.Location = new System.Drawing.Point(616, 13);
            this.gbBestand.Name = "gbBestand";
            this.gbBestand.Size = new System.Drawing.Size(268, 345);
            this.gbBestand.TabIndex = 2;
            this.gbBestand.TabStop = false;
            this.gbBestand.Text = "Bestand";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 311);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(256, 23);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pbBestand
            // 
            this.pbBestand.Location = new System.Drawing.Point(6, 19);
            this.pbBestand.Name = "pbBestand";
            this.pbBestand.Size = new System.Drawing.Size(256, 286);
            this.pbBestand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBestand.TabIndex = 0;
            this.pbBestand.TabStop = false;
            // 
            // gbBerichten
            // 
            this.gbBerichten.Controls.Add(this.tbCategorie);
            this.gbBerichten.Controls.Add(this.cbZoek);
            this.gbBerichten.Controls.Add(this.btnRefresh);
            this.gbBerichten.Controls.Add(this.btnRaporteer);
            this.gbBerichten.Controls.Add(this.lblSelectBericht);
            this.gbBerichten.Controls.Add(this.btnLike);
            this.gbBerichten.Controls.Add(this.btnBestand);
            this.gbBerichten.Controls.Add(this.label3);
            this.gbBerichten.Controls.Add(this.btnZoek);
            this.gbBerichten.Controls.Add(this.tbZoek);
            this.gbBerichten.Controls.Add(this.label2);
            this.gbBerichten.Controls.Add(this.label1);
            this.gbBerichten.Controls.Add(this.tvBericht);
            this.gbBerichten.Controls.Add(this.rtbTekst);
            this.gbBerichten.Controls.Add(this.btnPost);
            this.gbBerichten.Location = new System.Drawing.Point(13, 13);
            this.gbBerichten.Name = "gbBerichten";
            this.gbBerichten.Size = new System.Drawing.Size(596, 374);
            this.gbBerichten.TabIndex = 7;
            this.gbBerichten.TabStop = false;
            this.gbBerichten.Text = "Berichten";
            // 
            // btnRaporteer
            // 
            this.btnRaporteer.Location = new System.Drawing.Point(336, 340);
            this.btnRaporteer.Name = "btnRaporteer";
            this.btnRaporteer.Size = new System.Drawing.Size(253, 23);
            this.btnRaporteer.TabIndex = 15;
            this.btnRaporteer.Text = "Raporteer";
            this.btnRaporteer.UseVisualStyleBackColor = true;
            this.btnRaporteer.Click += new System.EventHandler(this.btnRaporteer_Click);
            // 
            // lblSelectBericht
            // 
            this.lblSelectBericht.AutoSize = true;
            this.lblSelectBericht.Location = new System.Drawing.Point(448, 237);
            this.lblSelectBericht.Name = "lblSelectBericht";
            this.lblSelectBericht.Size = new System.Drawing.Size(27, 13);
            this.lblSelectBericht.TabIndex = 18;
            this.lblSelectBericht.Text = "N/A";
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(336, 311);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(253, 23);
            this.btnLike.TabIndex = 14;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnBestand
            // 
            this.btnBestand.Location = new System.Drawing.Point(336, 282);
            this.btnBestand.Name = "btnBestand";
            this.btnBestand.Size = new System.Drawing.Size(254, 23);
            this.btnBestand.TabIndex = 10;
            this.btnBestand.Text = "Voeg Bestand Toe";
            this.btnBestand.UseVisualStyleBackColor = true;
            this.btnBestand.Click += new System.EventHandler(this.btnBestand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Geselecteerd Bericht:";
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(336, 11);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(66, 23);
            this.btnZoek.TabIndex = 12;
            this.btnZoek.Text = "Zoek op";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.Location = new System.Drawing.Point(6, 13);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(324, 20);
            this.tbZoek.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tekst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categorie";
            // 
            // tvBericht
            // 
            this.tvBericht.Location = new System.Drawing.Point(6, 42);
            this.tvBericht.Name = "tvBericht";
            this.tvBericht.Size = new System.Drawing.Size(324, 321);
            this.tvBericht.TabIndex = 14;
            this.tvBericht.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBericht_AfterSelect);
            this.tvBericht.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvBericht_MouseDown);
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(337, 68);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(253, 166);
            this.rtbTekst.TabIndex = 8;
            this.rtbTekst.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(336, 253);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(253, 23);
            this.btnPost.TabIndex = 9;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(535, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbZoek
            // 
            this.cbZoek.FormattingEnabled = true;
            this.cbZoek.Items.AddRange(new object[] {
            "Woorden",
            "Tags"});
            this.cbZoek.Location = new System.Drawing.Point(408, 13);
            this.cbZoek.Name = "cbZoek";
            this.cbZoek.Size = new System.Drawing.Size(121, 21);
            this.cbZoek.TabIndex = 20;
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(468, 42);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(122, 20);
            this.tbCategorie.TabIndex = 21;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 395);
            this.Controls.Add(this.gbBerichten);
            this.Controls.Add(this.gbBestand);
            this.Controls.Add(this.btnBack);
            this.Name = "MediaForm";
            this.Text = "MediaForm";
            this.gbBestand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBestand)).EndInit();
            this.gbBerichten.ResumeLayout(false);
            this.gbBerichten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbBestand;
        private System.Windows.Forms.PictureBox pbBestand;
        private System.Windows.Forms.GroupBox gbBerichten;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnBestand;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.TextBox tbZoek;
        private System.Windows.Forms.TreeView tvBericht;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnRaporteer;
        private System.Windows.Forms.Label lblSelectBericht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbZoek;
        private System.Windows.Forms.TextBox tbCategorie;
    }
}