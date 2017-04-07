namespace _4Events.View
{
    partial class ReserveringsForm
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
            this.pb_Plattegrond = new System.Windows.Forms.PictureBox();
            this.cbKampeerplaatsen = new System.Windows.Forms.ComboBox();
            this.lbl_plaatsen = new System.Windows.Forms.Label();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.btnReserveer = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Plattegrond)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Plattegrond
            // 
            this.pb_Plattegrond.InitialImage = global::_4Events.Properties.Resources.Camping_ReeënDal;
            this.pb_Plattegrond.Location = new System.Drawing.Point(12, 12);
            this.pb_Plattegrond.Name = "pb_Plattegrond";
            this.pb_Plattegrond.Size = new System.Drawing.Size(918, 626);
            this.pb_Plattegrond.TabIndex = 0;
            this.pb_Plattegrond.TabStop = false;
            // 
            // cbKampeerplaatsen
            // 
            this.cbKampeerplaatsen.FormattingEnabled = true;
            this.cbKampeerplaatsen.Location = new System.Drawing.Point(935, 106);
            this.cbKampeerplaatsen.Name = "cbKampeerplaatsen";
            this.cbKampeerplaatsen.Size = new System.Drawing.Size(138, 24);
            this.cbKampeerplaatsen.TabIndex = 1;
            // 
            // lbl_plaatsen
            // 
            this.lbl_plaatsen.AutoSize = true;
            this.lbl_plaatsen.Location = new System.Drawing.Point(936, 87);
            this.lbl_plaatsen.Name = "lbl_plaatsen";
            this.lbl_plaatsen.Size = new System.Drawing.Size(123, 17);
            this.lbl_plaatsen.TabIndex = 2;
            this.lbl_plaatsen.Text = "Kampeer plaatsen";
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Location = new System.Drawing.Point(1098, 86);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(39, 17);
            this.lbl_filter.TabIndex = 3;
            this.lbl_filter.Text = "Filter";
            // 
            // cb_Filter
            // 
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Location = new System.Drawing.Point(1079, 106);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(119, 24);
            this.cb_Filter.TabIndex = 4;
            // 
            // btnReserveer
            // 
            this.btnReserveer.Location = new System.Drawing.Point(936, 373);
            this.btnReserveer.Name = "btnReserveer";
            this.btnReserveer.Size = new System.Drawing.Size(262, 65);
            this.btnReserveer.TabIndex = 11;
            this.btnReserveer.Text = "Reserveer";
            this.btnReserveer.UseVisualStyleBackColor = true;
            this.btnReserveer.Click += new System.EventHandler(this.btnReserveer_Click);
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(941, 324);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(62, 17);
            this.lblPrijs.TabIndex = 12;
            this.lblPrijs.Text = "Prijs in €";
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(937, 345);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.ReadOnly = true;
            this.tbPrijs.Size = new System.Drawing.Size(138, 22);
            this.tbPrijs.TabIndex = 13;
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(935, 50);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(262, 24);
            this.cbEvent.TabIndex = 14;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(936, 30);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(44, 17);
            this.lblEvent.TabIndex = 15;
            this.lblEvent.Text = "Event";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voeg accounts toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(937, 185);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(260, 84);
            this.lbAccounts.TabIndex = 17;
            // 
            // ReserveringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 650);
            this.Controls.Add(this.lbAccounts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnReserveer);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.lbl_plaatsen);
            this.Controls.Add(this.cbKampeerplaatsen);
            this.Controls.Add(this.pb_Plattegrond);
            this.Name = "ReserveringsForm";
            this.Text = "ReserveringsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Plattegrond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Plattegrond;
        private System.Windows.Forms.ComboBox cbKampeerplaatsen;
        private System.Windows.Forms.Label lbl_plaatsen;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Button btnReserveer;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbAccounts;
    }
}