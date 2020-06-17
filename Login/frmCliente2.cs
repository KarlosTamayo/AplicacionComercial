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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void editItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void addNewITemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void searchBindingNavigator_Click(object sender, EventArgs e)
        {

        }
    }
}
