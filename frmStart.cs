using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verrechnung
{
    public partial class frmStart : Form
    {
        internal static frmStart f1;
        public frmStart()
        {
            InitializeComponent();
        }

        #region variablen

        internal int displayWidth;
        internal int displayHeight;
        internal int buttonHeight;
        internal Button[] buttons;
        internal Color buttonC = Color.DarkSlateGray;

        internal frmArtikel frmArt;
        internal frmKunde frmKun;
        internal frmRechnung frmRech;
        internal frmUmsatzsteuer frmUSt;
        internal frmWarenkorb frmWar;
        internal frmStatistik frmStat;

        #endregion;

        private void frmStart_Load(object sender, EventArgs e)
        {
            displayWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            displayHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = (displayWidth-10) / 5;
            this.Height = displayHeight+10;
            this.Location = new Point(-10, 0);
            buttonHeight = (displayHeight-20) / 8;
            buttons = new Button[] { btnWarenkorb, btnArtikel, btnKunde, btnRechnung, btnUSt, btnStatistik, btnFensterSchließen, btnPrgmSchließen};

            int xpos = 0;
            int ypos = 0;
            foreach(Button b in buttons)
            {
                b.Width = this.Width-15;
                b.Height = buttonHeight+5;
                b.Location = new Point(xpos, ypos);
                ypos = ypos + buttonHeight;
                b.Font = new Font("Verdana Pro", 20, FontStyle.Bold);
            }

            resetButtons();
        }

        internal void resetButtons()
        {
            foreach (Button b in buttons)
            {
                b.BackColor = buttonC;
                b.ForeColor = Color.White;
            }
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            if(frmArt != null)
            {
                frmArt.BringToFront();

            }

            else
            {
                btnArtikel.BackColor = Color.White;
                btnArtikel.ForeColor = buttonC;
                frmArt = new frmArtikel();
                frmArt.Text = "Artikelverwaltung";
                frmArt.Show();
            }
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            if (frmKun != null)
            {
                frmKun.BringToFront();

            }

            else
            {
                btnKunde.BackColor = Color.White;
                btnKunde.ForeColor = buttonC;
                frmKun = new frmKunde();
                frmKun.Text = "Kundenverwaltung";
                frmKun.Show();
            }
        }

        private void btnRechnung_Click(object sender, EventArgs e)
        {
            if (frmRech != null)
            {
                frmRech.BringToFront();

            }

            else
            {
                btnRechnung.BackColor = Color.White;
                btnRechnung.ForeColor = buttonC;
                frmRech = new frmRechnung();
                frmRech.Text = "Rechnungsverwaltung";
                frmRech.Show();
            }
        }

        private void btnUSt_Click(object sender, EventArgs e)
        {
            if (frmUSt != null)
            {
                frmUSt.BringToFront();

            }

            else
            {
                btnUSt.BackColor = Color.White;
                btnUSt.ForeColor = buttonC;
                frmUSt = new frmUmsatzsteuer();
                frmUSt.Text = "Umsatzsteuer";
                frmUSt.Show();
            }
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            if (frmStat != null)
            {
                frmStat.BringToFront();

            }

            else
            {
                btnStatistik.BackColor = Color.White;
                btnStatistik.ForeColor = buttonC;
                frmStat = new frmStatistik();
                frmStat.Text = "Statistik";
                frmStat.Show();
            }
        }

        private void btnWarenkorb_Click(object sender, EventArgs e)
        {
            if (frmWar != null)
            {
                frmWar.BringToFront();

            }

            else
            {
                btnWarenkorb.BackColor = Color.White;
                btnWarenkorb.ForeColor = buttonC;
                frmWar = new frmWarenkorb();
                frmWar.Text = "Warenkorb";
                frmWar.Show();
            }
        }

        private void btnPrgmSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFensterSchließen_Click(object sender, EventArgs e)
        {
            if (frmArt != null) frmArt.Close();
            if (frmKun != null) frmKun.Close();
            if (frmWar != null) frmWar.Close();
            if (frmUSt != null) frmUSt.Close();
            if (frmStat != null) frmStat.Close();
            if (frmRech != null) frmRech.Close();
        }
    }
}
