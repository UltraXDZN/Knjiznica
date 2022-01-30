namespace AplikacijaZaBiblioteku
{
    partial class Pretraga
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
            this.VracanjePretraga = new System.Windows.Forms.TextBox();
            this.PretragaButun = new System.Windows.Forms.Button();
            this.KorisnikPretraga = new System.Windows.Forms.TextBox();
            this.KnjigaPretraga = new System.Windows.Forms.TextBox();
            this.PosudbaPretraga = new System.Windows.Forms.TextBox();
            this.PretragaRichTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZatvoriButun = new System.Windows.Forms.Button();
            this.OIBCheck = new System.Windows.Forms.CheckBox();
            this.PosudbaCheck = new System.Windows.Forms.CheckBox();
            this.VracanjeCheck = new System.Windows.Forms.CheckBox();
            this.ISBNCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // VracanjePretraga
            // 
            this.VracanjePretraga.Location = new System.Drawing.Point(333, 146);
            this.VracanjePretraga.Name = "VracanjePretraga";
            this.VracanjePretraga.Size = new System.Drawing.Size(100, 20);
            this.VracanjePretraga.TabIndex = 0;
            // 
            // PretragaButun
            // 
            this.PretragaButun.Location = new System.Drawing.Point(333, 194);
            this.PretragaButun.Name = "PretragaButun";
            this.PretragaButun.Size = new System.Drawing.Size(100, 23);
            this.PretragaButun.TabIndex = 2;
            this.PretragaButun.Text = "Pretraži";
            this.PretragaButun.UseVisualStyleBackColor = true;
            this.PretragaButun.Click += new System.EventHandler(this.PretragaButun_Click);
            // 
            // KorisnikPretraga
            // 
            this.KorisnikPretraga.Location = new System.Drawing.Point(333, 21);
            this.KorisnikPretraga.Name = "KorisnikPretraga";
            this.KorisnikPretraga.Size = new System.Drawing.Size(100, 20);
            this.KorisnikPretraga.TabIndex = 3;
            // 
            // KnjigaPretraga
            // 
            this.KnjigaPretraga.Location = new System.Drawing.Point(333, 60);
            this.KnjigaPretraga.Name = "KnjigaPretraga";
            this.KnjigaPretraga.Size = new System.Drawing.Size(100, 20);
            this.KnjigaPretraga.TabIndex = 4;
            // 
            // PosudbaPretraga
            // 
            this.PosudbaPretraga.Location = new System.Drawing.Point(333, 103);
            this.PosudbaPretraga.Name = "PosudbaPretraga";
            this.PosudbaPretraga.Size = new System.Drawing.Size(100, 20);
            this.PosudbaPretraga.TabIndex = 5;
            // 
            // PretragaRichTextbox
            // 
            this.PretragaRichTextbox.Location = new System.Drawing.Point(12, 21);
            this.PretragaRichTextbox.Name = "PretragaRichTextbox";
            this.PretragaRichTextbox.Size = new System.Drawing.Size(268, 196);
            this.PretragaRichTextbox.TabIndex = 6;
            this.PretragaRichTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OIB Korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ISBN Knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum Posudbe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum Vraćanja";
            // 
            // ZatvoriButun
            // 
            this.ZatvoriButun.Location = new System.Drawing.Point(333, 240);
            this.ZatvoriButun.Name = "ZatvoriButun";
            this.ZatvoriButun.Size = new System.Drawing.Size(100, 23);
            this.ZatvoriButun.TabIndex = 11;
            this.ZatvoriButun.Text = "Zatvori";
            this.ZatvoriButun.UseVisualStyleBackColor = true;
            this.ZatvoriButun.Click += new System.EventHandler(this.ZatvoriButun_Click);
            // 
            // OIBCheck
            // 
            this.OIBCheck.AutoSize = true;
            this.OIBCheck.Location = new System.Drawing.Point(311, 24);
            this.OIBCheck.Name = "OIBCheck";
            this.OIBCheck.Size = new System.Drawing.Size(15, 14);
            this.OIBCheck.TabIndex = 12;
            this.OIBCheck.UseVisualStyleBackColor = true;
            // 
            // PosudbaCheck
            // 
            this.PosudbaCheck.AutoSize = true;
            this.PosudbaCheck.Location = new System.Drawing.Point(311, 106);
            this.PosudbaCheck.Name = "PosudbaCheck";
            this.PosudbaCheck.Size = new System.Drawing.Size(15, 14);
            this.PosudbaCheck.TabIndex = 13;
            this.PosudbaCheck.UseVisualStyleBackColor = true;
            // 
            // VracanjeCheck
            // 
            this.VracanjeCheck.AutoSize = true;
            this.VracanjeCheck.Location = new System.Drawing.Point(311, 149);
            this.VracanjeCheck.Name = "VracanjeCheck";
            this.VracanjeCheck.Size = new System.Drawing.Size(15, 14);
            this.VracanjeCheck.TabIndex = 15;
            this.VracanjeCheck.UseVisualStyleBackColor = true;
            // 
            // ISBNCheck
            // 
            this.ISBNCheck.AutoSize = true;
            this.ISBNCheck.Location = new System.Drawing.Point(311, 63);
            this.ISBNCheck.Name = "ISBNCheck";
            this.ISBNCheck.Size = new System.Drawing.Size(15, 14);
            this.ISBNCheck.TabIndex = 16;
            this.ISBNCheck.UseVisualStyleBackColor = true;
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 275);
            this.Controls.Add(this.ISBNCheck);
            this.Controls.Add(this.VracanjeCheck);
            this.Controls.Add(this.PosudbaCheck);
            this.Controls.Add(this.OIBCheck);
            this.Controls.Add(this.ZatvoriButun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PretragaRichTextbox);
            this.Controls.Add(this.PosudbaPretraga);
            this.Controls.Add(this.KnjigaPretraga);
            this.Controls.Add(this.KorisnikPretraga);
            this.Controls.Add(this.PretragaButun);
            this.Controls.Add(this.VracanjePretraga);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VracanjePretraga;
        private System.Windows.Forms.Button PretragaButun;
        private System.Windows.Forms.TextBox KorisnikPretraga;
        private System.Windows.Forms.TextBox KnjigaPretraga;
        private System.Windows.Forms.TextBox PosudbaPretraga;
        private System.Windows.Forms.RichTextBox PretragaRichTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZatvoriButun;
        private System.Windows.Forms.CheckBox OIBCheck;
        private System.Windows.Forms.CheckBox PosudbaCheck;
        private System.Windows.Forms.CheckBox VracanjeCheck;
        private System.Windows.Forms.CheckBox ISBNCheck;
    }
}