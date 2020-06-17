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
            HabilitarCampos();
            proveedorBindingSource.AddNew();
            nombresContactoTextBox.Focus();
        }

        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas Segura de borar el registro actual", "Comfimar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);


        }
        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return; ;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            deshabilitarCampos();
        }

      

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.proveedorBindingSource.CancelEdit();
            deshabilitarCampos();
            errorProvider1.Clear();
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

        private void deshabilitarCampos()
        {
            iDTipoDocumentoComboBox.Enabled = false;
            nombresContactoTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            documentoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;

            firstItemBindingNavigator.Enabled = true;
            previousItemBindingNavigator.Enabled = true;
            nextItemBindingNavigator.Enabled = true;
            lastItemBindingNavigator.Enabled = true;
            editItemBindingNavigator.Enabled = true;
            addNewITembindingNavigator.Enabled = true;
            deleteItemBindingNavigator.Enabled = true;
            saveItemBindingNavigator.Enabled = false;
            cancelItemBindingNavigator.Enabled = false;
            searchBindingNavigator.Enabled = true;

        }
        private bool validarCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox,"Debes Escoger Un Tipo De Documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombresContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debes Ingrsar Nombre De Contacto");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (apellidosContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe Ingresar Apellido");
                apellidosContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe Ingresar Nombre");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debe Ingresasr Documento");
                documentoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (correoTextBox.Text != string.Empty)
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Ingresa Correo Valido");
                    correoTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }



            return true;

        }

    }
}
