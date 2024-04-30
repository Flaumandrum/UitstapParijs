namespace UitstapParijs
{
    partial class FrmTonen
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
            this.grbKeuze = new System.Windows.Forms.GroupBox();
            this.rbAlleLln = new System.Windows.Forms.RadioButton();
            this.rbLlnPerUistap = new System.Windows.Forms.RadioButton();
            this.rbAlleUitstappen = new System.Windows.Forms.RadioButton();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.grbKeuze.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKeuze
            // 
            this.grbKeuze.Controls.Add(this.rbAlleUitstappen);
            this.grbKeuze.Controls.Add(this.rbLlnPerUistap);
            this.grbKeuze.Controls.Add(this.rbAlleLln);
            this.grbKeuze.Location = new System.Drawing.Point(12, 12);
            this.grbKeuze.Name = "grbKeuze";
            this.grbKeuze.Size = new System.Drawing.Size(306, 146);
            this.grbKeuze.TabIndex = 0;
            this.grbKeuze.TabStop = false;
            // 
            // rbAlleLln
            // 
            this.rbAlleLln.AutoSize = true;
            this.rbAlleLln.Location = new System.Drawing.Point(7, 29);
            this.rbAlleLln.Name = "rbAlleLln";
            this.rbAlleLln.Size = new System.Drawing.Size(196, 28);
            this.rbAlleLln.TabIndex = 0;
            this.rbAlleLln.TabStop = true;
            this.rbAlleLln.Text = "Toon alle leerlingen";
            this.rbAlleLln.UseVisualStyleBackColor = true;
            // 
            // rbLlnPerUistap
            // 
            this.rbLlnPerUistap.AutoSize = true;
            this.rbLlnPerUistap.Location = new System.Drawing.Point(7, 63);
            this.rbLlnPerUistap.Name = "rbLlnPerUistap";
            this.rbLlnPerUistap.Size = new System.Drawing.Size(253, 28);
            this.rbLlnPerUistap.TabIndex = 1;
            this.rbLlnPerUistap.TabStop = true;
            this.rbLlnPerUistap.Text = "Toon leerlingen per uitstap";
            this.rbLlnPerUistap.UseVisualStyleBackColor = true;
            // 
            // rbAlleUitstappen
            // 
            this.rbAlleUitstappen.AutoSize = true;
            this.rbAlleUitstappen.Location = new System.Drawing.Point(7, 97);
            this.rbAlleUitstappen.Name = "rbAlleUitstappen";
            this.rbAlleUitstappen.Size = new System.Drawing.Size(198, 28);
            this.rbAlleUitstappen.TabIndex = 2;
            this.rbAlleUitstappen.TabStop = true;
            this.rbAlleUitstappen.Text = "Toon alle uitstappen";
            this.rbAlleUitstappen.UseVisualStyleBackColor = true;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(379, 94);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 15;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.BackColor = System.Drawing.Color.Peru;
            this.btnTonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnTonen.Location = new System.Drawing.Point(379, 26);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(147, 58);
            this.btnTonen.TabIndex = 14;
            this.btnTonen.Text = "Tonen";
            this.btnTonen.UseVisualStyleBackColor = false;
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.Color.SeaShell;
            this.txtToon.Location = new System.Drawing.Point(19, 187);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.Size = new System.Drawing.Size(507, 206);
            this.txtToon.TabIndex = 16;
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(548, 405);
            this.ControlBox = false;
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.grbKeuze);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTonen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tonen van gegevens";
            this.grbKeuze.ResumeLayout(false);
            this.grbKeuze.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKeuze;
        private System.Windows.Forms.RadioButton rbAlleUitstappen;
        private System.Windows.Forms.RadioButton rbLlnPerUistap;
        private System.Windows.Forms.RadioButton rbAlleLln;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnTonen;
        private System.Windows.Forms.TextBox txtToon;
    }
}