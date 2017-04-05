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
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvAanwezig = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReservering = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Betaald = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(685, 262);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbRFID);
            this.tabPage1.Controls.Add(this.lvAccounts);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(677, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvAccounts
            // 
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.Location = new System.Drawing.Point(86, 11);
            this.lvAccounts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(362, 222);
            this.lvAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAccounts.TabIndex = 40;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            this.lvAccounts.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Naam";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Functie";
            this.columnHeader5.Width = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Postcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Straat - Huisnr";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(532, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(140, 20);
            this.tbEmail.TabIndex = 36;
            // 
            // tbHuisnr
            // 
            this.tbHuisnr.Location = new System.Drawing.Point(638, 60);
            this.tbHuisnr.Name = "tbHuisnr";
            this.tbHuisnr.Size = new System.Drawing.Size(34, 20);
            this.tbHuisnr.TabIndex = 35;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(532, 84);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(140, 20);
            this.tbPostcode.TabIndex = 34;
            // 
            // tbStraat
            // 
            this.tbStraat.Location = new System.Drawing.Point(532, 58);
            this.tbStraat.Name = "tbStraat";
            this.tbStraat.Size = new System.Drawing.Size(100, 20);
            this.tbStraat.TabIndex = 33;
            // 
            // tbPlaats
            // 
            this.tbPlaats.Location = new System.Drawing.Point(532, 34);
            this.tbPlaats.Name = "tbPlaats";
            this.tbPlaats.Size = new System.Drawing.Size(140, 20);
            this.tbPlaats.TabIndex = 32;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(532, 8);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(140, 20);
            this.tbNaam.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Plaats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naam";
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(6, 35);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 7;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvEvents);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(677, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Event";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.Location = new System.Drawing.Point(86, 6);
            this.lvEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(362, 222);
            this.lvEvents.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEvents.TabIndex = 41;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Naam";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Datum";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Max Bezoekers";
            this.columnHeader8.Width = 105;
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(3, 63);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(78, 23);
            this.btnOverzicht.TabIndex = 15;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnNieuwEvent
            // 
            this.btnNieuwEvent.Location = new System.Drawing.Point(454, 207);
            this.btnNieuwEvent.Name = "btnNieuwEvent";
            this.btnNieuwEvent.Size = new System.Drawing.Size(217, 23);
            this.btnNieuwEvent.TabIndex = 14;
            this.btnNieuwEvent.Text = "Maak nieuw";
            this.btnNieuwEvent.UseVisualStyleBackColor = true;
            this.btnNieuwEvent.Click += new System.EventHandler(this.btnNieuwEvent_Click);
            // 
            // btnEventWijzig
            // 
            this.btnEventWijzig.Enabled = false;
            this.btnEventWijzig.Location = new System.Drawing.Point(6, 34);
            this.btnEventWijzig.Name = "btnEventWijzig";
            this.btnEventWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnEventWijzig.TabIndex = 13;
            this.btnEventWijzig.Text = "Wijzig";
            this.btnEventWijzig.UseVisualStyleBackColor = true;
            // 
            // cbLocatie
            // 
            this.cbLocatie.FormattingEnabled = true;
            this.cbLocatie.Location = new System.Drawing.Point(532, 87);
            this.cbLocatie.Name = "cbLocatie";
            this.cbLocatie.Size = new System.Drawing.Size(140, 21);
            this.cbLocatie.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Locatie";
            // 
            // dtpEvent
            // 
            this.dtpEvent.Location = new System.Drawing.Point(532, 34);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(140, 20);
            this.dtpEvent.TabIndex = 10;
            // 
            // tbEventBezoekers
            // 
            this.tbEventBezoekers.Location = new System.Drawing.Point(532, 60);
            this.tbEventBezoekers.Name = "tbEventBezoekers";
            this.tbEventBezoekers.Size = new System.Drawing.Size(140, 20);
            this.tbEventBezoekers.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Max Bezoekers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Datum";
            // 
            // tbEventNaam
            // 
            this.tbEventNaam.Location = new System.Drawing.Point(532, 8);
            this.tbEventNaam.Name = "tbEventNaam";
            this.tbEventNaam.Size = new System.Drawing.Size(140, 20);
            this.tbEventNaam.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Naam";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Verwijder";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAanwezig);
            this.tabPage3.Controls.Add(this.lvReservering);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservering";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvAanwezig
            // 
            this.lvAanwezig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAanwezig.FullRowSelect = true;
            this.lvAanwezig.Location = new System.Drawing.Point(332, 23);
            this.lvAanwezig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvAanwezig.Name = "lvAanwezig";
            this.lvAanwezig.Size = new System.Drawing.Size(346, 199);
            this.lvAanwezig.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAanwezig.TabIndex = 5;
            this.lvAanwezig.UseCompatibleStateImageBehavior = false;
            this.lvAanwezig.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            // 
            // lvReservering
            // 
            this.lvReservering.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Betaald});
            this.lvReservering.FullRowSelect = true;
            this.lvReservering.Location = new System.Drawing.Point(3, 23);
            this.lvReservering.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvReservering.Name = "lvReservering";
            this.lvReservering.Size = new System.Drawing.Size(325, 199);
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Aanwezigen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Reserveringen";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 281);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(677, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Enabled = false;
            this.tbRFID.Location = new System.Drawing.Point(532, 137);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(140, 20);
            this.tbRFID.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "RFID";
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 313);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl);
            this.Name = "BeheerForm";
            this.Text = "Beheer Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeheerForm_FormClosed);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteEvent;
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
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRFID;
    }
}