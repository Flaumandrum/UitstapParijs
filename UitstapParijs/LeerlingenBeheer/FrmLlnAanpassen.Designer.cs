namespace UitstapParijs
{
    partial class FrmLlnAanpassen
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtNaamLeerling = new System.Windows.Forms.TextBox();
            this.lblNaamLeerling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(197, 25);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(205, 32);
            this.cmbKies.TabIndex = 3;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(24, 25);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(161, 24);
            this.lblKies.TabIndex = 2;
            this.lblKies.Text = "Kies een leerling: ";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(255, 122);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 13;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.Peru;
            this.btnAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanpassen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAanpassen.Location = new System.Drawing.Point(28, 122);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(147, 58);
            this.btnAanpassen.TabIndex = 12;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            // 
            // txtNaamLeerling
            // 
            this.txtNaamLeerling.Location = new System.Drawing.Point(197, 73);
            this.txtNaamLeerling.Name = "txtNaamLeerling";
            this.txtNaamLeerling.Size = new System.Drawing.Size(205, 29);
            this.txtNaamLeerling.TabIndex = 11;
            // 
            // lblNaamLeerling
            // 
            this.lblNaamLeerling.AutoSize = true;
            this.lblNaamLeerling.Location = new System.Drawing.Point(24, 73);
            this.lblNaamLeerling.Name = "lblNaamLeerling";
            this.lblNaamLeerling.Size = new System.Drawing.Size(137, 24);
            this.lblNaamLeerling.TabIndex = 10;
            this.lblNaamLeerling.Text = "Naam leerling: ";
            // 
            // FrmLlnAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(431, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtNaamLeerling);
            this.Controls.Add(this.lblNaamLeerling);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLlnAanpassen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gegevens van de leerling aanpassen";
            this.Load += new System.EventHandler(this.FrmLlnAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtNaamLeerling;
        private System.Windows.Forms.Label lblNaamLeerling;
    }
}