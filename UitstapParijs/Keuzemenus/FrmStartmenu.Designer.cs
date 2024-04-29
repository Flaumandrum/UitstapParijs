namespace UitstapParijs
{
    partial class FrmStartmenu
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.Tonen = new System.Windows.Forms.Button();
            this.btnUitstappenBeheer = new System.Windows.Forms.Button();
            this.btnLeerlingBeheer = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.Peru;
            this.btnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfsluiten.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAfsluiten.Location = new System.Drawing.Point(36, 254);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(147, 58);
            this.btnAfsluiten.TabIndex = 9;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // Tonen
            // 
            this.Tonen.BackColor = System.Drawing.Color.Peru;
            this.Tonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tonen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Tonen.Location = new System.Drawing.Point(36, 190);
            this.Tonen.Name = "Tonen";
            this.Tonen.Size = new System.Drawing.Size(147, 58);
            this.Tonen.TabIndex = 8;
            this.Tonen.Text = "Menu tonen";
            this.Tonen.UseVisualStyleBackColor = false;
            this.Tonen.Click += new System.EventHandler(this.Tonen_Click);
            // 
            // btnUitstappenBeheer
            // 
            this.btnUitstappenBeheer.BackColor = System.Drawing.Color.Peru;
            this.btnUitstappenBeheer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUitstappenBeheer.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnUitstappenBeheer.Location = new System.Drawing.Point(36, 126);
            this.btnUitstappenBeheer.Name = "btnUitstappenBeheer";
            this.btnUitstappenBeheer.Size = new System.Drawing.Size(147, 58);
            this.btnUitstappenBeheer.TabIndex = 7;
            this.btnUitstappenBeheer.Text = "Beheer uitstappen";
            this.btnUitstappenBeheer.UseVisualStyleBackColor = false;
            this.btnUitstappenBeheer.Click += new System.EventHandler(this.btnUitstappenBeheer_Click);
            // 
            // btnLeerlingBeheer
            // 
            this.btnLeerlingBeheer.BackColor = System.Drawing.Color.Peru;
            this.btnLeerlingBeheer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerlingBeheer.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnLeerlingBeheer.Location = new System.Drawing.Point(36, 62);
            this.btnLeerlingBeheer.Name = "btnLeerlingBeheer";
            this.btnLeerlingBeheer.Size = new System.Drawing.Size(147, 58);
            this.btnLeerlingBeheer.TabIndex = 6;
            this.btnLeerlingBeheer.Text = "Beheer leerlingen";
            this.btnLeerlingBeheer.UseVisualStyleBackColor = false;
            this.btnLeerlingBeheer.Click += new System.EventHandler(this.btnLeerlingBeheer_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIntro.Location = new System.Drawing.Point(32, 20);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(146, 24);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Maak uw keuze:";
            // 
            // FrmStartmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(219, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.Tonen);
            this.Controls.Add(this.btnUitstappenBeheer);
            this.Controls.Add(this.btnLeerlingBeheer);
            this.Controls.Add(this.lblIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmStartmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button Tonen;
        private System.Windows.Forms.Button btnUitstappenBeheer;
        private System.Windows.Forms.Button btnLeerlingBeheer;
        private System.Windows.Forms.Label lblIntro;
    }
}

