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
            this.lblAantalpersonen = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtpBegindatum = new System.Windows.Forms.DateTimePicker();
            this.lblBegindatum = new System.Windows.Forms.Label();
            this.lblEinddatum = new System.Windows.Forms.Label();
            this.dtpEinddatum = new System.Windows.Forms.DateTimePicker();
            this.btnReserveer = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Plattegrond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.cbKampeerplaatsen.Location = new System.Drawing.Point(937, 32);
            this.cbKampeerplaatsen.Name = "cbKampeerplaatsen";
            this.cbKampeerplaatsen.Size = new System.Drawing.Size(138, 24);
            this.cbKampeerplaatsen.TabIndex = 1;
            // 
            // lbl_plaatsen
            // 
            this.lbl_plaatsen.AutoSize = true;
            this.lbl_plaatsen.Location = new System.Drawing.Point(938, 13);
            this.lbl_plaatsen.Name = "lbl_plaatsen";
            this.lbl_plaatsen.Size = new System.Drawing.Size(123, 17);
            this.lbl_plaatsen.TabIndex = 2;
            this.lbl_plaatsen.Text = "Kampeer plaatsen";
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Location = new System.Drawing.Point(1100, 12);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(39, 17);
            this.lbl_filter.TabIndex = 3;
            this.lbl_filter.Text = "Filter";
            // 
            // cb_Filter
            // 
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Location = new System.Drawing.Point(1081, 32);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(119, 24);
            this.cb_Filter.TabIndex = 4;
            // 
            // lblAantalpersonen
            // 
            this.lblAantalpersonen.AutoSize = true;
            this.lblAantalpersonen.Location = new System.Drawing.Point(941, 82);
            this.lblAantalpersonen.Name = "lblAantalpersonen";
            this.lblAantalpersonen.Size = new System.Drawing.Size(112, 17);
            this.lblAantalpersonen.TabIndex = 5;
            this.lblAantalpersonen.Text = "Aantal personen";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(937, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dtpBegindatum
            // 
            this.dtpBegindatum.Location = new System.Drawing.Point(938, 192);
            this.dtpBegindatum.Name = "dtpBegindatum";
            this.dtpBegindatum.Size = new System.Drawing.Size(262, 22);
            this.dtpBegindatum.TabIndex = 7;
            // 
            // lblBegindatum
            // 
            this.lblBegindatum.AutoSize = true;
            this.lblBegindatum.Location = new System.Drawing.Point(941, 169);
            this.lblBegindatum.Name = "lblBegindatum";
            this.lblBegindatum.Size = new System.Drawing.Size(87, 17);
            this.lblBegindatum.TabIndex = 8;
            this.lblBegindatum.Text = "Begin datum";
            // 
            // lblEinddatum
            // 
            this.lblEinddatum.AutoSize = true;
            this.lblEinddatum.Location = new System.Drawing.Point(941, 244);
            this.lblEinddatum.Name = "lblEinddatum";
            this.lblEinddatum.Size = new System.Drawing.Size(79, 17);
            this.lblEinddatum.TabIndex = 9;
            this.lblEinddatum.Text = "Eind datum";
            // 
            // dtpEinddatum
            // 
            this.dtpEinddatum.Location = new System.Drawing.Point(937, 273);
            this.dtpEinddatum.Name = "dtpEinddatum";
            this.dtpEinddatum.Size = new System.Drawing.Size(262, 22);
            this.dtpEinddatum.TabIndex = 10;
            // 
            // btnReserveer
            // 
            this.btnReserveer.Location = new System.Drawing.Point(936, 411);
            this.btnReserveer.Name = "btnReserveer";
            this.btnReserveer.Size = new System.Drawing.Size(262, 65);
            this.btnReserveer.TabIndex = 11;
            this.btnReserveer.Text = "Reserveer";
            this.btnReserveer.UseVisualStyleBackColor = true;
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
            // ReserveringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 650);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnReserveer);
            this.Controls.Add(this.dtpEinddatum);
            this.Controls.Add(this.lblEinddatum);
            this.Controls.Add(this.lblBegindatum);
            this.Controls.Add(this.dtpBegindatum);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblAantalpersonen);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.lbl_plaatsen);
            this.Controls.Add(this.cbKampeerplaatsen);
            this.Controls.Add(this.pb_Plattegrond);
            this.Name = "ReserveringsForm";
            this.Text = "ReserveringsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Plattegrond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Plattegrond;
        private System.Windows.Forms.ComboBox cbKampeerplaatsen;
        private System.Windows.Forms.Label lbl_plaatsen;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Label lblAantalpersonen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dtpBegindatum;
        private System.Windows.Forms.Label lblBegindatum;
        private System.Windows.Forms.Label lblEinddatum;
        private System.Windows.Forms.DateTimePicker dtpEinddatum;
        private System.Windows.Forms.Button btnReserveer;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox tbPrijs;
    }
}