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
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 352);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(450, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbVoorraad
            // 
            this.lbVoorraad.FormattingEnabled = true;
            this.lbVoorraad.Location = new System.Drawing.Point(272, 25);
            this.lbVoorraad.Name = "lbVoorraad";
            this.lbVoorraad.Size = new System.Drawing.Size(190, 316);
            this.lbVoorraad.TabIndex = 2;
            // 
            // lbAccount
            // 
            this.lbAccount.FormattingEnabled = true;
            this.lbAccount.Location = new System.Drawing.Point(12, 25);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(190, 316);
            this.lbAccount.TabIndex = 3;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(209, 105);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(57, 42);
            this.btnVerhuur.TabIndex = 4;
            this.btnVerhuur.Text = ">>";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            // 
            // btnTeruggave
            // 
            this.btnTeruggave.Location = new System.Drawing.Point(209, 153);
            this.btnTeruggave.Name = "btnTeruggave";
            this.btnTeruggave.Size = new System.Drawing.Size(57, 42);
            this.btnTeruggave.TabIndex = 5;
            this.btnTeruggave.Text = "<<";
            this.btnTeruggave.UseVisualStyleBackColor = true;
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Location = new System.Drawing.Point(272, 6);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(50, 13);
            this.lblVoorraad.TabIndex = 6;
            this.lblVoorraad.Text = "Voorraad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account";
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.btnTeruggave);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbVoorraad);
            this.Controls.Add(this.btnBack);
            this.Name = "VerhuurForm";
            this.Text = "Verhuur";
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
    }
}