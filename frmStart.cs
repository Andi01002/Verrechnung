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
        public frmStart()
        {
            InitializeComponent();
        }

        internal int displayWidth;
        internal int displayHeight;
        internal int buttonHeight;
        internal Button[] buttons;

        private void frmStart_Load(object sender, EventArgs e)
        {
            displayWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            displayHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = displayWidth / 5;
            this.Height = displayHeight;
            this.Location = new Point(0, 0);
            buttonHeight = displayHeight / 6;
            buttons = new Button[] { btnWarenkorb, btnArtikel, btnKunde, btnRechnung, btnUSt, btnStatistik };

            int xpos = 0;
            int ypos = 0;
            foreach(Button b in buttons)
            {
                b.Width = this.Width;
                b.Height = buttonHeight;
                b.Location = new Point(xpos, ypos);
                ypos = ypos + buttonHeight;
                b.Font = new Font("Verdana Pro", 30, FontStyle.Bold);
            }
        }
    }
}
