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
    }
}
