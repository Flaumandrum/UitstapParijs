namespace UitstapParijs
{
    partial class FrmKeuzeToevoegen
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
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKiesKeuze = new System.Windows.Forms.ComboBox();
            this.lblKiesKeuze = new System.Windows.Forms.Label();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnKeuzeToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(196, 28);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(205, 32);
            this.cmbKies.TabIndex = 5;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(23, 31);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(161, 24);
            this.lblKies.TabIndex = 4;
            this.lblKies.Text = "Kies een leerling: ";
            // 
            // cmbKiesKeuze
            // 
            this.cmbKiesKeuze.FormattingEnabled = true;
            this.cmbKiesKeuze.Location = new System.Drawing.Point(196, 76);
            this.cmbKiesKeuze.Name = "cmbKiesKeuze";
            this.cmbKiesKeuze.Size = new System.Drawing.Size(205, 32);
            this.cmbKiesKeuze.TabIndex = 7;
            // 
            // lblKiesKeuze
            // 
            this.lblKiesKeuze.AutoSize = true;
            this.lblKiesKeuze.Location = new System.Drawing.Point(23, 79);
            this.lblKiesKeuze.Name = "lblKiesKeuze";
            this.lblKiesKeuze.Size = new System.Drawing.Size(150, 24);
            this.lblKiesKeuze.TabIndex = 6;
            this.lblKiesKeuze.Text = "Kies een keuze: ";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(254, 140);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 15;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnKeuzeToevoegen
            // 
            this.btnKeuzeToevoegen.BackColor = System.Drawing.Color.Peru;
            this.btnKeuzeToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeuzeToevoegen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnKeuzeToevoegen.Location = new System.Drawing.Point(27, 140);
            this.btnKeuzeToevoegen.Name = "btnKeuzeToevoegen";
            this.btnKeuzeToevoegen.Size = new System.Drawing.Size(147, 58);
            this.btnKeuzeToevoegen.TabIndex = 14;
            this.btnKeuzeToevoegen.Text = "Keuze toevoegen";
            this.btnKeuzeToevoegen.UseVisualStyleBackColor = false;
            this.btnKeuzeToevoegen.Click += new System.EventHandler(this.btnKeuzeToevoegen_Click);
            // 
            // FrmKeuzeToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(429, 228);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnKeuzeToevoegen);
            this.Controls.Add(this.cmbKiesKeuze);
            this.Controls.Add(this.lblKiesKeuze);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKeuzeToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keuze van de leerling toevoegen";
            this.Load += new System.EventHandler(this.FrmKeuzeToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKiesKeuze;
        private System.Windows.Forms.Label lblKiesKeuze;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnKeuzeToevoegen;
    }
}