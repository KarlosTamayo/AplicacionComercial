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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSALl);

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSALl.BodegaProducto' table. You can move, or remove it, as needed.
            this.bodegaProductoTableAdapter.Fill(this.dSALl.BodegaProducto);           
            // TODO: This line of code loads data into the 'dSALl.Medida' table. You can move, or remove it, as needed.
            this.medidaTableAdapter.Fill(this.dSALl.Medida);
            // TODO: This line of code loads data into the 'dSALl.IVA' table. You can move, or remove it, as needed.
            this.iVATableAdapter.Fill(this.dSALl.IVA);
            // TODO: This line of code loads data into the 'dSALl.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.dSALl.Departamento);
            // TODO: This line of code loads data into the 'dSALl.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dSALl.Producto);
            
            llenarGrillas();

        }

        private void llenarGrillas()
        {
            // TODO: This line of code loads data into the 'dSALl.Barra' table. You can move, or remove it, as needed.
            this.barraTableAdapter.FillBy(this.dSALl.Barra, Convert.ToInt32(iDProductoTextBox.Text));
        }

        #region Moven Item
        private void firstItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }

        private void previousItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }

        private void NextItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }

        private void LastItemBindingNavigator_Click(object sender, EventArgs e)
        {
            llenarGrillas();
        }
        #endregion

        private void bodegaProductoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bodegaProductoTableAdapter.FillBy(this.dSALl.BodegaProducto, ((int)(System.Convert.ChangeType(iDProductoToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
