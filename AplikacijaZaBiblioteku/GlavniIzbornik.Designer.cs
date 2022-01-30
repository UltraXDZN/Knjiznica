namespace AplikacijaZaBiblioteku
{
    partial class GlavniIzbornik
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
            this.UpisKorisnikaButton = new System.Windows.Forms.Button();
            this.PVButton = new System.Windows.Forms.Button();
            this.UpisKnjigeButton = new System.Windows.Forms.Button();
            this.DBBrowserButun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpisKorisnikaButton
            // 
            this.UpisKorisnikaButton.Location = new System.Drawing.Point(37, 51);
            this.UpisKorisnikaButton.Name = "UpisKorisnikaButton";
            this.UpisKorisnikaButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKorisnikaButton.TabIndex = 0;
            this.UpisKorisnikaButton.Text = "Upis Korisnika";
            this.UpisKorisnikaButton.UseVisualStyleBackColor = true;
            this.UpisKorisnikaButton.Click += new System.EventHandler(this.UpisKorisnikaButton_Click);
            // 
            // PVButton
            // 
            this.PVButton.Location = new System.Drawing.Point(180, 51);
            this.PVButton.Name = "PVButton";
            this.PVButton.Size = new System.Drawing.Size(137, 69);
            this.PVButton.TabIndex = 1;
            this.PVButton.Text = "Posudivanje/Vracanje";
            this.PVButton.UseVisualStyleBackColor = true;
            this.PVButton.Click += new System.EventHandler(this.PVButton_Click);
            // 
            // UpisKnjigeButton
            // 
            this.UpisKnjigeButton.Location = new System.Drawing.Point(323, 51);
            this.UpisKnjigeButton.Name = "UpisKnjigeButton";
            this.UpisKnjigeButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKnjigeButton.TabIndex = 2;
            this.UpisKnjigeButton.Text = "Upis Knjige";
            this.UpisKnjigeButton.UseVisualStyleBackColor = true;
            this.UpisKnjigeButton.Click += new System.EventHandler(this.UpisKnjigeButton_Click);
            // 
            // DBBrowserButun
            // 
            this.DBBrowserButun.Location = new System.Drawing.Point(37, 136);
            this.DBBrowserButun.Name = "DBBrowserButun";
            this.DBBrowserButun.Size = new System.Drawing.Size(423, 69);
            this.DBBrowserButun.TabIndex = 3;
            this.DBBrowserButun.Text = "Pregled i pretraživanje podataka";
            this.DBBrowserButun.UseVisualStyleBackColor = true;
            this.DBBrowserButun.Click += new System.EventHandler(this.DBBrowserButun_Click);
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 236);
            this.Controls.Add(this.DBBrowserButun);
            this.Controls.Add(this.UpisKnjigeButton);
            this.Controls.Add(this.PVButton);
            this.Controls.Add(this.UpisKorisnikaButton);
            this.Name = "GlavniIzbornik";
            this.Text = "Glavni Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpisKorisnikaButton;
        private System.Windows.Forms.Button PVButton;
        private System.Windows.Forms.Button UpisKnjigeButton;
        private System.Windows.Forms.Button DBBrowserButun;
    }
}

