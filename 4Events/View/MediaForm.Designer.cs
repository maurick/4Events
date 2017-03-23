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
            this.lbReacties = new System.Windows.Forms.ListBox();
            this.lbBerichten = new System.Windows.Forms.ListBox();
            this.gbBerichten = new System.Windows.Forms.GroupBox();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
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
            this.pbBestand.TabIndex = 0;
            this.pbBestand.TabStop = false;
            // 
            // lbReacties
            // 
            this.lbReacties.FormattingEnabled = true;
            this.lbReacties.Location = new System.Drawing.Point(177, 15);
            this.lbReacties.Name = "lbReacties";
            this.lbReacties.Size = new System.Drawing.Size(154, 290);
            this.lbReacties.TabIndex = 6;
            this.lbReacties.SelectedIndexChanged += new System.EventHandler(this.GetBericht);
            // 
            // lbBerichten
            // 
            this.lbBerichten.FormattingEnabled = true;
            this.lbBerichten.Location = new System.Drawing.Point(6, 15);
            this.lbBerichten.Name = "lbBerichten";
            this.lbBerichten.Size = new System.Drawing.Size(154, 290);
            this.lbBerichten.TabIndex = 5;
            this.lbBerichten.SelectedIndexChanged += new System.EventHandler(this.GetBericht);
            // 
            // gbBerichten
            // 
            this.gbBerichten.Controls.Add(this.rtbTekst);
            this.gbBerichten.Controls.Add(this.textBox1);
            this.gbBerichten.Controls.Add(this.lbReacties);
            this.gbBerichten.Controls.Add(this.lbBerichten);
            this.gbBerichten.Location = new System.Drawing.Point(13, 13);
            this.gbBerichten.Name = "gbBerichten";
            this.gbBerichten.Size = new System.Drawing.Size(337, 460);
            this.gbBerichten.TabIndex = 7;
            this.gbBerichten.TabStop = false;
            this.gbBerichten.Text = "Berichten";
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(7, 339);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(263, 115);
            this.rtbTekst.TabIndex = 8;
            this.rtbTekst.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
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
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 485);
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

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbBestand;
        private System.Windows.Forms.PictureBox pbBestand;
        private System.Windows.Forms.ListBox lbReacties;
        private System.Windows.Forms.ListBox lbBerichten;
        private System.Windows.Forms.GroupBox gbBerichten;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPost;
    }
}