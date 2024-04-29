namespace UitstapParijs
{
    partial class FrmKeuzeAanpassen
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
            this.btnKeuzeAanpassen = new System.Windows.Forms.Button();
            this.cmbKiesKeuze = new System.Windows.Forms.ComboBox();
            this.lblKiesKeuze = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(253, 138);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 21;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnKeuzeAanpassen
            // 
            this.btnKeuzeAanpassen.BackColor = System.Drawing.Color.Peru;
            this.btnKeuzeAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeuzeAanpassen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnKeuzeAanpassen.Location = new System.Drawing.Point(26, 138);
            this.btnKeuzeAanpassen.Name = "btnKeuzeAanpassen";
            this.btnKeuzeAanpassen.Size = new System.Drawing.Size(147, 58);
            this.btnKeuzeAanpassen.TabIndex = 20;
            this.btnKeuzeAanpassen.Text = "Keuze aanpassen";
            this.btnKeuzeAanpassen.UseVisualStyleBackColor = false;
            // 
            // cmbKiesKeuze
            // 
            this.cmbKiesKeuze.FormattingEnabled = true;
            this.cmbKiesKeuze.Location = new System.Drawing.Point(195, 74);
            this.cmbKiesKeuze.Name = "cmbKiesKeuze";
            this.cmbKiesKeuze.Size = new System.Drawing.Size(205, 32);
            this.cmbKiesKeuze.TabIndex = 19;
            // 
            // lblKiesKeuze
            // 
            this.lblKiesKeuze.AutoSize = true;
            this.lblKiesKeuze.Location = new System.Drawing.Point(22, 77);
            this.lblKiesKeuze.Name = "lblKiesKeuze";
            this.lblKiesKeuze.Size = new System.Drawing.Size(179, 24);
            this.lblKiesKeuze.TabIndex = 18;
            this.lblKiesKeuze.Text = "Kies nieuwe keuze: ";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(195, 26);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(205, 32);
            this.cmbKies.TabIndex = 17;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(22, 29);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(161, 24);
            this.lblKies.TabIndex = 16;
            this.lblKies.Text = "Kies een leerling: ";
            // 
            // FrmKeuzeAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(425, 228);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnKeuzeAanpassen);
            this.Controls.Add(this.cmbKiesKeuze);
            this.Controls.Add(this.lblKiesKeuze);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKeuzeAanpassen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanpassen keuze van leerling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnKeuzeAanpassen;
        private System.Windows.Forms.ComboBox cmbKiesKeuze;
        private System.Windows.Forms.Label lblKiesKeuze;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
    }
}