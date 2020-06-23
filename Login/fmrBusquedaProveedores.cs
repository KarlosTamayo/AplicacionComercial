using System;
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
    public partial class fmrBusquedaProveedores : Form
    {
        private int idproveedor;

        public int Idproveedor { get => idproveedor;  }

        public fmrBusquedaProveedores()
        {
            InitializeComponent();
        }

        private void fmrBusquedaProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAplicacionComercial.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void busquedaProveedorToolStripButton_Click(object sender, EventArgs e)
        {
            string nombre, nombresContacto, apellidosContacto;

            if (contengaRadioButton.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";

            }
            else if (empieceradioButton.Checked == true)
            {
                nombre = nombreToolStripTextBox.Text + "%";
                nombresContacto = nombresContactoToolStripTextBox.Text + "%";
                apellidosContacto = apellidosContactoToolStripTextBox.Text + "%";

            }
            else if (termineRadioButton.Checked== true)
            {
                nombre = "%" + nombreToolStripTextBox.Text ;
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text ;
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text ;
            }
            else
            {
                nombre =  nombreToolStripTextBox.Text;
                nombresContacto =  nombresContactoToolStripTextBox.Text;
                apellidosContacto =  apellidosContactoToolStripTextBox.Text;
            }

            try
            {
                this.proveedorTableAdapter.BusquedaProveedor(this.dSAplicacionComercial.Proveedor,
                nombre,
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
            nombreToolStripTextBox.Text = string.Empty;
            nombresContactoToolStripTextBox.Text = string.Empty;
            apellidosContactoToolStripTextBox.Text = string.Empty;
            busquedaProveedorToolStripButton_Click(sender, e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.Rows.Count == 0)
            {
                idproveedor = 0;        
          
            }
            else if (proveedorDataGridView.SelectedRows.Count != 0)
            {
                idproveedor = (int)proveedorDataGridView.Rows[0].Cells[0].Value;
            }
            else
            {
                idproveedor = (int)proveedorDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }  


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            idproveedor = 0;
            this.Close();
        }
    }


}

