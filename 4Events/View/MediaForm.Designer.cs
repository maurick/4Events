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
            this.pbBestand = new System.Windows.Forms.PictureBox();
            this.gbBerichten = new System.Windows.Forms.GroupBox();
            this.tvBericht = new System.Windows.Forms.TreeView();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnBestand = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnZoek = new System.Windows.Forms.Button();
            this.tbZoek = new System.Windows.Forms.TextBox();
            this.gbBestand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBestand)).BeginInit();
            this.gbBerichten.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(554, 324);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbBestand
            // 
            this.gbBestand.Controls.Add(this.pbBestand);
            this.gbBestand.Location = new System.Drawing.Point(356, 13);
            this.gbBestand.Name = "gbBestand";
            this.gbBestand.Size = new System.Drawing.Size(268, 305);
            this.gbBestand.TabIndex = 2;
            this.gbBestand.TabStop = false;
            this.gbBestand.Text = "Bestand";
            // 
            // pbBestand
            // 
            this.pbBestand.Location = new System.Drawing.Point(6, 19);
            this.pbBestand.Name = "pbBestand";
            this.pbBestand.Size = new System.Drawing.Size(256, 280);
            this.pbBestand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBestand.TabIndex = 0;
            this.pbBestand.TabStop = false;
            // 
            // gbBerichten
            // 
            this.gbBerichten.Controls.Add(this.tvBericht);
            this.gbBerichten.Controls.Add(this.rtbTekst);
            this.gbBerichten.Controls.Add(this.tbTags);
            this.gbBerichten.Location = new System.Drawing.Point(13, 13);
            this.gbBerichten.Name = "gbBerichten";
            this.gbBerichten.Size = new System.Drawing.Size(337, 460);
            this.gbBerichten.TabIndex = 7;
            this.gbBerichten.TabStop = false;
            this.gbBerichten.Text = "Berichten";
            // 
            // tvBericht
            // 
            this.tvBericht.Location = new System.Drawing.Point(7, 18);
            this.tvBericht.Name = "tvBericht";
            this.tvBericht.Size = new System.Drawing.Size(324, 287);
            this.tvBericht.TabIndex = 14;
            this.tvBericht.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBericht_AfterSelect);
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(7, 339);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(263, 115);
            this.rtbTekst.TabIndex = 8;
            this.rtbTekst.Text = "";
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(7, 312);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(100, 20);
            this.tbTags.TabIndex = 7;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(549, 450);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 9;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnBestand
            // 
            this.btnBestand.Location = new System.Drawing.Point(356, 323);
            this.btnBestand.Name = "btnBestand";
            this.btnBestand.Size = new System.Drawing.Size(75, 23);
            this.btnBestand.TabIndex = 10;
            this.btnBestand.Text = "Bestand";
            this.btnBestand.UseVisualStyleBackColor = true;
            this.btnBestand.Click += new System.EventHandler(this.btnBestand_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(357, 352);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(356, 381);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 23);
            this.btnZoek.TabIndex = 12;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.Location = new System.Drawing.Point(437, 383);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(100, 20);
            this.tbZoek.TabIndex = 13;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.tbZoek);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBestand);
            this.Controls.Add(this.btnPost);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbBestand;
        private System.Windows.Forms.PictureBox pbBestand;
        private System.Windows.Forms.GroupBox gbBerichten;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnBestand;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.TextBox tbZoek;
        private System.Windows.Forms.TreeView tvBericht;
    }
}