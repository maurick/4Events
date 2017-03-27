namespace _4Events.View
{
    partial class BeheerForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHuisnr = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbStraat = new System.Windows.Forms.TextBox();
            this.tbPlaats = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnNieuwEvent = new System.Windows.Forms.Button();
            this.btnEventWijzig = new System.Windows.Forms.Button();
            this.cbLocatie = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.tbEventBezoekers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEventNaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvReservering = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Betaald = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAanwezig = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(17, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(913, 322);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.tbHuisnr);
            this.tabPage1.Controls.Add(this.tbPostcode);
            this.tabPage1.Controls.Add(this.tbStraat);
            this.tabPage1.Controls.Add(this.tbPlaats);
            this.tabPage1.Controls.Add(this.tbNaam);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWijzig);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.lbAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(905, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Postcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Straat - Huisnr";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(709, 135);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(185, 22);
            this.tbEmail.TabIndex = 36;
            // 
            // tbHuisnr
            // 
            this.tbHuisnr.Location = new System.Drawing.Point(851, 74);
            this.tbHuisnr.Margin = new System.Windows.Forms.Padding(4);
            this.tbHuisnr.Name = "tbHuisnr";
            this.tbHuisnr.Size = new System.Drawing.Size(44, 22);
            this.tbHuisnr.TabIndex = 35;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(709, 103);
            this.tbPostcode.Margin = new System.Windows.Forms.Padding(4);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(185, 22);
            this.tbPostcode.TabIndex = 34;
            // 
            // tbStraat
            // 
            this.tbStraat.Location = new System.Drawing.Point(709, 71);
            this.tbStraat.Margin = new System.Windows.Forms.Padding(4);
            this.tbStraat.Name = "tbStraat";
            this.tbStraat.Size = new System.Drawing.Size(132, 22);
            this.tbStraat.TabIndex = 33;
            // 
            // tbPlaats
            // 
            this.tbPlaats.Location = new System.Drawing.Point(709, 42);
            this.tbPlaats.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaats.Name = "tbPlaats";
            this.tbPlaats.Size = new System.Drawing.Size(185, 22);
            this.tbPlaats.TabIndex = 32;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(709, 10);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(185, 22);
            this.tbNaam.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Plaats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naam";
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(8, 43);
            this.btnWijzig.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(100, 28);
            this.btnWijzig.TabIndex = 7;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(116, 7);
            this.lbAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(480, 276);
            this.lbAccounts.TabIndex = 4;
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOverzicht);
            this.tabPage2.Controls.Add(this.btnNieuwEvent);
            this.tabPage2.Controls.Add(this.btnEventWijzig);
            this.tabPage2.Controls.Add(this.cbLocatie);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpEvent);
            this.tabPage2.Controls.Add(this.tbEventBezoekers);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbEventNaam);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnDeleteEvent);
            this.tabPage2.Controls.Add(this.lbEvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(905, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Event";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(4, 78);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(104, 28);
            this.btnOverzicht.TabIndex = 15;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnNieuwEvent
            // 
            this.btnNieuwEvent.Location = new System.Drawing.Point(605, 255);
            this.btnNieuwEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnNieuwEvent.Name = "btnNieuwEvent";
            this.btnNieuwEvent.Size = new System.Drawing.Size(289, 28);
            this.btnNieuwEvent.TabIndex = 14;
            this.btnNieuwEvent.Text = "Maak nieuw";
            this.btnNieuwEvent.UseVisualStyleBackColor = true;
            this.btnNieuwEvent.Click += new System.EventHandler(this.btnNieuwEvent_Click);
            // 
            // btnEventWijzig
            // 
            this.btnEventWijzig.Enabled = false;
            this.btnEventWijzig.Location = new System.Drawing.Point(8, 42);
            this.btnEventWijzig.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventWijzig.Name = "btnEventWijzig";
            this.btnEventWijzig.Size = new System.Drawing.Size(100, 28);
            this.btnEventWijzig.TabIndex = 13;
            this.btnEventWijzig.Text = "Wijzig";
            this.btnEventWijzig.UseVisualStyleBackColor = true;
            // 
            // cbLocatie
            // 
            this.cbLocatie.FormattingEnabled = true;
            this.cbLocatie.Location = new System.Drawing.Point(709, 107);
            this.cbLocatie.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocatie.Name = "cbLocatie";
            this.cbLocatie.Size = new System.Drawing.Size(185, 24);
            this.cbLocatie.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Locatie";
            // 
            // dtpEvent
            // 
            this.dtpEvent.Location = new System.Drawing.Point(709, 42);
            this.dtpEvent.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(185, 22);
            this.dtpEvent.TabIndex = 10;
            // 
            // tbEventBezoekers
            // 
            this.tbEventBezoekers.Location = new System.Drawing.Point(709, 74);
            this.tbEventBezoekers.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventBezoekers.Name = "tbEventBezoekers";
            this.tbEventBezoekers.Size = new System.Drawing.Size(185, 22);
            this.tbEventBezoekers.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Max Bezoekers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Datum";
            // 
            // tbEventNaam
            // 
            this.tbEventNaam.Location = new System.Drawing.Point(709, 10);
            this.tbEventNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventNaam.Name = "tbEventNaam";
            this.tbEventNaam.Size = new System.Drawing.Size(185, 22);
            this.tbEventNaam.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Naam";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.Location = new System.Drawing.Point(8, 7);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Verwijder";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(116, 7);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(480, 276);
            this.lbEvents.TabIndex = 0;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.SelectedEventChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAanwezig);
            this.tabPage3.Controls.Add(this.lvReservering);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(905, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservering";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Aanwezigen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Reserveringen";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 346);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(903, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvReservering
            // 
            this.lvReservering.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Betaald});
            this.lvReservering.FullRowSelect = true;
            this.lvReservering.Location = new System.Drawing.Point(4, 28);
            this.lvReservering.Name = "lvReservering";
            this.lvReservering.Size = new System.Drawing.Size(432, 244);
            this.lvReservering.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvReservering.TabIndex = 4;
            this.lvReservering.UseCompatibleStateImageBehavior = false;
            this.lvReservering.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            // 
            // Betaald
            // 
            this.Betaald.Text = "Betaald";
            this.Betaald.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvAanwezig
            // 
            this.lvAanwezig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAanwezig.FullRowSelect = true;
            this.lvAanwezig.Location = new System.Drawing.Point(442, 28);
            this.lvAanwezig.Name = "lvAanwezig";
            this.lvAanwezig.Size = new System.Drawing.Size(460, 244);
            this.lvAanwezig.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAanwezig.TabIndex = 5;
            this.lvAanwezig.UseCompatibleStateImageBehavior = false;
            this.lvAanwezig.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 385);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BeheerForm";
            this.Text = "Beheer Form";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbHuisnr;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbStraat;
        private System.Windows.Forms.TextBox tbPlaats;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.TextBox tbEventBezoekers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEventNaam;
        private System.Windows.Forms.ComboBox cbLocatie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNieuwEvent;
        private System.Windows.Forms.Button btnEventWijzig;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvReservering;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Betaald;
        private System.Windows.Forms.ListView lvAanwezig;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}