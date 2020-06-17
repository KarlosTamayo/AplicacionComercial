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
    public partial class frmCliente2 : Form
    {
        public frmCliente2()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void frmCliente2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSALl.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSALl.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }
    }
}
