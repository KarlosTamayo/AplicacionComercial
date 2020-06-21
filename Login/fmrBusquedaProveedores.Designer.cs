namespace Login
{
    partial class fmrBusquedaProveedores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.busquedaProveedorToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.eleccionGroupBox = new System.Windows.Forms.GroupBox();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.empieceradioButton = new System.Windows.Forms.RadioButton();
            this.termineRadioButton = new System.Windows.Forms.RadioButton();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new Login.DS.DSAplicacionComercial();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new Login.DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.tipoDocumentoTableAdapter = new Login.DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.busquedaProveedorToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.busquedaProveedorToolStrip.SuspendLayout();
            this.eleccionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // busquedaProveedorToolStrip
            // 
            this.busquedaProveedorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.nombresContactoToolStripLabel,
            this.nombresContactoToolStripTextBox,
            this.apellidosContactoToolStripLabel,
            this.apellidosContactoToolStripTextBox,
            this.busquedaProveedorToolStripButton});
            this.busquedaProveedorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.busquedaProveedorToolStrip.Name = "busquedaProveedorToolStrip";
            this.busquedaProveedorToolStrip.Size = new System.Drawing.Size(819, 25);
            this.busquedaProveedorToolStrip.TabIndex = 1;
            this.busquedaProveedorToolStrip.Text = "busquedaProveedorToolStrip";
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombresContactoToolStripLabel
            // 
            this.nombresContactoToolStripLabel.Name = "nombresContactoToolStripLabel";
            this.nombresContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.nombresContactoToolStripLabel.Text = "NombresContacto:";
            // 
            // nombresContactoToolStripTextBox
            // 
            this.nombresContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombresContactoToolStripTextBox.Name = "nombresContactoToolStripTextBox";
            this.nombresContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // apellidosContactoToolStripLabel
            // 
            this.apellidosContactoToolStripLabel.Name = "apellidosContactoToolStripLabel";
            this.apellidosContactoToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.apellidosContactoToolStripLabel.Text = "ApellidosContacto:";
            // 
            // apellidosContactoToolStripTextBox
            // 
            this.apellidosContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellidosContactoToolStripTextBox.Name = "apellidosContactoToolStripTextBox";
            this.apellidosContactoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // eleccionGroupBox
            // 
            this.eleccionGroupBox.Controls.Add(this.reiniciarButton);
            this.eleccionGroupBox.Controls.Add(this.termineRadioButton);
            this.eleccionGroupBox.Controls.Add(this.empieceradioButton);
            this.eleccionGroupBox.Controls.Add(this.contengaRadioButton);
            this.eleccionGroupBox.Location = new System.Drawing.Point(12, 61);
            this.eleccionGroupBox.Name = "eleccionGroupBox";
            this.eleccionGroupBox.Size = new System.Drawing.Size(458, 58);
            this.eleccionGroupBox.TabIndex = 2;
            this.eleccionGroupBox.TabStop = false;
            this.eleccionGroupBox.Text = "Caracter de Busqueda";
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(34, 20);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // empieceradioButton
            // 
            this.empieceradioButton.AutoSize = true;
            this.empieceradioButton.Location = new System.Drawing.Point(148, 20);
            this.empieceradioButton.Name = "empieceradioButton";
            this.empieceradioButton.Size = new System.Drawing.Size(66, 17);
            this.empieceradioButton.TabIndex = 1;
            this.empieceradioButton.TabStop = true;
            this.empieceradioButton.Text = "Empiece";
            this.empieceradioButton.UseVisualStyleBackColor = true;
            // 
            // termineRadioButton
            // 
            this.termineRadioButton.AutoSize = true;
            this.termineRadioButton.Location = new System.Drawing.Point(253, 20);
            this.termineRadioButton.Name = "termineRadioButton";
            this.termineRadioButton.Size = new System.Drawing.Size(63, 17);
            this.termineRadioButton.TabIndex = 2;
            this.termineRadioButton.TabStop = true;
            this.termineRadioButton.Text = "Termine";
            this.termineRadioButton.UseVisualStyleBackColor = true;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Name = "iDTipoDocumentoDataGridViewTextBoxColumn";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresContactoDataGridViewTextBoxColumn
            // 
            this.nombresContactoDataGridViewTextBoxColumn.DataPropertyName = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.HeaderText = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.Name = "nombresContactoDataGridViewTextBoxColumn";
            this.nombresContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Image = global::Login.Properties.Resources._32x32cerrar;
            this.cancelarButton.Location = new System.Drawing.Point(658, 81);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 34);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = global::Login.Properties.Resources.aceptarinicio_32x32;
            this.aceptarButton.Location = new System.Drawing.Point(540, 73);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 46);
            this.aceptarButton.TabIndex = 3;
            this.aceptarButton.UseVisualStyleBackColor = true;
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.FlatAppearance.BorderSize = 0;
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciarButton.Image = global::Login.Properties.Resources.refr_32x321;
            this.reiniciarButton.Location = new System.Drawing.Point(356, 12);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(75, 33);
            this.reiniciarButton.TabIndex = 3;
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // busquedaProveedorToolStripButton
            // 
            this.busquedaProveedorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busquedaProveedorToolStripButton.Image = global::Login.Properties.Resources.search2_32x32;
            this.busquedaProveedorToolStripButton.Name = "busquedaProveedorToolStripButton";
            this.busquedaProveedorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.busquedaProveedorToolStripButton.Text = "BusquedaProveedor";
            this.busquedaProveedorToolStripButton.Click += new System.EventHandler(this.busquedaProveedorToolStripButton_Click);
            // 
            // fmrBusquedaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.eleccionGroupBox);
            this.Controls.Add(this.busquedaProveedorToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fmrBusquedaProveedores";
            this.Text = "fmrBusquedaProveedores";
            this.Load += new System.EventHandler(this.fmrBusquedaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.busquedaProveedorToolStrip.ResumeLayout(false);
            this.busquedaProveedorToolStrip.PerformLayout();
            this.eleccionGroupBox.ResumeLayout(false);
            this.eleccionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DS.DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DS.DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DS.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip busquedaProveedorToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton busquedaProveedorToolStripButton;
        private System.Windows.Forms.GroupBox eleccionGroupBox;
        private System.Windows.Forms.RadioButton termineRadioButton;
        private System.Windows.Forms.RadioButton empieceradioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}