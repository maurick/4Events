namespace _4Events.View
{
    partial class AddAccountForm
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
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.lbSelectedAccounts = new System.Windows.Forms.ListBox();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(13, 13);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(194, 324);
            this.lbAccounts.TabIndex = 0;
            // 
            // lbSelectedAccounts
            // 
            this.lbSelectedAccounts.FormattingEnabled = true;
            this.lbSelectedAccounts.ItemHeight = 16;
            this.lbSelectedAccounts.Location = new System.Drawing.Point(297, 13);
            this.lbSelectedAccounts.Name = "lbSelectedAccounts";
            this.lbSelectedAccounts.Size = new System.Drawing.Size(194, 324);
            this.lbSelectedAccounts.TabIndex = 1;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Location = new System.Drawing.Point(214, 45);
            this.btnUnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(76, 52);
            this.btnUnSelect.TabIndex = 5;
            this.btnUnSelect.Text = "<<";
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(214, 105);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 52);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = ">>";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 344);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(478, 50);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 395);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUnSelect);
            this.Controls.Add(this.lbSelectedAccounts);
            this.Controls.Add(this.lbAccounts);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAccountForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.ListBox lbSelectedAccounts;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOk;
    }
}