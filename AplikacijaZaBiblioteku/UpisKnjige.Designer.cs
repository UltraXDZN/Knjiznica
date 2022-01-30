namespace AplikacijaZaBiblioteku
{
    partial class UpisKnjige
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
            this.UnosButun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.AutorKnjige = new System.Windows.Forms.TextBox();
            this.KolicinaKnjige = new System.Windows.Forms.TextBox();
            this.NazivKnjige = new System.Windows.Forms.TextBox();
            this.ISBNKnjige = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnosButun
            // 
            this.UnosButun.Location = new System.Drawing.Point(89, 104);
            this.UnosButun.Name = "UnosButun";
            this.UnosButun.Size = new System.Drawing.Size(100, 23);
            this.UnosButun.TabIndex = 13;
            this.UnosButun.Text = "Unesi";
            this.UnosButun.UseVisualStyleBackColor = true;
            this.UnosButun.Click += new System.EventHandler(this.UnosButun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kolicina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(39, 9);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(34, 13);
            this.Ime.TabIndex = 10;
            this.Ime.Text = "Naziv";
            this.Ime.Click += new System.EventHandler(this.Ime_Click);
            // 
            // AutorKnjige
            // 
            this.AutorKnjige.Location = new System.Drawing.Point(39, 65);
            this.AutorKnjige.Name = "AutorKnjige";
            this.AutorKnjige.Size = new System.Drawing.Size(100, 20);
            this.AutorKnjige.TabIndex = 9;
            this.AutorKnjige.TextChanged += new System.EventHandler(this.AutorKnjige_TextChanged);
            // 
            // KolicinaKnjige
            // 
            this.KolicinaKnjige.Location = new System.Drawing.Point(148, 65);
            this.KolicinaKnjige.Name = "KolicinaKnjige";
            this.KolicinaKnjige.Size = new System.Drawing.Size(100, 20);
            this.KolicinaKnjige.TabIndex = 8;
            this.KolicinaKnjige.TextChanged += new System.EventHandler(this.KolicinaKnjige_TextChanged);
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.Location = new System.Drawing.Point(39, 28);
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.Size = new System.Drawing.Size(100, 20);
            this.NazivKnjige.TabIndex = 7;
            this.NazivKnjige.TextChanged += new System.EventHandler(this.NazivKnjige_TextChanged);
            // 
            // ISBNKnjige
            // 
            this.ISBNKnjige.Location = new System.Drawing.Point(148, 28);
            this.ISBNKnjige.Name = "ISBNKnjige";
            this.ISBNKnjige.Size = new System.Drawing.Size(100, 20);
            this.ISBNKnjige.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ISBN";
            // 
            // UpisKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNKnjige);
            this.Controls.Add(this.UnosButun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.AutorKnjige);
            this.Controls.Add(this.KolicinaKnjige);
            this.Controls.Add(this.NazivKnjige);
            this.Name = "UpisKnjige";
            this.Text = "Upis Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnosButun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox AutorKnjige;
        private System.Windows.Forms.TextBox KolicinaKnjige;
        private System.Windows.Forms.TextBox NazivKnjige;
        private System.Windows.Forms.TextBox ISBNKnjige;
        private System.Windows.Forms.Label label1;
    }
}