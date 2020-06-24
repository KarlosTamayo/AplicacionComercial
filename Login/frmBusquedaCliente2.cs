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
    public partial class frmBusquedaCliente2 : Form
    {
        public frmBusquedaCliente2()
        {
            InitializeComponent();
        }

        private void frmBusquedaCliente2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }

        private void busquedaCliente2ToolStripButton_Click(object sender, EventArgs e)
        {
            string nombreComercial, nombresContacto, apellidosContacto;

            if (contengaRadioButton.Checked == true)
            {
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text + "%";
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";

            }
            else if (empieceRadioButton.Checked == true)
            {
                nombreComercial = nombreComercialToolStripTextBox.Text + "%";
                nombresContacto = nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = apellidosContactoToolStripTextBox.Text + "%";

            }
            else if (termineRadioButton.Checked == true)
            {
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text;
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text;
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text;
            }
            else
            {
                nombreComercial = nombreComercialToolStripTextBox.Text;
                nombresContacto = nombresContactoToolStripTextBox.Text;
                apellidosContacto = apellidosContactoToolStripTextBox.Text;
            }
            try
            {
                this.clienteTableAdapter.BusquedaCliente2(this.dSAplicacionComercial.Cliente, 
                    nombreComercial, 
                    nombresContacto,
                    apellidosContacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            nombreComercialToolStripTextBox.Text = string.Empty;
            nombresContactoToolStripTextBox.Text = string.Empty;
            apellidosContactoToolStripTextBox.Text = string.Empty;
            busquedaCliente2ToolStripButton_Click(sender, e);
        }
    }
}
