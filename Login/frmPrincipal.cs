﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente2 frm = new frmCliente2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvedores frm = new frmProvedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipalMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMDI frm = new frmPrincipalMDI();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
