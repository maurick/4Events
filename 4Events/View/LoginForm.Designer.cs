﻿namespace _4Events
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(156, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(12, 64);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(156, 20);
            this.tbWachtwoord.TabIndex = 2;
            this.tbWachtwoord.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord";
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(93, 90);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreer.TabIndex = 5;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.ForeColor = System.Drawing.Color.Red;
            this.lblDebug.Location = new System.Drawing.Point(243, 48);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(81, 13);
            this.lblDebug.TabIndex = 6;
            this.lblDebug.Text = "Debug Enabled";
            this.lblDebug.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 121);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Label lblDebug;
    }
}

