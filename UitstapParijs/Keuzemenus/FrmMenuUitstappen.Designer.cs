namespace UitstapParijs
{
    partial class FrmMenuUitstappen
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
            this.btnUistapVerwijderen = new System.Windows.Forms.Button();
            this.btnAanpassenUitstap = new System.Windows.Forms.Button();
            this.btnToevoegenUitstap = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(32, 254);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 23;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnUistapVerwijderen
            // 
            this.btnUistapVerwijderen.BackColor = System.Drawing.Color.Peru;
            this.btnUistapVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUistapVerwijderen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnUistapVerwijderen.Location = new System.Drawing.Point(32, 190);
            this.btnUistapVerwijderen.Name = "btnUistapVerwijderen";
            this.btnUistapVerwijderen.Size = new System.Drawing.Size(147, 58);
            this.btnUistapVerwijderen.TabIndex = 20;
            this.btnUistapVerwijderen.Text = "Uitstappen verwijderen";
            this.btnUistapVerwijderen.UseVisualStyleBackColor = false;
            // 
            // btnAanpassenUitstap
            // 
            this.btnAanpassenUitstap.BackColor = System.Drawing.Color.Peru;
            this.btnAanpassenUitstap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanpassenUitstap.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAanpassenUitstap.Location = new System.Drawing.Point(32, 126);
            this.btnAanpassenUitstap.Name = "btnAanpassenUitstap";
            this.btnAanpassenUitstap.Size = new System.Drawing.Size(147, 58);
            this.btnAanpassenUitstap.TabIndex = 19;
            this.btnAanpassenUitstap.Text = "Uitstappen aanpassen";
            this.btnAanpassenUitstap.UseVisualStyleBackColor = false;
            // 
            // btnToevoegenUitstap
            // 
            this.btnToevoegenUitstap.BackColor = System.Drawing.Color.Peru;
            this.btnToevoegenUitstap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegenUitstap.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnToevoegenUitstap.Location = new System.Drawing.Point(32, 62);
            this.btnToevoegenUitstap.Name = "btnToevoegenUitstap";
            this.btnToevoegenUitstap.Size = new System.Drawing.Size(147, 58);
            this.btnToevoegenUitstap.TabIndex = 18;
            this.btnToevoegenUitstap.Text = "Uitstappen toevoegen";
            this.btnToevoegenUitstap.UseVisualStyleBackColor = false;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIntro.Location = new System.Drawing.Point(28, 20);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(146, 24);
            this.lblIntro.TabIndex = 17;
            this.lblIntro.Text = "Maak uw keuze:";
            // 
            // FrmMenuUitstappen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(224, 342);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnUistapVerwijderen);
            this.Controls.Add(this.btnAanpassenUitstap);
            this.Controls.Add(this.btnToevoegenUitstap);
            this.Controls.Add(this.lblIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMenuUitstappen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu uitstappen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnUistapVerwijderen;
        private System.Windows.Forms.Button btnAanpassenUitstap;
        private System.Windows.Forms.Button btnToevoegenUitstap;
        private System.Windows.Forms.Label lblIntro;
    }
}