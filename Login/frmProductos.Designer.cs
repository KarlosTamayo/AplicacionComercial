﻿namespace Login
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDDepartamentoLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label iDMedidaLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.dSALl = new Login.DSAll.DSALl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Login.DSAll.DSALlTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new Login.DSAll.DSALlTableAdapters.TableAdapterManager();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.editItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.addNewITemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.firstItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.previousItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NextItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.LastItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.saveItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.cancelItemBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.searchBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.iDMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.departamentoTableAdapter = new Login.DSAll.DSALlTableAdapters.DepartamentoTableAdapter();
            this.iVATableAdapter = new Login.DSAll.DSALlTableAdapters.IVATableAdapter();
            this.medidaTableAdapter = new Login.DSAll.DSALlTableAdapters.MedidaTableAdapter();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.buscarImagenButton = new System.Windows.Forms.Button();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.codigoBarraGroupBox = new System.Windows.Forms.GroupBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.barraTextBox = new System.Windows.Forms.TextBox();
            this.barraLabel = new System.Windows.Forms.Label();
            this.barraDataGridView = new System.Windows.Forms.DataGridView();
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaGroupBox = new System.Windows.Forms.GroupBox();
            this.agregarBodegaButton = new System.Windows.Forms.Button();
            this.bodegaDataGridView = new System.Windows.Forms.DataGridView();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barraTableAdapter = new Login.DSAll.DSALlTableAdapters.BarraTableAdapter();
            this.bodegaProductoTableAdapter = new Login.DSAll.DSALlTableAdapters.BodegaProductoTableAdapter();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDProductoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDProductoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            iDDepartamentoLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            iDMedidaLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSALl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.codigoBarraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            this.bodegaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDDepartamentoLabel
            // 
            iDDepartamentoLabel.AutoSize = true;
            iDDepartamentoLabel.Location = new System.Drawing.Point(15, 57);
            iDDepartamentoLabel.Name = "iDDepartamentoLabel";
            iDDepartamentoLabel.Size = new System.Drawing.Size(88, 13);
            iDDepartamentoLabel.TabIndex = 2;
            iDDepartamentoLabel.Text = "IDDepartamento:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(382, 57);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(38, 13);
            iDIVALabel.TabIndex = 4;
            iDIVALabel.Text = "IDIVA:";
            // 
            // iDMedidaLabel
            // 
            iDMedidaLabel.AutoSize = true;
            iDMedidaLabel.Location = new System.Drawing.Point(653, 55);
            iDMedidaLabel.Name = "iDMedidaLabel";
            iDMedidaLabel.Size = new System.Drawing.Size(56, 13);
            iDMedidaLabel.TabIndex = 6;
            iDMedidaLabel.Text = "IDMedida:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(39, 84);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(64, 13);
            iDProductoLabel.TabIndex = 8;
            iDProductoLabel.Text = "IDProducto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(63, 110);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 10;
            precioLabel.Text = "Precio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(354, 81);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 12;
            descripcionLabel.Text = "Descripcion:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(65, 140);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 14;
            notasLabel.Text = "Notas:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(375, 110);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(45, 13);
            imagenLabel.TabIndex = 16;
            imagenLabel.Text = "Imagen:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(664, 88);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(45, 13);
            medidaLabel.TabIndex = 18;
            medidaLabel.Text = "Medida:";
            // 
            // dSALl
            // 
            this.dSALl.DataSetName = "DSALl";
            this.dSALl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSALl;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraDetalleTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.KardexTableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SalidaDetalleTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.TrasladoDetalleTableAdapter = null;
            this.tableAdapterManager.TrasladoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Login.DSAll.DSALlTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VentaDetalleTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.editItemBindingNavigator;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.addNewITemBindingNavigator;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItemBindingNavigator,
            this.previousItemBindingNavigator,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.NextItemBindingNavigator,
            this.LastItemBindingNavigator,
            this.bindingNavigatorSeparator2,
            this.editItemBindingNavigator,
            this.addNewITemBindingNavigator,
            this.deleteItemBindingNavigator,
            this.saveItemBindingNavigator,
            this.cancelItemBindingNavigator,
            this.searchBindingNavigator});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.firstItemBindingNavigator;
            this.productoBindingNavigator.MoveLastItem = this.LastItemBindingNavigator;
            this.productoBindingNavigator.MoveNextItem = this.NextItemBindingNavigator;
            this.productoBindingNavigator.MovePreviousItem = this.previousItemBindingNavigator;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1175, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // editItemBindingNavigator
            // 
            this.editItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editItemBindingNavigator.Image = global::Login.Properties.Resources.editar32s32;
            this.editItemBindingNavigator.Name = "editItemBindingNavigator";
            this.editItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.editItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.editItemBindingNavigator.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // addNewITemBindingNavigator
            // 
            this.addNewITemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewITemBindingNavigator.Image = global::Login.Properties.Resources._34x34busqueda;
            this.addNewITemBindingNavigator.Name = "addNewITemBindingNavigator";
            this.addNewITemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.addNewITemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.addNewITemBindingNavigator.Text = "Delete";
            // 
            // firstItemBindingNavigator
            // 
            this.firstItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstItemBindingNavigator.Image = global::Login.Properties.Resources.finalizquierda32x32;
            this.firstItemBindingNavigator.Name = "firstItemBindingNavigator";
            this.firstItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.firstItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.firstItemBindingNavigator.Text = "Move first";
            this.firstItemBindingNavigator.Click += new System.EventHandler(this.firstItemBindingNavigator_Click);
            // 
            // previousItemBindingNavigator
            // 
            this.previousItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousItemBindingNavigator.Image = global::Login.Properties.Resources.flechaizquierda32x32;
            this.previousItemBindingNavigator.Name = "previousItemBindingNavigator";
            this.previousItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.previousItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.previousItemBindingNavigator.Text = "Move previous";
            this.previousItemBindingNavigator.Click += new System.EventHandler(this.previousItemBindingNavigator_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NextItemBindingNavigator
            // 
            this.NextItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextItemBindingNavigator.Image = global::Login.Properties.Resources.flechaderecha32x32;
            this.NextItemBindingNavigator.Name = "NextItemBindingNavigator";
            this.NextItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.NextItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.NextItemBindingNavigator.Text = "Move next";
            this.NextItemBindingNavigator.Click += new System.EventHandler(this.NextItemBindingNavigator_Click);
            // 
            // LastItemBindingNavigator
            // 
            this.LastItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastItemBindingNavigator.Image = global::Login.Properties.Resources.flechafinalderecha32x32;
            this.LastItemBindingNavigator.Name = "LastItemBindingNavigator";
            this.LastItemBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.LastItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.LastItemBindingNavigator.Text = "Move last";
            this.LastItemBindingNavigator.Click += new System.EventHandler(this.LastItemBindingNavigator_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteItemBindingNavigator
            // 
            this.deleteItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemBindingNavigator.Image = global::Login.Properties.Resources.delete32x32;
            this.deleteItemBindingNavigator.Name = "deleteItemBindingNavigator";
            this.deleteItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.deleteItemBindingNavigator.Text = "Save Data";
            this.deleteItemBindingNavigator.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // saveItemBindingNavigator
            // 
            this.saveItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveItemBindingNavigator.Enabled = false;
            this.saveItemBindingNavigator.Image = global::Login.Properties.Resources.guardar32x32exceletne;
            this.saveItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveItemBindingNavigator.Name = "saveItemBindingNavigator";
            this.saveItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.saveItemBindingNavigator.Text = "toolStripButton1";
            // 
            // cancelItemBindingNavigator
            // 
            this.cancelItemBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelItemBindingNavigator.Enabled = false;
            this.cancelItemBindingNavigator.Image = global::Login.Properties.Resources.cancelar32x32;
            this.cancelItemBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelItemBindingNavigator.Name = "cancelItemBindingNavigator";
            this.cancelItemBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.cancelItemBindingNavigator.Text = "toolStripButton2";
            // 
            // searchBindingNavigator
            // 
            this.searchBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBindingNavigator.Image = global::Login.Properties.Resources.search2_32x321;
            this.searchBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBindingNavigator.Name = "searchBindingNavigator";
            this.searchBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.searchBindingNavigator.Text = "toolStripButton3";
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToOrderColumns = true;
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(0, 363);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(1175, 238);
            this.productoDataGridView.TabIndex = 1;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSALl;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSALl;
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dSALl;
            // 
            // iDDepartamentoComboBox
            // 
            this.iDDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDDepartamento", true));
            this.iDDepartamentoComboBox.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoComboBox.DisplayMember = "Descripcion";
            this.iDDepartamentoComboBox.Enabled = false;
            this.iDDepartamentoComboBox.FormattingEnabled = true;
            this.iDDepartamentoComboBox.Location = new System.Drawing.Point(109, 54);
            this.iDDepartamentoComboBox.Name = "iDDepartamentoComboBox";
            this.iDDepartamentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDDepartamentoComboBox.TabIndex = 3;
            this.iDDepartamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.Enabled = false;
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(435, 54);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDIVAComboBox.TabIndex = 5;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // iDMedidaComboBox
            // 
            this.iDMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDMedida", true));
            this.iDMedidaComboBox.DataSource = this.medidaBindingSource;
            this.iDMedidaComboBox.DisplayMember = "Descripcion";
            this.iDMedidaComboBox.Enabled = false;
            this.iDMedidaComboBox.FormattingEnabled = true;
            this.iDMedidaComboBox.Location = new System.Drawing.Point(724, 49);
            this.iDMedidaComboBox.Name = "iDMedidaComboBox";
            this.iDMedidaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDMedidaComboBox.TabIndex = 7;
            this.iDMedidaComboBox.ValueMember = "IDMedida";
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(109, 81);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.ReadOnly = true;
            this.iDProductoTextBox.Size = new System.Drawing.Size(121, 20);
            this.iDProductoTextBox.TabIndex = 9;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(109, 107);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 11;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(435, 78);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descripcionTextBox.TabIndex = 13;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(109, 133);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(329, 53);
            this.notasTextBox.TabIndex = 15;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(435, 107);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.ReadOnly = true;
            this.imagenTextBox.Size = new System.Drawing.Size(121, 20);
            this.imagenTextBox.TabIndex = 17;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(724, 84);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.ReadOnly = true;
            this.medidaTextBox.Size = new System.Drawing.Size(121, 20);
            this.medidaTextBox.TabIndex = 19;
            // 
            // buscarImagenButton
            // 
            this.buscarImagenButton.Enabled = false;
            this.buscarImagenButton.FlatAppearance.BorderSize = 0;
            this.buscarImagenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarImagenButton.Image = global::Login.Properties.Resources.ic_launcher1;
            this.buscarImagenButton.Location = new System.Drawing.Point(481, 133);
            this.buscarImagenButton.Name = "buscarImagenButton";
            this.buscarImagenButton.Size = new System.Drawing.Size(75, 66);
            this.buscarImagenButton.TabIndex = 20;
            this.buscarImagenButton.UseVisualStyleBackColor = true;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.Location = new System.Drawing.Point(562, 117);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(115, 69);
            this.imagenPictureBox.TabIndex = 21;
            this.imagenPictureBox.TabStop = false;
            // 
            // codigoBarraGroupBox
            // 
            this.codigoBarraGroupBox.Controls.Add(this.eliminarButton);
            this.codigoBarraGroupBox.Controls.Add(this.agregarButton);
            this.codigoBarraGroupBox.Controls.Add(this.barraTextBox);
            this.codigoBarraGroupBox.Controls.Add(this.barraLabel);
            this.codigoBarraGroupBox.Controls.Add(this.barraDataGridView);
            this.codigoBarraGroupBox.Location = new System.Drawing.Point(0, 216);
            this.codigoBarraGroupBox.Name = "codigoBarraGroupBox";
            this.codigoBarraGroupBox.Size = new System.Drawing.Size(392, 141);
            this.codigoBarraGroupBox.TabIndex = 22;
            this.codigoBarraGroupBox.TabStop = false;
            this.codigoBarraGroupBox.Text = "Codigo Barra";
            // 
            // eliminarButton
            // 
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Image = global::Login.Properties.Resources.cancelar31x31;
            this.eliminarButton.Location = new System.Drawing.Point(311, 13);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 38);
            this.eliminarButton.TabIndex = 4;
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // agregarButton
            // 
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Image = global::Login.Properties.Resources.agregarbueno34x34;
            this.agregarButton.Location = new System.Drawing.Point(230, 13);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 38);
            this.agregarButton.TabIndex = 3;
            this.agregarButton.UseVisualStyleBackColor = true;
            // 
            // barraTextBox
            // 
            this.barraTextBox.Location = new System.Drawing.Point(44, 20);
            this.barraTextBox.Name = "barraTextBox";
            this.barraTextBox.Size = new System.Drawing.Size(100, 20);
            this.barraTextBox.TabIndex = 2;
            // 
            // barraLabel
            // 
            this.barraLabel.AutoSize = true;
            this.barraLabel.Location = new System.Drawing.Point(6, 23);
            this.barraLabel.Name = "barraLabel";
            this.barraLabel.Size = new System.Drawing.Size(32, 13);
            this.barraLabel.TabIndex = 1;
            this.barraLabel.Text = "Barra";
            // 
            // barraDataGridView
            // 
            this.barraDataGridView.AllowUserToAddRows = false;
            this.barraDataGridView.AllowUserToDeleteRows = false;
            this.barraDataGridView.AllowUserToOrderColumns = true;
            this.barraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraDataGridView.AutoGenerateColumns = false;
            this.barraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.barraDataGridViewTextBoxColumn});
            this.barraDataGridView.DataSource = this.barraBindingSource;
            this.barraDataGridView.Location = new System.Drawing.Point(6, 57);
            this.barraDataGridView.Name = "barraDataGridView";
            this.barraDataGridView.ReadOnly = true;
            this.barraDataGridView.Size = new System.Drawing.Size(386, 78);
            this.barraDataGridView.TabIndex = 0;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "Barra";
            this.barraBindingSource.DataSource = this.dSALl;
            // 
            // bodegaGroupBox
            // 
            this.bodegaGroupBox.Controls.Add(this.agregarBodegaButton);
            this.bodegaGroupBox.Controls.Add(this.bodegaDataGridView);
            this.bodegaGroupBox.Location = new System.Drawing.Point(435, 216);
            this.bodegaGroupBox.Name = "bodegaGroupBox";
            this.bodegaGroupBox.Size = new System.Drawing.Size(720, 141);
            this.bodegaGroupBox.TabIndex = 23;
            this.bodegaGroupBox.TabStop = false;
            this.bodegaGroupBox.Text = "Bodegas";
            // 
            // agregarBodegaButton
            // 
            this.agregarBodegaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarBodegaButton.FlatAppearance.BorderSize = 0;
            this.agregarBodegaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBodegaButton.Image = global::Login.Properties.Resources.agregarbueno34x341;
            this.agregarBodegaButton.Location = new System.Drawing.Point(535, 13);
            this.agregarBodegaButton.Name = "agregarBodegaButton";
            this.agregarBodegaButton.Size = new System.Drawing.Size(75, 38);
            this.agregarBodegaButton.TabIndex = 1;
            this.agregarBodegaButton.UseVisualStyleBackColor = true;
            // 
            // bodegaDataGridView
            // 
            this.bodegaDataGridView.AllowUserToAddRows = false;
            this.bodegaDataGridView.AllowUserToDeleteRows = false;
            this.bodegaDataGridView.AllowUserToOrderColumns = true;
            this.bodegaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodegaDataGridView.AutoGenerateColumns = false;
            this.bodegaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bodegaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.bodegaDataGridView.DataSource = this.bodegaProductoBindingSource;
            this.bodegaDataGridView.Location = new System.Drawing.Point(0, 57);
            this.bodegaDataGridView.Name = "bodegaDataGridView";
            this.bodegaDataGridView.ReadOnly = true;
            this.bodegaDataGridView.Size = new System.Drawing.Size(714, 72);
            this.bodegaDataGridView.TabIndex = 0;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dSALl;
            this.bodegaProductoBindingSource.CurrentChanged += new System.EventHandler(this.bodegaProductoBindingSource_CurrentChanged);
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.DataSource = this.departamentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDDepartamento";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Imagen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Imagen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDMedida";
            this.dataGridViewTextBoxColumn8.DataSource = this.medidaBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID Medida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDMedida";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.iDBodegaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "ID Bodega";
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn1
            // 
            this.iDProductoDataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.DataSource = this.productoBindingSource;
            this.iDProductoDataGridViewTextBoxColumn1.DisplayMember = "Descripcion";
            this.iDProductoDataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.iDProductoDataGridViewTextBoxColumn1.Name = "iDProductoDataGridViewTextBoxColumn1";
            this.iDProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDProductoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDProductoDataGridViewTextBoxColumn1.ValueMember = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.minimoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Mínimo";
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.maximoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Máximo";
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.diasReposicionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "Días Reposición";
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.cantidadMinimaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "Cantidad Minima";
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDProductoToolStripLabel,
            this.iDProductoToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1175, 25);
            this.fillByToolStrip.TabIndex = 24;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // iDProductoToolStripLabel
            // 
            this.iDProductoToolStripLabel.Name = "iDProductoToolStripLabel";
            this.iDProductoToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.iDProductoToolStripLabel.Text = "IDProducto:";
            // 
            // iDProductoToolStripTextBox
            // 
            this.iDProductoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iDProductoToolStripTextBox.Name = "iDProductoToolStripTextBox";
            this.iDProductoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 613);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.bodegaGroupBox);
            this.Controls.Add(this.codigoBarraGroupBox);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.buscarImagenButton);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(this.medidaTextBox);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(iDMedidaLabel);
            this.Controls.Add(this.iDMedidaComboBox);
            this.Controls.Add(iDIVALabel);
            this.Controls.Add(this.iDIVAComboBox);
            this.Controls.Add(iDDepartamentoLabel);
            this.Controls.Add(this.iDDepartamentoComboBox);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSALl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.codigoBarraGroupBox.ResumeLayout(false);
            this.codigoBarraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            this.bodegaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAll.DSALl dSALl;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSAll.DSALlTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DSAll.DSALlTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton editItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton addNewITemBindingNavigator;
        private System.Windows.Forms.ToolStripButton firstItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton previousItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton LastItemBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton deleteItemBindingNavigator;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.ComboBox iDDepartamentoComboBox;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.ComboBox iDMedidaComboBox;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAll.DSALlTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSAll.DSALlTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DSAll.DSALlTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.Button buscarImagenButton;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.ToolStripButton saveItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton cancelItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton searchBindingNavigator;
        private System.Windows.Forms.GroupBox codigoBarraGroupBox;
        private System.Windows.Forms.TextBox barraTextBox;
        private System.Windows.Forms.Label barraLabel;
        private System.Windows.Forms.DataGridView barraDataGridView;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.GroupBox bodegaGroupBox;
        private System.Windows.Forms.Button agregarBodegaButton;
        private System.Windows.Forms.DataGridView bodegaDataGridView;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private DSAll.DSALlTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DSAll.DSALlTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel iDProductoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDProductoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}