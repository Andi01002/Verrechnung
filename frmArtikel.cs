﻿using System;
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
    public partial class frmArtikel : Form
    {
        public frmArtikel()
        {
            InitializeComponent();
        }
        
        private void frmArtikel_Load(object sender, EventArgs e)
        {
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.buttonC;
        }

        private void frmArtikel_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnArtikel.BackColor = frmStart.f1.buttonC;
            frmStart.f1.btnArtikel.ForeColor = Color.White;
            frmStart.f1.frmArt = null;
        }
    }
}
