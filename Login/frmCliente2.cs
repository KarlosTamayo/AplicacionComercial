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

      

        private void frmCliente2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSALl.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSALl.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }

        private void firstItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void previousItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void NextItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void LastItemBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void editItemBindingNavigator_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }        

        private void addNewITemBindingNavigator_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            nombresContactoTextBox.Focus();
            HabilitarCampos();
        }


        private void deleteItemBindingNavigator_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas Segura de borar el registro actual", "Comfimar",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
           clienteBindingSource.RemoveAt(clienteBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void saveItemBindingNavigator_Click(object sender, EventArgs e)
        {
            if(!validarCampos()) return;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            deshabilitarCampos();


        }

        private void cancelItemBindingNavigator_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
            deshabilitarCampos();
            errorProvider1.Clear();
        }


        private void searchBindingNavigator_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente2 frm = new frmBusquedaCliente2();
            frm.ShowDialog();
            //frm.Show();
        }

        //************************************************** Metodos **********************************************
        private void HabilitarCampos()
        {
            //iDClienteTextBox.ReadOnly = true;
            iDTipoDocumentoComboBox.Enabled = true;
            documentoTextBox.ReadOnly = false;
            nombreComercialTextBox.ReadOnly = false;
            nombresContactoTextBox.ReadOnly = false;
            apellidosContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            aniversarioDateTimePicker.Enabled = true;
            notasTextBox.ReadOnly = false;


            firstItemBindingNavigator.Enabled = false;
            previousItemBindingNavigator.Enabled = false;
            NextItemBindingNavigator.Enabled = false;
            LastItemBindingNavigator.Enabled = false;
            editItemBindingNavigator.Enabled = false;
            addNewITemBindingNavigator.Enabled = false;
            deleteItemBindingNavigator.Enabled = false;
            saveItemBindingNavigator.Enabled = true;
            cancelItemBindingNavigator.Enabled = true;
            searchBindingNavigator.Enabled = false;

        }

        private void deshabilitarCampos()
        {
           // iDClienteTextBox.ReadOnly = true;
            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;
            nombreComercialTextBox.ReadOnly = true;
            nombresContactoTextBox.ReadOnly = true;
            apellidosContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            aniversarioDateTimePicker.Enabled = false;
            notasTextBox.ReadOnly = true;


            firstItemBindingNavigator.Enabled = true;
            previousItemBindingNavigator.Enabled = true;
            NextItemBindingNavigator.Enabled = true;
            LastItemBindingNavigator.Enabled = true;
            editItemBindingNavigator.Enabled = true;
            addNewITemBindingNavigator.Enabled = true;
            deleteItemBindingNavigator.Enabled = true;
            saveItemBindingNavigator.Enabled = false;
            cancelItemBindingNavigator.Enabled = false;
            searchBindingNavigator.Enabled = true;          
        }

        private bool validarCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debes ingresar un typo de documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debes ingresar un typo de documento");
                documentoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreComercialTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreComercialTextBox, "Debe Ingrsar Nombre Comercial");
                nombreComercialTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombresContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debe Ingresar Nombre Contacto");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (apellidosContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe Ingreasr Apellido");
                apellidosContactoTextBox.Focus();
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
