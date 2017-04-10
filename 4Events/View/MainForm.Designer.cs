namespace _4Events.View
{
    partial class MainForm
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.btnAccountBeheer = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReservering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 171);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Log uit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Location = new System.Drawing.Point(12, 9);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(80, 13);
            this.lblWelkom.TabIndex = 1;
            this.lblWelkom.Text = "Welkom, Naam";
            this.lblWelkom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.Location = new System.Drawing.Point(12, 22);
            this.lblFunctie.Name = "lblFunctie";
            this.lblFunctie.Size = new System.Drawing.Size(146, 13);
            this.lblFunctie.TabIndex = 2;
            this.lblFunctie.Text = "Uw huidige functie is: Functie";
            this.lblFunctie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAccountBeheer
            // 
            this.btnAccountBeheer.Enabled = false;
            this.btnAccountBeheer.Location = new System.Drawing.Point(13, 44);
            this.btnAccountBeheer.Name = "btnAccountBeheer";
            this.btnAccountBeheer.Size = new System.Drawing.Size(120, 37);
            this.btnAccountBeheer.TabIndex = 3;
            this.btnAccountBeheer.Text = "Beheer";
            this.btnAccountBeheer.UseVisualStyleBackColor = true;
            this.btnAccountBeheer.Click += new System.EventHandler(this.btnAccountBeheer_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(15, 87);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(118, 37);
            this.btnMedia.TabIndex = 4;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Toegangscontrole";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Verhuur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservering
            // 
            this.btnReservering.Location = new System.Drawing.Point(78, 128);
            this.btnReservering.Name = "btnReservering";
            this.btnReservering.Size = new System.Drawing.Size(115, 36);
            this.btnReservering.TabIndex = 7;
            this.btnReservering.Text = "Reservering";
            this.btnReservering.UseVisualStyleBackColor = true;
            this.btnReservering.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 204);
            this.Controls.Add(this.btnReservering);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnAccountBeheer);
            this.Controls.Add(this.lblFunctie);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.btnBack);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.Button btnAccountBeheer;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReservering;
    }
}