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
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(201, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Location = new System.Drawing.Point(96, 9);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(80, 13);
            this.lblWelkom.TabIndex = 1;
            this.lblWelkom.Text = "Welkom, Naam";
            this.lblWelkom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.Location = new System.Drawing.Point(69, 22);
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
            this.btnAccountBeheer.Size = new System.Drawing.Size(103, 37);
            this.btnAccountBeheer.TabIndex = 3;
            this.btnAccountBeheer.Text = "Account Beheer";
            this.btnAccountBeheer.UseVisualStyleBackColor = true;
            this.btnAccountBeheer.Click += new System.EventHandler(this.btnAccountBeheer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAccountBeheer);
            this.Controls.Add(this.lblFunctie);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.btnBack);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.Button btnAccountBeheer;
    }
}