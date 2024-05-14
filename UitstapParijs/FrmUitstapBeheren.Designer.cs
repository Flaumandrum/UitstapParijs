namespace UitstapParijs
{
    partial class FrmUitstapBeheren
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtNaamUitstap = new System.Windows.Forms.TextBox();
            this.lblNaamUitstap = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(253, 121);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 19;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.Peru;
            this.btnAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanpassen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAanpassen.Location = new System.Drawing.Point(26, 121);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(147, 58);
            this.btnAanpassen.TabIndex = 18;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtNaamUitstap
            // 
            this.txtNaamUitstap.Location = new System.Drawing.Point(195, 72);
            this.txtNaamUitstap.Name = "txtNaamUitstap";
            this.txtNaamUitstap.Size = new System.Drawing.Size(205, 29);
            this.txtNaamUitstap.TabIndex = 17;
            // 
            // lblNaamUitstap
            // 
            this.lblNaamUitstap.AutoSize = true;
            this.lblNaamUitstap.Location = new System.Drawing.Point(22, 75);
            this.lblNaamUitstap.Name = "lblNaamUitstap";
            this.lblNaamUitstap.Size = new System.Drawing.Size(123, 24);
            this.lblNaamUitstap.TabIndex = 16;
            this.lblNaamUitstap.Text = "Naam uitstap:";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(195, 24);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(205, 32);
            this.cmbKies.TabIndex = 15;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(22, 27);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(152, 24);
            this.lblKies.TabIndex = 14;
            this.lblKies.Text = "Kies een uitstap: ";
            // 
            // FrmUitstapBeheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(432, 212);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtNaamUitstap);
            this.Controls.Add(this.lblNaamUitstap);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmUitstapBeheren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uitstappen beheren:";
            this.Load += new System.EventHandler(this.FrmUitstapBeheren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtNaamUitstap;
        private System.Windows.Forms.Label lblNaamUitstap;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
    }
}