namespace Verrechnung
{
    partial class frmStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.btnWarenkorb = new System.Windows.Forms.Button();
            this.btnArtikel = new System.Windows.Forms.Button();
            this.btnKunde = new System.Windows.Forms.Button();
            this.btnRechnung = new System.Windows.Forms.Button();
            this.btnUSt = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.btnFensterSchließen = new System.Windows.Forms.Button();
            this.btnPrgmSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarenkorb
            // 
            this.btnWarenkorb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWarenkorb.BackgroundImage")));
            this.btnWarenkorb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWarenkorb.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarenkorb.Location = new System.Drawing.Point(179, 58);
            this.btnWarenkorb.Name = "btnWarenkorb";
            this.btnWarenkorb.Size = new System.Drawing.Size(75, 23);
            this.btnWarenkorb.TabIndex = 0;
            this.btnWarenkorb.UseVisualStyleBackColor = true;
            this.btnWarenkorb.Click += new System.EventHandler(this.btnWarenkorb_Click);
            // 
            // btnArtikel
            // 
            this.btnArtikel.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikel.Location = new System.Drawing.Point(179, 124);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(75, 24);
            this.btnArtikel.TabIndex = 0;
            this.btnArtikel.Text = "Artikel";
            this.btnArtikel.UseVisualStyleBackColor = true;
            this.btnArtikel.Click += new System.EventHandler(this.btnArtikel_Click);
            // 
            // btnKunde
            // 
            this.btnKunde.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKunde.Location = new System.Drawing.Point(179, 193);
            this.btnKunde.Name = "btnKunde";
            this.btnKunde.Size = new System.Drawing.Size(75, 24);
            this.btnKunde.TabIndex = 0;
            this.btnKunde.Text = "Kunde";
            this.btnKunde.UseVisualStyleBackColor = true;
            this.btnKunde.Click += new System.EventHandler(this.btnKunde_Click);
            // 
            // btnRechnung
            // 
            this.btnRechnung.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechnung.Location = new System.Drawing.Point(179, 255);
            this.btnRechnung.Name = "btnRechnung";
            this.btnRechnung.Size = new System.Drawing.Size(75, 24);
            this.btnRechnung.TabIndex = 0;
            this.btnRechnung.Text = "Rechnung";
            this.btnRechnung.UseVisualStyleBackColor = true;
            this.btnRechnung.Click += new System.EventHandler(this.btnRechnung_Click);
            // 
            // btnUSt
            // 
            this.btnUSt.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSt.Location = new System.Drawing.Point(179, 318);
            this.btnUSt.Name = "btnUSt";
            this.btnUSt.Size = new System.Drawing.Size(75, 24);
            this.btnUSt.TabIndex = 0;
            this.btnUSt.Text = "USt";
            this.btnUSt.UseVisualStyleBackColor = true;
            this.btnUSt.Click += new System.EventHandler(this.btnUSt_Click);
            // 
            // btnStatistik
            // 
            this.btnStatistik.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistik.Location = new System.Drawing.Point(179, 379);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(75, 24);
            this.btnStatistik.TabIndex = 0;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            // 
            // btnFensterSchließen
            // 
            this.btnFensterSchließen.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFensterSchließen.Location = new System.Drawing.Point(179, 432);
            this.btnFensterSchließen.Name = "btnFensterSchließen";
            this.btnFensterSchließen.Size = new System.Drawing.Size(75, 24);
            this.btnFensterSchließen.TabIndex = 0;
            this.btnFensterSchließen.Text = "Alle Schließen";
            this.btnFensterSchließen.UseVisualStyleBackColor = true;
            this.btnFensterSchließen.Click += new System.EventHandler(this.btnFensterSchließen_Click);
            // 
            // btnPrgmSchließen
            // 
            this.btnPrgmSchließen.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrgmSchließen.Location = new System.Drawing.Point(179, 480);
            this.btnPrgmSchließen.Name = "btnPrgmSchließen";
            this.btnPrgmSchließen.Size = new System.Drawing.Size(75, 24);
            this.btnPrgmSchließen.TabIndex = 0;
            this.btnPrgmSchließen.Text = "Programm schließen";
            this.btnPrgmSchließen.UseVisualStyleBackColor = true;
            this.btnPrgmSchließen.Click += new System.EventHandler(this.btnPrgmSchließen_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnPrgmSchließen);
            this.Controls.Add(this.btnFensterSchließen);
            this.Controls.Add(this.btnStatistik);
            this.Controls.Add(this.btnUSt);
            this.Controls.Add(this.btnRechnung);
            this.Controls.Add(this.btnKunde);
            this.Controls.Add(this.btnArtikel);
            this.Controls.Add(this.btnWarenkorb);
            this.Name = "frmStart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarenkorb;
        private System.Windows.Forms.Button btnKunde;
        private System.Windows.Forms.Button btnRechnung;
        private System.Windows.Forms.Button btnUSt;
        private System.Windows.Forms.Button btnStatistik;
        private System.Windows.Forms.Button btnFensterSchließen;
        private System.Windows.Forms.Button btnPrgmSchließen;
        internal System.Windows.Forms.Button btnArtikel;
    }
}

