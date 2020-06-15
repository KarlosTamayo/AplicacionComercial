using Login.DS;
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
    public partial class frmCliente : Form
    {
        private int i = 0;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSALl.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.dSALl.TipoDocumento);
            // TODO: This line of code loads data into the 'dSAplicacionComercial.Cliente' table. You can move, or remove it, as needed.

            clientesDataGridView.DataSource = CADCliente.GetData();
            MostrarRagistro();

        }


        private void MostrarRagistro()
        {
            if (clientesDataGridView.Rows.Count == 0) return ;
            iDClienteTextBox.Text = clientesDataGridView.Rows[i].Cells["IDCliente"].Value.ToString();
            documentoTextBox.Text = clientesDataGridView.Rows[i].Cells["Documento"].Value.ToString();
            nombresContactoTextBox.Text = clientesDataGridView.Rows[i].Cells["NombresContacto"].Value.ToString();
            apellidosContactoTextBox.Text = clientesDataGridView.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            nombreComercialTextBox.Text = clientesDataGridView.Rows[i].Cells["NombreComercial"].Value.ToString();
            direccionTextBox.Text = clientesDataGridView.Rows[i].Cells["Direccion"].Value.ToString();
            telefono1TextBox.Text = clientesDataGridView.Rows[i].Cells["Telefono1"].Value.ToString();
            telefono2TextBox.Text = clientesDataGridView.Rows[i].Cells["Telefono2"].Value.ToString();
            correoTextBox.Text = clientesDataGridView.Rows[i].Cells["Correo"].Value.ToString();
            notasTextBox.Text = clientesDataGridView.Rows[i].Cells["Notas"].Value.ToString();
            iDTipoDocumentoComboBox.SelectedValue = clientesDataGridView.Rows[i].Cells["IDTipoDocumento"].Value;
            aniversarioDateTimePicker.Value = Convert.ToDateTime(clientesDataGridView.Rows[i].Cells["Aniversario"].Value);
        }



        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
     
        }
    }
}
