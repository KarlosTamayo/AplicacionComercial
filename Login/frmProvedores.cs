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
    public partial class frmProvedores : Form
    {
        public frmProvedores()
        {
            InitializeComponent();
        }

        

        private void frmProvedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSALl.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSALl.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }
                                                                                                                                                                          
        private void firstItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void previousItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void nextItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void lastItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void editItemBindingNavigator_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

     

        private void addNewITembindingNavigator_Click(object sender, EventArgs e)
        {
           


        }

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }
        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
        }

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void searchBindingNavigator_Click(object sender, EventArgs e)
        {

        }


        //************* metodos *****************
        private void HabilitarCampos()
        {
            iDTipoDocumentoComboBox.Enabled = true;
            nombresContactoTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            documentoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;

            firstItemBindingNavigator.Enabled = false;
            previousItemBindingNavigator.Enabled = false;
            nextItemBindingNavigator.Enabled = false;
            lastItemBindingNavigator.Enabled = false;
            editItemBindingNavigator.Enabled = false;
            addNewITembindingNavigator.Enabled = false;
            deleteItemBindingNavigator.Enabled = false;
            saveItemBindingNavigator.Enabled = true;
            cancelItemBindingNavigator.Enabled = true;           
            searchBindingNavigator.Enabled = false;

        }                                                                                                                                                                                                                                                                                    

    }
}
