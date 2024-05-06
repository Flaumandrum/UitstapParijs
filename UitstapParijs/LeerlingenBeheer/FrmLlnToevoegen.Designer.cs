namespace UitstapParijs
{
    partial class FrmLlnToevoegen
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
            this.lblNaamLeerling = new System.Windows.Forms.Label();
            this.txtNaamLeerling = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaamLeerling
            // 
            this.lblNaamLeerling.AutoSize = true;
            this.lblNaamLeerling.Location = new System.Drawing.Point(22, 27);
            this.lblNaamLeerling.Name = "lblNaamLeerling";
            this.lblNaamLeerling.Size = new System.Drawing.Size(137, 24);
            this.lblNaamLeerling.TabIndex = 0;
            this.lblNaamLeerling.Text = "Naam leerling: ";
            // 
            // txtNaamLeerling
            // 
            this.txtNaamLeerling.Location = new System.Drawing.Point(195, 27);
            this.txtNaamLeerling.Name = "txtNaamLeerling";
            this.txtNaamLeerling.Size = new System.Drawing.Size(205, 29);
            this.txtNaamLeerling.TabIndex = 1;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Peru;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAnnuleren.Location = new System.Drawing.Point(253, 76);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 58);
            this.btnAnnuleren.TabIndex = 9;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.Peru;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnToevoegen.Location = new System.Drawing.Point(26, 76);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(147, 58);
            this.btnToevoegen.TabIndex = 8;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // FrmLlnToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(428, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtNaamLeerling);
            this.Controls.Add(this.lblNaamLeerling);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLlnToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leerling toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaamLeerling;
        private System.Windows.Forms.TextBox txtNaamLeerling;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnToevoegen;
    }
}