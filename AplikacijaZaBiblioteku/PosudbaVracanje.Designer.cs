namespace AplikacijaZaBiblioteku
{
    partial class PosudbaVracanje
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
            this.ZavrsiButun = new System.Windows.Forms.Button();
            this.VracanjeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KnjigaText = new System.Windows.Forms.TextBox();
            this.KorisnikText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZavrsiButun
            // 
            this.ZavrsiButun.Location = new System.Drawing.Point(161, 116);
            this.ZavrsiButun.Name = "ZavrsiButun";
            this.ZavrsiButun.Size = new System.Drawing.Size(121, 23);
            this.ZavrsiButun.TabIndex = 0;
            this.ZavrsiButun.Text = "Unesi";
            this.ZavrsiButun.UseVisualStyleBackColor = true;
            this.ZavrsiButun.Click += new System.EventHandler(this.ZavrsiButun_Click);
            // 
            // VracanjeCheck
            // 
            this.VracanjeCheck.AutoSize = true;
            this.VracanjeCheck.Location = new System.Drawing.Point(34, 122);
            this.VracanjeCheck.Name = "VracanjeCheck";
            this.VracanjeCheck.Size = new System.Drawing.Size(68, 17);
            this.VracanjeCheck.TabIndex = 3;
            this.VracanjeCheck.Text = "Vracanje";
            this.VracanjeCheck.UseVisualStyleBackColor = true;
            this.VracanjeCheck.CheckedChanged += new System.EventHandler(this.VracanjeCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OIB Korisnika";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISBN Knjige";
            // 
            // KnjigaText
            // 
            this.KnjigaText.Location = new System.Drawing.Point(165, 54);
            this.KnjigaText.Name = "KnjigaText";
            this.KnjigaText.Size = new System.Drawing.Size(100, 20);
            this.KnjigaText.TabIndex = 6;
            // 
            // KorisnikText
            // 
            this.KorisnikText.Location = new System.Drawing.Point(37, 54);
            this.KorisnikText.Name = "KorisnikText";
            this.KorisnikText.Size = new System.Drawing.Size(100, 20);
            this.KorisnikText.TabIndex = 7;
            // 
            // PosudbaVracanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 194);
            this.Controls.Add(this.KorisnikText);
            this.Controls.Add(this.KnjigaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VracanjeCheck);
            this.Controls.Add(this.ZavrsiButun);
            this.Name = "PosudbaVracanje";
            this.Text = "PosudbaVracanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZavrsiButun;
        private System.Windows.Forms.CheckBox VracanjeCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KnjigaText;
        private System.Windows.Forms.TextBox KorisnikText;
    }
}