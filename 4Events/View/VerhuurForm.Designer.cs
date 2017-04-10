namespace _4Events.View
{
    partial class VerhuurForm
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
            this.lbVoorraad = new System.Windows.Forms.ListBox();
            this.lbAccount = new System.Windows.Forms.ListBox();
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnTeruggave = new System.Windows.Forms.Button();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(480, 433);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbVoorraad
            // 
            this.lbVoorraad.FormattingEnabled = true;
            this.lbVoorraad.ItemHeight = 16;
            this.lbVoorraad.Location = new System.Drawing.Point(363, 31);
            this.lbVoorraad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbVoorraad.Name = "lbVoorraad";
            this.lbVoorraad.Size = new System.Drawing.Size(252, 388);
            this.lbVoorraad.TabIndex = 2;
            // 
            // lbAccount
            // 
            this.lbAccount.FormattingEnabled = true;
            this.lbAccount.ItemHeight = 16;
            this.lbAccount.Location = new System.Drawing.Point(16, 31);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(252, 388);
            this.lbAccount.TabIndex = 3;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(279, 129);
            this.btnVerhuur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(76, 52);
            this.btnVerhuur.TabIndex = 4;
            this.btnVerhuur.Text = "<<";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // btnTeruggave
            // 
            this.btnTeruggave.Location = new System.Drawing.Point(279, 188);
            this.btnTeruggave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeruggave.Name = "btnTeruggave";
            this.btnTeruggave.Size = new System.Drawing.Size(76, 52);
            this.btnTeruggave.TabIndex = 5;
            this.btnTeruggave.Text = ">>";
            this.btnTeruggave.UseVisualStyleBackColor = true;
            this.btnTeruggave.Click += new System.EventHandler(this.btnTeruggave_Click);
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Location = new System.Drawing.Point(363, 7);
            this.lblVoorraad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(67, 17);
            this.lblVoorraad.TabIndex = 6;
            this.lblVoorraad.Text = "Voorraad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account";
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(17, 433);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(455, 28);
            this.btnOverzicht.TabIndex = 8;
            this.btnOverzicht.Text = "Overzicht van Account";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 476);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.btnTeruggave);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbVoorraad);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerhuurForm";
            this.Text = "Verhuur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerhuurForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbVoorraad;
        private System.Windows.Forms.ListBox lbAccount;
        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnTeruggave;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOverzicht;
    }
}