namespace _4Events.View
{
    partial class ToegangscontroleStatusFrom
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBetalingsstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIngechecked = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Betalingsstatus";
            // 
            // cbBetalingsstatus
            // 
            this.cbBetalingsstatus.FormattingEnabled = true;
            this.cbBetalingsstatus.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbBetalingsstatus.Location = new System.Drawing.Point(149, 12);
            this.cbBetalingsstatus.Name = "cbBetalingsstatus";
            this.cbBetalingsstatus.Size = new System.Drawing.Size(121, 24);
            this.cbBetalingsstatus.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingechecked";
            // 
            // cbIngechecked
            // 
            this.cbIngechecked.FormattingEnabled = true;
            this.cbIngechecked.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbIngechecked.Location = new System.Drawing.Point(149, 54);
            this.cbIngechecked.Name = "cbIngechecked";
            this.cbIngechecked.Size = new System.Drawing.Size(121, 24);
            this.cbIngechecked.TabIndex = 4;
            // 
            // ToegangscontroleStatusFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 134);
            this.Controls.Add(this.cbIngechecked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBetalingsstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "ToegangscontroleStatusFrom";
            this.Text = "Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBetalingsstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIngechecked;
    }
}