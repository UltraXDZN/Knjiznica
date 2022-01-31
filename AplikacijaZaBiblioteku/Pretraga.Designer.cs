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
            this.PretragaButun = new System.Windows.Forms.Button();
            this.PretragaRichTextbox = new System.Windows.Forms.RichTextBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.OIBtextBox = new System.Windows.Forms.TextBox();
            this.OIBLabel = new System.Windows.Forms.Label();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.AutortextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazivtextBox = new System.Windows.Forms.TextBox();
            this.Nazivlabel = new System.Windows.Forms.Label();
            this.pretragaKorisnikaButton = new System.Windows.Forms.Button();
            this.pretragaKnjigeButton = new System.Windows.Forms.Button();
            this.pretragaPosuditeljaKnjigeButton = new System.Windows.Forms.Button();
            this.pretragaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PretragaButun
            // 
            this.PretragaButun.Location = new System.Drawing.Point(413, 194);
            this.PretragaButun.Name = "PretragaButun";
            this.PretragaButun.Size = new System.Drawing.Size(100, 23);
            this.PretragaButun.TabIndex = 2;
            this.PretragaButun.Text = "Pretraži";
            this.PretragaButun.UseVisualStyleBackColor = true;
            this.PretragaButun.Click += new System.EventHandler(this.PretragaButun_Click);
            // 
            // PretragaRichTextbox
            // 
            this.PretragaRichTextbox.Location = new System.Drawing.Point(12, 21);
            this.PretragaRichTextbox.Name = "PretragaRichTextbox";
            this.PretragaRichTextbox.Size = new System.Drawing.Size(268, 196);
            this.PretragaRichTextbox.TabIndex = 6;
            this.PretragaRichTextbox.Text = "";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(330, 46);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeLabel.TabIndex = 13;
            this.imeLabel.Text = "Ime:";
            this.imeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(333, 62);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 14;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(333, 110);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 16;
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(330, 94);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.prezimeLabel.TabIndex = 15;
            this.prezimeLabel.Text = "Prezime:";
            this.prezimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OIBtextBox
            // 
            this.OIBtextBox.Location = new System.Drawing.Point(333, 158);
            this.OIBtextBox.Name = "OIBtextBox";
            this.OIBtextBox.Size = new System.Drawing.Size(100, 20);
            this.OIBtextBox.TabIndex = 18;
            // 
            // OIBLabel
            // 
            this.OIBLabel.AutoSize = true;
            this.OIBLabel.Location = new System.Drawing.Point(330, 142);
            this.OIBLabel.Name = "OIBLabel";
            this.OIBLabel.Size = new System.Drawing.Size(28, 13);
            this.OIBLabel.TabIndex = 17;
            this.OIBLabel.Text = "OIB:";
            this.OIBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(481, 158);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNtextBox.TabIndex = 25;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(478, 142);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(35, 13);
            this.ISBNLabel.TabIndex = 24;
            this.ISBNLabel.Text = "ISBN:";
            this.ISBNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutortextBox
            // 
            this.AutortextBox.Location = new System.Drawing.Point(481, 110);
            this.AutortextBox.Name = "AutortextBox";
            this.AutortextBox.Size = new System.Drawing.Size(100, 20);
            this.AutortextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Autor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazivtextBox
            // 
            this.NazivtextBox.Location = new System.Drawing.Point(481, 62);
            this.NazivtextBox.Name = "NazivtextBox";
            this.NazivtextBox.Size = new System.Drawing.Size(100, 20);
            this.NazivtextBox.TabIndex = 21;
            // 
            // Nazivlabel
            // 
            this.Nazivlabel.AutoSize = true;
            this.Nazivlabel.Location = new System.Drawing.Point(478, 46);
            this.Nazivlabel.Name = "Nazivlabel";
            this.Nazivlabel.Size = new System.Drawing.Size(37, 13);
            this.Nazivlabel.TabIndex = 20;
            this.Nazivlabel.Text = "Naziv:";
            this.Nazivlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pretragaKorisnikaButton
            // 
            this.pretragaKorisnikaButton.Location = new System.Drawing.Point(614, 62);
            this.pretragaKorisnikaButton.Name = "pretragaKorisnikaButton";
            this.pretragaKorisnikaButton.Size = new System.Drawing.Size(75, 23);
            this.pretragaKorisnikaButton.TabIndex = 26;
            this.pretragaKorisnikaButton.Text = "Posuditelja";
            this.pretragaKorisnikaButton.UseVisualStyleBackColor = true;
            this.pretragaKorisnikaButton.Click += new System.EventHandler(this.pretragaKorisnikaButton_Click);
            // 
            // pretragaKnjigeButton
            // 
            this.pretragaKnjigeButton.Location = new System.Drawing.Point(614, 107);
            this.pretragaKnjigeButton.Name = "pretragaKnjigeButton";
            this.pretragaKnjigeButton.Size = new System.Drawing.Size(75, 23);
            this.pretragaKnjigeButton.TabIndex = 27;
            this.pretragaKnjigeButton.Text = "Knjige";
            this.pretragaKnjigeButton.UseVisualStyleBackColor = true;
            this.pretragaKnjigeButton.Click += new System.EventHandler(this.pretragaKnjigeButton_Click);
            // 
            // pretragaPosuditeljaKnjigeButton
            // 
            this.pretragaPosuditeljaKnjigeButton.Location = new System.Drawing.Point(614, 158);
            this.pretragaPosuditeljaKnjigeButton.Name = "pretragaPosuditeljaKnjigeButton";
            this.pretragaPosuditeljaKnjigeButton.Size = new System.Drawing.Size(75, 23);
            this.pretragaPosuditeljaKnjigeButton.TabIndex = 28;
            this.pretragaPosuditeljaKnjigeButton.Text = "Oboje";
            this.pretragaPosuditeljaKnjigeButton.UseVisualStyleBackColor = true;
            this.pretragaPosuditeljaKnjigeButton.Click += new System.EventHandler(this.pretragaPosuditeljaKnjigeButton_Click);
            // 
            // pretragaLabel
            // 
            this.pretragaLabel.AutoSize = true;
            this.pretragaLabel.Location = new System.Drawing.Point(611, 33);
            this.pretragaLabel.Name = "pretragaLabel";
            this.pretragaLabel.Size = new System.Drawing.Size(50, 13);
            this.pretragaLabel.TabIndex = 29;
            this.pretragaLabel.Text = "Pretraga:";
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 275);
            this.Controls.Add(this.pretragaLabel);
            this.Controls.Add(this.pretragaPosuditeljaKnjigeButton);
            this.Controls.Add(this.pretragaKnjigeButton);
            this.Controls.Add(this.pretragaKorisnikaButton);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.AutortextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NazivtextBox);
            this.Controls.Add(this.Nazivlabel);
            this.Controls.Add(this.OIBtextBox);
            this.Controls.Add(this.OIBLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.PretragaRichTextbox);
            this.Controls.Add(this.PretragaButun);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PretragaButun;
        private System.Windows.Forms.RichTextBox PretragaRichTextbox;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox OIBtextBox;
        private System.Windows.Forms.Label OIBLabel;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox AutortextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NazivtextBox;
        private System.Windows.Forms.Label Nazivlabel;
        private System.Windows.Forms.Button pretragaKorisnikaButton;
        private System.Windows.Forms.Button pretragaKnjigeButton;
        private System.Windows.Forms.Button pretragaPosuditeljaKnjigeButton;
        private System.Windows.Forms.Label pretragaLabel;
    }
}